using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FastFoodDemo
{
    public partial class EmployeesCustomControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf; Integrated Security = True");
        SqlCommand cmd;
        public EmployeesCustomControl()
        {
            InitializeComponent();
        }
        // 
        // method reset
        // 
        private void Reset()
        {
            TextboxPass.Visible = false;
            labelPass.Visible = false;
            TextboxPass.ResetText();
            Submit.Visible = false;
            CustomDataGrid1.Visible = false;
            Incorrect.Visible = false;
        }
        // 
        // button
        // 
        private void ButtonSwitch1_OnValueChange(object sender, EventArgs e)
        {

            if (ButtonSwitch1.Value == false)
            {
                Reset();
            }
            else 
            {
                TextboxPass.Visible = true;
                labelPass.Visible = true;
                Submit.Visible = true;

            }
        }
        // 
        // button
        // 
        private void Submit_Click(object sender, EventArgs e)
        {
                if (TextboxPass.Text == "8080")
                {
       
                cmd = new SqlCommand("select * from Tbl_Emp", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                CustomDataGrid1.DataSource = dt;

                CustomDataGrid1.Visible = true;
                TextboxPass.Visible = false;
                labelPass.Visible = false;

                Submit.Visible = false;

                Incorrect.Visible = false;
                TextboxPass.ResetText();

            }
            else
            {
                CustomDataGrid1.Visible = false;
                Incorrect.Visible = true;
            }
        }
    }
}
