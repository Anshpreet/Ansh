using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinFormsApp1
{
    public partial class CallAPI : Form
    {
        List<User> users = new List<User>();
        
        
        public CallAPI()
        {
            InitializeComponent();
            label2.Text = "";
            lname.Text = null;
            fname.Text = null;
            users.Add(new User() { 
                Id = 1,
            FirstName ="Amrita",
            LastName = "Hora"
            });
            users.Add(new User()
            {
                Id = 2,
                FirstName = "Anshpreet",
                LastName = "Kaur"
            });
            users.Add(new User()
            {
                Id=3,
                FirstName = "Aayushi",
                LastName = "Hardiya"
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayData.Text = "";
            foreach (User u in users)
            {
                displayData.Text = displayData.Text+ u.Id.ToString()+". "+ u.FirstName+ " " + u.LastName + "\n";
            }
            
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            displayData.Text = "";
            if (id.Text != null)
            {
                var user= users.Where(x => x.Id.ToString().Equals(id.Text)).FirstOrDefault();
                if (user != null)
                    displayData.Text = "User Id: " + user.Id.ToString() + 
                        "\nFirst Name: " + user.FirstName +
                        "\nLast Name: " + user.LastName + "\n";
                else
                    label2.Text = "The User Id you entered does not exist.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CallAPI_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(fname.Text=="" || lname.Text == "")
            {
                label2.Text = "First Name or Last Name cannot be empty";
                
            }
            else if(users.Where(x=>x.FirstName.Equals(fname.Text)).Any() &&
                users.Where(x => x.LastName.Equals(lname.Text)).Any())
            {
                label2.Text = "The user already exists";
            }
            else
            {
                User user= new User() { 
                Id = users.Count() +1,
                FirstName = fname.Text,
                LastName = lname.Text
                };
                users.Add(user);
                label2.Text = "User added successfully";
                displayData.Text = "User Id: " + user.Id.ToString() +
                        "\nFirst Name: " + user.FirstName +
                        "\nLast Name: " + user.LastName + "\n";
            }
        }
    }
}
