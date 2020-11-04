namespace Matek_Form20201104
{
    partial class foForm
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
            this.lbEredmenyek = new System.Windows.Forms.ListBox();
            this.btnAtlag = new System.Windows.Forms.Button();
            this.btnHanyadik = new System.Windows.Forms.Button();
            this.btnHanyszor = new System.Windows.Forms.Button();
            this.btnVanE = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEredmenyek
            // 
            this.lbEredmenyek.FormattingEnabled = true;
            this.lbEredmenyek.ItemHeight = 20;
            this.lbEredmenyek.Location = new System.Drawing.Point(40, 81);
            this.lbEredmenyek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbEredmenyek.Name = "lbEredmenyek";
            this.lbEredmenyek.Size = new System.Drawing.Size(394, 244);
            this.lbEredmenyek.TabIndex = 0;
            // 
            // btnAtlag
            // 
            this.btnAtlag.Location = new System.Drawing.Point(40, 34);
            this.btnAtlag.Name = "btnAtlag";
            this.btnAtlag.Size = new System.Drawing.Size(75, 27);
            this.btnAtlag.TabIndex = 1;
            this.btnAtlag.Text = "Átlag";
            this.btnAtlag.UseVisualStyleBackColor = true;
            this.btnAtlag.Click += new System.EventHandler(this.btnAtlag_Click);
            // 
            // btnHanyadik
            // 
            this.btnHanyadik.Location = new System.Drawing.Point(139, 34);
            this.btnHanyadik.Name = "btnHanyadik";
            this.btnHanyadik.Size = new System.Drawing.Size(75, 27);
            this.btnHanyadik.TabIndex = 2;
            this.btnHanyadik.Text = "Hanyadik";
            this.btnHanyadik.UseVisualStyleBackColor = true;
            this.btnHanyadik.Click += new System.EventHandler(this.btnHanyadik_Click);
            // 
            // btnHanyszor
            // 
            this.btnHanyszor.Location = new System.Drawing.Point(250, 34);
            this.btnHanyszor.Name = "btnHanyszor";
            this.btnHanyszor.Size = new System.Drawing.Size(75, 27);
            this.btnHanyszor.TabIndex = 3;
            this.btnHanyszor.Text = "Hanyszor";
            this.btnHanyszor.UseVisualStyleBackColor = true;
            this.btnHanyszor.Click += new System.EventHandler(this.btnHanyszor_Click);
            // 
            // btnVanE
            // 
            this.btnVanE.Location = new System.Drawing.Point(359, 34);
            this.btnVanE.Name = "btnVanE";
            this.btnVanE.Size = new System.Drawing.Size(75, 27);
            this.btnVanE.TabIndex = 4;
            this.btnVanE.Text = "Van-e";
            this.btnVanE.UseVisualStyleBackColor = true;
            this.btnVanE.Click += new System.EventHandler(this.btnVanE_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(139, 333);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 27);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(271, 333);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 27);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // foForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 394);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnVanE);
            this.Controls.Add(this.btnHanyszor);
            this.Controls.Add(this.btnHanyadik);
            this.Controls.Add(this.btnAtlag);
            this.Controls.Add(this.lbEredmenyek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "foForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adat.txt Feldolgozó";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEredmenyek;
        private System.Windows.Forms.Button btnAtlag;
        private System.Windows.Forms.Button btnHanyadik;
        private System.Windows.Forms.Button btnHanyszor;
        private System.Windows.Forms.Button btnVanE;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

