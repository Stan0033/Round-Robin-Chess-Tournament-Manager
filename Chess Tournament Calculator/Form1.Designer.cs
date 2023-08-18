namespace Chess_Tournament_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button6 = new Button();
            listBox_players = new ListBox();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            button_start_tournament = new Button();
            tabPage2 = new TabPage();
            group_CurrentPairs = new GroupBox();
            panel_Pairings = new Panel();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listBox_standings = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showGamesToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            group_CurrentPairs.SuspendLayout();
            panel_Pairings.SuspendLayout();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(236, 120);
            button6.Name = "button6";
            button6.Size = new Size(212, 34);
            button6.TabIndex = 7;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Delete_Click;
            // 
            // listBox_players
            // 
            listBox_players.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_players.FormattingEnabled = true;
            listBox_players.ItemHeight = 20;
            listBox_players.Location = new Point(6, 5);
            listBox_players.Name = "listBox_players";
            listBox_players.Size = new Size(224, 264);
            listBox_players.TabIndex = 4;
            listBox_players.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(236, 46);
            button4.Name = "button4";
            button4.Size = new Size(212, 33);
            button4.TabIndex = 5;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Edit_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(236, 85);
            button5.Name = "button5";
            button5.Size = new Size(212, 29);
            button5.TabIndex = 6;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Add_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(236, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 33);
            textBox1.TabIndex = 8;
            textBox1.KeyDown += EnterName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Players:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(928, 509);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button_start_tournament);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(listBox_players);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(920, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Setup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(454, 8);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 10;
            label1.Text = "Add an amount of players in the list (4 or more).\r\nThen click \"Start Tournament\"\r\nYou can hit enter for faster Adding.";
            // 
            // button_start_tournament
            // 
            button_start_tournament.Cursor = Cursors.Hand;
            button_start_tournament.Enabled = false;
            button_start_tournament.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_start_tournament.Location = new Point(236, 237);
            button_start_tournament.Name = "button_start_tournament";
            button_start_tournament.Size = new Size(212, 32);
            button_start_tournament.TabIndex = 9;
            button_start_tournament.Text = "Start Tournament";
            button_start_tournament.UseVisualStyleBackColor = true;
            button_start_tournament.Click += Start_Tournament_click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Controls.Add(group_CurrentPairs);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(920, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage";
            // 
            // group_CurrentPairs
            // 
            group_CurrentPairs.Controls.Add(panel_Pairings);
            group_CurrentPairs.Dock = DockStyle.Fill;
            group_CurrentPairs.ForeColor = Color.White;
            group_CurrentPairs.Location = new Point(3, 3);
            group_CurrentPairs.Name = "group_CurrentPairs";
            group_CurrentPairs.Size = new Size(562, 475);
            group_CurrentPairs.TabIndex = 2;
            group_CurrentPairs.TabStop = false;
            group_CurrentPairs.Text = "Current Games";
            // 
            // panel_Pairings
            // 
            panel_Pairings.Controls.Add(button2);
            panel_Pairings.Controls.Add(button1);
            panel_Pairings.Dock = DockStyle.Fill;
            panel_Pairings.Location = new Point(3, 19);
            panel_Pairings.Name = "panel_Pairings";
            panel_Pairings.Size = new Size(556, 453);
            panel_Pairings.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(335, 427);
            button2.Name = "button2";
            button2.Size = new Size(218, 23);
            button2.TabIndex = 1;
            button2.Text = "Open Completed Games as  .txt File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ViewCompletedGamesTXT_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(335, 398);
            button1.Name = "button1";
            button1.Size = new Size(218, 23);
            button1.TabIndex = 0;
            button1.Text = "Open Current round Pairings .txt File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ViewPairingsTXT_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox_standings);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(565, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 475);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Standings";
            // 
            // listBox_standings
            // 
            listBox_standings.ContextMenuStrip = contextMenuStrip1;
            listBox_standings.Dock = DockStyle.Fill;
            listBox_standings.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox_standings.FormattingEnabled = true;
            listBox_standings.ItemHeight = 25;
            listBox_standings.Location = new Point(3, 19);
            listBox_standings.Name = "listBox_standings";
            listBox_standings.Size = new Size(346, 453);
            listBox_standings.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showGamesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 26);
            // 
            // showGamesToolStripMenuItem
            // 
            showGamesToolStripMenuItem.Name = "showGamesToolStripMenuItem";
            showGamesToolStripMenuItem.Size = new Size(142, 22);
            showGamesToolStripMenuItem.Text = "Show Games";
            showGamesToolStripMenuItem.Click += showGamesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 509);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Round-Robin Chess Tournament Manager";
            Load += Form_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            group_CurrentPairs.ResumeLayout(false);
            panel_Pairings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private ListBox listBox_players;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox group_CurrentPairs;
        private GroupBox groupBox1;
        private ListBox listBox_standings;
        private Button button_start_tournament;
        private Panel panel_Pairings;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showGamesToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}