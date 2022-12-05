using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final_IS.PL
{
    public partial class FRM_Add_User_UC : Form
    {
        pClasses.CLS_Login CLS_Login = new pClasses.CLS_Login();
        public FRM_Add_User_UC()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CLS_Login.New_User(TXT_UserName.Text, TXT_Password.Text); 
            Close();
        }
    }
}
