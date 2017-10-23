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
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1(int num_Players)
        {
            Num_Players = num_Players;
            this.FormClosed += new FormClosedEventHandler(f_FormClose);
            InitializeComponent();
        }
      
       
        int Num_Players = 0;
        int pattern_pos = 0;
        List<int> pattern = new List<int>();
        Random rand = new Random();
        bool playback = false;
        int player_counter = 0;
        private void Red_Click(object sender, EventArgs e)
        {
            testCorrect(0);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            testCorrect(1);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            testCorrect(2);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            testCorrect(3);
        }
        void testCorrect(int color)
        {
            if (playback)
                return;
            if(pattern[pattern_pos] == color)
            {
                pattern_pos++;
            }
            else
            {
                MessageBox.Show("Sorry, you lost!  Final Score is " + pattern.Count.ToString());
                SaveGame(pattern.Count, Num_Players);
                pattern_pos = 0;
                player_counter = 0;
                pattern = new List<int>();
                new Thread(PlayBack).Start();
            }
            if(pattern_pos >= pattern.Count)
            {
                pattern_pos = 0;
                pattern.Add(rand.Next(0, 4));
                new Thread(PlayBack).Start();
            }
            Score.Text = ("Score: " + (pattern.Count-1).ToString());
            
        }
     
        void PlayBack()
        {
            playback = true;
            //ToggleButtons(playback);
            player_counter++;
            if(player_counter > Num_Players || Num_Players == 1)
            {
                player_counter = 1;
            }
           
            PlayerTurnLabel.Invoke((MethodInvoker)delegate { PlayerTurnLabel.Text = "Watch Carefully!"; });
                
            foreach (int color in pattern)
            {
                switch (color)
                {
                    case 0:
                        Red.BackColor = Color.Red;
                        Thread.Sleep(200);
                        Red.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        break;
                    case 1:
                        Blue.BackColor = Color.Blue;
                        Thread.Sleep(200);
                        Blue.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        break;
                    case 2:
                        Green.BackColor = Color.Green;
                        Thread.Sleep(200);
                        Green.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        break;
                    case 3:
                        Yellow.BackColor = Color.Yellow;
                        Thread.Sleep(200);
                        Yellow.BackColor = Color.Transparent;
                        Thread.Sleep(200);
                        break;

                }
            }
                Thread.Sleep(200);
                playback = false;
            PlayerTurnLabel.Invoke((MethodInvoker)delegate { PlayerTurnLabel.Text = "Player " + (player_counter).ToString() + "'s Turn."; });
                
                
                

            }
        void SaveGame(int score, int num_players)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection("Server=DESKTOP-TV4RQQR;user=mfiles;pwd=Testing123;Database=Games"))
                {
                   

                    using (SqlCommand sqlCmd = new SqlCommand("Insert into Game_History (Number_Of_Players, Final_Score,Game_End_Time) Values ('" + num_players + "','" + score + "','" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + "')",sqlCon))
                    {
                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
                
             
         }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            pattern.Add(rand.Next(0, 4));
            new Thread(PlayBack).Start();
        }
        void f_FormClose(Object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
