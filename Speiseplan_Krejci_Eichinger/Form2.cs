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
            
        }

        public void Veränderung()
        {
            try
            {
                if (this.Text.Equals("Vorpeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Vorspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE VorspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.VorspeiseEinlesen();
                }

                else if (this.Text.Equals("Vorspeise hinzufügen"))
                {
                    Form1.f1.sql = @"Insert into Vorspeise (Speiseart, Bezeichnung)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "');";

                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.VorspeiseEinlesen();
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
            //Form1.f1.alleSpeisenEinlesen();
            //Form1.f1.VorspeiseEinlesen();


            try
            {
                if (this.Text.Equals("Hauptspeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Hauptspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE HauptspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.HauptspeiseEinlesen();
                }

                else if (this.Text.Equals("Hauptspeise hinzufügen"))
                {
                    Form1.f1.sql = @"Insert into Hauptspeise (Speiseart, Bezeichnung)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "');";

                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.HauptspeiseEinlesen();
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
            //Form1.f1.alleSpeisenEinlesen();
            //Form1.f1.HauptspeiseEinlesen();


            try
            {
                if (this.Text.Equals("Nachspeise bearbeiten"))
                {
                    if (cbSpeiseart.SelectedIndex == -1 || txtBezeichnung.Text.Equals(""))
                    {
                        MessageBox.Show("Sie haben nicht alle Felder ausgefüllt", "Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Form1.f1.sql = "UPDATE Nachspeise SET Speiseart = '" + cbSpeiseart.Text + "', Bezeichnung = '" + txtBezeichnung.Text +
                    "' WHERE NachspeiseID = " + Convert.ToInt16(txtSpeiseID.Text);
                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.NachspeiseEinlesen();
                }

                else if (this.Text.Equals("Nachspeise hinzufügen"))
                {
                    Form1.f1.sql = @"Insert into Nachspeise (Speiseart, Bezeichnung)
                    values ('" + cbSpeiseart.Text + "', '" + txtBezeichnung.Text + "');";

                    //MessageBox.Show(Form1.f1.sql);
                    Form1.f1.db.Ausfuehren(Form1.f1.sql);
                    //Form1.f1.alleSpeisenEinlesen();
                    //Form1.f1.NachspeiseEinlesen();
                }
                Form1.f1.alleSpeisenEinlesen();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehlermeldung: " + ex.Message);
            }
            //Form1.f1.alleSpeisenEinlesen();
            //Form1.f1.NachspeiseEinlesen();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Veränderung();
        }

        private void txtBezeichnung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                Veränderung();
            }
        }
    }
}
