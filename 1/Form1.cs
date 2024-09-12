using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Блакнот : Form
    {
        public Блакнот()
        {
            InitializeComponent();
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
