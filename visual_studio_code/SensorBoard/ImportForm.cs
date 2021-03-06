﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace SensorBoard
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnClick_Import(object sender, EventArgs e)
        {

            try {
                OpenFileDialog pickedfile = new OpenFileDialog();
                //on récupère le formulaire parent de l'import form, il ns renvoie que le type du dessus
                //le parent c'est en fait le MainForm
                //Form.cb ne nous donne pas accès au sensor, c'est le MainForm qui contient la combobox
                //on cast le form parent en MainForm pour avoir le bon type
                //la cb ne peut tjs pas être récupérée car elle est en privé, dc on va faire un get ds MainForm

                if (pickedfile.ShowDialog() == DialogResult.OK)
                {
                    
                    Form form = this.ParentForm;
                    MainForm main = (MainForm)form;
                    String sensor = main.getSensor();
                    if (sensor == "") throw new Exception("Merci de sélectionner un capteur");
                    if (!File.Exists(pickedfile.FileName)) throw new Exception("Fichier Inexistant");

                    long finfo = new FileInfo(pickedfile.FileName).Length;
                    if (finfo == 0) throw new Exception("Fichier vide");

                    String[] content = File.ReadAllLines(pickedfile.FileName);
                    List<int> unformatedLines = new List<int>();

                    for (int lineNumber = 1; lineNumber < content.Length; lineNumber++)
                    {
                        String[] columns = content[lineNumber].Split(' ');
                        if (columns.Length != 5) unformatedLines.Add(lineNumber + 1);
                    }

                    if (unformatedLines.Count > 0)
                    {
                        throw new Exception("Certaines lignes sont mal formatées : \n\r" + String.Join(", ", unformatedLines.ToArray())
                            + "\n\rVeuillez reformater votre fichier");
                    }

                    List<int> nonExecutedQueries = new List<int>();

                    //On itère sur chaque ligne du fichier sélectionné
                    for (int i = 0; i < content.Length; i ++)
                    {
                    //on split sur les espace, on a autant d'éléments ds le tableau que de colonnes ds le fichier
                        String[] columns = content[i].Split(' ');

                        String humidity = Regex.Replace(columns[4], "%", "");
                        String temperature = columns[3];
                        String dataDate = columns[1] + " " + columns[2];
                        try
                        {
                        DBInteractor.QuickExecute("INSERT INTO data(data_date,temperature,humidity,import_date,sensor) " +
                            "VALUES(@data_date, @temperature, @humidity, @import_date, @sensor)",
                            new Dictionary<String, String>(){
                                { "@data_date", dataDate},
                                {"@temperature", temperature },
                                {"@humidity", humidity },
                                {"@import_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                                {"@sensor", sensor },
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERREUR : Impossible de se connecter à la base de données...\n\r\n\r" +
                                ex.Message + "\n\r" + ex.StackTrace);
                        }
                    }
                    MessageBox.Show("L'insertion de vos données a été effectuée avec succès");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR : " + ex.Message);
            }
        }
    }
}
