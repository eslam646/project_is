using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Final_IS.PL
{
    public partial class FRM_Add_Moive : Form
    {
        public FRM_Add_Moive()
        {
            InitializeComponent();
        }

        private void FRM_Add_Moive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_ISDataSet1.Language_Of_Movies' table. You can move, or remove it, as needed.
            this.language_Of_MoviesTableAdapter1.Fill(this.project_ISDataSet1.Language_Of_Movies);
            // TODO: This line of code loads data into the 'project_ISDataSet1.Quality_Of_Movies' table. You can move, or remove it, as needed.
            this.quality_Of_MoviesTableAdapter1.Fill(this.project_ISDataSet1.Quality_Of_Movies);
            // TODO: This line of code loads data into the 'project_ISDataSet1.Type_Of_Movies' table. You can move, or remove it, as needed.
            this.type_Of_MoviesTableAdapter1.Fill(this.project_ISDataSet1.Type_Of_Movies);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BTN_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTN_Enter.Text == "إضافة")
                {
                    DAL.Data Data = new DAL.Data();
                    pClasses.CLS_Movies CLS_Movies = new pClasses.CLS_Movies();
                    FRM_Movies_UC.getforitemaction.dataGridView_Movies.DataSource = CLS_Movies.Add_Item(TXT_Name.Text, TXT_Desc.Text, Txt_Actors.Text, Convert.ToInt32(TXT_Duar.Text), Convert.ToInt32(TXT_Quant.Text), COMP_Type.SelectedIndex, COMP_Qualty.SelectedIndex, COMP_Lang.SelectedIndex, Convert.ToInt32(TXT_Date.Text));
                    MessageBox.Show("تم الإضافة بنجاح.", "إعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_Movies_UC.getforitemaction.dataGridView_Movies.DataSource = Data.Query(null, "Get_All_Movies_As");
                    TXT_ID.Text =TXT_Name.Text =Txt_Actors.Text = TXT_Desc.Text =TXT_Duar.Text =TXT_Quant.Text =TXT_ID.Text = "";
                    TXT_ID.Focus();
                }

                else if (BTN_Enter.Text == "تعديل")
                {
                    DAL.Data Data = new DAL.Data();
                    pClasses.CLS_Movies CLS_Movies0 = new pClasses.CLS_Movies();
                    FRM_Movies_UC.getforitemaction.dataGridView_Movies.DataSource = CLS_Movies0.Edite_Movie(TXT_ID.Text, TXT_Name.Text, TXT_Desc.Text, Txt_Actors.Text, Convert.ToInt32(TXT_Duar.Text), Convert.ToInt32(TXT_Quant.Text), COMP_Type.SelectedIndex, COMP_Qualty.SelectedIndex, COMP_Lang.SelectedIndex, Convert.ToInt32(TXT_Date.Text));
                    MessageBox.Show("تم التعديل بنجاح.", "إعلام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("الرجاء اكمال كل الحقول");
            }
        }
    }
}
