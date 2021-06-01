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

        #region Variablen
        internal string sql;
        internal ListViewItem lvItem;
        internal OleDbDataReader dr;
        internal Datenbank db;

        ImageList bilderListe = new ImageList();
        internal int i = 0;

        ArrayList arrVor = new ArrayList();
        ArrayList arrHaupt = new ArrayList();
        ArrayList arrNach = new ArrayList();

        Random rand = new Random();

        int id;
        #endregion

        private void Speiseplan_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;

            //Datenbankobjekt
            db = new Datenbank();

            i = 0;
            BilderAnzeigen();
            alleSpeisenEinlesen();
        }

        //Speisen zufällig ziehen
        public void ZufälligeVorspeisen()
        {
            Form3.f3.textbox1.Clear();
            Form3.f3.txt2.Text = "";
            Form3.f3.txt3.Text = "";
            Form3.f3.txt4.Text = "";
            Form3.f3.txt5.Text = "";
            
            int letzteid = db.BerechnenInt("Select Max(VorspeiseId) from Vorspeise") ;
            
            for (int i = 0; i <= 4; i++)
            {
                int index = rand.Next(1, letzteid);
                
                sql = "Select Bezeichnung from Vorspeise Where VorspeiseID = " + index;
                dr = db.Einlesen(sql);

                while (dr.Read())
                {
                    arrVor.Add(dr[0].ToString());
                }

            }
            Form3.f3.textbox1.Text = arrVor[0] as string;
            Form3.f3.txt2.Text = arrVor[1] as string;
            Form3.f3.txt3.Text = arrVor[2] as string;
            Form3.f3.txt4.Text = arrVor[3] as string;
            Form3.f3.txt5.Text = arrVor[4] as string;
        }

        public void ZufälligeHauptspeise()
        {
            Form3.f3.txtMoHaupt.Text = "";
            Form3.f3.txtDiHaupt.Text = "";
            Form3.f3.txtMiHaupt.Text = "";
            Form3.f3.txtDoHaupt.Text = "";
            Form3.f3.txtFrHaupt.Text = "";
            
            int letzteid = db.BerechnenInt("Select Max(HauptspeiseId) from Hauptspeise");

            for (int i = 0; i <= 4; i++)
            {
                    int index = rand.Next(1, letzteid);

                    //MessageBox.Show(index.ToString());

                    sql = "Select Bezeichnung from Hauptspeise Where HauptspeiseId = " + index;
                    dr = db.Einlesen(sql);
                
                    while (dr.Read())
                    {
                        arrHaupt.Add(dr[0].ToString());
                    }
            }
            Form3.f3.txtMoHaupt.Text = arrHaupt[0] as string;
            Form3.f3.txtDiHaupt.Text = arrHaupt[1] as string;
            Form3.f3.txtMiHaupt.Text = arrHaupt[2] as string;
            Form3.f3.txtDoHaupt.Text = arrHaupt[3] as string;
            Form3.f3.txtFrHaupt.Text = arrHaupt[4] as string;
        }

        public void ZufälligeNachspeise()
        {
            Form3.f3.txtMoNach.Text = "";
            Form3.f3.txtDiNach.Text = "";
            Form3.f3.txtMiNach.Text = "";
            Form3.f3.txtDoNach.Text = "";
            Form3.f3.txtFrNach.Text = "";
            
            int letzteid = db.BerechnenInt("Select Max(NachspeiseId) from Nachspeise") + 1;

            for (int i = 0; i <= 4; i++)
            {
                int index = rand.Next(1, letzteid);

                sql = "Select Bezeichnung from Nachspeise Where NachspeiseId = " + index;
                dr = db.Einlesen(sql);

                while (dr.Read())
                {
                    arrNach.Add(dr[0].ToString());
                }
            }
            Form3.f3.txtMoNach.Text = arrNach[0] as string;
            Form3.f3.txtDiNach.Text = arrNach[1] as string;
            Form3.f3.txtMiNach.Text = arrNach[2] as string;
            Form3.f3.txtDoNach.Text = arrNach[3] as string;
            Form3.f3.txtFrNach.Text = arrNach[4] as string;
        }

        //Speisen einlesen
        public void listViewEinrichten()
        {
            listView1.Columns.Clear();
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Bild");
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Speise");
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

            sql = "Select VorspeiseID, Bezeichnung, Bildpfad FROM Vorspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));

                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listView1.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        internal void NachspeiseEinlesen()
        {
            listViewVorspeise.Visible = false;
            listViewNachspeise.Visible = false;
            listViewHauptspeise.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
            listView1.Items.Clear();

            sql = "Select NachspeiseID, Bezeichnung, Bildpfad FROM Nachspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));

                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listView1.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listView1.Items.Add(lvItem);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        internal void HauptspeiseEinlesen()
        {
            listViewVorspeise.Visible = false;
            listViewNachspeise.Visible = false;
            listViewHauptspeise.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            listView1.Visible = true;
            listView1.Items.Clear();

            sql = "Select HauptspeiseID, Bezeichnung, Bildpfad FROM Hauptspeise";

            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));

                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listView1.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
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
            listViewVorspeise.Columns.Add("Bild");
            listViewVorspeise.Columns.Add("ID");
            listViewVorspeise.Columns.Add("Speise");
            listViewVorspeise.Font = new Font("Calibri", 12);

            listViewHauptspeise.Columns.Clear();
            listViewHauptspeise.FullRowSelect = true;
            listViewHauptspeise.View = View.Details;
            listViewHauptspeise.Columns.Add("Bild");
            listViewHauptspeise.Columns.Add("ID");
            listViewHauptspeise.Columns.Add("Speise");
            listViewHauptspeise.Font = new Font("Calibri", 12);

            listViewNachspeise.Columns.Clear();
            listViewNachspeise.FullRowSelect = true;
            listViewNachspeise.View = View.Details;
            listViewNachspeise.Columns.Add("Bild");
            listViewNachspeise.Columns.Add("ID");
            listViewNachspeise.Columns.Add("Speise");
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

            sql = "Select VorspeiseID, Bezeichnung, Bildpfad FROM Vorspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));
                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listViewVorspeise.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewVorspeise.Items.Add(lvItem);
            }
            listViewVorspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewVorspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            sql = "Select HauptspeiseID, Bezeichnung, Bildpfad FROM Hauptspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));

                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listViewHauptspeise.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewHauptspeise.Items.Add(lvItem);
            }
            listViewHauptspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewHauptspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            sql = "Select NachspeiseID, Bezeichnung, Bildpfad FROM Nachspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem();
                try
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + dr[2].ToString()));

                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\Bilder\\default.png"));
                    continue;
                }
                listViewNachspeise.SmallImageList = bilderListe;
                lvItem.ImageIndex = i;
                i++;
                lvItem.SubItems.Add(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                listViewNachspeise.Items.Add(lvItem);
            }
            listViewNachspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewNachspeise.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void BilderAnzeigen()
        {
            bilderListe.ColorDepth = ColorDepth.Depth32Bit;
            bilderListe.ImageSize = new System.Drawing.Size(32, 32);
            bilderListe.Images.Clear();
        }

        private void wochenspeiseplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            Form3.f3.Text = "Wochenspeiseplan";
            ZufälligeVorspeisen();
            ZufälligeHauptspeise();
            ZufälligeNachspeise();
            Form3.f3.ShowDialog();
        }

        //Speisen aus Datenbank auslesen
        private void vorspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Vorspeisen";
            listViewEinrichten();
            i = 0;
            BilderAnzeigen();
            VorspeiseEinlesen();
        }
        private void nachspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Nachspeisen";
            listViewEinrichten();
            i = 0;
            BilderAnzeigen();
            NachspeiseEinlesen();
        }
        private void hauptspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Hauptspeisen";
            listViewEinrichten();
            i = 0;
            BilderAnzeigen();
            HauptspeiseEinlesen();
        }
        private void alleSpeisenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Speisen";
            i = 0;
            BilderAnzeigen();
            alleSpeisenEinlesen();
        }

        //Nachspeise bearbeiten / hinzufügen / löschen
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

            f2.txtSpeiseID.Text = lvItem.SubItems[1].Text;
            f2.cbSpeiseart.Text = label2.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[2].Text;

            f2.ShowDialog();
        }

        private void nachspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Nachspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(NachspeiseID) from Nachspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label2.Text;
            f2.pic = Application.StartupPath + "\\Bilder\\default.png";
            f2.textBox1.Text = f2.pic;

            f2.ShowDialog();
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

        //Vorspeise bearbeiten / hinzufügen / löschen
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

            f2.txtSpeiseID.Text = lvItem.SubItems[1].Text;
            f2.cbSpeiseart.Text = label1.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[2].Text;

            f2.ShowDialog();
        }

        private void vorspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Vorspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(VorspeiseID) from Vorspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label1.Text;
            f2.pic = Application.StartupPath + "\\Bilder\\default.png";
            f2.textBox1.Text = f2.pic;

            f2.ShowDialog();
        }

        private void vorspeiseLöschen_Click(object sender, EventArgs e)
        {
            if (listViewVorspeise.SelectedItems.Count == 0)
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

        //Hauptspeise bearbeiten / hinzufügen / löschen
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

            f2.txtSpeiseID.Text = lvItem.SubItems[1].Text;
            f2.cbSpeiseart.Text = label3.Text;
            f2.txtBezeichnung.Text = lvItem.SubItems[2].Text;

            f2.ShowDialog();
        }

        private void hauptspeiseHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Hauptspeise hinzufügen";

            int speiseid = db.BerechnenInt("Select Max(HauptspeiseID) from Hauptspeise") + 1;
            f2.txtSpeiseID.Text = speiseid.ToString();
            f2.cbSpeiseart.Text = label3.Text;
            f2.pic = Application.StartupPath + "\\Bilder\\default.png";
            f2.textBox1.Text = f2.pic;

            f2.ShowDialog();
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

        //Speisen bewerten
        private void vorspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

                lvItem = listViewVorspeise.SelectedItems[0];

                sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label1.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

                db.Ausfuehren(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sie haben keine Bewertung abgegeben!");
                return;
            }
        }

        private void hauptspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

                lvItem = listViewHauptspeise.SelectedItems[0];

                sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label3.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

                db.Ausfuehren(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie haben keine Bewertung abgegeben!");
                return;
            }
        }

        private void nachspeiseBewertenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string eingabe = Microsoft.VisualBasic.Interaction.InputBox("Geben Sie Ihre Bewertung ab: (Punktesystem von 1 - 5)");

                lvItem = listViewNachspeise.SelectedItems[0];

                sql = @"Insert into Bewertungen (Kategorie, Bezeichnung, Bewertung)
                    values ('" + label2.Text + "', '" + lvItem.SubItems[1].Text + "', '" + eingabe + "');";

                db.Ausfuehren(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie haben keine Bewertung abgegeben!");
                return;
            }
        }

        //Bewertungen ansehen
        private void bewertungenAnsehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Bewertung der Vorspeisen";
            Form4.f4.EinlesenVorspeisen();
            Form4.f4.ShowDialog();
        }

        private void bewertungenAnsehenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Bewertung der Hauptspeisen";
            Form4.f4.EinlesenHauptspeisen();
            Form4.f4.ShowDialog();
        }

        private void bewertungenAnsehenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            Form4.f4.Text = "Bewertung der Nachspeisen";
            Form4.f4.EinlesenNachspeisen();
            Form4.f4.ShowDialog();
        }

        private void auswählenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            lvItem = listView1.SelectedItems[0];
            string text = lvItem.SubItems[2].Text;
            Form3.f3.Show();

            if(Form3.f3.tag.Equals("MoVor"))
            { 
                Form3.f3.textbox1.Text = text;
            }
            else if(Form3.f3.tag.Equals("DiVor"))
            {
                Form3.f3.txt2.Text = text;
            }
            else if (Form3.f3.tag.Equals("MiVor"))
            {
                Form3.f3.txt3.Text = text;
            }
            else if (Form3.f3.tag.Equals("DoVor"))
            {
                Form3.f3.txt4.Text = text;
            }
            else if (Form3.f3.tag.Equals("FrVor"))
            {
                Form3.f3.txt5.Text = text;
            }
            else if (Form3.f3.tag.Equals("MoHaupt"))
            {
                Form3.f3.txtMoHaupt.Text = text;
            }
            else if (Form3.f3.tag.Equals("DiHaupt"))
            {
                Form3.f3.txtDiHaupt.Text = text;
            }
            else if (Form3.f3.tag.Equals("MiHaupt"))
            {
                Form3.f3.txtMiHaupt.Text = text;
            }
            else if (Form3.f3.tag.Equals("DoHaupt"))
            {
                Form3.f3.txtDoHaupt.Text = text;
            }
            else if (Form3.f3.tag.Equals("FrHaupt"))
            {
                Form3.f3.txtFrHaupt.Text = text;
            }
            else if (Form3.f3.tag.Equals("MoNach"))
            {
                Form3.f3.txtMoNach.Text = text;
            }
            else if (Form3.f3.tag.Equals("DiNach"))
            {
                Form3.f3.txtDiNach.Text = text;
            }
            else if (Form3.f3.tag.Equals("MiNach"))
            {
                Form3.f3.txtMiNach.Text = text;
            }
            else if (Form3.f3.tag.Equals("DoNach"))
            {
                Form3.f3.txtDiNach.Text = text;
            }
            else if (Form3.f3.tag.Equals("FrNach"))
            {
                Form3.f3.txtFrNach.Text = text;
            }
            auswählenToolStripMenuItem.Visible = false;
        }
    }
}
