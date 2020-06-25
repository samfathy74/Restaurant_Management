using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FastFoodDemo
{
    public partial class MenuUserControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf; Integrated Security = True");
        SqlCommand cmd;

        public MenuUserControl()
        {
            InitializeComponent();
            TypeDropDownList.AddItem("Select Order");
            TypeDropDownList.AddItem("Pizza");
            TypeDropDownList.AddItem("Hamburger");
            TypeDropDownList.AddItem("Cheeseburger");
            TypeDropDownList.AddItem("Hot dog");
            TypeDropDownList.AddItem("Noodle");
            TypeDropDownList.AddItem("Fried chicken");
            TypeDropDownList.AddItem("Cola");
            TypeDropDownList.AddItem("Soft Drink");
            TypeDropDownList.AddItem("Ice Cream");


            SizeDropDownList.AddItem("");
            SizeDropDownList.AddItem("Small");
            SizeDropDownList.AddItem("Middle");
            SizeDropDownList.AddItem("Large");


        }
        // 
        // form load
        // 
        private void MenuUserControl_Click(object sender, EventArgs e)
        {

        }
        // 
        // Dropdown order
        // 
        private void PizzaSmall_Click(object sender, EventArgs e)
        {
            if (TypeDropDownList.selectedIndex != 0)
            {
                SizeDropDownList.Enabled = true;
            }
            else
            {
                SizeDropDownList.Enabled = false;
                SizeDropDownList.selectedIndex = 0;

                panelRadio.Visible = false;
                SubmitPanal.Visible = false;

            }
        }
        //
        //Retrive price of order from database
        //
        private void GetPrice()
        {
            con.Open();
            cmd = new SqlCommand("select OrderPrice from Tbl_Price where OrderName='" + TypeDropDownList.selectedValue + "' and OrderSize='" + SizeDropDownList.selectedValue + "'", con);

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                PriceLabel.Text = read["OrderPrice"].ToString();
            }
            con.Close();
        }
        // 
        // Dropdown size
        // 
        private void SizeDropDownList_onItemSelected(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;

            if (SizeDropDownList.selectedIndex != 0)
            {
                dateTimePicker1.Visible = true;
                labelTimeDate.Visible = true;
                panelRadio.Visible = true;
                PriceLabel.Visible = true;
                labelPriceInfo.Visible = true;

                GetPrice();
            }
            else
            {
                dateTimePicker1.Visible = false;
                labelTimeDate.Visible = false;

                PriceLabel.Visible = false;
                labelPriceInfo.Visible = false;
                panelRadio.Visible = false;
            }
        }
        // 
        // button
        // 
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string Type;
            if (DeliveryButton.Checked == true)
            {
                Type = DeliveryButton.Text;
            }
            else
            {
                Type = TakeAwayButton.Text;
            }

            if ((txtName.Text != "" || txtPhone.Text != "" || txtAddress.Text != "") && SizeDropDownList.selectedIndex != 0 && TypeDropDownList.selectedIndex != 0 && Incorrectname.Visible != true && IncorrectPhone.Visible != true && IncorrectAddress.Visible != true)
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Order(OrderName, OrderSize, Price, OrderType, Name, Address, Phone, OrderDateandTime)values(@OrderName, @OrderSize, @Price, @OrderType, @Name, @Address, @Phone, @OrderDateandTime)", con);
                cmd.Parameters.AddWithValue("@OrderName", TypeDropDownList.selectedValue);
                cmd.Parameters.AddWithValue("@OrderSize", SizeDropDownList.selectedValue);
                cmd.Parameters.AddWithValue("@Price", PriceLabel.Text);
                cmd.Parameters.AddWithValue("@OrderType", Type);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@OrderDateandTime", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                //=========================================================================================================//

                StreamWriter File = new StreamWriter("Billing/" + txtName.Text + ".txt");
                File.WriteLine("+================================================================+");
                File.Write("||");
                File.Write("\t\t\t Welcome in Restarunt \t\t\t"); //title
                File.WriteLine("||");
                File.WriteLine("+=============================Billing===================================+");

                File.WriteLine();

                File.WriteLine("+=========order================+");
                File.WriteLine("1. " + TypeDropDownList.selectedValue);
                File.WriteLine("+===========Size=============+");
                File.WriteLine("2. " + SizeDropDownList.selectedValue);
                File.WriteLine("+===========Price============+");
                File.WriteLine("3. " + labelPriceInfo.Text);
                File.WriteLine("+===========Type make order============+");
                File.WriteLine("4. " + Type);
                File.WriteLine("+===========Name============+");
                File.WriteLine("5. " + txtName.Text);
                File.WriteLine("+===========Phone number=============+");
                File.WriteLine("6. " + txtPhone.Text);
                File.WriteLine("+===========Address============+");
                File.WriteLine("7. " + txtAddress.Text);
                File.WriteLine("+===========Time and Date===============+");
                File.WriteLine("8. " + dateTimePicker1.Text);

                File.Close();


                MessageBox.Show("Done ,booking confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                Type = "";

            }
            else
            {
                MessageBox.Show("Confirm enter Vaild data !", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 
        // Radio take away 
        // 
        private void TakeAwayButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (TakeAwayButton.Checked == true)
            {
                DeliveryButton.Checked = false;
                txtName.Visible = true;
                txtAddress.Visible = false;
                txtPhone.Visible = false;
                buttonSubmit.Visible = true;
                SubmitPanal.Visible = true;
            }
            else
            {
                TakeAwayButton.Checked = false;
                CorrectAddres.Visible = false;
                CorrectName.Visible = false;
                CorrectPhone.Visible = false;

                IncorrectAddress.Visible = false;
                Incorrectname.Visible = false;
                IncorrectPhone.Visible = false;
                SubmitPanal.Visible = false;


            }
        }
        // 
        // Delivery radio
        // 
        private void DeliveryButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (DeliveryButton.Checked == true)
            {
                TakeAwayButton.Checked = false;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                buttonSubmit.Visible = true;

                SubmitPanal.Visible = true;

            }
            else
            {
                DeliveryButton.Checked = false;
                CorrectAddres.Visible = false;
                CorrectName.Visible = false;
                CorrectPhone.Visible = false;

                IncorrectAddress.Visible = false;
                Incorrectname.Visible = false;
                IncorrectPhone.Visible = false;
                SubmitPanal.Visible = false;

            }
        }

        private void MenuUserControl_Load(object sender, EventArgs e)
        {

        }
        // 
        // textbox name
        // 
        private void txtName_Validated(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                Incorrectname.Visible = true;
                CorrectName.Visible = false;

            }
            else
            {
                CorrectName.Visible = true;
                Incorrectname.Visible = false;
            }
        }
        // 
        // textbox phone
        // 
        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length != 11)
            {
                IncorrectPhone.Visible = true;
                CorrectPhone.Visible = false;
                txtPhone.HintText = "Enter valid number phone from 11 number";
            }
            else
            {
                CorrectPhone.Visible = true;
                IncorrectPhone.Visible = false;
                txtPhone.HintText = "phone number";
            }
        }
        // 
        // textbox address
        // 
        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
            {
                IncorrectAddress.Visible = true;
                CorrectAddres.Visible = false;

            }
            else
            {
                CorrectAddres.Visible = true;
                IncorrectAddress.Visible = false;
            }
        }
        protected void Reset()
        {
            txtAddress.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();

            TypeDropDownList.selectedIndex = 0;
            labelPriceInfo.Visible = false;

        }
    }
}
