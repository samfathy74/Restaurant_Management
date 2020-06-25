namespace FastFoodDemo
{
    partial class EmployeesCustomControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesCustomControl));
            this.tblEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ButtonSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelPass = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Incorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEmpBindingSource
            // 
            this.tblEmpBindingSource.DataMember = "Tbl_Emp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees Update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomDataGrid1
            // 
            this.CustomDataGrid1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomDataGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.CustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomDataGrid1.DoubleBuffered = true;
            this.CustomDataGrid1.EnableHeadersVisualStyles = false;
            this.CustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.CustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.CustomDataGrid1.Location = new System.Drawing.Point(15, 102);
            this.CustomDataGrid1.Name = "CustomDataGrid1";
            this.CustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomDataGrid1.Size = new System.Drawing.Size(787, 338);
            this.CustomDataGrid1.TabIndex = 0;
            this.CustomDataGrid1.Visible = false;
            // 
            // ButtonSwitch1
            // 
            this.ButtonSwitch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSwitch1.BackgroundImage")));
            this.ButtonSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSwitch1.Location = new System.Drawing.Point(682, 40);
            this.ButtonSwitch1.Name = "ButtonSwitch1";
            this.ButtonSwitch1.OffColor = System.Drawing.Color.Red;
            this.ButtonSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.ButtonSwitch1.Size = new System.Drawing.Size(43, 25);
            this.ButtonSwitch1.TabIndex = 0;
            this.ButtonSwitch1.Value = false;
            this.ButtonSwitch1.OnValueChange += new System.EventHandler(this.ButtonSwitch1_OnValueChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(540, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Display Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextboxPass
            // 
            this.TextboxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextboxPass.BorderColorFocused = System.Drawing.Color.Blue;
            this.TextboxPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TextboxPass.BorderThickness = 3;
            this.TextboxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPass.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.TextboxPass.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.TextboxPass.isPassword = true;
            this.TextboxPass.Location = new System.Drawing.Point(283, 93);
            this.TextboxPass.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPass.Name = "TextboxPass";
            this.TextboxPass.Size = new System.Drawing.Size(279, 44);
            this.TextboxPass.TabIndex = 1;
            this.TextboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxPass.Visible = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.labelPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPass.Location = new System.Drawing.Point(156, 102);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(110, 29);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Enter Pin";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPass.Visible = false;
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.Location = new System.Drawing.Point(283, 136);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(279, 34);
            this.Submit.TabIndex = 2;
            this.Submit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Incorrect
            // 
            this.Incorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Incorrect.AutoSize = true;
            this.Incorrect.Image = ((System.Drawing.Image)(resources.GetObject("Incorrect.Image")));
            this.Incorrect.Location = new System.Drawing.Point(564, 102);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(34, 26);
            this.Incorrect.TabIndex = 22;
            this.Incorrect.Text = "        \r\n         ";
            this.Incorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Incorrect.Visible = false;
            // 
            // EmployeesCustomControl
            // 
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.TextboxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSwitch1);
            this.Controls.Add(this.CustomDataGrid1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeesCustomControl";
            this.Size = new System.Drawing.Size(817, 455);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.BindingSource tblEmpBindingSource;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid CustomDataGrid1;
        private Bunifu.Framework.UI.BunifuiOSSwitch ButtonSwitch1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Incorrect;
    }
}