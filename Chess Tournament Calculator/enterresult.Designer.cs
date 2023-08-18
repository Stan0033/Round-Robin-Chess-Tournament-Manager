namespace Chess_Tournament_Calculator
{
    partial class enterresult
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterresult));
            button_whitewin = new RadioButton();
            button_blackwin = new RadioButton();
            button_draw = new RadioButton();
            groupBox1 = new GroupBox();
            by_win = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            by_draw = new GroupBox();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton15 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            by_win.SuspendLayout();
            by_draw.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button_whitewin
            // 
            button_whitewin.AutoSize = true;
            button_whitewin.Location = new Point(6, 22);
            button_whitewin.Name = "button_whitewin";
            button_whitewin.Size = new Size(80, 19);
            button_whitewin.TabIndex = 4;
            button_whitewin.TabStop = true;
            button_whitewin.Text = "White Win";
            button_whitewin.UseVisualStyleBackColor = true;
            button_whitewin.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button_blackwin
            // 
            button_blackwin.AutoSize = true;
            button_blackwin.Location = new Point(6, 47);
            button_blackwin.Name = "button_blackwin";
            button_blackwin.Size = new Size(77, 19);
            button_blackwin.TabIndex = 5;
            button_blackwin.TabStop = true;
            button_blackwin.Text = "Black Win";
            button_blackwin.UseVisualStyleBackColor = true;
            button_blackwin.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button_draw
            // 
            button_draw.AutoSize = true;
            button_draw.Location = new Point(6, 72);
            button_draw.Name = "button_draw";
            button_draw.Size = new Size(52, 19);
            button_draw.TabIndex = 6;
            button_draw.TabStop = true;
            button_draw.Text = "Draw";
            button_draw.UseVisualStyleBackColor = true;
            button_draw.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_whitewin);
            groupBox1.Controls.Add(button_draw);
            groupBox1.Controls.Add(button_blackwin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // by_win
            // 
            by_win.Controls.Add(radioButton9);
            by_win.Controls.Add(radioButton8);
            by_win.Controls.Add(radioButton7);
            by_win.Controls.Add(radioButton4);
            by_win.Controls.Add(radioButton5);
            by_win.Controls.Add(radioButton6);
            by_win.Location = new Point(136, 12);
            by_win.Name = "by_win";
            by_win.Size = new Size(154, 179);
            by_win.TabIndex = 8;
            by_win.TabStop = false;
            by_win.Text = "By";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(6, 147);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(132, 19);
            radioButton9.TabIndex = 9;
            radioButton9.Text = "Arbitrator's Decision";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(6, 122);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(59, 19);
            radioButton8.TabIndex = 8;
            radioButton8.Text = "Forfeit";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 97);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(107, 19);
            radioButton7.TabIndex = 7;
            radioButton7.Text = "Disqualification";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Checkmate";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 72);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(87, 19);
            radioButton5.TabIndex = 6;
            radioButton5.Text = "Resignation";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 47);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(69, 19);
            radioButton6.TabIndex = 5;
            radioButton6.Text = "Timeout";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // by_draw
            // 
            by_draw.Controls.Add(radioButton11);
            by_draw.Controls.Add(radioButton12);
            by_draw.Controls.Add(radioButton13);
            by_draw.Controls.Add(radioButton14);
            by_draw.Controls.Add(radioButton15);
            by_draw.Location = new Point(136, 197);
            by_draw.Name = "by_draw";
            by_draw.Size = new Size(154, 152);
            by_draw.TabIndex = 10;
            by_draw.TabStop = false;
            by_draw.Text = "By";
            by_draw.Visible = false;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(6, 122);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(133, 19);
            radioButton11.TabIndex = 8;
            radioButton11.Text = "Insufficient Material ";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(6, 97);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(98, 19);
            radioButton12.TabIndex = 7;
            radioButton12.Text = "50-move Rule";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Checked = true;
            radioButton13.Location = new Point(6, 22);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(77, 19);
            radioButton13.TabIndex = 4;
            radioButton13.TabStop = true;
            radioButton13.Text = "Stalemate";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(6, 72);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(132, 19);
            radioButton14.TabIndex = 6;
            radioButton14.Text = "Threefold Repetition";
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(6, 47);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(84, 19);
            radioButton15.TabIndex = 5;
            radioButton15.Text = "Agreement";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(302, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 179);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "PGN";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(148, 157);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // enterresult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 205);
            ControlBox = false;
            Controls.Add(by_draw);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(by_win);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "enterresult";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Result";
            Load += enterresult_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            by_win.ResumeLayout(false);
            by_win.PerformLayout();
            by_draw.ResumeLayout(false);
            by_draw.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox by_win;
        private GroupBox by_draw;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        public RadioButton button_whitewin;
        public RadioButton button_blackwin;
        public RadioButton button_draw;
    }
}