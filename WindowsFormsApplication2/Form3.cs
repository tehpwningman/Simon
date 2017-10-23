using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.FormClosed += new FormClosedEventHandler(f_FormClose);
            InitializeComponent();
        }
        bool startGame = false;
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            startGame = true;
            this.Close();
            
        }
        void f_FormClose(Object Sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (startGame)
            {

                Form1 f1 = new Form1((int)PlayerCounter.Value);
                f1.ShowDialog();
                
            }
            else
            {
                
                Form2 f2 = new Form2();
                f2.ShowDialog();
              
            }
            this.Dispose();
        }
    }
}
