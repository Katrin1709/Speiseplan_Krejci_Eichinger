using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan_Krejci_Eichinger
{
    public partial class Form2 : Form
    {
        internal static Form2 f2;
        public Form2()
        {
            InitializeComponent();
        }

        #region Variablen
        internal string pic;
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Veränderung();
        }

        //Methode für Button speichern
        public void Veränderung()
        {
            try
            {
                if (this.Text.Equals("Vorspeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Vorspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE VorspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }

                else if (this.Text.Equals("Vorspeise hinzufügen"))
                {                    
                    Form1.f1.sql = @"Insert into Vorspeise (Speiseart, Bezeichnung, Bildpfad)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + textBox1.Text + "');";

                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
            
            try
            {
                if (this.Text.Equals("Hauptspeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Hauptspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE HauptspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }

                else if (this.Text.Equals("Hauptspeise hinzufügen"))
                {
                    Form1.f1.sql = @"Insert into Hauptspeise (Speiseart, Bezeichnung)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "');";
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
            
            try
            {
                if (this.Text.Equals("Nachspeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Nachspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE NachspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }

                else if (this.Text.Equals("Nachspeise hinzufügen"))
                {
                    Form1.f1.sql = @"Insert into Nachspeise (Speiseart, Bezeichnung)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "');";
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
        }

        //Enter
        private void txtBezeichnung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Veränderung();
            }
        }

        public void VorspeiseBilderEinlesen()
        {
            List<string> pfadliste = new List<string>();

            Form1.f1.sql = "Select Bildpfad From VorspeiseListe";
            Form1.f1.db.Einlesen(Form1.f1.sql);
            while(Form1.f1.dr.Read())
            {
                pfadliste.Add(Form1.f1.dr[0].ToString());
            }

            //foreach(String s in pfadliste)
            //{
            //    if()
            //}
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.InitialDirectory = "D:";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                pic = openFileDialog1.FileName;
            }
        }
    }
}
