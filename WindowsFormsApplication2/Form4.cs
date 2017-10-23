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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gamesDataSet.Game_History' table. You can move, or remove it, as needed.
            this.game_HistoryTableAdapter.Fill(this.gamesDataSet.Game_History);
            this.FormClosed += new FormClosedEventHandler(f4_FormClose);
        }
        void f4_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new WindowsFormsApplication2.Form2();
            f2.ShowDialog();
            this.Dispose();
        }
    }
   
}
