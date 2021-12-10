using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bertani
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            home.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            home.BringToFront();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnTutorial.Top;
            tipsAndTrick.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHargaPasar_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHargaPasar.Top;
            hargaPasar.BringToFront();
        }

        private void btnLahanku_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnLahanku.Top;
            catatan.BringToFront();
        }

        private void btnTentangKami_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnTentangKami.Top;
            tentangKami.BringToFront();
        }
    }
}
