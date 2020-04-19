using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _438_IntelliBros
{
    public partial class GameBoard : Form

    {
        const int BOARDSIZE = 15; // The height/width of the board
        Button [,] spaces = new Button[BOARDSIZE,BOARDSIZE]; // *** Use this array to modify button background colors/images/etc !!! *** //

        public GameBoard()
        {
            InitializeComponent();
            for(int i = 0; i < BOARDSIZE; i++)
            {
                for(int j = 0; j < BOARDSIZE; j++)
                {
                    spaces[i,j] = new Button();                   
                }
            }
            spaces[0, 0] = this.b0_0;
            spaces[0, 1] = this.b0_1;
            spaces[0, 2] = this.b0_2;
            spaces[0, 3] = this.b0_3;
            spaces[0, 4] = this.b0_4;
            spaces[0, 5] = this.b0_5;
            spaces[0, 6] = this.b0_6;
            spaces[0, 7] = this.b0_7;
            spaces[0, 8] = this.b0_8;
            spaces[0, 9] = this.b0_9;
            spaces[0, 10] = this.b0_10;
            spaces[0, 11] = this.b0_11;
            spaces[0, 12] = this.b0_12;
            spaces[0, 13] = this.b0_13;
            spaces[0, 14] = this.b0_14;
            spaces[1, 0] = this.b1_0;
            spaces[1, 1] = this.b1_1;
            spaces[1, 2] = this.b1_2;
            spaces[1, 3] = this.b1_3;
            spaces[1, 4] = this.b1_4;
            spaces[1, 5] = this.b1_5;
            spaces[1, 6] = this.b1_6;
            spaces[1, 7] = this.b1_7;
            spaces[1, 8] = this.b1_8;
            spaces[1, 9] = this.b1_9;
            spaces[1, 10] = this.b1_10;
            spaces[1, 11] = this.b1_11;
            spaces[1, 12] = this.b1_12;
            spaces[1, 13] = this.b1_13;
            spaces[1, 14] = this.b1_14;
            spaces[2, 0] = this.b2_0;
            spaces[2, 1] = this.b2_1;
            spaces[2, 2] = this.b2_2;
            spaces[2, 3] = this.b2_3;
            spaces[2, 4] = this.b2_4;
            spaces[2, 5] = this.b2_5;
            spaces[2, 6] = this.b2_6;
            spaces[2, 7] = this.b2_7;
            spaces[2, 8] = this.b2_8;
            spaces[2, 9] = this.b2_9;
            spaces[2, 10] = this.b2_10;
            spaces[2, 11] = this.b2_11;
            spaces[2, 12] = this.b2_12;
            spaces[2, 13] = this.b2_13;
            spaces[2, 14] = this.b2_14;
            spaces[3, 0] = this.b3_0;
            spaces[3, 1] = this.b3_1;
            spaces[3, 2] = this.b3_2;
            spaces[3, 3] = this.b3_3;
            spaces[3, 4] = this.b3_4;
            spaces[3, 5] = this.b3_5;
            spaces[3, 6] = this.b3_6;
            spaces[3, 7] = this.b3_7;
            spaces[3, 8] = this.b3_8;
            spaces[3, 9] = this.b3_9;
            spaces[3, 10] = this.b3_10;
            spaces[3, 11] = this.b3_11;
            spaces[3, 12] = this.b3_12;
            spaces[3, 13] = this.b3_13;
            spaces[3, 14] = this.b3_14;
            spaces[4, 0] = this.b4_0;
            spaces[4, 1] = this.b4_1;
            spaces[4, 2] = this.b4_2;
            spaces[4, 3] = this.b4_3;
            spaces[4, 4] = this.b4_4;
            spaces[4, 5] = this.b4_5;
            spaces[4, 6] = this.b4_6;
            spaces[4, 7] = this.b4_7;
            spaces[4, 8] = this.b4_8;
            spaces[4, 9] = this.b4_9;
            spaces[4, 10] = this.b4_10;
            spaces[4, 11] = this.b4_11;
            spaces[4, 12] = this.b4_12;
            spaces[4, 13] = this.b4_13;
            spaces[4, 14] = this.b4_14;
            spaces[5, 0] = this.b5_0;
            spaces[5, 1] = this.b5_1;
            spaces[5, 2] = this.b5_2;
            spaces[5, 3] = this.b5_3;
            spaces[5, 4] = this.b5_4;
            spaces[5, 5] = this.b5_5;
            spaces[5, 6] = this.b5_6;
            spaces[5, 7] = this.b5_7;
            spaces[5, 8] = this.b5_8;
            spaces[5, 9] = this.b5_9;
            spaces[5, 10] = this.b5_10;
            spaces[5, 11] = this.b5_11;
            spaces[5, 12] = this.b5_12;
            spaces[5, 13] = this.b5_13;
            spaces[5, 14] = this.b5_14;
            spaces[6, 0] = this.b6_0;
            spaces[6, 1] = this.b6_1;
            spaces[6, 2] = this.b6_2;
            spaces[6, 3] = this.b6_3;
            spaces[6, 4] = this.b6_4;
            spaces[6, 5] = this.b6_5;
            spaces[6, 6] = this.b6_6;
            spaces[6, 7] = this.b6_7;
            spaces[6, 8] = this.b6_8;
            spaces[6, 9] = this.b6_9;
            spaces[6, 10] = this.b6_10;
            spaces[6, 11] = this.b6_11;
            spaces[6, 12] = this.b6_12;
            spaces[6, 13] = this.b6_13;
            spaces[6, 14] = this.b6_14;
            spaces[7, 0] = this.b1_0;
            spaces[7, 1] = this.b7_1;
            spaces[7, 2] = this.b7_2;
            spaces[7, 3] = this.b7_3;
            spaces[7, 4] = this.b7_4;
            spaces[7, 5] = this.b7_5;
            spaces[7, 6] = this.b7_6;
            spaces[7, 7] = this.b7_7;
            spaces[7, 8] = this.b7_8;
            spaces[7, 9] = this.b7_9;
            spaces[7, 10] = this.b7_10;
            spaces[7, 11] = this.b7_11;
            spaces[7, 12] = this.b7_12;
            spaces[7, 13] = this.b7_13;
            spaces[7, 14] = this.b7_14;
            spaces[8, 0] = this.b8_0;
            spaces[8, 1] = this.b8_1;
            spaces[8, 2] = this.b8_2;
            spaces[8, 3] = this.b8_3;
            spaces[8, 4] = this.b8_4;
            spaces[8, 5] = this.b8_5;
            spaces[8, 6] = this.b8_6;
            spaces[8, 7] = this.b8_7;
            spaces[8, 8] = this.b8_8;
            spaces[8, 9] = this.b8_9;
            spaces[8, 10] = this.b8_10;
            spaces[8, 11] = this.b8_11;
            spaces[8, 12] = this.b8_12;
            spaces[8, 13] = this.b8_13;
            spaces[8, 14] = this.b8_14;
            spaces[9, 0] = this.b9_0;
            spaces[9, 1] = this.b9_1;
            spaces[9, 2] = this.b9_2;
            spaces[9, 3] = this.b9_3;
            spaces[9, 4] = this.b9_4;
            spaces[9, 5] = this.b9_5;
            spaces[9, 6] = this.b9_6;
            spaces[9, 7] = this.b9_7;
            spaces[9, 8] = this.b9_8;
            spaces[9, 9] = this.b9_9;
            spaces[9, 10] = this.b9_10;
            spaces[9, 11] = this.b9_11;
            spaces[9, 12] = this.b9_12;
            spaces[9, 13] = this.b9_13;
            spaces[9, 14] = this.b9_14;
            spaces[10, 0] = this.b10_0;
            spaces[10, 1] = this.b10_1;
            spaces[10, 2] = this.b10_2;
            spaces[10, 3] = this.b10_3;
            spaces[10, 4] = this.b10_4;
            spaces[10, 5] = this.b10_5;
            spaces[10, 6] = this.b10_6;
            spaces[10, 7] = this.b10_7;
            spaces[10, 8] = this.b10_8;
            spaces[10, 9] = this.b10_9;
            spaces[10, 10] = this.b10_10;
            spaces[10, 11] = this.b10_11;
            spaces[10, 12] = this.b10_12;
            spaces[10, 13] = this.b10_13;
            spaces[10, 14] = this.b10_14;
            spaces[11, 0] = this.b11_0;
            spaces[11, 1] = this.b11_1;
            spaces[11, 2] = this.b11_2;
            spaces[11, 3] = this.b11_3;
            spaces[11, 4] = this.b11_4;
            spaces[11, 5] = this.b11_5;
            spaces[11, 6] = this.b11_6;
            spaces[11, 7] = this.b11_7;
            spaces[11, 8] = this.b11_8;
            spaces[11, 9] = this.b11_9;
            spaces[11, 10] = this.b11_10;
            spaces[11, 11] = this.b11_11;
            spaces[11, 12] = this.b11_12;
            spaces[11, 13] = this.b11_13;
            spaces[11, 14] = this.b11_14;
            spaces[12, 0] = this.b12_0;
            spaces[12, 1] = this.b12_1;
            spaces[12, 2] = this.b12_2;
            spaces[12, 3] = this.b12_3;
            spaces[12, 4] = this.b12_4;
            spaces[12, 5] = this.b12_5;
            spaces[12, 6] = this.b12_6;
            spaces[12, 7] = this.b12_7;
            spaces[12, 8] = this.b12_8;
            spaces[12, 9] = this.b12_9;
            spaces[12, 10] = this.b12_10;
            spaces[12, 11] = this.b12_11;
            spaces[12, 12] = this.b12_12;
            spaces[12, 13] = this.b12_13;
            spaces[12, 14] = this.b12_14;
            spaces[13, 0] = this.b13_0;
            spaces[13, 1] = this.b13_1;
            spaces[13, 2] = this.b13_2;
            spaces[13, 3] = this.b13_3;
            spaces[13, 4] = this.b13_4;
            spaces[13, 5] = this.b13_5;
            spaces[13, 6] = this.b13_6;
            spaces[13, 7] = this.b13_7;
            spaces[13, 8] = this.b13_8;
            spaces[13, 9] = this.b13_9;
            spaces[13, 10] = this.b13_10;
            spaces[13, 11] = this.b13_11;
            spaces[13, 12] = this.b13_12;
            spaces[13, 13] = this.b13_13;
            spaces[13, 14] = this.b13_14;
            spaces[14, 0] = this.b14_0;
            spaces[14, 1] = this.b14_1;
            spaces[14, 2] = this.b14_2;
            spaces[14, 3] = this.b14_3;
            spaces[14, 4] = this.b14_4;
            spaces[14, 5] = this.b14_5;
            spaces[14, 6] = this.b14_6;
            spaces[14, 7] = this.b14_7;
            spaces[14, 8] = this.b14_8;
            spaces[14, 9] = this.b14_9;
            spaces[14, 10] = this.b14_10;
            spaces[14, 11] = this.b14_11;
            spaces[14, 12] = this.b14_12;
            spaces[14, 13] = this.b14_13;
            spaces[14, 14] = this.b14_14;
        }

        private void groupBox_E2_Enter(object sender, EventArgs e)
        {
            
        }

        

        

        

        private void b0_0_Click(object sender, EventArgs e)
        {

        }

        private void b0_1_Click(object sender, EventArgs e)
        {

        }

        private void b0_2_Click(object sender, EventArgs e)
        {

        }

        private void b0_3_Click(object sender, EventArgs e)
        {

        }

        private void b0_4_Click(object sender, EventArgs e)
        {

        }

        private void b0_5_Click(object sender, EventArgs e)
        {

        }

        private void b0_6_Click(object sender, EventArgs e)
        {

        }

        private void b0_7_Click(object sender, EventArgs e)
        {

        }

        private void b0_8_Click(object sender, EventArgs e)
        {

        }

        private void b0_9_Click(object sender, EventArgs e)
        {

        }

        private void b0_10_Click(object sender, EventArgs e)
        {

        }

        private void b0_11_Click(object sender, EventArgs e)
        {

        }

        private void b0_12_Click(object sender, EventArgs e)
        {

        }

        private void b0_13_Click(object sender, EventArgs e)
        {

        }

        private void b0_14_Click(object sender, EventArgs e)
        {

        }

        private void b1_0_Click(object sender, EventArgs e)
        {

        }

        private void b1_1_Click(object sender, EventArgs e)
        {

        }

        private void b1_2_Click(object sender, EventArgs e)
        {

        }

        private void b1_3_Click(object sender, EventArgs e)
        {

        }

        private void b1_4_Click(object sender, EventArgs e)
        {

        }

        private void b1_5_Click(object sender, EventArgs e)
        {

        }

        private void b1_6_Click(object sender, EventArgs e)
        {

        }

        private void b1_7_Click(object sender, EventArgs e)
        {

        }

        private void b1_8_Click(object sender, EventArgs e)
        {

        }

        private void b1_9_Click(object sender, EventArgs e)
        {

        }

        private void b1_10_Click(object sender, EventArgs e)
        {

        }

        private void b1_11_Click(object sender, EventArgs e)
        {

        }
        private void b1_12_Click(object sender, EventArgs e)
        {

            b1_12.Text = "HI!";
            b1_12.BackColor = Color.White;
            //b0_12.BackgroundImage = ImageList.ImageCollection
            b2_12.BackgroundImage = imageList1.Images[0];
            spaces[0, 0].BackColor = Color.White;
        }

        private void b1_13_Click(object sender, EventArgs e)
        {

        }

        private void b1_14_Click(object sender, EventArgs e)
        {

        }

        private void b2_0_Click(object sender, EventArgs e)
        {

        }

        private void b2_1_Click(object sender, EventArgs e)
        {

        }

        private void b2_2_Click(object sender, EventArgs e)
        {

        }

        private void b2_3_Click(object sender, EventArgs e)
        {

        }

        private void b2_4_Click(object sender, EventArgs e)
        {

        }

        private void b2_5_Click(object sender, EventArgs e)
        {

        }

        private void b2_6_Click(object sender, EventArgs e)
        {

        }

        private void b2_7_Click(object sender, EventArgs e)
        {

        }

        private void b2_8_Click(object sender, EventArgs e)
        {

        }

        private void b2_9_Click(object sender, EventArgs e)
        {

        }

        private void b2_10_Click(object sender, EventArgs e)
        {

        }

        private void b2_11_Click(object sender, EventArgs e)
        {

        }

        private void b2_12_Click(object sender, EventArgs e)
        {

        }

        private void b2_13_Click(object sender, EventArgs e)
        {

        }

        private void b2_14_Click(object sender, EventArgs e)
        {

        }

        private void b3_0_Click(object sender, EventArgs e)
        {

        }

        private void b3_1_Click(object sender, EventArgs e)
        {

        }

        private void b3_2_Click(object sender, EventArgs e)
        {

        }

        private void b3_3_Click(object sender, EventArgs e)
        {

        }

        private void b3_4_Click(object sender, EventArgs e)
        {

        }

        private void b3_5_Click(object sender, EventArgs e)
        {

        }

        private void b3_6_Click(object sender, EventArgs e)
        {

        }

        private void b3_7_Click(object sender, EventArgs e)
        {

        }

        private void b3_8_Click(object sender, EventArgs e)
        {

        }

        private void b3_9_Click(object sender, EventArgs e)
        {

        }

        private void b3_10_Click(object sender, EventArgs e)
        {

        }

        private void b3_11_Click(object sender, EventArgs e)
        {

        }

        private void b3_12_Click(object sender, EventArgs e)
        {

        }

        private void b3_13_Click(object sender, EventArgs e)
        {

        }

        private void b3_14_Click(object sender, EventArgs e)
        {

        }

        private void b4_0_Click(object sender, EventArgs e)
        {

        }

        private void b4_1_Click(object sender, EventArgs e)
        {

        }

        private void b4_2_Click(object sender, EventArgs e)
        {

        }

        private void b4_3_Click(object sender, EventArgs e)
        {

        }

        private void b4_4_Click(object sender, EventArgs e)
        {

        }

        private void b4_5_Click(object sender, EventArgs e)
        {

        }

        private void b4_6_Click(object sender, EventArgs e)
        {

        }

        private void b4_7_Click(object sender, EventArgs e)
        {

        }

        private void b4_8_Click(object sender, EventArgs e)
        {

        }

        private void b4_9_Click(object sender, EventArgs e)
        {

        }

        private void b4_10_Click(object sender, EventArgs e)
        {

        }

        private void b4_11_Click(object sender, EventArgs e)
        {

        }

        private void b4_12_Click(object sender, EventArgs e)
        {

        }

        private void b4_13_Click(object sender, EventArgs e)
        {

        }

        private void b4_14_Click(object sender, EventArgs e)
        {

        }

        private void b5_0_Click(object sender, EventArgs e)
        {

        }

        private void b5_1_Click(object sender, EventArgs e)
        {

        }

        private void b5_2_Click(object sender, EventArgs e)
        {

        }

        private void b5_3_Click(object sender, EventArgs e)
        {

        }

        private void b5_4_Click(object sender, EventArgs e)
        {

        }

        private void b5_5_Click(object sender, EventArgs e)
        {

        }

        private void b5_6_Click(object sender, EventArgs e)
        {

        }

        private void b5_7_Click(object sender, EventArgs e)
        {

        }

        private void b5_8_Click(object sender, EventArgs e)
        {

        }

        private void button86_Click(object sender, EventArgs e) //wrong title?
        {

        }

        private void b5_10_Click(object sender, EventArgs e)
        {

        }
        private void button29_Click(object sender, EventArgs e) //wrong title?
        {

        }

        private void b5_12_Click(object sender, EventArgs e)
        {

        }

        private void b5_13_Click(object sender, EventArgs e)
        {

        }

        private void b5_14_Click(object sender, EventArgs e)
        {

        }

        private void b6_0_Click(object sender, EventArgs e)
        {

        }

        private void b6_1_Click(object sender, EventArgs e)
        {

        }

        private void b6_2_Click(object sender, EventArgs e)
        {

        }

        private void b6_3_Click(object sender, EventArgs e)
        {

        }

        private void b6_4_Click(object sender, EventArgs e)
        {

        }

        private void b6_5_Click(object sender, EventArgs e)
        {

        }

        private void b6_6_Click(object sender, EventArgs e)
        {

        }

        private void b6_7_Click(object sender, EventArgs e)
        {

        }

        private void b6_8_Click(object sender, EventArgs e)
        {

        }

        private void b6_9_Click(object sender, EventArgs e)
        {

        }

        private void b6_10_Click(object sender, EventArgs e)
        {

        }

        private void b6_11_Click(object sender, EventArgs e)
        {

        }

        private void b6_12_Click(object sender, EventArgs e)
        {

        }

        private void b6_13_Click(object sender, EventArgs e)
        {

        }

        private void b6_14_Click(object sender, EventArgs e)
        {

        }

        private void b7_0_Click(object sender, EventArgs e)
        {

        }

        private void b7_1_Click(object sender, EventArgs e)
        {

        }

        private void b7_2_Click(object sender, EventArgs e)
        {

        }

        private void b7_3_Click(object sender, EventArgs e)
        {

        }

        private void b7_4_Click(object sender, EventArgs e)
        {

        }

        private void b7_5_Click(object sender, EventArgs e)
        {

        }

        private void b7_6_Click(object sender, EventArgs e)
        {

        }

        private void b7_7_Click(object sender, EventArgs e)
        {

        }

        private void b7_8_Click(object sender, EventArgs e)
        {

        }

        private void b7_9_Click(object sender, EventArgs e)
        {

        }

        private void b7_10_Click(object sender, EventArgs e)
        {

        }

        private void b7_11_Click(object sender, EventArgs e)
        {

        }

        private void b7_12_Click(object sender, EventArgs e)
        {

        }

        private void b7_13_Click(object sender, EventArgs e)
        {

        }

        private void b7_14_Click(object sender, EventArgs e)
        {

        }

        private void b8_0_Click(object sender, EventArgs e)
        {

        }

        private void b8_1_Click(object sender, EventArgs e)
        {

        }

        private void b8_2_Click(object sender, EventArgs e)
        {

        }

        private void b8_3_Click(object sender, EventArgs e)
        {

        }

        private void b8_4_Click(object sender, EventArgs e)
        {

        }

        private void b8_5_Click(object sender, EventArgs e)
        {

        }

        private void b8_6_Click(object sender, EventArgs e)
        {

        }

        private void b8_7_Click(object sender, EventArgs e)
        {

        }

        private void b8_8_Click(object sender, EventArgs e)
        {

        }

        private void b8_9_Click(object sender, EventArgs e)
        {

        }

        private void b8_10_Click(object sender, EventArgs e)
        {

        }

        private void b8_11_Click(object sender, EventArgs e)
        {

        }

        private void b8_12_Click(object sender, EventArgs e)
        {

        }

        private void b8_13_Click(object sender, EventArgs e)
        {

        }

        private void b8_14_Click(object sender, EventArgs e)
        {

        }

        private void b9_0_Click(object sender, EventArgs e)
        {

        }

        private void b9_1_Click(object sender, EventArgs e)
        {

        }

        private void b9_2_Click(object sender, EventArgs e)
        {

        }

        private void b9_3_Click(object sender, EventArgs e)
        {

        }

        private void b9_4_Click(object sender, EventArgs e)
        {

        }

        private void b9_5_Click(object sender, EventArgs e)
        {

        }

        private void b9_6_Click(object sender, EventArgs e)
        {

        }

        private void b9_7_Click(object sender, EventArgs e)
        {

        }

        private void b9_8_Click(object sender, EventArgs e)
        {

        }

        private void b9_9_Click(object sender, EventArgs e)
        {

        }

        private void b9_10_Click(object sender, EventArgs e)
        {

        }

        private void b9_11_Click(object sender, EventArgs e)
        {

        }

        private void b9_12_Click(object sender, EventArgs e)
        {

        }

        private void b9_13_Click(object sender, EventArgs e)
        {

        }

        private void b9_14_Click(object sender, EventArgs e)
        {

        }

        private void b10_0_Click(object sender, EventArgs e)
        {

        }

        private void b10_1_Click(object sender, EventArgs e)
        {

        }

        private void b10_2_Click(object sender, EventArgs e)
        {

        }

        private void b10_3_Click(object sender, EventArgs e)
        {

        }

        private void b10_4_Click(object sender, EventArgs e)
        {

        }

        private void b10_5_Click(object sender, EventArgs e)
        {

        }

        private void b10_6_Click(object sender, EventArgs e)
        {

        }

        private void b10_7_Click(object sender, EventArgs e)
        {

        }

        private void b10_8_Click(object sender, EventArgs e)
        {

        }

        private void b10_9_Click(object sender, EventArgs e)
        {

        }

        private void b10_10_Click(object sender, EventArgs e)
        {

        }

        private void b10_11_Click(object sender, EventArgs e)
        {

        }

        private void b10_12_Click(object sender, EventArgs e)
        {

        }

        private void b10_13_Click(object sender, EventArgs e)
        {

        }

        private void b10_14_Click(object sender, EventArgs e)
        {

        }

        private void b11_0_Click(object sender, EventArgs e)
        {

        }

        private void b11_1_Click(object sender, EventArgs e)
        {

        }

        private void b11_2_Click(object sender, EventArgs e)
        {

        }

        private void b11_3_Click(object sender, EventArgs e)
        {

        }

        private void b11_4_Click(object sender, EventArgs e)
        {

        }

        private void b11_5_Click(object sender, EventArgs e)
        {

        }

        private void b11_6_Click(object sender, EventArgs e)
        {

        }

        private void b11_7_Click(object sender, EventArgs e)
        {

        }

        private void b11_8_Click(object sender, EventArgs e)
        {

        }

        private void b11_9_Click(object sender, EventArgs e)
        {

        }

        private void b11_10_Click(object sender, EventArgs e)
        {

        }

        private void b11_11_Click(object sender, EventArgs e)
        {

        }

        private void b11_12_Click(object sender, EventArgs e)
        {

        }

        private void b11_13_Click(object sender, EventArgs e)
        {

        }

        private void b11_14_Click(object sender, EventArgs e)
        {

        }

        private void b12_0_Click(object sender, EventArgs e)
        {

        }

        private void b12_1_Click(object sender, EventArgs e)
        {

        }

        private void b12_2_Click(object sender, EventArgs e)
        {

        }

        private void b12_3_Click(object sender, EventArgs e)
        {

        }

        private void b12_4_Click(object sender, EventArgs e)
        {

        }

        private void b12_5_Click(object sender, EventArgs e)
        {

        }

        private void b12_6_Click(object sender, EventArgs e)
        {

        }

        private void b12_7_Click(object sender, EventArgs e)
        {

        }

        private void b12_8_Click(object sender, EventArgs e)
        {

        }

        private void b12_9_Click(object sender, EventArgs e)
        {

        }

        private void b12_10_Click(object sender, EventArgs e)
        {

        }

        private void b12_11_Click(object sender, EventArgs e)
        {

        }

        private void b12_12_Click(object sender, EventArgs e)
        {

        }

        private void b12_13_Click(object sender, EventArgs e)
        {

        }

        private void b12_14_Click(object sender, EventArgs e)
        {

        }

        private void b13_0_Click(object sender, EventArgs e)
        {

        }

        private void b13_1_Click(object sender, EventArgs e)
        {

        }

        private void b13_2_Click(object sender, EventArgs e)
        {

        }

        private void b13_3_Click(object sender, EventArgs e)
        {

        }

        private void b13_4_Click(object sender, EventArgs e)
        {

        }

        private void b13_5_Click(object sender, EventArgs e)
        {

        }

        private void b13_6_Click(object sender, EventArgs e)
        {

        }

        private void b13_7_Click(object sender, EventArgs e)
        {

        }

        private void b13_8_Click(object sender, EventArgs e)
        {

        }

        private void b13_9_Click(object sender, EventArgs e)
        {

        }

        private void b13_10_Click(object sender, EventArgs e)
        {

        }

        private void b13_11_Click(object sender, EventArgs e)
        {

        }

        private void b13_12_Click(object sender, EventArgs e)
        {

        }

        private void b13_13_Click(object sender, EventArgs e)
        {

        }

        private void b13_14_Click(object sender, EventArgs e)
        {

        }

        private void b14_0_Click(object sender, EventArgs e)
        {

        }

        private void b14_1_Click(object sender, EventArgs e)
        {

        }

        private void b14_2_Click(object sender, EventArgs e)
        {

        }

        private void b14_3_Click(object sender, EventArgs e)
        {

        }

        private void b14_4_Click(object sender, EventArgs e)
        {

        }

        private void b14_5_Click(object sender, EventArgs e)
        {

        }

        private void b14_6_Click(object sender, EventArgs e)
        {

        }

        private void b14_7_Click(object sender, EventArgs e)
        {

        }

        private void b14_8_Click(object sender, EventArgs e)
        {

        }

        private void b14_9_Click(object sender, EventArgs e)
        {

        }

        private void b14_10_Click(object sender, EventArgs e)
        {

        }

        private void b14_11_Click(object sender, EventArgs e)
        {

        }

        private void b14_12_Click(object sender, EventArgs e)
        {

        }

        private void b14_13_Click(object sender, EventArgs e)
        {

        }

        private void b14_14_Click(object sender, EventArgs e)
        {

        }
    }
}
