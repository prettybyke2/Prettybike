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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            amounts.Add(200);
            amounts.Add(300);
            amounts.Add(150);
            orders.Add("vélos noirs City 26''");
            orders.Add("vélos jaunes City 28''");
            orders.Add("vélos bleus City 28''");
        }

        public static List<string> orders = new List<string>();
        public static List<int> amounts = new List<int>();
        private void lbl_Identif_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


           

        }

        public static class myAmount
        {

            public static int currentAmount = amounts[0];

        }
        public static class myOrder
        {

            public static string currentOrder = orders[0];

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            switch ((txtbox_ID.Text, txtbox_Passwd.Text))
            {
                case ("Admin1", "1234") or ("Admin2", "5678") or ("", ""):
                    lbl_Connection.Text = "Connection réussie";
                    Manager_Part manager_Part = new Manager_Part();
                    manager_Part.Show();
                    manager_Part.lbl_ManagerName.Text = txtbox_ID.Text;
                    this.Hide();
                    manager_Part.txtbox_CurrentOrder.Text = myOrder.currentOrder;
                    manager_Part.lbl_amt_left.Text = Convert.ToString(myAmount.currentAmount);

                    break;

                case ("Builder", "1234") or ("Builder2", "5678"):
                    Builder_home builder_Home = new Builder_home(); 
                    this.Hide();
                    builder_Home.Show();
                break;

                default:
                    lbl_Connection.Text = "Informations incorrectes";
                    break;
            }
        }
    }
}
