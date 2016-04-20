using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMSNMP
{
    public partial class Properties_Dialog : Form
    {
        public Properties_Dialog()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            DialogAddUser diaadduser = new DialogAddUser();
            diaadduser.Show();
        }
    }
}
