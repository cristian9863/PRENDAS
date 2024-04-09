using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PRENDAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Stream myStream;
        int conunter = 0;
        string Line;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.*)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    if ((myStream = openFileDialog.OpenFile())!= null)
                    {
                        using (myStream) 
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                            while ((Line = file.ReadLine()) != null) 
                            {
                                txtArchivo.Text = txtArchivo.Text + Line + Environment.NewLine;
                                int Counter = 0;
                                Counter++;
                            }
                            file.Close();
                        }

                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error: podria no existir el archivo" + ex.Message);
                }
            }

                
        }
    }
}
