using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dropDownMenu1.Show(btnSolicitudes, btnSolicitudes.Width, 0);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            dropDownMenu2.Show(btnGestion, btnGestion.Width, 0);
        }
    }
}
