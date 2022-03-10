namespace Prettybike
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog catalog = new Catalog();    
            catalog.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}