namespace _438_IntelliBros
{
    partial class Form1
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
            this.label_TimeLimit = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.button_IncTimer = new System.Windows.Forms.Button();
            this.buttonDecTimer = new System.Windows.Forms.Button();
            this.groupBox_E1 = new System.Windows.Forms.GroupBox();
            this.groupBox_E2 = new System.Windows.Forms.GroupBox();
            this.E1_User = new System.Windows.Forms.Button();
            this.E1_ShortestDist = new System.Windows.Forms.Button();
            this.E1_Closest = new System.Windows.Forms.Button();
            this.E2_Closest = new System.Windows.Forms.Button();
            this.E2_ShortestDist = new System.Windows.Forms.Button();
            this.button_Backward = new System.Windows.Forms.Button();
            this.button_Forward = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
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
            this.groupBox_E1.Controls.Add(this.E1_Closest);
            this.groupBox_E1.Controls.Add(this.E1_ShortestDist);
            this.groupBox_E1.Controls.Add(this.E1_User);
            this.groupBox_E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E1.Location = new System.Drawing.Point(12, 93);
            this.groupBox_E1.Name = "groupBox_E1";
            this.groupBox_E1.Size = new System.Drawing.Size(551, 230);
            this.groupBox_E1.TabIndex = 4;
            this.groupBox_E1.TabStop = false;
            this.groupBox_E1.Text = "Entity 1:";
            // 
            // groupBox_E2
            // 
            this.groupBox_E2.Controls.Add(this.E2_Closest);
            this.groupBox_E2.Controls.Add(this.E2_ShortestDist);
            this.groupBox_E2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_E2.Location = new System.Drawing.Point(12, 329);
            this.groupBox_E2.Name = "groupBox_E2";
            this.groupBox_E2.Size = new System.Drawing.Size(551, 230);
            this.groupBox_E2.TabIndex = 5;
            this.groupBox_E2.TabStop = false;
            this.groupBox_E2.Text = "Entity 2:";
            // 
            // E1_User
            // 
            this.E1_User.Location = new System.Drawing.Point(346, 59);
            this.E1_User.Name = "E1_User";
            this.E1_User.Size = new System.Drawing.Size(179, 37);
            this.E1_User.TabIndex = 0;
            this.E1_User.Text = "Change to User";
            this.E1_User.UseVisualStyleBackColor = true;
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
            // E1_Closest
            // 
            this.E1_Closest.Location = new System.Drawing.Point(6, 118);
            this.E1_Closest.Name = "E1_Closest";
            this.E1_Closest.Size = new System.Drawing.Size(179, 37);
            this.E1_Closest.TabIndex = 2;
            this.E1_Closest.Text = "Closest";
            this.E1_Closest.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 765);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_E1.ResumeLayout(false);
            this.groupBox_E2.ResumeLayout(false);
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
    }
}

