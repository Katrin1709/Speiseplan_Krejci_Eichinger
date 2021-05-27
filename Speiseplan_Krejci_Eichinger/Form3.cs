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

        Random rand = new Random();

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void alleSpeisenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.f1.ShowDialog();
            Form1.f1.alleSpeisenEinlesen();
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

        private void Drucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }
            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../Wochenspeiseplan.docx");
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
            //wordapp.ActiveDocument.Close(); schließt das offene Worddokument
            //wordapp.Quit(); schlißt word
        }
    }
}
