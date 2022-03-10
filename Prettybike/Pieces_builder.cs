using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prettybike
{
    public partial class Pieces_builder : Form
    {
        public Pieces_builder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Builder_home f2 = new Builder_home();
            f2.Show();
        }
    }
}
