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
    public partial class Form3 : Form
    {
        internal static Form3 f3;

        public Form3()
        {
            f3 = this;
            InitializeComponent();
        }

        #region Variablen
        internal string tag;
        #endregion

        public void Form3_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;

            Form1.f1.ZufälligeVorspeisen();
            Form1.f1.ZufälligeHauptspeise();
            Form1.f1.ZufälligeNachspeise();
        }

        #region Toolstrips Einlesen
        private void alleSpeisenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Speisen";
            this.Hide();
            Form1.f1.ShowDialog();
            Form1.f1.i = 0;
            Form1.f1.BilderAnzeigen();
            Form1.f1.alleSpeisenEinlesen();
        }

        private void vorspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Vorspeisen";
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.i = 0;
            Form1.f1.BilderAnzeigen();
            Form1.f1.VorspeiseEinlesen();
            Form1.f1.Show();
        }

        private void hauptspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Hauptspeisen";
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.i = 0;
            Form1.f1.BilderAnzeigen();
            Form1.f1.HauptspeiseEinlesen();
            Form1.f1.Show();
        }

        private void nachspeiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f1.Text = "Nachspeisen";
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.i = 0;
            Form1.f1.BilderAnzeigen();
            Form1.f1.NachspeiseEinlesen();
            Form1.f1.Show();
        }
        #endregion

        #region Speisen ändern
        public void VorspeiseÄndern()
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.VorspeiseEinlesen();
            Form1.f1.Show();

            Form1.f1.auswählenToolStripMenuItem.Visible = true;
        }
        public void HauptspeiseÄndern()
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.HauptspeiseEinlesen();
            Form1.f1.Show();

            Form1.f1.auswählenToolStripMenuItem.Visible = true;
        }
        public void NachspeiseÄndern()
        {
            this.Hide();
            Form1.f1.listViewEinrichten();
            Form1.f1.NachspeiseEinlesen();
            Form1.f1.Show();

            Form1.f1.auswählenToolStripMenuItem.Visible = true;
        }

        private void textbox1_DoubleClick(object sender, EventArgs e)
        {
            VorspeiseÄndern();
            tag = "MoVor";
        }
        private void txt2_DoubleClick(object sender, EventArgs e)
        {
            VorspeiseÄndern();
            tag = "DiVor";
        }
        private void txt3_DoubleClick(object sender, EventArgs e)
        {
            VorspeiseÄndern();
            tag = "MiVor";
        }
        private void txt4_DoubleClick(object sender, EventArgs e)
        {
            VorspeiseÄndern();
            tag = "DoVor";
        }
        private void txt5_DoubleClick(object sender, EventArgs e)
        {
            VorspeiseÄndern();
            tag = "FrVor";
        }

        private void txtMoHaupt_DoubleClick(object sender, EventArgs e)
        {
            HauptspeiseÄndern();
            tag = "MoHaupt";
        }
        private void txtDiHaupt_DoubleClick(object sender, EventArgs e)
        {
            HauptspeiseÄndern();
            tag = "DiHaupt";
        }
        private void txtMiHaupt_DoubleClick(object sender, EventArgs e)
        {
            HauptspeiseÄndern();
            tag = "MiHaupt";
        }
        private void txtDoHaupt_DoubleClick(object sender, EventArgs e)
        {
            HauptspeiseÄndern();
            tag = "DoHaupt";
        }
        private void txtFrHaupt_DoubleClick(object sender, EventArgs e)
        {
            HauptspeiseÄndern();
            tag = "FrHaupt";
        }

        private void txtMoNach_DoubleClick(object sender, EventArgs e)
        {
            NachspeiseÄndern();
            tag = "MoNach";
        }
        private void txtDiNach_DoubleClick(object sender, EventArgs e)
        {
            NachspeiseÄndern();
            tag = "DiNach";
        }
        private void txtMiNach_DoubleClick(object sender, EventArgs e)
        {
            NachspeiseÄndern();
            tag = "MiNach";
        }
        private void txtDoNach_DoubleClick(object sender, EventArgs e)
        {
            NachspeiseÄndern();
            tag = "DoNach";
        }
        private void txtFrNach_DoubleClick(object sender, EventArgs e)
        {
            NachspeiseÄndern();
            tag = "FrNach";
        }
        #endregion

        #region Drucken
        private void Drucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../../Wochenspeiseplan.docx");
            wordapp.ActiveDocument.FormFields["MoVor"].Result = txtMoVor.Text;
            wordapp.ActiveDocument.FormFields["MoHaupt"].Result = txtMoHaupt.Text;
            wordapp.ActiveDocument.FormFields["MoNach"].Result = txtMoNach.Text;
            wordapp.ActiveDocument.FormFields["DiVor"].Result = txtDiVor.Text;
            wordapp.ActiveDocument.FormFields["DiHaupt"].Result = txtDiHaupt.Text;
            wordapp.ActiveDocument.FormFields["DiNach"].Result = txtDiNach.Text;
            wordapp.ActiveDocument.FormFields["MiVor"].Result = txtMiVor.Text;
            wordapp.ActiveDocument.FormFields["MiHaupt"].Result = txtMiHaupt.Text;
            wordapp.ActiveDocument.FormFields["MiNach"].Result = txtMiNach.Text;
            wordapp.ActiveDocument.FormFields["DoVor"].Result = txtDoVor.Text;
            wordapp.ActiveDocument.FormFields["DoHaupt"].Result = txtDoHaupt.Text;
            wordapp.ActiveDocument.FormFields["DoNach"].Result = txtDoNach.Text;
            wordapp.ActiveDocument.FormFields["FrVor"].Result = txtFrVor.Text;
            wordapp.ActiveDocument.FormFields["FrHaupt"].Result = txtFrHaupt.Text;
            wordapp.ActiveDocument.FormFields["FrNach"].Result = txtFrNach.Text;

            wordapp.ActiveDocument.SaveAs2(Application.StartupPath + "\\../../../" + wochenspeiseplanToolStripMenuItem.Text + ".docx");
            wordapp.ActiveDocument.ExportAsFixedFormat(Application.StartupPath + "\\../../../" + wochenspeiseplanToolStripMenuItem.Text + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, true);
        }

        private void alsWordDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../../Wochenspeiseplan.docx");
            wordapp.ActiveDocument.FormFields["MoVor"].Result = txtMoVor.Text;
            wordapp.ActiveDocument.FormFields["MoHaupt"].Result = txtMoHaupt.Text;
            wordapp.ActiveDocument.FormFields["MoNach"].Result = txtMoNach.Text;
            wordapp.ActiveDocument.FormFields["DiVor"].Result = txtDiVor.Text;
            wordapp.ActiveDocument.FormFields["DiHaupt"].Result = txtDiHaupt.Text;
            wordapp.ActiveDocument.FormFields["DiNach"].Result = txtDiNach.Text;
            wordapp.ActiveDocument.FormFields["MiVor"].Result = txtMiVor.Text;
            wordapp.ActiveDocument.FormFields["MiHaupt"].Result = txtMiHaupt.Text;
            wordapp.ActiveDocument.FormFields["MiNach"].Result = txtMiNach.Text;
            wordapp.ActiveDocument.FormFields["DoVor"].Result = txtDoVor.Text;
            wordapp.ActiveDocument.FormFields["DoHaupt"].Result = txtDoHaupt.Text;
            wordapp.ActiveDocument.FormFields["DoNach"].Result = txtDoNach.Text;
            wordapp.ActiveDocument.FormFields["FrVor"].Result = txtFrVor.Text;
            wordapp.ActiveDocument.FormFields["FrHaupt"].Result = txtFrHaupt.Text;
            wordapp.ActiveDocument.FormFields["FrNach"].Result = txtFrNach.Text;

            wordapp.ActiveDocument.SaveAs2(Application.StartupPath + "\\../../../" + wochenspeiseplanToolStripMenuItem.Text + ".docx");
        }

        private void alsPDFDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../../Wochenspeiseplan.docx");
            wordapp.ActiveDocument.FormFields["MoVor"].Result = txtMoVor.Text;
            wordapp.ActiveDocument.FormFields["MoHaupt"].Result = txtMoHaupt.Text;
            wordapp.ActiveDocument.FormFields["MoNach"].Result = txtMoNach.Text;
            wordapp.ActiveDocument.FormFields["DiVor"].Result = txtDiVor.Text;
            wordapp.ActiveDocument.FormFields["DiHaupt"].Result = txtDiHaupt.Text;
            wordapp.ActiveDocument.FormFields["DiNach"].Result = txtDiNach.Text;
            wordapp.ActiveDocument.FormFields["MiVor"].Result = txtMiVor.Text;
            wordapp.ActiveDocument.FormFields["MiHaupt"].Result = txtMiHaupt.Text;
            wordapp.ActiveDocument.FormFields["MiNach"].Result = txtMiNach.Text;
            wordapp.ActiveDocument.FormFields["DoVor"].Result = txtDoVor.Text;
            wordapp.ActiveDocument.FormFields["DoHaupt"].Result = txtDoHaupt.Text;
            wordapp.ActiveDocument.FormFields["DoNach"].Result = txtDoNach.Text;
            wordapp.ActiveDocument.FormFields["FrVor"].Result = txtFrVor.Text;
            wordapp.ActiveDocument.FormFields["FrHaupt"].Result = txtFrHaupt.Text;
            wordapp.ActiveDocument.FormFields["FrNach"].Result = txtFrNach.Text;
            
            wordapp.ActiveDocument.ExportAsFixedFormat(Application.StartupPath + "\\../../../" + wochenspeiseplanToolStripMenuItem.Text + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, true);
        }
        #endregion
    }
}
