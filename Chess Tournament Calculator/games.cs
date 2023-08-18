using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Tournament_Calculator
{
    public partial class Games_Display : Form
    {
        public List<Game> games_of_player = new List<Game>();
        public Games_Display()
        {
            InitializeComponent();
            games_of_player = new List<Game>();
        }

        private void games_Load(object sender, EventArgs e)
        {
            FillList();

        }
        public void FillList()
        {
            int counter = 1;
            foreach (Game game in games_of_player)
            {
                string result = string.Empty;
                string reason = string.Empty;
                if (game.Result == 0.5)
                {
                    reason = game.Draw_Reason;
                    result = "1/2-1/2";
                }


                if (game.Result == 1)
                {
                    result = "1-0";
                    reason = game.Decisive_Reason;
                }
                {
                    result = "0-1";
                    reason = game.Decisive_Reason;
                }

                string game_current = $"{game.Player_White} - {game.Player_Black} {result} by {reason}";
                listBox1.Items.Add(game_current);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            richTextBox1.Text = games_of_player[index].PGN;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }
    }
}
