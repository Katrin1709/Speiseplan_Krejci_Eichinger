namespace Speiseplan_Krejci_Eichinger
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewBewertung = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleSpeisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wochenspeiseplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speisenÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBewertung
            // 
            this.listViewBewertung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewBewertung.HideSelection = false;
            this.listViewBewertung.Location = new System.Drawing.Point(24, 36);
            this.listViewBewertung.Name = "listViewBewertung";
            this.listViewBewertung.Size = new System.Drawing.Size(1401, 690);
            this.listViewBewertung.TabIndex = 0;
            this.listViewBewertung.UseCompatibleStateImageBehavior = false;
            this.listViewBewertung.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorie";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bezeichnung";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bewertung";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speisenToolStripMenuItem,
            this.wochenspeiseplanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1451, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speisenToolStripMenuItem
            // 
            this.speisenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorspeiseToolStripMenuItem,
            this.hauptspeiseToolStripMenuItem,
            this.nachspeiseToolStripMenuItem,
            this.alleSpeisenToolStripMenuItem});
            this.speisenToolStripMenuItem.Name = "speisenToolStripMenuItem";
            this.speisenToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.speisenToolStripMenuItem.Text = "Speisen";
            // 
            // vorspeiseToolStripMenuItem
            // 
            this.vorspeiseToolStripMenuItem.Name = "vorspeiseToolStripMenuItem";
            this.vorspeiseToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.vorspeiseToolStripMenuItem.Text = "Vorspeisen";
            this.vorspeiseToolStripMenuItem.Click += new System.EventHandler(this.vorspeiseToolStripMenuItem_Click);
            // 
            // hauptspeiseToolStripMenuItem
            // 
            this.hauptspeiseToolStripMenuItem.Name = "hauptspeiseToolStripMenuItem";
            this.hauptspeiseToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.hauptspeiseToolStripMenuItem.Text = "Hauptspeisen";
            this.hauptspeiseToolStripMenuItem.Click += new System.EventHandler(this.hauptspeiseToolStripMenuItem_Click);
            // 
            // nachspeiseToolStripMenuItem
            // 
            this.nachspeiseToolStripMenuItem.Name = "nachspeiseToolStripMenuItem";
            this.nachspeiseToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.nachspeiseToolStripMenuItem.Text = "Nachspeisen";
            this.nachspeiseToolStripMenuItem.Click += new System.EventHandler(this.nachspeiseToolStripMenuItem_Click);
            // 
            // alleSpeisenToolStripMenuItem
            // 
            this.alleSpeisenToolStripMenuItem.Name = "alleSpeisenToolStripMenuItem";
            this.alleSpeisenToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.alleSpeisenToolStripMenuItem.Text = "Alle Speisen";
            this.alleSpeisenToolStripMenuItem.Click += new System.EventHandler(this.alleSpeisenToolStripMenuItem_Click);
            // 
            // wochenspeiseplanToolStripMenuItem
            // 
            this.wochenspeiseplanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speisenÄndernToolStripMenuItem});
            this.wochenspeiseplanToolStripMenuItem.Name = "wochenspeiseplanToolStripMenuItem";
            this.wochenspeiseplanToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.wochenspeiseplanToolStripMenuItem.Text = "Wochenspeiseplan";
            this.wochenspeiseplanToolStripMenuItem.Click += new System.EventHandler(this.wochenspeiseplanToolStripMenuItem_Click);
            // 
            // speisenÄndernToolStripMenuItem
            // 
            this.speisenÄndernToolStripMenuItem.Name = "speisenÄndernToolStripMenuItem";
            this.speisenÄndernToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.speisenÄndernToolStripMenuItem.Text = "Drucken";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1451, 752);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewBewertung);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bewertungen";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBewertung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleSpeisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wochenspeiseplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speisenÄndernToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}