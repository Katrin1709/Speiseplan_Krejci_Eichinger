namespace Speiseplan_Krejci_Eichinger
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpeiseID = new System.Windows.Forms.TextBox();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.cbSpeiseart = new System.Windows.Forms.ComboBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpeiseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speiseart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bezeichnung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bild";
            // 
            // txtSpeiseID
            // 
            this.txtSpeiseID.Enabled = false;
            this.txtSpeiseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeiseID.Location = new System.Drawing.Point(416, 120);
            this.txtSpeiseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpeiseID.Name = "txtSpeiseID";
            this.txtSpeiseID.Size = new System.Drawing.Size(122, 31);
            this.txtSpeiseID.TabIndex = 4;
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBezeichnung.Location = new System.Drawing.Point(277, 350);
            this.txtBezeichnung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(262, 31);
            this.txtBezeichnung.TabIndex = 5;
            this.txtBezeichnung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBezeichnung_KeyPress);
            // 
            // cbSpeiseart
            // 
            this.cbSpeiseart.Enabled = false;
            this.cbSpeiseart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeiseart.FormattingEnabled = true;
            this.cbSpeiseart.Items.AddRange(new object[] {
            "Vorspeisen",
            "Hauptspeisen",
            "Nachspeisen"});
            this.cbSpeiseart.Location = new System.Drawing.Point(277, 234);
            this.cbSpeiseart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSpeiseart.Name = "cbSpeiseart";
            this.cbSpeiseart.Size = new System.Drawing.Size(262, 33);
            this.cbSpeiseart.TabIndex = 6;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.SystemColors.Window;
            this.btnSpeichern.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(71, 620);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(471, 44);
            this.btnSpeichern.TabIndex = 7;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBild
            // 
            this.txtBild.Location = new System.Drawing.Point(277, 473);
            this.txtBild.Name = "txtBild";
            this.txtBild.Size = new System.Drawing.Size(262, 26);
            this.txtBild.TabIndex = 8;
            this.txtBild.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(615, 752);
            this.Controls.Add(this.txtBild);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.cbSpeiseart);
            this.Controls.Add(this.txtBezeichnung);
            this.Controls.Add(this.txtSpeiseID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpeichern;
        internal System.Windows.Forms.TextBox txtSpeiseID;
        internal System.Windows.Forms.TextBox txtBezeichnung;
        internal System.Windows.Forms.ComboBox cbSpeiseart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox txtBild;
    }
}