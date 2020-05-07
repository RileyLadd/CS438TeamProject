namespace _438_IntelliBros
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.label_TimeLimit = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.button_IncTimer = new System.Windows.Forms.Button();
            this.button_DecTimer = new System.Windows.Forms.Button();
            this.groupBox_E1 = new System.Windows.Forms.GroupBox();
            this.E1_FileSelectButton = new System.Windows.Forms.Button();
            this.E1_BigTrashFirst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.p1capacity_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1points_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p1icon = new System.Windows.Forms.Button();
            this.E1_Closest = new System.Windows.Forms.Button();
            this.E1_User = new System.Windows.Forms.Button();
            this.groupBox_E2 = new System.Windows.Forms.GroupBox();
            this.E2_FileSelectButton = new System.Windows.Forms.Button();
            this.E2_BigTrashFirst = new System.Windows.Forms.Button();
            this.E2_User = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.p2icon = new System.Windows.Forms.Button();
            this.p2capacity_label = new System.Windows.Forms.Label();
            this.E2_Closest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.p2points_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.Debug_Checkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Closest_InfoIcon = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox_E1.SuspendLayout();
            this.groupBox_E2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closest_InfoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TimeLimit
            // 
            this.label_TimeLimit.AutoSize = true;
            this.label_TimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeLimit.Location = new System.Drawing.Point(47, 18);
            this.label_TimeLimit.Name = "label_TimeLimit";
            this.label_TimeLimit.Size = new System.Drawing.Size(154, 20);
            this.label_TimeLimit.TabIndex = 0;
            this.label_TimeLimit.Text = "Time Limit (seconds)";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.Location = new System.Drawing.Point(12, 43);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(0, 20);
            this.label_Timer.TabIndex = 1;
            // 
            // button_IncTimer
            // 
            this.button_IncTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IncTimer.Location = new System.Drawing.Point(126, 41);
            this.button_IncTimer.Name = "button_IncTimer";
            this.button_IncTimer.Size = new System.Drawing.Size(75, 23);
            this.button_IncTimer.TabIndex = 2;
            this.button_IncTimer.Text = "+";
            this.button_IncTimer.UseVisualStyleBackColor = true;
            this.button_IncTimer.Click += new System.EventHandler(this.button_IncTimer_Click);
            // 
            // button_DecTimer
            // 
            this.button_DecTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DecTimer.Location = new System.Drawing.Point(45, 41);
            this.button_DecTimer.Name = "button_DecTimer";
            this.button_DecTimer.Size = new System.Drawing.Size(75, 23);
            this.button_DecTimer.TabIndex = 3;
            this.button_DecTimer.Text = "-";
            this.button_DecTimer.UseVisualStyleBackColor = true;
            this.button_DecTimer.Click += new System.EventHandler(this.button_DecTimer_Click);
            // 
            // groupBox_E1
            // 
            this.groupBox_E1.Controls.Add(this.E1_FileSelectButton);
            this.groupBox_E1.Controls.Add(this.E1_BigTrashFirst);
            this.groupBox_E1.Controls.Add(this.label5);
            this.groupBox_E1.Controls.Add(this.p1capacity_label);
            this.groupBox_E1.Controls.Add(this.label3);
            this.groupBox_E1.Controls.Add(this.p1points_label);
            this.groupBox_E1.Controls.Add(this.label1);
            this.groupBox_E1.Controls.Add(this.p1icon);
            this.groupBox_E1.Controls.Add(this.E1_Closest);
            this.groupBox_E1.Controls.Add(this.E1_User);
            this.groupBox_E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E1.Location = new System.Drawing.Point(12, 93);
            this.groupBox_E1.Name = "groupBox_E1";
            this.groupBox_E1.Size = new System.Drawing.Size(687, 230);
            this.groupBox_E1.TabIndex = 4;
            this.groupBox_E1.TabStop = false;
            this.groupBox_E1.Text = "Player 1:";
            // 
            // E1_FileSelectButton
            // 
            this.E1_FileSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1_FileSelectButton.Location = new System.Drawing.Point(6, 167);
            this.E1_FileSelectButton.Name = "E1_FileSelectButton";
            this.E1_FileSelectButton.Size = new System.Drawing.Size(296, 37);
            this.E1_FileSelectButton.TabIndex = 9;
            this.E1_FileSelectButton.Text = "Select File ...";
            this.E1_FileSelectButton.UseVisualStyleBackColor = true;
            this.E1_FileSelectButton.Click += new System.EventHandler(this.E1_FileSelectButton_Click);
            // 
            // E1_BigTrashFirst
            // 
            this.E1_BigTrashFirst.Location = new System.Drawing.Point(207, 118);
            this.E1_BigTrashFirst.Name = "E1_BigTrashFirst";
            this.E1_BigTrashFirst.Size = new System.Drawing.Size(179, 37);
            this.E1_BigTrashFirst.TabIndex = 241;
            this.E1_BigTrashFirst.Text = "Big Trash First";
            this.E1_BigTrashFirst.UseVisualStyleBackColor = true;
            this.E1_BigTrashFirst.Click += new System.EventHandler(this.E1_BigTrashFirst_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 240;
            this.label5.Text = "(out of 200)";
            // 
            // p1capacity_label
            // 
            this.p1capacity_label.AutoSize = true;
            this.p1capacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1capacity_label.Location = new System.Drawing.Point(587, 155);
            this.p1capacity_label.Name = "p1capacity_label";
            this.p1capacity_label.Size = new System.Drawing.Size(20, 24);
            this.p1capacity_label.TabIndex = 239;
            this.p1capacity_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 238;
            this.label3.Text = "Bag Capacity:";
            // 
            // p1points_label
            // 
            this.p1points_label.AutoSize = true;
            this.p1points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1points_label.Location = new System.Drawing.Point(587, 72);
            this.p1points_label.Name = "p1points_label";
            this.p1points_label.Size = new System.Drawing.Size(20, 24);
            this.p1points_label.TabIndex = 237;
            this.p1points_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 236;
            this.label1.Text = "Points:";
            // 
            // p1icon
            // 
            this.p1icon.BackColor = System.Drawing.Color.White;
            this.p1icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1icon.Enabled = false;
            this.p1icon.Location = new System.Drawing.Point(417, 80);
            this.p1icon.Name = "p1icon";
            this.p1icon.Size = new System.Drawing.Size(75, 75);
            this.p1icon.TabIndex = 235;
            this.p1icon.UseVisualStyleBackColor = false;
            // 
            // E1_Closest
            // 
            this.E1_Closest.Location = new System.Drawing.Point(6, 118);
            this.E1_Closest.Name = "E1_Closest";
            this.E1_Closest.Size = new System.Drawing.Size(179, 37);
            this.E1_Closest.TabIndex = 2;
            this.E1_Closest.Text = "Closest";
            this.E1_Closest.UseVisualStyleBackColor = true;
            this.E1_Closest.Click += new System.EventHandler(this.E1_Closest_Click);
            // 
            // E1_User
            // 
            this.E1_User.Location = new System.Drawing.Point(6, 58);
            this.E1_User.Name = "E1_User";
            this.E1_User.Size = new System.Drawing.Size(179, 37);
            this.E1_User.TabIndex = 0;
            this.E1_User.Text = "Human";
            this.E1_User.UseVisualStyleBackColor = true;
            this.E1_User.Click += new System.EventHandler(this.E1_User_Click);
            // 
            // groupBox_E2
            // 
            this.groupBox_E2.Controls.Add(this.E2_FileSelectButton);
            this.groupBox_E2.Controls.Add(this.E2_BigTrashFirst);
            this.groupBox_E2.Controls.Add(this.E2_User);
            this.groupBox_E2.Controls.Add(this.label2);
            this.groupBox_E2.Controls.Add(this.p2icon);
            this.groupBox_E2.Controls.Add(this.p2capacity_label);
            this.groupBox_E2.Controls.Add(this.E2_Closest);
            this.groupBox_E2.Controls.Add(this.label6);
            this.groupBox_E2.Controls.Add(this.p2points_label);
            this.groupBox_E2.Controls.Add(this.label8);
            this.groupBox_E2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E2.Location = new System.Drawing.Point(12, 329);
            this.groupBox_E2.Name = "groupBox_E2";
            this.groupBox_E2.Size = new System.Drawing.Size(687, 230);
            this.groupBox_E2.TabIndex = 5;
            this.groupBox_E2.TabStop = false;
            this.groupBox_E2.Text = "Player 2:";
            // 
            // E2_FileSelectButton
            // 
            this.E2_FileSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E2_FileSelectButton.Location = new System.Drawing.Point(4, 160);
            this.E2_FileSelectButton.Name = "E2_FileSelectButton";
            this.E2_FileSelectButton.Size = new System.Drawing.Size(298, 37);
            this.E2_FileSelectButton.TabIndex = 242;
            this.E2_FileSelectButton.Text = "Select File ...";
            this.E2_FileSelectButton.UseVisualStyleBackColor = true;
            this.E2_FileSelectButton.Click += new System.EventHandler(this.E2_FileSelectButton_Click);
            // 
            // E2_BigTrashFirst
            // 
            this.E2_BigTrashFirst.Location = new System.Drawing.Point(207, 112);
            this.E2_BigTrashFirst.Name = "E2_BigTrashFirst";
            this.E2_BigTrashFirst.Size = new System.Drawing.Size(179, 37);
            this.E2_BigTrashFirst.TabIndex = 242;
            this.E2_BigTrashFirst.Text = "Big Trash First";
            this.E2_BigTrashFirst.UseVisualStyleBackColor = true;
            this.E2_BigTrashFirst.Click += new System.EventHandler(this.E2_BigTrashFirst_Click);
            // 
            // E2_User
            // 
            this.E2_User.Location = new System.Drawing.Point(6, 56);
            this.E2_User.Name = "E2_User";
            this.E2_User.Size = new System.Drawing.Size(179, 37);
            this.E2_User.TabIndex = 241;
            this.E2_User.Text = "Human";
            this.E2_User.UseVisualStyleBackColor = true;
            this.E2_User.Click += new System.EventHandler(this.E2_User_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 245;
            this.label2.Text = "(out of 200)";
            // 
            // p2icon
            // 
            this.p2icon.BackColor = System.Drawing.Color.White;
            this.p2icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2icon.Enabled = false;
            this.p2icon.Location = new System.Drawing.Point(417, 74);
            this.p2icon.Name = "p2icon";
            this.p2icon.Size = new System.Drawing.Size(75, 75);
            this.p2icon.TabIndex = 236;
            this.p2icon.UseVisualStyleBackColor = false;
            // 
            // p2capacity_label
            // 
            this.p2capacity_label.AutoSize = true;
            this.p2capacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2capacity_label.Location = new System.Drawing.Point(587, 160);
            this.p2capacity_label.Name = "p2capacity_label";
            this.p2capacity_label.Size = new System.Drawing.Size(20, 24);
            this.p2capacity_label.TabIndex = 244;
            this.p2capacity_label.Text = "0";
            // 
            // E2_Closest
            // 
            this.E2_Closest.Location = new System.Drawing.Point(4, 112);
            this.E2_Closest.Name = "E2_Closest";
            this.E2_Closest.Size = new System.Drawing.Size(179, 37);
            this.E2_Closest.TabIndex = 4;
            this.E2_Closest.Text = "Closest";
            this.E2_Closest.UseVisualStyleBackColor = true;
            this.E2_Closest.Click += new System.EventHandler(this.E2_Closest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 243;
            this.label6.Text = "Bag Capacity:";
            // 
            // p2points_label
            // 
            this.p2points_label.AutoSize = true;
            this.p2points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2points_label.Location = new System.Drawing.Point(587, 77);
            this.p2points_label.Name = "p2points_label";
            this.p2points_label.Size = new System.Drawing.Size(20, 24);
            this.p2points_label.TabIndex = 242;
            this.p2points_label.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 29);
            this.label8.TabIndex = 241;
            this.label8.Text = "Points:";
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(316, 623);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(225, 37);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(32, 623);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(225, 37);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Debug_Checkbox
            // 
            this.Debug_Checkbox.AutoSize = true;
            this.Debug_Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debug_Checkbox.Location = new System.Drawing.Point(32, 577);
            this.Debug_Checkbox.Name = "Debug_Checkbox";
            this.Debug_Checkbox.Size = new System.Drawing.Size(212, 24);
            this.Debug_Checkbox.TabIndex = 9;
            this.Debug_Checkbox.Text = "Show Debugging Console";
            this.Debug_Checkbox.UseVisualStyleBackColor = true;
            this.Debug_Checkbox.CheckedChanged += new System.EventHandler(this.Debug_Checkbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 246;
            this.label4.Text = "Key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 786);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 242;
            this.label7.Text = "2 points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(147, 804);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 251;
            this.label9.Text = "1 capacity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 806);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 253;
            this.label10.Text = "2 capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(305, 788);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 252;
            this.label11.Text = "5 points";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(462, 806);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 255;
            this.label12.Text = "3 capacity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 788);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 18);
            this.label13.TabIndex = 254;
            this.label13.Text = "10 points";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(614, 808);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 18);
            this.label14.TabIndex = 257;
            this.label14.Text = "5 capacity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(614, 790);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 256;
            this.label15.Text = "15 points";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Closest_InfoIcon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 702);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 141);
            this.groupBox1.TabIndex = 259;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Help:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(69, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 260;
            this.label16.Text = "AI behavior";
            this.label16.Click += new System.EventHandler(this.Closest_InfoIcon_Click);
            // 
            // Closest_InfoIcon
            // 
            this.Closest_InfoIcon.BackColor = System.Drawing.Color.Transparent;
            this.Closest_InfoIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Closest_InfoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Closest_InfoIcon.Image = global::_438_IntelliBros.Properties.Resources.info_icon;
            this.Closest_InfoIcon.Location = new System.Drawing.Point(30, 35);
            this.Closest_InfoIcon.Name = "Closest_InfoIcon";
            this.Closest_InfoIcon.Size = new System.Drawing.Size(25, 25);
            this.Closest_InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Closest_InfoIcon.TabIndex = 258;
            this.Closest_InfoIcon.TabStop = false;
            this.Closest_InfoIcon.Click += new System.EventHandler(this.Closest_InfoIcon_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::_438_IntelliBros.Properties.Resources.rat;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(548, 775);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 250;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::_438_IntelliBros.Properties.Resources.trash_3;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(396, 775);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 249;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::_438_IntelliBros.Properties.Resources.trash_2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(239, 775);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 248;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_438_IntelliBros.Properties.Resources.trash_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 775);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 247;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::_438_IntelliBros.Properties.Resources.timer;
            this.pictureBox1.Location = new System.Drawing.Point(208, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 261;
            this.pictureBox1.TabStop = false;
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(602, 623);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(80, 37);
            this.button_Exit.TabIndex = 262;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Debug_Checkbox);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox_E2);
            this.Controls.Add(this.groupBox_E1);
            this.Controls.Add(this.button_DecTimer);
            this.Controls.Add(this.button_IncTimer);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label_TimeLimit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Cat Cleaners";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_E1.ResumeLayout(false);
            this.groupBox_E1.PerformLayout();
            this.groupBox_E2.ResumeLayout(false);
            this.groupBox_E2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closest_InfoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TimeLimit;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Button button_IncTimer;
        private System.Windows.Forms.Button button_DecTimer;
        private System.Windows.Forms.GroupBox groupBox_E1;
        private System.Windows.Forms.GroupBox groupBox_E2;
        private System.Windows.Forms.Button E1_Closest;
        private System.Windows.Forms.Button E1_User;
        private System.Windows.Forms.Button E2_Closest;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p1points_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label p1capacity_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p2capacity_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label p2points_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button E2_User;
        private System.Windows.Forms.Button E1_BigTrashFirst;
        private System.Windows.Forms.Button E2_BigTrashFirst;
        public System.Windows.Forms.Button p2icon;
        public System.Windows.Forms.Button p1icon;
        private System.Windows.Forms.Button E1_FileSelectButton;
        private System.Windows.Forms.Button E2_FileSelectButton;
        private System.Windows.Forms.CheckBox Debug_Checkbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox Closest_InfoIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Exit;
    }
}

