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
    public partial class Form4 : Form
    {
        internal static Form4 f4;
        public Form4()
        {
            f4 = this;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Kategorie");
            listView1.Columns.Add("Bezeichnung");
            listView1.Columns.Add("Bewertung");
            listView1.Font = new Font("Calibri", 12);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        public void EinlesenVorspeisen()
        {
            Form1.f1.sql = "Select Kategorie, Bezeichnung, Bewertung FROM Bewertungen Where Kategorie = '" + Form1.f1.label1.Text + "' Order By Bezeichnung";

            Form1.f1.dr = Form1.f1.db.Einlesen(Form1.f1.sql);
            while (Form1.f1.dr.Read())
            {
                Form1.f1.lvItem = new ListViewItem(Form1.f1.dr[0].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[1].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[2].ToString() + " / 5");
                listView1.Items.Add(Form1.f1.lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void EinlesenHauptspeisen()
        {
            Form1.f1.sql = "Select Kategorie, Bezeichnung, Bewertung FROM Bewertungen Where Kategorie = '" + Form1.f1.label3.Text + "' Order By Bezeichnung";

            Form1.f1.dr = Form1.f1.db.Einlesen(Form1.f1.sql);
            while (Form1.f1.dr.Read())
            {
                Form1.f1.lvItem = new ListViewItem(Form1.f1.dr[0].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[1].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[2].ToString() + " / 5");
                listView1.Items.Add(Form1.f1.lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void EinlesenNachspeisen()
        {
            Form1.f1.sql = "Select Kategorie, Bezeichnung, Bewertung FROM Bewertungen Where Kategorie = '" + Form1.f1.label2.Text + "' Order By Bezeichnung";

            Form1.f1.dr = Form1.f1.db.Einlesen(Form1.f1.sql);
            while (Form1.f1.dr.Read())
            {
                Form1.f1.lvItem = new ListViewItem(Form1.f1.dr[0].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[1].ToString());
                Form1.f1.lvItem.SubItems.Add(Form1.f1.dr[2].ToString() + " / 5");
                listView1.Items.Add(Form1.f1.lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void vorspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.VorspeiseEinlesen();
            Form1.f1.Show();
        }

        private void hauptspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.HauptspeiseEinlesen();
            Form1.f1.Show();
        }

        private void nachspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.NachspeiseEinlesen();
            Form1.f1.Show();
        }

        private void alleSpeisenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.Show();
            Form1.f1.alleSpeisenEinlesen();
        }

        private void wochenspeiseplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            Form3.f3.Text = "Wochenspeiseplan";
            Form3.f3.Show();
        }
    }
}
