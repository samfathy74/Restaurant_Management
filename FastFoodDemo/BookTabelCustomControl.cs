using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FastFoodDemo
{
    public partial class BookTabelCustomControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf; Integrated Security = True");
        SqlCommand cmd;
        public BookTabelCustomControl()
        {
            InitializeComponent();
        }
        // 
        // FormLoad
        // 
        private void BookTabelCustomControl_Load(object sender, EventArgs e)
        {
            bunifuDropdown1.AddItem("Select Tabel");
            bunifuDropdown1.AddItem("Tabel A1");
            bunifuDropdown1.AddItem("Tabel A2");
            bunifuDropdown1.AddItem("Tabel A3");

            dateTimePicker1.Value = DateTime.Now;

        }
        // 
        // Dropdown
        // 
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

            if (bunifuDropdown1.selectedIndex != 0)
            {
                button1.Visible = true;
                bunifuMaterialTextbox1.Visible = true;
                bunifuMaterialTextbox2.Visible = true;
                labelCall.Visible = true;


                label1.Visible = true;
                label2.Visible = true;

                dateTimePicker1.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                button1.Visible = false;
                bunifuMaterialTextbox1.Visible = false;
                bunifuMaterialTextbox2.Visible = false;

                label1.Visible = false;
                label2.Visible = false;

                dateTimePicker1.Visible = false;
                numericUpDown1.Visible = false;

                labelCall.Visible = false;
                labelCorrect1.Visible = false;
                labelCorrect2.Visible = false;
                labelX1.Visible = false;
                labelX2.Visible = false;
            }

        }
        // 
        // textboxname
        // 
        private void bunifuMaterialTextbox1_Validated(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.Length < 3)
            {
                labelX1.Visible = true;
                labelCorrect1.Visible = false;
                bunifuMaterialTextbox1.HintText = "Enter name at least 3 letter";

            }
            else
            {
                labelX1.Visible = false;
                labelCorrect1.Visible = true;
                bunifuMaterialTextbox1.HintText = "Name";

            }
        }
        // 
        // textboxphone
        // 
        private void bunifuMaterialTextbox2_Validated(object sender, EventArgs e)
        {
            labelCall.Visible = false;
            if (bunifuMaterialTextbox2.Text.Length != 11)
            {
                labelX2.Visible = true;
                labelCorrect2.Visible = false;
                bunifuMaterialTextbox2.HintText = "Enter valid number phone from 11 number";

            }
            else
            {
                labelX2.Visible = false;
                labelCorrect2.Visible = true;
                bunifuMaterialTextbox2.HintText = " phone number";

            }
        }
        // 
        // button
        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" && bunifuDropdown1.selectedIndex != 0 && labelX1.Visible != true && labelX2.Visible != true)
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Book (TabelId,NamePerson,Phone,NumofPerson,DateandTime)values(@TabelId,@NamePerson,@Phone,@NumofPerson,@DateandTime)", con);
                cmd.Parameters.AddWithValue("@TabelId", bunifuDropdown1.selectedValue);
                cmd.Parameters.AddWithValue("@NamePerson", bunifuMaterialTextbox1.Text);
                cmd.Parameters.AddWithValue("@Phone", bunifuMaterialTextbox2.Text);
                cmd.Parameters.AddWithValue("@NumofPerson", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@DateandTime", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                //=====================================Make Bill====================================================================//

                StreamWriter File = new StreamWriter("Report/" + bunifuMaterialTextbox1.Text + ".txt");
                File.WriteLine("+================================================================+");
                File.Write("||");
                File.Write("\t\t\t Welcome in Restarunt \t\t\t"); //title
                File.WriteLine("||");
                File.WriteLine("+================================================================+");

                File.WriteLine();

                File.WriteLine("+=========Tabel number================+");
                File.WriteLine("1. " + bunifuDropdown1.selectedValue);
                File.WriteLine("+===========Name Customer=============+");
                File.WriteLine("2. " + bunifuMaterialTextbox1.Text);
                File.WriteLine("+===========Phone number=============+");
                File.WriteLine("3. " + bunifuMaterialTextbox2.Text);
                File.WriteLine("+===========How many Persons============+");
                File.WriteLine("4. " + numericUpDown1.Text);
                File.WriteLine("+===========Time and Date===============+");
                File.WriteLine("5. " + dateTimePicker1.Text);

                File.Close();

                MessageBox.Show("Done ,booking confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuMaterialTextbox1.ResetText();
                bunifuMaterialTextbox2.ResetText();
                bunifuDropdown1.selectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Confirm enter Vaild data !", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

}
}
