namespace DiakKezelo {
    partial class Form1 {
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
            this.lblDiakok = new System.Windows.Forms.Label();
            this.lblKivalasztottak = new System.Windows.Forms.Label();
            this.panelDiakok = new System.Windows.Forms.Panel();
            this.lbKivalasztottak = new System.Windows.Forms.ListBox();
            this.lblLegidosebbek = new System.Windows.Forms.Label();
            this.lbLegidosebbek = new System.Windows.Forms.ListBox();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.lblKivalasztottAdat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiakok
            // 
            this.lblDiakok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiakok.Location = new System.Drawing.Point(106, 39);
            this.lblDiakok.Name = "lblDiakok";
            this.lblDiakok.Size = new System.Drawing.Size(158, 23);
            this.lblDiakok.TabIndex = 0;
            this.lblDiakok.Text = "Diákok";
            this.lblDiakok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKivalasztottak
            // 
            this.lblKivalasztottak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKivalasztottak.Location = new System.Drawing.Point(456, 39);
            this.lblKivalasztottak.Name = "lblKivalasztottak";
            this.lblKivalasztottak.Size = new System.Drawing.Size(158, 23);
            this.lblKivalasztottak.TabIndex = 1;
            this.lblKivalasztottak.Text = "Kiválasztottak";
            this.lblKivalasztottak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDiakok
            // 
            this.panelDiakok.AutoScroll = true;
            this.panelDiakok.Location = new System.Drawing.Point(66, 65);
            this.panelDiakok.Name = "panelDiakok";
            this.panelDiakok.Size = new System.Drawing.Size(240, 309);
            this.panelDiakok.TabIndex = 2;
            // 
            // lbKivalasztottak
            // 
            this.lbKivalasztottak.FormattingEnabled = true;
            this.lbKivalasztottak.Location = new System.Drawing.Point(432, 65);
            this.lbKivalasztottak.Name = "lbKivalasztottak";
            this.lbKivalasztottak.Size = new System.Drawing.Size(212, 173);
            this.lbKivalasztottak.TabIndex = 3;
            this.lbKivalasztottak.SelectedIndexChanged += new System.EventHandler(this.lbKivalasztottak_SelectedIndexChanged);
            // 
            // lblLegidosebbek
            // 
            this.lblLegidosebbek.Location = new System.Drawing.Point(432, 256);
            this.lblLegidosebbek.Name = "lblLegidosebbek";
            this.lblLegidosebbek.Size = new System.Drawing.Size(100, 23);
            this.lblLegidosebbek.TabIndex = 4;
            this.lblLegidosebbek.Text = "Legidősebbek";
            this.lblLegidosebbek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLegidosebbek
            // 
            this.lbLegidosebbek.FormattingEnabled = true;
            this.lbLegidosebbek.Location = new System.Drawing.Point(432, 282);
            this.lbLegidosebbek.Name = "lbLegidosebbek";
            this.lbLegidosebbek.Size = new System.Drawing.Size(212, 95);
            this.lbLegidosebbek.TabIndex = 5;
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Enabled = false;
            this.btnKivalaszt.Location = new System.Drawing.Point(231, 398);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 6;
            this.btnKivalaszt.Text = "Kiválaszt";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(66, 398);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 7;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // lblKivalasztottAdat
            // 
            this.lblKivalasztottAdat.Location = new System.Drawing.Point(432, 395);
            this.lblKivalasztottAdat.Name = "lblKivalasztottAdat";
            this.lblKivalasztottAdat.Size = new System.Drawing.Size(356, 26);
            this.lblKivalasztottAdat.TabIndex = 8;
            this.lblKivalasztottAdat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKivalasztottAdat);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.lbLegidosebbek);
            this.Controls.Add(this.lblLegidosebbek);
            this.Controls.Add(this.lbKivalasztottak);
            this.Controls.Add(this.panelDiakok);
            this.Controls.Add(this.lblKivalasztottak);
            this.Controls.Add(this.lblDiakok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lbLegidosebbek;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Button btnAdatbevitel;

        private System.Windows.Forms.Panel panelDiakok;
        private System.Windows.Forms.Label lblKivalasztottak;
        private System.Windows.Forms.ListBox lbKivalasztottak;
        private System.Windows.Forms.Label lblLegidosebbek;

        private System.Windows.Forms.Label lblKivalasztottAdat;

        private System.Windows.Forms.Label lblDiakok;

        #endregion
    }
}