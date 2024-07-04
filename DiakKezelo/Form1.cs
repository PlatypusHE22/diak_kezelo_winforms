using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiakKezelo {
    public partial class Form1 : Form {
        private List<Diak> diakok = new List<Diak>();
        private BindingList<Diak> kivalasztottDiakok = new BindingList<Diak>();
        private BindingList<Diak> legidosebbDiakok = new BindingList<Diak>();

        public Form1()
        {
            InitializeComponent();
            lbKivalasztottak.DataSource = kivalasztottDiakok;
            lbKivalasztottak.DisplayMember = "NevEsSzak";

            lbLegidosebbek.DataSource = legidosebbDiakok;
            lbLegidosebbek.DisplayMember = "NevEsSzak";
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        diakok.Add(new Diak(line[0], line[1], int.Parse(line[2])));
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Hiba történt a fáll beolvasása során: " + exception.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < diakok.Count; i++)
            {
                int top = panelDiakok.AutoScrollPosition.Y + 30 * i;

                DiakControl control = new DiakControl(diakok[i]);
                control.Top = top;

                panelDiakok.Controls.Add(control);
            }

            btnAdatbevitel.Enabled = false;
            btnKivalaszt.Enabled = true;
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            kivalasztottDiakok.Clear();
            legidosebbDiakok.Clear();
            foreach (DiakControl con in panelDiakok.Controls)
            {
                if(con.Checked)
                    kivalasztottDiakok.Add(con.Diak);
            }

            if (kivalasztottDiakok.Count <= 0)
                return;

            // Legidősebb diakok
            int legidosebbKor = kivalasztottDiakok.Max(x => x.Kor);
            foreach (Diak diak in kivalasztottDiakok.Where(x => x.Kor == legidosebbKor))
            {
                legidosebbDiakok.Add(diak);
            }
        }

        private void lbKivalasztottak_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKivalasztottAdat.Text = "";
            if (kivalasztottDiakok.Count <= 0)
                return;

            lblKivalasztottAdat.Text = (lbKivalasztottak.SelectedItem as Diak).ToString();
        }
    }
}