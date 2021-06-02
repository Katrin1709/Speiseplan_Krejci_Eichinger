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
        
        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        
        #region btnSpeichern
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            SpeisenVerändern();
        }

        public void SpeisenVerändern()
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

                    Form1.f1.sql = "UPDATE Vorspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text + "', Bildpfad = '" + txtBild.Text +
                    "' WHERE VorspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    Form1.f1.alleSpeisenVorspeiseEinlesen();
                }

                else if (this.Text.Equals("Vorspeise hinzufügen"))
                {   
                    if(txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (txtBild.Text.Equals(""))
                    {
                        Form1.f1.sql = @"Insert into Vorspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + "\\Bilder\\default.png" + "');";
                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenVorspeiseEinlesen();
                    }
                    else
                    {
                        Form1.f1.sql = @"Insert into Vorspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + txtBild.Text + "');";

                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenVorspeiseEinlesen();
                    }
                }
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

                    Form1.f1.sql = "UPDATE Hauptspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text + "', Bildpfad = '" + txtBild.Text +
                    "' WHERE HauptspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    Form1.f1.alleSpeisenHauptspeiseEinlesen();
                }

                else if (this.Text.Equals("Hauptspeise hinzufügen"))
                {
                    if (txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if(txtBild.Text.Equals(""))
                    {
                        Form1.f1.sql = @"Insert into Hauptspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + "\\Bilder\\default.png" + "');";

                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenHauptspeiseEinlesen();
                    }
                    else
                    {
                        Form1.f1.sql = @"Insert into Hauptspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + txtBild.Text + "');";

                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenHauptspeiseEinlesen();
                    }
                }
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

                    Form1.f1.sql = "UPDATE Nachspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text + "', Bildpfad = '" + txtBild.Text +
                    "' WHERE NachspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    Form1.f1.alleSpeisenNachspeiseEinlesen();
                }

                else if (this.Text.Equals("Nachspeise hinzufügen"))
                {
                    if (txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle notwendigen Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if(txtBild.Text.Equals(""))
                    {
                        Form1.f1.sql = @"Insert into Nachspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + "\\Bilder\\default.png" + "');";

                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenNachspeiseEinlesen();
                    }
                    else
                    {
                        Form1.f1.sql = @"Insert into Nachspeise (Speiseart, Bezeichnung, Bildpfad)
                        values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "', '" + txtBild.Text + "');";

                        Form1.f1.db.Ausfuehren(Form1.f1.sql);
                        Form1.f1.alleSpeisenNachspeiseEinlesen();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
        }
        #endregion

        private void txtBezeichnung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SpeisenVerändern();
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\Bilder";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                
                MessageBox.Show(filename.Substring(filename.IndexOf("\\Bilder")));

                txtBild.Text = filename.Substring(filename.IndexOf("\\Bilder")); 
            }
        }
    }
}
