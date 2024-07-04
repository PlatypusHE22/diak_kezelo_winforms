namespace DiakKezeloKor {
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
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbDiakok = new System.Windows.Forms.ListBox();
            this.lbEredmeny = new System.Windows.Forms.ListBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.panelSzulEv = new System.Windows.Forms.Panel();
            this.lblSzulEv = new System.Windows.Forms.Label();
            this.lblKivalasztottAdat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiakok
            // 
            this.lblDiakok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiakok.Location = new System.Drawing.Point(82, 29);
            this.lblDiakok.Name = "lblDiakok";
            this.lblDiakok.Size = new System.Drawing.Size(158, 23);
            this.lblDiakok.TabIndex = 1;
            this.lblDiakok.Text = "Diákok";
            this.lblDiakok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(118, 415);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 8;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 251);
            this.listBox1.TabIndex = 9;
            // 
            // lbDiakok
            // 
            this.lbDiakok.FormattingEnabled = true;
            this.lbDiakok.Location = new System.Drawing.Point(58, 61);
            this.lbDiakok.Name = "lbDiakok";
            this.lbDiakok.Size = new System.Drawing.Size(200, 342);
            this.lbDiakok.TabIndex = 9;
            // 
            // lbEredmeny
            // 
            this.lbEredmeny.FormattingEnabled = true;
            this.lbEredmeny.Location = new System.Drawing.Point(366, 178);
            this.lbEredmeny.Name = "lbEredmeny";
            this.lbEredmeny.Size = new System.Drawing.Size(383, 225);
            this.lbEredmeny.TabIndex = 10;
            this.lbEredmeny.SelectedIndexChanged += new System.EventHandler(this.lbEredmeny_SelectedIndexChanged);
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.Location = new System.Drawing.Point(366, 159);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(141, 16);
            this.lblEredmeny.TabIndex = 12;
            this.lblEredmeny.Text = "A keresés eredménye";
            // 
            // panelSzulEv
            // 
            this.panelSzulEv.AutoScroll = true;
            this.panelSzulEv.Location = new System.Drawing.Point(366, 61);
            this.panelSzulEv.Name = "panelSzulEv";
            this.panelSzulEv.Size = new System.Drawing.Size(383, 53);
            this.panelSzulEv.TabIndex = 13;
            // 
            // lblSzulEv
            // 
            this.lblSzulEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzulEv.Location = new System.Drawing.Point(466, 29);
            this.lblSzulEv.Name = "lblSzulEv";
            this.lblSzulEv.Size = new System.Drawing.Size(158, 23);
            this.lblSzulEv.TabIndex = 14;
            this.lblSzulEv.Text = "Születési év";
            this.lblSzulEv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKivalasztottAdat
            // 
            this.lblKivalasztottAdat.Location = new System.Drawing.Point(366, 415);
            this.lblKivalasztottAdat.Name = "lblKivalasztottAdat";
            this.lblKivalasztottAdat.Size = new System.Drawing.Size(383, 23);
            this.lblKivalasztottAdat.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKivalasztottAdat);
            this.Controls.Add(this.lblSzulEv);
            this.Controls.Add(this.panelSzulEv);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.lbEredmeny);
            this.Controls.Add(this.lbDiakok);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lblDiakok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblKivalasztottAdat;

        private System.Windows.Forms.Label lblSzulEv;

        private System.Windows.Forms.Label lblEredmeny;

        private System.Windows.Forms.Panel panelSzulEv;

        private System.Windows.Forms.ListBox lbEredmeny;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbDiakok;

        private System.Windows.Forms.Button btnAdatbevitel;

        private System.Windows.Forms.Label lblDiakok;

        #endregion
    }
}