using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.IO;
using Microsoft.VisualBasic;

namespace Speiseplan_Krejci_Eichinger
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        internal string sql;
        internal ListViewItem lvItem;
        internal OleDbDataReader dr;
        internal Datenbank db;

        List<string> VorspeiseListe;
        List<string> HauptspeiseListe;
        List<string> NachspeiseListe;
        
        List<TextBox> TextBoxList = new List<TextBox>();

        string speise1;
        string speise2;
        string speise3;
        string speise4;
        string speise5;

        string zeile;
        int id;

        private void Speiseplan_Load(object sender, EventArgs e)
        {
            //Datenbankobjekt
            db = new Datenbank();

            //Liste initialisieren
            VorspeiseListe = new List<string>();
            HauptspeiseListe = new List<string>();
            NachspeiseListe = new List<string>();

            alleSpeisenEinlesen();
        }

        public void VorspeiseListeErstellen()
        {
            Form3.f3.textbox1.Text = "";
            Form3.f3.txt2.Text = "";
            Form3.f3.txt3.Text = "";
            Form3.f3.txt4.Text = "";
            Form3.f3.txt5.Text = "";

            TextBoxList.Add(Form3.f3.textbox1);
            TextBoxList.Add(Form3.f3.txt2);
            TextBoxList.Add(Form3.f3.txt3);
            TextBoxList.Add(Form3.f3.txt4);
            TextBoxList.Add(Form3.f3.txt5);

            Random rand = new Random(5);

            int letzteid = db.BerechnenInt("Select Max(NachspeiseID) from Nachspeise") + 1;

            for (int i = 0; i <= 4; i++)
            {
                int index = rand.Next(1, letzteid);

                sql = "Select Bezeichnung from Vorspeise Where VorspeiseID = " + index;
                dr = db.Einlesen(sql);

                while (dr.Read())
                {
                    //VorspeiseListe.Add(dr[0].ToString());

                    foreach (TextBox tb in TextBoxList)
                    {
                        tb.Text = dr[0].ToString();
                    }
                }
                //speise1 = VorspeiseListe[0];        

                //Form3.f3.textbox1.Text = speise1;
                //Form3.f3.txt2.Text = speise1;
                //Form3.f3.txt3.Text = speise1;
                //Form3.f3.txt4.Text = speise1;
                //Form3.f3.txt5.Text = speise1;
            }
        }

        public void listViewEinrichten()
        {
            listView1.Columns.Clear();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Speise");
            listView1.Columns.Add("Bild");
            listView1.Font = new Font("Calibri", 12);
        }

        internal void VorspeiseEinlesen()
        {
            listViewVorspeise.Visible = false;
            listViewNachspeise.Visible = false;
            listViewHauptspeise.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
            listView1.Items.Clear();

            sql = "Select VorspeiseID, Bezeichnung FROM Vorspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void NachspeiseEinlesen()
        {
            listViewVorspeise.Visible = false;
            listViewNachspeise.Visible = false;
            listViewHauptspeise.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
            listView1.Items.Clear();

            sql = "Select NachspeiseID, Bezeichnung FROM Nachspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        
        public void HauptspeiseEinlesen()
        {
            listViewVorspeise.Visible = false;
            listViewNachspeise.Visible = false;
            listViewHauptspeise.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
            listView1.Items.Clear();

            sql = "Select HauptspeiseID, Bezeichnung FROM Hauptspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void alleSpeisenEinlesen()
        {
            listViewVorspeise.Columns.Clear();
            listViewVorspeise.FullRowSelect = true;
            listViewVorspeise.View = View.Details;
            listViewVorspeise.Columns.Add("ID");
            listViewVorspeise.Columns.Add("Speise");
            listViewVorspeise.Columns.Add("Bild");
            listViewVorspeise.Font = new Font("Calibri", 12);

            listViewHauptspeise.Columns.Clear();
            listViewHauptspeise.FullRowSelect = true;
            listViewHauptspeise.View = View.Details;
            listViewHauptspeise.Columns.Add("ID");
            listViewHauptspeise.Columns.Add("Speise");
            listViewHauptspeise.Columns.Add("Bild");
            listViewHauptspeise.Font = new Font("Calibri", 12);

            listViewNachspeise.Columns.Clear();
            listViewNachspeise.FullRowSelect = true;
            listViewNachspeise.View = View.Details;
            listViewNachspeise.Columns.Add("ID");
            listViewNachspeise.Columns.Add("Speise");
            listViewNachspeise.Columns.Add("Bild");
            listViewNachspeise.Font = new Font("Calibri", 12);

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            listView1.Visible = false;
            listViewVorspeise.Visible = true;
            listViewHauptspeise.Visible = true;
            listViewNachspeise.Visible = true;

            listViewVorspeise.Items.Clear();
            listViewHauptspeise.Items.Clear();
            listViewNachspeise.Items.Clear();

            sql = "Select VorspeiseID, Bezeichnung FROM Vorspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            { 
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewVorspeise.Items.Add(lvItem);
            }
            listViewVorspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewVorspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            sql = "Select HauptspeiseID, Bezeichnung FROM Hauptspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewHauptspeise.Items.Add(lvItem);
            }
            listViewHauptspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewHauptspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            sql = "Select NachspeiseID, Bezeichnung FROM Nachspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewNachspeise.Items.Add(lvItem);
            }
            listViewNachspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewNachspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void wochenspeiseplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            Form3.f3.Text = "Wochenspeiseplan";
            Form3.f3.ShowDialog();
        }

        private void vorspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewEinrichten();
            VorspeiseEinlesen();
        }

        private void nachspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewEinrichten();
            NachspeiseEinlesen();
        }

        private void hauptspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewEinrichten();
            HauptspeiseEinlesen();
        }

        private void alleSpeisenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alleSpeisenEinlesen();
        }

        private void nachspeiseBearbeiten_Click(object sender, EventArgs e)
        {
            if (listViewNachspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise zum Bearbeiten aus!");
                return;
            }

            Form2 f2 = new Form2();
            f2.Text = "Nachspeise bearbeiten";

            lvItem = listViewNachspeise.SelectedItems[0];
            id = lvItem.Index;

            f2.txtSpeiseID.Text = lvItem.SubItems[0].Text;
            f2.cbSpeiseart.Text = label2.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[1].Text;

            f2.ShowDialog();
        }

        private void nachspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Nachspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(NachspeiseID) from Nachspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label2.Text;

            f2.ShowDialog();
        }

        private void vorspeiseBearbeiten_Click(object sender, EventArgs e)
        {
            if (listViewVorspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise zum Bearbeiten aus!");
                return;
            }

            Form2 f2 = new Form2();
            f2.Text = "Vorspeise bearbeiten";

            lvItem = listViewVorspeise.SelectedItems[0];
            id = lvItem.Index;

            f2.txtSpeiseID.Text = lvItem.SubItems[0].Text;
            f2.cbSpeiseart.Text = label1.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[1].Text;

            f2.ShowDialog();
        }

        private void vorspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Vorspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(VorspeiseID) from Vorspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label1.Text;

            f2.ShowDialog();
        }

        private void hauptspeiseBearbeiten_Click(object sender, EventArgs e)
        {
            if (listViewHauptspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise zum Bearbeiten aus!");
                return;
            }

            Form2 f2 = new Form2();
            f2.Text = "Hauptspeise bearbeiten";

            lvItem = listViewHauptspeise.SelectedItems[0];
            id = lvItem.Index;

            f2.txtSpeiseID.Text = lvItem.SubItems[0].Text;
            f2.cbSpeiseart.Text = label3.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[1].Text;

            f2.ShowDialog();
        }

        private void hauptspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Hauptspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(HauptspeiseID) from Hauptspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label3.Text;

            f2.ShowDialog();
        }

        private void vorspeiseLöschen_Click(object sender, EventArgs e)
        {
            if(listViewVorspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Zeile zum Löschen aus!");
                return;
            }

            DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen? ", "ACHTUNG:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lvItem = listViewVorspeise.SelectedItems[0];
                string id = lvItem.SubItems[0].Text;

                sql = "Delete From Vorspeise Where VorspeiseID = " + id;
                MessageBox.Show(sql);
                db.Ausfuehren(sql);
            }
            alleSpeisenEinlesen();
        }

        private void hauptspeiseLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewHauptspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Zeile zum Löschen aus!");
                return;
            }

            DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen? ", "ACHTUNG:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lvItem = listViewHauptspeise.SelectedItems[0];
                string id = lvItem.SubItems[0].Text;

                sql = "Delete From Hauptspeise Where HauptspeiseID = " + id;
                MessageBox.Show(sql);
                db.Ausfuehren(sql);
            }
            alleSpeisenEinlesen();
        }

        private void nachspeiseLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewNachspeise.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Zeile zum Löschen aus!");
                return;
            }

            DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen? ", "ACHTUNG:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lvItem = listViewNachspeise.SelectedItems[0];
                string id = lvItem.SubItems[0].Text;

                sql = "Delete From Nachspeise Where NachspeiseID = " + id;
                MessageBox.Show(sql);
                db.Ausfuehren(sql);
            }
            alleSpeisenEinlesen();
        }

        private void vorspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

            lvItem = listViewVorspeise.SelectedItems[0];

            sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label1.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

            db.Ausfuehren(sql);
        }

        private void bewertungenAnsehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Wochenspeiseplan";
            Form4.f4.EinlesenVorspeisen();
            Form4.f4.ShowDialog();
        }

        private void bewertungenAnsehenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Wochenspeiseplan";
            Form4.f4.EinlesenHauptspeisen();
            Form4.f4.ShowDialog();
        }

        private void bewertungenAnsehenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Wochenspeiseplan";
            Form4.f4.EinlesenNachspeisen();
            Form4.f4.ShowDialog();
        }

        private void hauptspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

            lvItem = listViewHauptspeise.SelectedItems[0];

            sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label3.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

            db.Ausfuehren(sql);
        }

        private void nachspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

            lvItem = listViewNachspeise.SelectedItems[0];

            sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label2.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

            db.Ausfuehren(sql);
        }
        
        private void auswählenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            lvItem = listView1.SelectedItems[0];
            string text = lvItem.SubItems[1].Text;
            Form3.f3.Show();
            Form3.f3.textbox1.Text = text;
            auswählenToolStripMenuItem.Visible = false;
        }
    }
}
