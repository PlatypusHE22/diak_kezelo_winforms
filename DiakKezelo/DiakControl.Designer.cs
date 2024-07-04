using System.ComponentModel;

namespace DiakKezelo {
    partial class DiakControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Location = new System.Drawing.Point(3, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(228, 24);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "checkBox1";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // DiakControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.checkBox);
            this.Name = "DiakControl";
            this.Size = new System.Drawing.Size(187, 29);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBox;

        #endregion
    }
}