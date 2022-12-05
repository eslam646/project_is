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
    public partial class FRM_Add_Customer : Form
    {
        pClasses.CLS_Customer cust = new pClasses.CLS_Customer();
        public FRM_Add_Customer()
        {
            InitializeComponent();
        }
        private void BTN_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_Enter.Text == "إضافة")
                {
                    FRM_Customer_UC.getforitemaction.dataGridView_Customer.DataSource = cust.Add_Customer(TXT_Name.Text, Convert.ToInt32(Txt_Num.Text), TXT_ADR.Text, COMP_Type.Text, TXT_Ema.Text);
                    MessageBox.Show("تم الإضافة بنجاح.", "إعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Num.Text = "";
                    TXT_Name.Text = "";
                    TXT_ADR.Text = "";
                    COMP_Type.Text = "";
                    TXT_Ema.Text = "";
                }
                else if (BTN_Enter.Text == "تعديل")
                {
                    FRM_Customer_UC.getforitemaction.dataGridView_Customer.DataSource = cust.Edite_Customer(Convert.ToInt32(TXT_ID.Text), TXT_Name.Text, Convert.ToInt32(Txt_Num.Text), TXT_ADR.Text, COMP_Type.Text, TXT_Ema.Text);
                    MessageBox.Show("تم التعديل بنجاح.", "إعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (FormatException m)
            {
                MessageBox.Show(m.ToString());
            }

        }
    }
}

