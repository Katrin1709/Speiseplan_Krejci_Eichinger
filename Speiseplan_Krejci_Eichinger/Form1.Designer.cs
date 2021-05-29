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
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vorspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseLöschen = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewVorspeise = new System.Windows.Forms.ListView();
            this.listViewHauptspeise = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hauptspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptspeiseLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewNachspeise = new System.Windows.Forms.ListView();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nachspeiseHinzufügen = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.nachspeiseLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vorspeiseBewertenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewertungenAnsehenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speisenToolStripMenuItem,
            this.wochenspeiseplanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 28);
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
            this.speisenToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.speisenToolStripMenuItem.Text = "Speisen";
            // 
            // vorspeiseToolStripMenuItem
            // 
            this.vorspeiseToolStripMenuItem.Name = "vorspeiseToolStripMenuItem";
            this.vorspeiseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.vorspeiseToolStripMenuItem.Text = "Vorspeisen";
            this.vorspeiseToolStripMenuItem.Click += new System.EventHandler(this.vorspeiseToolStripMenuItem_Click);
            // 
            // hauptspeiseToolStripMenuItem
            // 
            this.hauptspeiseToolStripMenuItem.Name = "hauptspeiseToolStripMenuItem";
            this.hauptspeiseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hauptspeiseToolStripMenuItem.Text = "Hauptspeisen";
            this.hauptspeiseToolStripMenuItem.Click += new System.EventHandler(this.hauptspeiseToolStripMenuItem_Click);
            // 
            // nachspeiseToolStripMenuItem
            // 
            this.nachspeiseToolStripMenuItem.Name = "nachspeiseToolStripMenuItem";
            this.nachspeiseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nachspeiseToolStripMenuItem.Text = "Nachspeisen";
            this.nachspeiseToolStripMenuItem.Click += new System.EventHandler(this.nachspeiseToolStripMenuItem_Click);
            // 
            // alleSpeisenToolStripMenuItem
            // 
            this.alleSpeisenToolStripMenuItem.Name = "alleSpeisenToolStripMenuItem";
            this.alleSpeisenToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.alleSpeisenToolStripMenuItem.Text = "Alle Speisen";
            this.alleSpeisenToolStripMenuItem.Click += new System.EventHandler(this.alleSpeisenToolStripMenuItem_Click);
            // 
            // wochenspeiseplanToolStripMenuItem
            // 
            this.wochenspeiseplanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speisenÄndernToolStripMenuItem});
            this.wochenspeiseplanToolStripMenuItem.Name = "wochenspeiseplanToolStripMenuItem";
            this.wochenspeiseplanToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.wochenspeiseplanToolStripMenuItem.Text = "Wochenspeiseplan";
            this.wochenspeiseplanToolStripMenuItem.Click += new System.EventHandler(this.wochenspeiseplanToolStripMenuItem_Click);
            // 
            // speisenÄndernToolStripMenuItem
            // 
            this.speisenÄndernToolStripMenuItem.Name = "speisenÄndernToolStripMenuItem";
            this.speisenÄndernToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.speisenÄndernToolStripMenuItem.Text = "Drucken";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1290, 574);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 124);
            // 
            // vorspeiseHinzufügen
            // 
            this.vorspeiseHinzufügen.Name = "vorspeiseHinzufügen";
            this.vorspeiseHinzufügen.Size = new System.Drawing.Size(223, 24);
            this.vorspeiseHinzufügen.Text = "Vorspeise hinzufügen";
            this.vorspeiseHinzufügen.Click += new System.EventHandler(this.vorspeiseHinzufügen_Click);
            // 
            // vorspeiseBearbeiten
            // 
            this.vorspeiseBearbeiten.Name = "vorspeiseBearbeiten";
            this.vorspeiseBearbeiten.Size = new System.Drawing.Size(223, 24);
            this.vorspeiseBearbeiten.Text = "Vorspeise bearbeiten";
            this.vorspeiseBearbeiten.Click += new System.EventHandler(this.vorspeiseBearbeiten_Click);
            // 
            // vorspeiseLöschen
            // 
            this.vorspeiseLöschen.Name = "vorspeiseLöschen";
            this.vorspeiseLöschen.Size = new System.Drawing.Size(223, 24);
            this.vorspeiseLöschen.Text = "Vorspeise löschen";
            this.vorspeiseLöschen.Click += new System.EventHandler(this.vorspeiseLöschen_Click);
            // 
            // listViewVorspeise
            // 
            this.listViewVorspeise.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewVorspeise.HideSelection = false;
            this.listViewVorspeise.Location = new System.Drawing.Point(15, 81);
            this.listViewVorspeise.Name = "listViewVorspeise";
            this.listViewVorspeise.Size = new System.Drawing.Size(401, 509);
            this.listViewVorspeise.TabIndex = 3;
            this.listViewVorspeise.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHauptspeise
            // 
            this.listViewHauptspeise.ContextMenuStrip = this.contextMenuStrip2;
            this.listViewHauptspeise.HideSelection = false;
            this.listViewHauptspeise.Location = new System.Drawing.Point(438, 81);
            this.listViewHauptspeise.Name = "listViewHauptspeise";
            this.listViewHauptspeise.Size = new System.Drawing.Size(401, 509);
            this.listViewHauptspeise.TabIndex = 4;
            this.listViewHauptspeise.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptspeiseHinzufügen,
            this.hauptspeiseBearbeiten,
            this.hauptspeiseLöschenToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(238, 76);
            // 
            // hauptspeiseHinzufügen
            // 
            this.hauptspeiseHinzufügen.Name = "hauptspeiseHinzufügen";
            this.hauptspeiseHinzufügen.Size = new System.Drawing.Size(237, 24);
            this.hauptspeiseHinzufügen.Text = "Hauptspeise hinzufügen";
            this.hauptspeiseHinzufügen.Click += new System.EventHandler(this.hauptspeiseHinzufügen_Click);
            // 
            // hauptspeiseBearbeiten
            // 
            this.hauptspeiseBearbeiten.Name = "hauptspeiseBearbeiten";
            this.hauptspeiseBearbeiten.Size = new System.Drawing.Size(237, 24);
            this.hauptspeiseBearbeiten.Text = "Hauptspeise bearbeiten";
            this.hauptspeiseBearbeiten.Click += new System.EventHandler(this.hauptspeiseBearbeiten_Click);
            // 
            // hauptspeiseLöschenToolStripMenuItem
            // 
            this.hauptspeiseLöschenToolStripMenuItem.Name = "hauptspeiseLöschenToolStripMenuItem";
            this.hauptspeiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.hauptspeiseLöschenToolStripMenuItem.Text = "Hauptspeise löschen";
            this.hauptspeiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.hauptspeiseLöschenToolStripMenuItem_Click);
            // 
            // listViewNachspeise
            // 
            this.listViewNachspeise.ContextMenuStrip = this.contextMenuStrip3;
            this.listViewNachspeise.HideSelection = false;
            this.listViewNachspeise.Location = new System.Drawing.Point(866, 81);
            this.listViewNachspeise.Name = "listViewNachspeise";
            this.listViewNachspeise.Size = new System.Drawing.Size(401, 509);
            this.listViewNachspeise.TabIndex = 5;
            this.listViewNachspeise.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachspeiseHinzufügen,
            this.nachspeiseBearbeiten,
            this.nachspeiseLöschenToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(231, 76);
            // 
            // nachspeiseHinzufügen
            // 
            this.nachspeiseHinzufügen.Name = "nachspeiseHinzufügen";
            this.nachspeiseHinzufügen.Size = new System.Drawing.Size(230, 24);
            this.nachspeiseHinzufügen.Text = "Nachspeise hinzufügen";
            this.nachspeiseHinzufügen.Click += new System.EventHandler(this.nachspeiseHinzufügen_Click);
            // 
            // nachspeiseBearbeiten
            // 
            this.nachspeiseBearbeiten.Name = "nachspeiseBearbeiten";
            this.nachspeiseBearbeiten.Size = new System.Drawing.Size(230, 24);
            this.nachspeiseBearbeiten.Text = "Nachspeise bearbeiten";
            this.nachspeiseBearbeiten.Click += new System.EventHandler(this.nachspeiseBearbeiten_Click);
            // 
            // nachspeiseLöschenToolStripMenuItem
            // 
            this.nachspeiseLöschenToolStripMenuItem.Name = "nachspeiseLöschenToolStripMenuItem";
            this.nachspeiseLöschenToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.nachspeiseLöschenToolStripMenuItem.Text = "Nachspeise löschen";
            this.nachspeiseLöschenToolStripMenuItem.Click += new System.EventHandler(this.nachspeiseLöschenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vorspeisen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1019, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nachspeisen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hauptspeisen";
            // 
            // vorspeiseBewertenToolStripMenuItem
            // 
            this.vorspeiseBewertenToolStripMenuItem.Name = "vorspeiseBewertenToolStripMenuItem";
            this.vorspeiseBewertenToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.vorspeiseBewertenToolStripMenuItem.Text = "Vorspeise bewerten";
            // 
            // bewertungenAnsehenToolStripMenuItem
            // 
            this.bewertungenAnsehenToolStripMenuItem.Name = "bewertungenAnsehenToolStripMenuItem";
            this.bewertungenAnsehenToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.bewertungenAnsehenToolStripMenuItem.Text = "Bewertungen ansehen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewNachspeise);
            this.Controls.Add(this.listViewHauptspeise);
            this.Controls.Add(this.listViewVorspeise);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Speiseplan";
            this.Load += new System.EventHandler(this.Speiseplan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
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
        internal System.Windows.Forms.ListView listView1;
    }
}

