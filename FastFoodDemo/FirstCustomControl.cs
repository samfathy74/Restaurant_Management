using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
        }

        int numberImg = 1;
        private void LoadNextImg()
         {
         if(numberImg==10)
         {
                numberImg = 1;
         }

            SlideShow.ImageLocation = string.Format(@"Img\" + numberImg + ".jpeg");
            numberImg++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }
    }
}
