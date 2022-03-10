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
    public partial class Builder_home : Form
    {
        public Builder_home()
        {
            InitializeComponent();
        }

        private void lbl_Builder_Click(object sender, EventArgs e)
        {

        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar_Builder f5 = new Calendar_Builder();
            f5.Show();
        }

        private void btn_piecies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pieces_builder f2 = new Pieces_builder();
            f2.Show();
        }
    }
}
