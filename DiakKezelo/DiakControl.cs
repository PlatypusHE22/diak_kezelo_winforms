using System.Windows.Forms;

namespace DiakKezelo {
    public partial class DiakControl : UserControl{
        private Diak diak;

        public bool Checked => checkBox.Checked;
        public Diak Diak => diak;

        public DiakControl(Diak diak)
        {
            InitializeComponent();
            this.diak = diak;
            checkBox.Text = diak.NevEsSzak;
        }
    }
}