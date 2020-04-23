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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.label_TimeLimit = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.button_IncTimer = new System.Windows.Forms.Button();
            this.buttonDecTimer = new System.Windows.Forms.Button();
            this.groupBox_E1 = new System.Windows.Forms.GroupBox();
            this.p1icon = new System.Windows.Forms.Button();
            this.E1_Closest = new System.Windows.Forms.Button();
            this.E1_ShortestDist = new System.Windows.Forms.Button();
            this.E1_User = new System.Windows.Forms.Button();
            this.groupBox_E2 = new System.Windows.Forms.GroupBox();
            this.p2icon = new System.Windows.Forms.Button();
            this.E2_Closest = new System.Windows.Forms.Button();
            this.E2_ShortestDist = new System.Windows.Forms.Button();
            this.button_Backward = new System.Windows.Forms.Button();
            this.button_Forward = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.p1points_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1capacity_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2capacity_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p2points_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_E1.SuspendLayout();
            this.groupBox_E2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TimeLimit
            // 
            this.label_TimeLimit.AutoSize = true;
            this.label_TimeLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeLimit.Location = new System.Drawing.Point(12, 9);
            this.label_TimeLimit.Name = "label_TimeLimit";
            this.label_TimeLimit.Size = new System.Drawing.Size(185, 24);
            this.label_TimeLimit.TabIndex = 0;
            this.label_TimeLimit.Text = "Time Limit (seconds)";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.Location = new System.Drawing.Point(12, 43);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(27, 20);
            this.label_Timer.TabIndex = 1;
            this.label_Timer.Text = "30";
            // 
            // button_IncTimer
            // 
            this.button_IncTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IncTimer.Location = new System.Drawing.Point(136, 40);
            this.button_IncTimer.Name = "button_IncTimer";
            this.button_IncTimer.Size = new System.Drawing.Size(75, 23);
            this.button_IncTimer.TabIndex = 2;
            this.button_IncTimer.Text = "+";
            this.button_IncTimer.UseVisualStyleBackColor = true;
            // 
            // buttonDecTimer
            // 
            this.buttonDecTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecTimer.Location = new System.Drawing.Point(55, 40);
            this.buttonDecTimer.Name = "buttonDecTimer";
            this.buttonDecTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonDecTimer.TabIndex = 3;
            this.buttonDecTimer.Text = "-";
            this.buttonDecTimer.UseVisualStyleBackColor = true;
            // 
            // groupBox_E1
            // 
            this.groupBox_E1.Controls.Add(this.label5);
            this.groupBox_E1.Controls.Add(this.p1capacity_label);
            this.groupBox_E1.Controls.Add(this.label3);
            this.groupBox_E1.Controls.Add(this.p1points_label);
            this.groupBox_E1.Controls.Add(this.label1);
            this.groupBox_E1.Controls.Add(this.p1icon);
            this.groupBox_E1.Controls.Add(this.E1_Closest);
            this.groupBox_E1.Controls.Add(this.E1_ShortestDist);
            this.groupBox_E1.Controls.Add(this.E1_User);
            this.groupBox_E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E1.Location = new System.Drawing.Point(12, 93);
            this.groupBox_E1.Name = "groupBox_E1";
            this.groupBox_E1.Size = new System.Drawing.Size(687, 230);
            this.groupBox_E1.TabIndex = 4;
            this.groupBox_E1.TabStop = false;
            this.groupBox_E1.Text = "Entity 1:";
            // 
            // p1icon
            // 
            this.p1icon.BackColor = System.Drawing.Color.White;
            this.p1icon.BackgroundImage = global::_438_IntelliBros.Properties.Resources.p1;
            this.p1icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1icon.Location = new System.Drawing.Point(417, 92);
            this.p1icon.Name = "p1icon";
            this.p1icon.Size = new System.Drawing.Size(75, 75);
            this.p1icon.TabIndex = 235;
            this.p1icon.UseVisualStyleBackColor = false;
            this.p1icon.Click += new System.EventHandler(this.button_Click);
            // 
            // E1_Closest
            // 
            this.E1_Closest.Location = new System.Drawing.Point(6, 118);
            this.E1_Closest.Name = "E1_Closest";
            this.E1_Closest.Size = new System.Drawing.Size(179, 37);
            this.E1_Closest.TabIndex = 2;
            this.E1_Closest.Text = "Closest";
            this.E1_Closest.UseVisualStyleBackColor = true;
            // 
            // E1_ShortestDist
            // 
            this.E1_ShortestDist.Location = new System.Drawing.Point(6, 59);
            this.E1_ShortestDist.Name = "E1_ShortestDist";
            this.E1_ShortestDist.Size = new System.Drawing.Size(179, 37);
            this.E1_ShortestDist.TabIndex = 1;
            this.E1_ShortestDist.Text = "Shortest Distance";
            this.E1_ShortestDist.UseVisualStyleBackColor = true;
            // 
            // E1_User
            // 
            this.E1_User.Location = new System.Drawing.Point(207, 59);
            this.E1_User.Name = "E1_User";
            this.E1_User.Size = new System.Drawing.Size(179, 37);
            this.E1_User.TabIndex = 0;
            this.E1_User.Text = "Change to User";
            this.E1_User.UseVisualStyleBackColor = true;
            // 
            // groupBox_E2
            // 
            this.groupBox_E2.Controls.Add(this.label2);
            this.groupBox_E2.Controls.Add(this.p2icon);
            this.groupBox_E2.Controls.Add(this.p2capacity_label);
            this.groupBox_E2.Controls.Add(this.E2_Closest);
            this.groupBox_E2.Controls.Add(this.label6);
            this.groupBox_E2.Controls.Add(this.p2points_label);
            this.groupBox_E2.Controls.Add(this.E2_ShortestDist);
            this.groupBox_E2.Controls.Add(this.label8);
            this.groupBox_E2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E2.Location = new System.Drawing.Point(12, 329);
            this.groupBox_E2.Name = "groupBox_E2";
            this.groupBox_E2.Size = new System.Drawing.Size(687, 230);
            this.groupBox_E2.TabIndex = 5;
            this.groupBox_E2.TabStop = false;
            this.groupBox_E2.Text = "Entity 2:";
            // 
            // p2icon
            // 
            this.p2icon.BackColor = System.Drawing.Color.White;
            this.p2icon.BackgroundImage = global::_438_IntelliBros.Properties.Resources.p2;
            this.p2icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2icon.Location = new System.Drawing.Point(417, 77);
            this.p2icon.Name = "p2icon";
            this.p2icon.Size = new System.Drawing.Size(75, 75);
            this.p2icon.TabIndex = 236;
            this.p2icon.UseVisualStyleBackColor = false;
            // 
            // E2_Closest
            // 
            this.E2_Closest.Location = new System.Drawing.Point(4, 112);
            this.E2_Closest.Name = "E2_Closest";
            this.E2_Closest.Size = new System.Drawing.Size(179, 37);
            this.E2_Closest.TabIndex = 4;
            this.E2_Closest.Text = "Closest";
            this.E2_Closest.UseVisualStyleBackColor = true;
            // 
            // E2_ShortestDist
            // 
            this.E2_ShortestDist.Location = new System.Drawing.Point(4, 53);
            this.E2_ShortestDist.Name = "E2_ShortestDist";
            this.E2_ShortestDist.Size = new System.Drawing.Size(179, 37);
            this.E2_ShortestDist.TabIndex = 3;
            this.E2_ShortestDist.Text = "Shortest Distance";
            this.E2_ShortestDist.UseVisualStyleBackColor = true;
            // 
            // button_Backward
            // 
            this.button_Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Backward.Location = new System.Drawing.Point(32, 594);
            this.button_Backward.Name = "button_Backward";
            this.button_Backward.Size = new System.Drawing.Size(225, 37);
            this.button_Backward.TabIndex = 5;
            this.button_Backward.Text = "Step backward in Log";
            this.button_Backward.UseVisualStyleBackColor = true;
            // 
            // button_Forward
            // 
            this.button_Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Forward.Location = new System.Drawing.Point(312, 594);
            this.button_Forward.Name = "button_Forward";
            this.button_Forward.Size = new System.Drawing.Size(225, 37);
            this.button_Forward.TabIndex = 6;
            this.button_Forward.Text = "Step forward in Log";
            this.button_Forward.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(312, 665);
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
            this.button_Reset.Location = new System.Drawing.Point(32, 665);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(225, 37);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "p1.png");
            this.imageList1.Images.SetKeyName(1, "p2.png");
            this.imageList1.Images.SetKeyName(2, "rat.png");
            this.imageList1.Images.SetKeyName(3, "trash 1.png");
            this.imageList1.Images.SetKeyName(4, "trash 2.png");
            this.imageList1.Images.SetKeyName(5, "trash 3.png");
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
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Forward);
            this.Controls.Add(this.button_Backward);
            this.Controls.Add(this.groupBox_E2);
            this.Controls.Add(this.groupBox_E1);
            this.Controls.Add(this.buttonDecTimer);
            this.Controls.Add(this.button_IncTimer);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label_TimeLimit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Cat Cleaners";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_E1.ResumeLayout(false);
            this.groupBox_E1.PerformLayout();
            this.groupBox_E2.ResumeLayout(false);
            this.groupBox_E2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_TimeLimit;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Button button_IncTimer;
        private System.Windows.Forms.Button buttonDecTimer;
        private System.Windows.Forms.GroupBox groupBox_E1;
        private System.Windows.Forms.GroupBox groupBox_E2;
        private System.Windows.Forms.Button E1_Closest;
        private System.Windows.Forms.Button E1_ShortestDist;
        private System.Windows.Forms.Button E1_User;
        private System.Windows.Forms.Button E2_Closest;
        private System.Windows.Forms.Button E2_ShortestDist;
        private System.Windows.Forms.Button button_Backward;
        private System.Windows.Forms.Button button_Forward;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Reset;

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button p2icon;
        private System.Windows.Forms.Button p1icon;
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
    }
}

