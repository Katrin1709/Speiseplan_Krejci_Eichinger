namespace Speiseplan_Krejci_Eichinger
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alleSpeisenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wochenspeiseplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speisenÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewSpeisen = new System.Windows.Forms.ListView();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.auswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vorspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseLöschen = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseBewertenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungenAnsehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewVorspeise = new System.Windows.Forms.ListView();
            this.listViewHauptspeise = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hauptspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseBewertenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungenAnsehenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewNachspeise = new System.Windows.Forms.ListView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nachspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseBewertenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungenAnsehenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbVorspeisen = new System.Windows.Forms.Label();
            this.lbNachspeisen = new System.Windows.Forms.Label();
            this.lbHauptspeisen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
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
            // listViewSpeisen
            // 
            this.listViewSpeisen.ContextMenuStrip = this.contextMenuStrip4;
            this.listViewSpeisen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSpeisen.HideSelection = false;
            this.listViewSpeisen.Location = new System.Drawing.Point(0, 33);
            this.listViewSpeisen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSpeisen.Name = "listViewSpeisen";
            this.listViewSpeisen.Size = new System.Drawing.Size(1451, 719);
            this.listViewSpeisen.TabIndex = 1;
            this.listViewSpeisen.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auswählenToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(241, 67);
            
            // 
            // auswählenToolStripMenuItem
            // 
            this.auswählenToolStripMenuItem.Name = "auswählenToolStripMenuItem";
            this.auswählenToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.auswählenToolStripMenuItem.Text = "Auswählen";
            this.auswählenToolStripMenuItem.Visible = false;
            this.auswählenToolStripMenuItem.Click += new System.EventHandler(this.auswählenToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorspeiseHinzufügen,
            this.vorspeiseBearbeiten,
            this.vorspeiseLöschen,
            this.vorspeiseBewertenToolStripMenuItem,
            this.bewertungenAnsehenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 154);
            // 
            // vorspeiseHinzufügen
            // 
            this.vorspeiseHinzufügen.Name = "vorspeiseHinzufügen";
            this.vorspeiseHinzufügen.Size = new System.Drawing.Size(257, 30);
            this.vorspeiseHinzufügen.Text = "Vorspeise hinzufügen";
            this.vorspeiseHinzufügen.Click += new System.EventHandler(this.vorspeiseHinzufügen_Click);
            // 
            // vorspeiseBearbeiten
            // 
            this.vorspeiseBearbeiten.Name = "vorspeiseBearbeiten";
            this.vorspeiseBearbeiten.Size = new System.Drawing.Size(257, 30);
            this.vorspeiseBearbeiten.Text = "Vorspeise bearbeiten";
            this.vorspeiseBearbeiten.Click += new System.EventHandler(this.vorspeiseBearbeiten_Click);
            // 
            // vorspeiseLöschen
            // 
            this.vorspeiseLöschen.Name = "vorspeiseLöschen";
            this.vorspeiseLöschen.Size = new System.Drawing.Size(257, 30);
            this.vorspeiseLöschen.Text = "Vorspeise löschen";
            this.vorspeiseLöschen.Click += new System.EventHandler(this.vorspeiseLöschen_Click);
            // 
            // vorspeiseBewertenToolStripMenuItem
            // 
            this.vorspeiseBewertenToolStripMenuItem.Name = "vorspeiseBewertenToolStripMenuItem";
            this.vorspeiseBewertenToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.vorspeiseBewertenToolStripMenuItem.Text = "Vorspeise bewerten";
            this.vorspeiseBewertenToolStripMenuItem.Click += new System.EventHandler(this.vorspeiseBewertenToolStripMenuItem_Click);
            // 
            // bewertungenAnsehenToolStripMenuItem
            // 
            this.bewertungenAnsehenToolStripMenuItem.Name = "bewertungenAnsehenToolStripMenuItem";
            this.bewertungenAnsehenToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.bewertungenAnsehenToolStripMenuItem.Text = "Bewertungen ansehen";
            this.bewertungenAnsehenToolStripMenuItem.Click += new System.EventHandler(this.bewertungenAnsehenToolStripMenuItem_Click);
            // 
            // listViewVorspeise
            // 
            this.listViewVorspeise.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewVorspeise.HideSelection = false;
            this.listViewVorspeise.Location = new System.Drawing.Point(17, 101);
            this.listViewVorspeise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewVorspeise.Name = "listViewVorspeise";
            this.listViewVorspeise.Size = new System.Drawing.Size(451, 635);
            this.listViewVorspeise.TabIndex = 3;
            this.listViewVorspeise.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHauptspeise
            // 
            this.listViewHauptspeise.ContextMenuStrip = this.contextMenuStrip2;
            this.listViewHauptspeise.HideSelection = false;
            this.listViewHauptspeise.Location = new System.Drawing.Point(493, 101);
            this.listViewHauptspeise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewHauptspeise.Name = "listViewHauptspeise";
            this.listViewHauptspeise.Size = new System.Drawing.Size(451, 635);
            this.listViewHauptspeise.TabIndex = 4;
            this.listViewHauptspeise.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptspeiseHinzufügen,
            this.hauptspeiseBearbeiten,
            this.hauptspeiseLöschenToolStripMenuItem,
            this.hauptspeiseBewertenToolStripMenuItem,
            this.bewertungenAnsehenToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(276, 154);
            // 
            // hauptspeiseHinzufügen
            // 
            this.hauptspeiseHinzufügen.Name = "hauptspeiseHinzufügen";
            this.hauptspeiseHinzufügen.Size = new System.Drawing.Size(275, 30);
            this.hauptspeiseHinzufügen.Text = "Hauptspeise hinzufügen";
            this.hauptspeiseHinzufügen.Click += new System.EventHandler(this.hauptspeiseHinzufügen_Click);
            // 
            // hauptspeiseBearbeiten
            // 
            this.hauptspeiseBearbeiten.Name = "hauptspeiseBearbeiten";
            this.hauptspeiseBearbeiten.Size = new System.Drawing.Size(275, 30);
            this.hauptspeiseBearbeiten.Text = "Hauptspeise bearbeiten";
            this.hauptspeiseBearbeiten.Click += new System.EventHandler(this.hauptspeiseBearbeiten_Click);
            // 
            // hauptspeiseLöschenToolStripMenuItem
            // 
            this.hauptspeiseLöschenToolStripMenuItem.Name = "hauptspeiseLöschenToolStripMenuItem";
            this.hauptspeiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.hauptspeiseLöschenToolStripMenuItem.Text = "Hauptspeise löschen";
            this.hauptspeiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.hauptspeiseLöschenToolStripMenuItem_Click);
            // 
            // hauptspeiseBewertenToolStripMenuItem
            // 
            this.hauptspeiseBewertenToolStripMenuItem.Name = "hauptspeiseBewertenToolStripMenuItem";
            this.hauptspeiseBewertenToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.hauptspeiseBewertenToolStripMenuItem.Text = "Hauptspeise bewerten";
            this.hauptspeiseBewertenToolStripMenuItem.Click += new System.EventHandler(this.hauptspeiseBewertenToolStripMenuItem_Click);
            // 
            // bewertungenAnsehenToolStripMenuItem1
            // 
            this.bewertungenAnsehenToolStripMenuItem1.Name = "bewertungenAnsehenToolStripMenuItem1";
            this.bewertungenAnsehenToolStripMenuItem1.Size = new System.Drawing.Size(275, 30);
            this.bewertungenAnsehenToolStripMenuItem1.Text = "Bewertungen ansehen";
            this.bewertungenAnsehenToolStripMenuItem1.Click += new System.EventHandler(this.bewertungenAnsehenToolStripMenuItem1_Click);
            // 
            // listViewNachspeise
            // 
            this.listViewNachspeise.ContextMenuStrip = this.contextMenuStrip3;
            this.listViewNachspeise.HideSelection = false;
            this.listViewNachspeise.Location = new System.Drawing.Point(974, 101);
            this.listViewNachspeise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewNachspeise.Name = "listViewNachspeise";
            this.listViewNachspeise.Size = new System.Drawing.Size(451, 635);
            this.listViewNachspeise.TabIndex = 5;
            this.listViewNachspeise.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachspeiseHinzufügen,
            this.nachspeiseBearbeiten,
            this.nachspeiseLöschenToolStripMenuItem,
            this.nachspeiseBewertenToolStripMenuItem,
            this.bewertungenAnsehenToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(267, 154);
            // 
            // nachspeiseHinzufügen
            // 
            this.nachspeiseHinzufügen.Name = "nachspeiseHinzufügen";
            this.nachspeiseHinzufügen.Size = new System.Drawing.Size(266, 30);
            this.nachspeiseHinzufügen.Text = "Nachspeise hinzufügen";
            this.nachspeiseHinzufügen.Click += new System.EventHandler(this.nachspeiseHinzufügen_Click);
            // 
            // nachspeiseBearbeiten
            // 
            this.nachspeiseBearbeiten.Name = "nachspeiseBearbeiten";
            this.nachspeiseBearbeiten.Size = new System.Drawing.Size(266, 30);
            this.nachspeiseBearbeiten.Text = "Nachspeise bearbeiten";
            this.nachspeiseBearbeiten.Click += new System.EventHandler(this.nachspeiseBearbeiten_Click);
            // 
            // nachspeiseLöschenToolStripMenuItem
            // 
            this.nachspeiseLöschenToolStripMenuItem.Name = "nachspeiseLöschenToolStripMenuItem";
            this.nachspeiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.nachspeiseLöschenToolStripMenuItem.Text = "Nachspeise löschen";
            this.nachspeiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.nachspeiseLöschenToolStripMenuItem_Click);
            // 
            // nachspeiseBewertenToolStripMenuItem
            // 
            this.nachspeiseBewertenToolStripMenuItem.Name = "nachspeiseBewertenToolStripMenuItem";
            this.nachspeiseBewertenToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.nachspeiseBewertenToolStripMenuItem.Text = "Nachspeise bewerten";
            this.nachspeiseBewertenToolStripMenuItem.Click += new System.EventHandler(this.nachspeiseBewertenToolStripMenuItem_Click);
            // 
            // bewertungenAnsehenToolStripMenuItem2
            // 
            this.bewertungenAnsehenToolStripMenuItem2.Name = "bewertungenAnsehenToolStripMenuItem2";
            this.bewertungenAnsehenToolStripMenuItem2.Size = new System.Drawing.Size(266, 30);
            this.bewertungenAnsehenToolStripMenuItem2.Text = "Bewertungen ansehen";
            this.bewertungenAnsehenToolStripMenuItem2.Click += new System.EventHandler(this.bewertungenAnsehenToolStripMenuItem2_Click);
            // 
            // lbVorspeisen
            // 
            this.lbVorspeisen.AutoSize = true;
            this.lbVorspeisen.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorspeisen.Location = new System.Drawing.Point(172, 61);
            this.lbVorspeisen.Name = "lbVorspeisen";
            this.lbVorspeisen.Size = new System.Drawing.Size(125, 33);
            this.lbVorspeisen.TabIndex = 6;
            this.lbVorspeisen.Text = "Vorspeisen";
            // 
            // lbNachspeisen
            // 
            this.lbNachspeisen.AutoSize = true;
            this.lbNachspeisen.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNachspeisen.Location = new System.Drawing.Point(1146, 61);
            this.lbNachspeisen.Name = "lbNachspeisen";
            this.lbNachspeisen.Size = new System.Drawing.Size(138, 33);
            this.lbNachspeisen.TabIndex = 7;
            this.lbNachspeisen.Text = "Nachspeisen";
            // 
            // lbHauptspeisen
            // 
            this.lbHauptspeisen.AutoSize = true;
            this.lbHauptspeisen.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHauptspeisen.Location = new System.Drawing.Point(639, 61);
            this.lbHauptspeisen.Name = "lbHauptspeisen";
            this.lbHauptspeisen.Size = new System.Drawing.Size(150, 33);
            this.lbHauptspeisen.TabIndex = 8;
            this.lbHauptspeisen.Text = "Hauptspeisen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1451, 752);
            this.Controls.Add(this.lbHauptspeisen);
            this.Controls.Add(this.lbNachspeisen);
            this.Controls.Add(this.lbVorspeisen);
            this.Controls.Add(this.listViewNachspeise);
            this.Controls.Add(this.listViewHauptspeise);
            this.Controls.Add(this.listViewVorspeise);
            this.Controls.Add(this.listViewSpeisen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speisen";
            this.Load += new System.EventHandler(this.Speiseplan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alleSpeisenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wochenspeiseplanToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseHinzufügen;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseLöschen;
        private System.Windows.Forms.ListView listViewHauptspeise;
        private System.Windows.Forms.ListView listViewNachspeise;
        internal System.Windows.Forms.Label lbVorspeisen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseHinzufügen;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseLöschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseHinzufügen;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speisenÄndernToolStripMenuItem;
        internal System.Windows.Forms.ListView listViewVorspeise;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseBewertenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewertungenAnsehenToolStripMenuItem;
        internal System.Windows.Forms.ListView listViewSpeisen;
        private System.Windows.Forms.ToolStripMenuItem hauptspeiseBewertenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewertungenAnsehenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nachspeiseBewertenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewertungenAnsehenToolStripMenuItem2;
        internal System.Windows.Forms.Label lbNachspeisen;
        internal System.Windows.Forms.Label lbHauptspeisen;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        internal System.Windows.Forms.ToolStripMenuItem auswählenToolStripMenuItem;
    }
}

