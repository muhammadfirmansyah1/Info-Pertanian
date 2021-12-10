using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bertani
{
    public partial class Catatan : UserControl
    {
        public Catatan()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            LahankuTambahForm lahankuTambahForm = new LahankuTambahForm();
            lahankuTambahForm.ShowDialog();
        }
    }
}
