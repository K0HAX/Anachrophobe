using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pushover;

namespace PushoverUsers
{
    public partial class Form1 : Form
    {
        Pushover.Users users;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users = Pushover.SaveStore.LoadControls();
            foreach(string user in users.GetUsers())
            {
                uxUsersListBox.Items.Add(user);
            }
        }

        private void uxAddBtn_Click(object sender, EventArgs e)
        {
            users.AddUser(uxNewUserTxt.Text);
            uxUsersListBox.Items.Add(uxNewUserTxt.Text);
            Pushover.SaveStore.SaveControls(users);
        }

        private void uxDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckedListBox.CheckedItemCollection checkedUsers = uxUsersListBox.CheckedItems;
                foreach (string user in checkedUsers)
                {
                    users.DelUser(user);
                    uxUsersListBox.Items.Remove(user);
                    Pushover.SaveStore.SaveControls(users);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
