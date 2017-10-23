using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           
            InitializeComponent();
        }

        private void New_Game_Button_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Dispose();

        }

        private void High_Scores_Button_Click(object sender, EventArgs e)
        {

        }

        private void View_History_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new WindowsFormsApplication2.Form4();
            f4.ShowDialog();
            this.Dispose();

        }
       
    }
}

