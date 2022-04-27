namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Page 1";
            textWelcome.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String fName= tbFirstName.Text;
            String lName= tbLastName.Text;
            textWelcome.Text = "Welcome, "+fName+" "+lName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text="";
            tbLastName.Text = "";
            textWelcome.Text = "";
        }
    }
}