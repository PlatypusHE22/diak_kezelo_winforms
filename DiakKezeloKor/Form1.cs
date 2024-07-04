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
using DiakKezelo;

namespace DiakKezeloKor {
    public partial class Form1 : Form {
        private BindingList<Diak> diakok = new BindingList<Diak>();
        private BindingList<Diak> kivalasztottDiakok = new BindingList<Diak>();
        private List<int> szuletesiEvek = new List<int>();

        public Form1()
        {
            InitializeComponent();
            lbDiakok.DataSource = diakok;
            lbDiakok.DisplayMember = "NevEsSzak";

            lbEredmeny.DataSource = kivalasztottDiakok;
            lbEredmeny.DisplayMember = "NevEsSzak";
        }

        private void btnAdatbevitel_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if(res == DialogResult.Cancel)
                return;

            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                HashSet<int> szuletesiEvekSet = new HashSet<int>();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    diakok.Add(new Diak(line[0], line[1], int.Parse(line[2])));
                    szuletesiEvekSet.Add(int.Parse(line[2]));
                }

                szuletesiEvek = new List<int>(szuletesiEvekSet);
            }

            szuletesiEvek.Sort();

            // Gombok hozzáadása
            foreach (int ev in szuletesiEvek)
            {
                Button b = new Button();

                b.Text = ev.ToString();
                b.Left = panelSzulEv.AutoScrollPosition.X + 60 * panelSzulEv.Controls.Count;
                b.Width = 45;
                b.Click += Kivalaszt;

                panelSzulEv.Controls.Add(b);
            }

            btnAdatbevitel.Enabled = false;
        }

        private void Kivalaszt(object sender, EventArgs e)
        {
            int kivalasztottEv = int.Parse((sender as Button).Text);
            kivalasztottDiakok.Clear();
            foreach (Diak diak in diakok)
            {
                if(diak.SzuletesiEv == kivalasztottEv)
                    kivalasztottDiakok.Add(diak);
            }
        }

        private void lbEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKivalasztottAdat.Text = (lbEredmeny.SelectedItem as Diak).ToString();
        }
    }
}