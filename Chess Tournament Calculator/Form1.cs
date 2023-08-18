using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Chess_Tournament_Calculator
{
    public partial class Form1 : Form
    {
        List<Player>? Players;
        Dictionary<Player, double> Player_Scores;
        Dictionary<Player, List<Game>> Games;
        int OddPlayers;
        int Current_Round;
        int count_games_this_round;
        int Real_Pairs;
        List<List<string>> schedule;
        public Form1()
        {
            InitializeComponent();
            Players = new List<Player>();
            Games = new Dictionary<Player, List<Game>>();
            Current_Round = 0;
            schedule = new List<List<string>>();
            Player_Scores = new Dictionary<Player, double>();
            count_games_this_round = 0;
            OddPlayers = 0;
            Real_Pairs = 0;

        }
        private void Add_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool ValidName = ValidateInput(name);
            if (!ValidName) { return; }

            bool met = false;
            foreach (string field in listBox_players.Items)
            {
                if (field == name) { met = true; }
            }
            if (met) { MessageBox.Show("already entered"); }
            else
            {
                listBox_players.Items.Add(name);

            }
            textBox1.Text = string.Empty;
            if (listBox_players.Items.Count >= 4)
            {
                button_start_tournament.Enabled = true;
            }
            else
            {
                button_start_tournament.Enabled = false;
            }
        }
        private bool ValidateInput(string input)
        {
            // Check for empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Input cannot be empty.");
                return false;
            }

            // Check for numbers or symbols
            if (input.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Input cannot contain numbers or symbols.");
                return false;
            }

            // Check length
            if (input.Length <= 6)
            {
                MessageBox.Show("Input must be longer than 6 characters.");
                return false;
            }

            // Check word count
            int wordCount = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            if (wordCount < 2 || wordCount > 3)
            {
                MessageBox.Show("Input must have 2 or 3 words.");
                return false;
            }

            return true;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox_players.SelectedItems.Count == 1)
            {
                string name = textBox1.Text;
                bool ValidName = ValidateInput(name);
                if (ValidName)
                {
                    int pos = listBox_players.SelectedIndex;
                    listBox_players.Items[pos] = textBox1.Text;
                    textBox1.Text = string.Empty;
                }


            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox_players.SelectedItems.Count == 1)
            {
                int pos = listBox_players.SelectedIndex;
                listBox_players.Items.RemoveAt(pos);

            }
            if (listBox_players.Items.Count >= 4)
            {
                button_start_tournament.Enabled = true;
            }
            else
            {
                button_start_tournament.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_players.Items.Count >= 4)
            {
                List<string> list = new List<string>();
                foreach (string field in listBox_players.Items) { list.Add(field); }


            }
            else
            {
                MessageBox.Show("Minimum number of players has to be 4. Number of players has to be even.");
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_players.SelectedIndex;
            if (index >= 0)
            {
                textBox1.Text = listBox_players.Items[index].ToString();
            }
        }

        private void EnterName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                string name = textBox1.Text;
                bool ValidName = ValidateInput(name);
                if (!ValidName) { return; }

                bool met = false;
                foreach (string field in listBox_players.Items)
                {
                    if (field == name) { met = true; }
                }
                if (met) { MessageBox.Show("already entered"); }
                else
                {
                    listBox_players.Items.Add(name);

                }
                textBox1.Text = string.Empty;
                if (listBox_players.Items.Count >= 4)
                {
                    button_start_tournament.Enabled = true;
                }
                else
                {
                    button_start_tournament.Enabled = false;
                }


            }

        }

        private void Start_Tournament_click(object sender, EventArgs e)
        {

            tabControl1.TabPages[0].Enabled = false;
            tabControl1.TabPages[1].Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            if (listBox_players.Items.Count % 2 != 0)
            {
                Player bye = new Player();
                bye.Name = "BYE";
                Players.Add(bye);
                Player_Scores.Add(bye, 0);
                Games.Add(bye, new List<Game>());
                OddPlayers = 1;
                Real_Pairs = (listBox_players.Items.Count - 1) / 2;
            }
            else
            {
                Real_Pairs = listBox_players.Items.Count / 2;
            }
            foreach (string field in listBox_players.Items)
            {

                Player P = new Player();
                P.Name = field;
                Players.Add(P);
                Player_Scores.Add(P, 0);
                List<Game> game = new List<Game>();
                Games.Add(P, game);

                listBox_standings.Items.Add(field + " - 0");
            }

            tabControl1.TabPages[1].Text = $"Round {Current_Round + 1}/{Players.Count}";
            schedule = GenerateRoundRobinSchedule(Players);

            GenerateButtonsForPlayers(Current_Round);
            // MessageBox.Show(schedule[0].Count.ToString() + " pairings");
            //  MessageBox.Show(Games. + " players");
        }
        public void GenerateButtonsForPlayers(int whichRound)
        {

            int forname = 0;
            int currentPosition = 10;
            foreach (string pair in schedule[whichRound])
            {
                if (pair.Contains("BYE"))
                {
                    string[] players = pair.Split(" - ");
                    int byeIndex = players[0] == "BYE" ? 0 : 1;
                    int playerIndex = players[0] == "BYE" ? 1 : 0;
                    Game byeGame = new Game();
                    byeGame.Player_White = players[0];
                    byeGame.Player_Black = players[1];
                    byeGame.Result = playerIndex == 0 ? 1 : 0;
                    byeGame.Decisive_Reason = "Forfeit";

                    foreach (var player in Games)
                    {
                        if (player.Key.Name == players[playerIndex])
                        {
                            Games[player.Key].Add(byeGame);

                        }
                        if (player.Key.Name == players[byeIndex])
                        {
                            Games[player.Key].Add(byeGame);

                        }
                    }

                    continue;
                }
                ButtonForPair button = new ButtonForPair();
                //group_CurrentPairs.Controls.Add(button);
                button.Height = 50;
                button.Width = 500;
                button.Location = new Point(0, currentPosition);
                currentPosition += 50;
                button.Text = pair;
                button.Enabled = true;
                button.Visible = true;
                button.ForeColor = Color.White;
                button.Click += DecideResultOfPair;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
                button.Name = Convert.ToString(forname);
                button.Cursor = Cursors.Hand;
                forname++;
                panel_Pairings.Controls.Add(button);

            }
        }
        public void DecideResultOfPair(object sender, EventArgs e)
        {
            ButtonForPair clickedButton = (ButtonForPair)sender;
            using (var dg = new enterresult())
            {
                dg.ShowDialog(this);
                if (dg.DialogResult == DialogResult.OK)
                {
                    string white = clickedButton.Text.Split(" - ")[0];
                    string black = clickedButton.Text.Split(" - ")[1];
                    Game game = new Game();

                    if (dg.button_whitewin.Checked) { game.Result = 1.0; game.Decisive_Reason = dg.reason; }
                    if (dg.button_blackwin.Checked) { game.Result = 0; game.Decisive_Reason = dg.reason; }
                    if (dg.button_draw.Checked) { game.Result = 0.5; game.Draw_Reason = dg.reason; }

                    game.Player_White = white;
                    game.Player_Black = black;
                    game.PGN = dg.PGN;
                    foreach (var Player_Game_Pair in Games)
                    {
                        if (Player_Game_Pair.Key.Name == white) { Player_Game_Pair.Value.Add(game); }
                        if (Player_Game_Pair.Key.Name == black) { Player_Game_Pair.Value.Add(game); }
                    }
                    //--------------------------------------
                    Refresh_Standings();
                    panel_Pairings.Controls.Remove(clickedButton);
                    count_games_this_round += 1;
                    //--------------------------------------

                    if (count_games_this_round == Real_Pairs)
                    // if the rounds played are ==equal to the players, then it's tiem for new round
                    {
                        Current_Round++;
                        if (Current_Round == Players.Count) // if all rounds have been played
                        {
                            tabControl1.TabPages[1].Text = "Tournament is over";
                        }
                        else
                        {
                            GenerateButtonsForPlayers(Current_Round);
                            tabControl1.TabPages[1].Text = $"Round {Current_Round + 1}/{Players.Count}";
                            count_games_this_round = 0;

                        }



                    }
                    else
                    {

                    }

                }
            }
        }

        public void Refresh_Standings()
        {
            List<string> player_scores = new List<string>();
            foreach (var player in Games)
            {
                //  MessageBox.Show(player.Value.Count.ToString());
                double score = 0;
                if (player.Key.Name == "BYE") { continue; }
                foreach (var game in player.Value)
                {

                    if (game.Player_White == player.Key.Name)
                    {
                        if (game.Result == 1) { score += 1; }
                    }
                    if (game.Player_Black == player.Key.Name)
                    {
                        if (game.Result == 0) { score += 1; }
                    }
                    if (game.Result == 0.5) { score += 0.5; }
                }
                string formatted = $"{player.Key.Name} - {score:f1}";

                player_scores.Add(formatted);
            }
            player_scores = SortPlayerScores(player_scores);
            listBox_standings.Items.Clear();
            // MessageBox.Show(player_scores.Count.ToString());
            foreach (string standing in player_scores)
            {
                listBox_standings.Items.Add(standing);
            }
        }
        static List<string> SortPlayerScores(List<string> playerScores)
        {
            var sortedScores = playerScores
                .Select(entry =>
                {
                    string[] parts = entry.Split(new[] { " - " }, StringSplitOptions.None);
                    return new { Player = parts[0], Score = double.Parse(parts[1]) };
                })
                .OrderByDescending(entry => entry.Score) // Sort by score in descending order
                .ThenBy(entry => entry.Player)
                .Select(entry => $"{entry.Player} - {entry.Score:F1}") // Format score with one decimal place
                .ToList();

            return sortedScores;
        }
        public static List<List<string>> GenerateRoundRobinSchedule(List<Player> players)
        {
            List<List<string>> schedule = new List<List<string>>();

            int numPlayers = players.Count;
            int numRounds = numPlayers - 1;

            bool isWhiteTurn = true; // Initialize as true for the first round

            for (int round = 0; round < numRounds; round++)
            {
                List<string> roundPairings = new List<string>();

                for (int i = 0; i < numPlayers / 2; i++)
                {
                    string pairing;
                    if (isWhiteTurn)
                    {
                        pairing = $"{players[i].Name} - {players[numPlayers - 1 - i].Name}";
                    }
                    else
                    {
                        pairing = $"{players[numPlayers - 1 - i].Name} - {players[i].Name}";
                    }
                    roundPairings.Add(pairing);
                }

                schedule.Add(roundPairings);

                // Rotate players for the next round
                Player lastPlayer = players[numPlayers - 1];
                players.RemoveAt(numPlayers - 1);
                players.Insert(1, lastPlayer);

                // Toggle the color for the next round
                isWhiteTurn = !isWhiteTurn;
            }

            // Add the last round (odd player count)
            List<string> lastRoundPairings = new List<string>();
            for (int i = 0; i < numPlayers / 2; i++)
            {
                string pairing;
                if (isWhiteTurn)
                {
                    pairing = $"{players[i].Name} - {players[numPlayers - 1 - i].Name}";
                }
                else
                {
                    pairing = $"{players[numPlayers - 1 - i].Name} - {players[i].Name}";
                }
                lastRoundPairings.Add(pairing);
            }
            schedule.Add(lastRoundPairings);

            return schedule;
        }

        private void showGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_standings.SelectedItems.Count == 1)
            {
                int index = listBox_standings.SelectedIndex;
                if (index < 0) { return; }
                string name = listBox_players.Items[index].ToString().Split(" - ")[0];
                var dialog = new Games_Display();
                dialog.Text = "Games of " + name;
                foreach (var v in Games)
                {


                    if (v.Key.Name == name)
                    {


                        dialog.games_of_player = v.Value;

                        break;
                    }

                }

                dialog.ShowDialog();
            }
        }



        private void ViewPairingsTXT_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[1].Text.Contains("over"))
            {
                return;
            }
            string filename = $"rr_schedule_{Current_Round}.txt";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Pairings for round {Current_Round + 1}:\n"); // Adding the header

                for (int i = 0; i < schedule[Current_Round].Count; i++)
                {
                    string enumeratedLine = $"{i + 1}. {schedule[Current_Round][i]}"; // Adding line numbers
                    writer.WriteLine(enumeratedLine);
                }
            }

            Process.Start("notepad.exe", filename); // Run the external file

        }

        private void ViewCompletedGamesTXT_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(Games[Games.Keys.FirstOrDefault(x => x.Name == "BYE")].Count.ToString());
            //return;
            string content = string.Empty;
            string filename = "past_games.txt";

            // Create a list to track written games
            List<Game> writtenGames = new List<Game>();

            for (int i = 0; i < Current_Round; i++)
            {
                content += $"Round {i + 1}\n";

                foreach (var player in Games)
                {
                    // Get the game for the current round
                    Game game = player.Value[i];

                    // Check if the game has already been written
                    if (!writtenGames.Contains(game))
                    {
                        string result = game.Result == 0 ? "0-1" : "1-0";
                        result = game.Result == 0.5 ? "1/2-1/2" : result;
                        string reason = game.Result == 0.5 ? game.Draw_Reason : game.Decisive_Reason;

                        content += $"{game.Player_White} - {game.Player_Black} - {result} by {reason}\n";

                        // Mark the game as written
                        writtenGames.Add(game);
                    }
                }
            }

            // Write the content to the file and open it
            File.WriteAllText(filename, content);
            Process.Start("notepad.exe", filename);
        }
        public static List<Player> FindPlayersWithHighestScore(Dictionary<Player, int> playerScores)
        {
            // give Player_Scores
            List<Player> playersWithHighestScore = new List<Player>();

            if (playerScores.Count == 0)
            {
                return playersWithHighestScore;
            }

            // Find the highest score
            int maxScore = playerScores.Max(kvp => kvp.Value);

            // Find players with the highest score
            playersWithHighestScore = playerScores.Where(kvp => kvp.Value == maxScore).Select(kvp => kvp.Key).ToList();

            return playersWithHighestScore;
        }
    }
}