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
        class Player
        {
            public int row, col, score, capacity;
            public Player()
            {
                row = col = -1;
                score = capacity = 0;
            }
        }
        Player P1, P2;
        //change the starting positions
        const int p1_start_row = 7;
        const int p1_start_col = 0;
        const int p2_start_row = 14;
        const int p2_start_col = 7;

        const int BOARDSIZE = 15; // The height/width of the board
        const int MAX_CAPACITY = 200; // Max cleaning capacity of the cats
        const int BUTTON_SIZE = 50;
        const int SMALL_TRASH_POINT_VAL = 2;
        const int MEDIUM_TRASH_POINT_VAL = 5;
        const int LARGE_TRASH_POINT_VAL = 10;
        const int SMALL_TRASH_CAPACITY_VAL = 1;
        const int MEDIUM_TRASH_CAPACITY_VAL = 2;
        const int LARGE_TRASH_CAPACITY_VAL = 3;
        const string SMALL_TRASH_TAG = "SMALL";
        const string MEDIUM_TRASH_TAG = "MEDIUM";
        const string LARGE_TRASH_TAG = "LARGE";
        Button[,] spaces = new Button[BOARDSIZE, BOARDSIZE]; // *** Use this array to modify button background colors/images/etc !!! *** //
        int currentTurn = 1; // Keeps track of if player 1 or player 2 is currently playing/making a move
        
        public GameBoard()
        {
            InitializeComponent();
            for (int row = 0; row < BOARDSIZE; ++row)
            {
                for (int col = 0; col < BOARDSIZE; ++col)
                {
                    //create button and assign attributes
                    Button tempButton = new Button();
                    tempButton.Height = BUTTON_SIZE;
                    tempButton.Width = BUTTON_SIZE;
                    //731, 29 is location of the first button
                    tempButton.Location = new Point(731 + (row * BUTTON_SIZE),29 + (col * BUTTON_SIZE));
                    tempButton.AutoSize = false;

                    spaces[row, col] = tempButton;
                }
            }
        }

        public void generateTrash() // Called when beginning a new game. Uses random num generator to scatter trash across board
        {
            Random rand_num = new Random();
            int rand = 0;
            for(int i = 0; i < BOARDSIZE; ++i)
            {
                for(int j = 0; j < BOARDSIZE; ++j)
                {
                    if( (i == p1_start_row && j == p1_start_col) || (i == p2_start_row && j == p2_start_col)) { } // Don't spawn trash on starting positions
                    else  { 
                        rand = rand_num.Next(0, 4); // generates num between 0 and 3. only spawn trash if num is 3. 25% trash rate across board.
                        //spaces[i, j].BackColor = Color.Gray;
                        //Console.WriteLine(rand);
                        if (rand == 3)
                        {
                            rand = rand_num.Next(2, 8); //generate rand num between 2 and 7
                            if (rand == 2 || rand == 3 || rand == 4)
                            {
                                spaces[i, j].BackgroundImage = imageList1.Images[3];
                                spaces[i, j].Tag = SMALL_TRASH_TAG;
                            }
                            else if (rand == 5 || rand == 6)
                            {
                                spaces[i, j].BackgroundImage = imageList1.Images[4];
                                spaces[i, j].Tag = MEDIUM_TRASH_TAG;
                            }
                            else
                            {
                                spaces[i, j].BackgroundImage = imageList1.Images[5];
                                spaces[i, j].Tag = LARGE_TRASH_TAG;
                            }
                        }
                    }
                }
            }
        }

        public bool isNeighbor(int newRow, int newCol) // Determines if the space passed in is a neighbor of the player's current space 
        {
            if (currentTurn == 1)
            {
                if (newRow == P1.row && newCol == P1.col) { return false; } // can't "move" to same space
                if (newRow == P2.row && newCol == P2.col) { return false; } // can't sit on another player's space
                if (Math.Abs(newRow - P1.row) <= 1 && Math.Abs(newCol - P1.col) <= 1) { return true; }
            } else // it is player 2's turn
            {
                if (newRow == P2.row && newCol == P2.col) { return false; } // can't "move" to same space
                if (newRow == P1.row && newCol == P1.col) { return false; } // can't sit on another player's space
                if (Math.Abs(newRow - P2.row) <= 1 && Math.Abs(newCol - P2.col) <= 1) { return true; }
            }
            return false;
        }
        public void makeMove(int newRow, int newCol)
        {
            if (currentTurn == 1)
            {
                if((string)spaces[newRow,newCol].Tag == SMALL_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P1.score += SMALL_TRASH_POINT_VAL;
                    p1points_label.Text = P1.score.ToString();
                    if (P1.capacity + SMALL_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P1.capacity += SMALL_TRASH_CAPACITY_VAL;
                        p1capacity_label.Text = P1.capacity.ToString();
                    }
                }
                else if ((string)spaces[newRow, newCol].Tag == MEDIUM_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P1.score += MEDIUM_TRASH_POINT_VAL;
                    p1points_label.Text = P1.score.ToString();
                    if (P1.capacity + MEDIUM_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P1.capacity += MEDIUM_TRASH_CAPACITY_VAL;
                        p1capacity_label.Text = P1.capacity.ToString();
                    }
                }
                else if ((string)spaces[newRow, newCol].Tag == LARGE_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P1.score += LARGE_TRASH_POINT_VAL;
                    p1points_label.Text = P1.score.ToString();
                    if (P1.capacity + LARGE_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P1.capacity += LARGE_TRASH_CAPACITY_VAL;
                        p1capacity_label.Text = P1.capacity.ToString();
                    }
                }
                spaces[newRow, newCol].BackgroundImage = imageList1.Images[0];
                spaces[P1.row, P1.col].BackgroundImage = null;
                P1.row = newRow;
                P1.col = newCol;
            } else // it is player 2's turn
            {
                if ((string)spaces[newRow, newCol].Tag == SMALL_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P2.score += SMALL_TRASH_POINT_VAL;
                    p2points_label.Text = P2.score.ToString();
                    if (P2.capacity + SMALL_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P2.capacity += SMALL_TRASH_CAPACITY_VAL;
                        p2capacity_label.Text = P2.capacity.ToString();
                    }
                }
                else if ((string)spaces[newRow, newCol].Tag == MEDIUM_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P2.score += MEDIUM_TRASH_POINT_VAL;
                    p2points_label.Text = P2.score.ToString();
                    if (P2.capacity + MEDIUM_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P2.capacity += MEDIUM_TRASH_CAPACITY_VAL;
                        p2capacity_label.Text = P2.capacity.ToString();
                    }
                }
                else if ((string)spaces[newRow, newCol].Tag == LARGE_TRASH_TAG)
                {
                    spaces[newRow, newCol].BackgroundImage = null;
                    spaces[newRow, newCol].Tag = "";
                    P2.score += LARGE_TRASH_POINT_VAL;
                    p2points_label.Text = P2.score.ToString();
                    if (P2.capacity + LARGE_TRASH_CAPACITY_VAL > MAX_CAPACITY)
                    { // check to verify that player still has capacity space
                        MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                    }
                    else
                    {
                        P2.capacity += LARGE_TRASH_CAPACITY_VAL;
                        p2capacity_label.Text = P2.capacity.ToString();
                    }
                }
                spaces[newRow, newCol].BackgroundImage = imageList1.Images[1];
                spaces[P2.row, P2.col].BackgroundImage = null;
                P2.row = newRow;
                P2.col = newCol;
            }
        }

        public void nextTurn() // changes the currentTurn field to next player
        {
            if (currentTurn == 1) 
            { 
                currentTurn = 2;
                p2icon.BackColor = Color.LightGreen;
                p1icon.BackColor = Color.Gray;
            }
            else
            {
                currentTurn = 1;
                p1icon.BackColor = Color.LightGreen;
                p2icon.BackColor = Color.Gray;
            }
        }

        public bool verifyMove(int newRow, int newCol) // verifies that the move to the passed-in row and col
                                                       // is valid by considering the player who is moving and their current location
        {
            // Check who is currently moving. Get their current location. 
            // Check if the new desired location is a valid move (neighboring space).
            if (P1.row == -1 || P1.col == -1 || P2.row == -1 || P2.col == 1)
            {
                return false; // if anything is = -1, game has not started yet. Don't move any pieces.
            }
            if (isNeighbor(newRow, newCol)) // if true, make move.
            {
                makeMove(newRow, newCol);
                nextTurn();
                return true;
            }
            else return false;
        }

        public void clearBoard() //removes any leftover cats & trash that are on board before beginning new game
        {
            if(P1.row != -1)
            {
                spaces[P1.row, P1.col].BackgroundImage = null;
            }
            if(P2.row != -1)
            {
                spaces[P2.row, P2.col].BackgroundImage = null;
            }
            for(int row = 0; row < BOARDSIZE; ++row)
            {
                for(int col = 0; col < BOARDSIZE; ++col)
                {
                    spaces[row, col].BackgroundImage = null; // remove trash images
                }
            }
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Reset_Click(sender, e);

            p1icon.BackColor = Color.LightGreen;
            p2icon.BackColor = Color.Gray;

            generateTrash();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            if (P1.row != -1 || P1.col != -1 || P2.row != -1 || P2.col != -1) { clearBoard(); }

            spaces[p1_start_row, p1_start_col].BackgroundImage = imageList1.Images[0]; // place Player 1 on the board
            spaces[p2_start_row, p1_start_col].BackgroundImage = imageList1.Images[1]; // place Player 2 on the board

            p1icon.BackColor = Color.White;
            p2icon.BackColor = Color.White;

            p1capacity_label.Text = P1.capacity.ToString();
            p1points_label.Text = P1.score.ToString();
            p2capacity_label.Text = P2.capacity.ToString();
            p2points_label.Text = P2.score.ToString();
        }
        private void groupBox_E2_Enter(object sender, EventArgs e)
        {
            
        }

        

        

        

        private void b0_0_Click(object sender, EventArgs e)
        {
            verifyMove(0, 0);
        }

        private void b0_1_Click(object sender, EventArgs e)
        {
            verifyMove(0, 1);
        }

        private void b0_2_Click(object sender, EventArgs e)
        {
            verifyMove(0, 2);
        }

        private void b0_3_Click(object sender, EventArgs e)
        {
            verifyMove(0, 3);
        }

        private void b0_4_Click(object sender, EventArgs e)
        {
            verifyMove(0, 4);
        }

        private void b0_5_Click(object sender, EventArgs e)
        {
            verifyMove(0, 5);
        }

        private void b0_6_Click(object sender, EventArgs e)
        {
            verifyMove(0, 6);
        }

        private void b0_7_Click(object sender, EventArgs e)
        {
            verifyMove(0, 7);
        }

        private void b0_8_Click(object sender, EventArgs e)
        {
            verifyMove(0, 8);
        }

        private void b0_9_Click(object sender, EventArgs e)
        {
            verifyMove(0, 9);
        }

        private void b0_10_Click(object sender, EventArgs e)
        {
            verifyMove(0, 10);
        }

        private void b0_11_Click(object sender, EventArgs e)
        {
            verifyMove(0, 11);
        }

        private void b0_12_Click(object sender, EventArgs e)
        {
            verifyMove(0, 12);
        }

        private void b0_13_Click(object sender, EventArgs e)
        {
            verifyMove(0, 13);
        }

        private void b0_14_Click(object sender, EventArgs e)
        {
            verifyMove(0, 14);
        }

        private void b1_0_Click(object sender, EventArgs e)
        {
            verifyMove(1, 0);
        }

        private void b1_1_Click(object sender, EventArgs e)
        {
            verifyMove(1, 1);
        }

        private void b1_2_Click(object sender, EventArgs e)
        {
            verifyMove(1, 2);
        }

        private void b1_3_Click(object sender, EventArgs e)
        {
            verifyMove(1, 3);
        }

        private void b1_4_Click(object sender, EventArgs e)
        {
            verifyMove(1, 4);
        }

        private void b1_5_Click(object sender, EventArgs e)
        {
            verifyMove(1, 5);
        }

        private void b1_6_Click(object sender, EventArgs e)
        {
            verifyMove(1, 6);
        }

        private void b1_7_Click(object sender, EventArgs e)
        {
            verifyMove(1, 7);
        }

        private void b1_8_Click(object sender, EventArgs e)
        {
            verifyMove(1, 8);
        }

        private void b1_9_Click(object sender, EventArgs e)
        {
            verifyMove(1, 9);
        }

        private void b1_10_Click(object sender, EventArgs e)
        {
            verifyMove(1, 10);
        }

        private void b1_11_Click(object sender, EventArgs e)
        {
            verifyMove(1, 11);
        }
        private void b1_12_Click(object sender, EventArgs e)
        {
            /*
            b1_12.Text = "HI!";
            b1_12.BackColor = Color.White;
            //b0_12.BackgroundImage = ImageList.ImageCollection
            b2_12.BackgroundImage = imageList1.Images[0];
            spaces[0, 0].BackColor = Color.White;
            */
            verifyMove(1, 12);
        }

        private void b1_13_Click(object sender, EventArgs e)
        {
            verifyMove(1, 13);
        }

        private void b1_14_Click(object sender, EventArgs e)
        {
            verifyMove(1, 14);
        }

        private void b2_0_Click(object sender, EventArgs e)
        {
            verifyMove(2, 0);
        }

        private void b2_1_Click(object sender, EventArgs e)
        {
            verifyMove(2, 1);
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            verifyMove(2, 2);
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            verifyMove(2, 3);
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            verifyMove(2, 4);
        }

        private void b2_5_Click(object sender, EventArgs e)
        {
            verifyMove(2, 5);
        }

        private void b2_6_Click(object sender, EventArgs e)
        {
            verifyMove(2, 6);
        }

        private void b2_7_Click(object sender, EventArgs e)
        {
            verifyMove(2, 7);
        }

        private void b2_8_Click(object sender, EventArgs e)
        {
            verifyMove(2, 8);
        }

        private void b2_9_Click(object sender, EventArgs e)
        {
            verifyMove(2, 9);
        }

        private void b2_10_Click(object sender, EventArgs e)
        {
            verifyMove(2, 10);
        }

        private void b2_11_Click(object sender, EventArgs e)
        {
            verifyMove(2, 11);
        }

        private void b2_12_Click(object sender, EventArgs e)
        {
            verifyMove(2, 12);
        }

        private void b2_13_Click(object sender, EventArgs e)
        {
            verifyMove(2, 13);
        }

        private void b2_14_Click(object sender, EventArgs e)
        {
            verifyMove(2, 14);
        }

        private void b3_0_Click(object sender, EventArgs e)
        {
            verifyMove(3, 0);
        }

        private void b3_1_Click(object sender, EventArgs e)
        {
            verifyMove(3, 1);
        }

        private void b3_2_Click(object sender, EventArgs e)
        {
            verifyMove(3, 2);
        }

        private void b3_3_Click(object sender, EventArgs e)
        {
            verifyMove(3, 3);
        }

        private void b3_4_Click(object sender, EventArgs e)
        {
            verifyMove(3, 4);
        }

        private void b3_5_Click(object sender, EventArgs e)
        {
            verifyMove(3, 5);
        }

        private void b3_6_Click(object sender, EventArgs e)
        {
            verifyMove(3, 6);
        }

        private void b3_7_Click(object sender, EventArgs e)
        {
            verifyMove(3, 7);
        }

        private void b3_8_Click(object sender, EventArgs e)
        {
            verifyMove(3, 8);
        }

        private void b3_9_Click(object sender, EventArgs e)
        {
            verifyMove(3, 9);
        }

        private void b3_10_Click(object sender, EventArgs e)
        {
            verifyMove(3, 10);
        }

        private void b3_11_Click(object sender, EventArgs e)
        {
            verifyMove(3, 11);
        }

        private void b3_12_Click(object sender, EventArgs e)
        {
            verifyMove(3, 12);
        }

        private void b3_13_Click(object sender, EventArgs e)
        {
            verifyMove(3, 13);
        }

        private void b3_14_Click(object sender, EventArgs e)
        {
            verifyMove(3, 14);
        }

        private void b4_0_Click(object sender, EventArgs e)
        {
            verifyMove(4, 0);
        }

        private void b4_1_Click(object sender, EventArgs e)
        {
            verifyMove(4, 1);
        }

        private void b4_2_Click(object sender, EventArgs e)
        {
            verifyMove(4, 2);
        }

        private void b4_3_Click(object sender, EventArgs e)
        {
            verifyMove(4, 3);
        }

        private void b4_4_Click(object sender, EventArgs e)
        {
            verifyMove(4, 4);
        }

        private void b4_5_Click(object sender, EventArgs e)
        {
            verifyMove(4, 5);
        }

        private void b4_6_Click(object sender, EventArgs e)
        {
            verifyMove(4, 6);
        }

        private void b4_7_Click(object sender, EventArgs e)
        {
            verifyMove(4, 7);
        }

        private void b4_8_Click(object sender, EventArgs e)
        {
            verifyMove(4, 8);
        }

        private void b4_9_Click(object sender, EventArgs e)
        {
            verifyMove(4, 9);
        }

        private void b4_10_Click(object sender, EventArgs e)
        {
            verifyMove(4, 10);
        }

        private void b4_11_Click(object sender, EventArgs e)
        {
            verifyMove(4, 11);
        }

        private void b4_12_Click(object sender, EventArgs e)
        {
            verifyMove(4, 12);
        }

        private void b4_13_Click(object sender, EventArgs e)
        {
            verifyMove(4, 13);
        }

        private void b4_14_Click(object sender, EventArgs e)
        {
            verifyMove(4, 14);
        }

        private void b5_0_Click(object sender, EventArgs e)
        {
            verifyMove(5, 0);
        }

        private void b5_1_Click(object sender, EventArgs e)
        {
            verifyMove(5, 1);
        }

        private void b5_2_Click(object sender, EventArgs e)
        {
            verifyMove(5, 2);
        }

        private void b5_3_Click(object sender, EventArgs e)
        {
            verifyMove(5, 3);
        }

        private void b5_4_Click(object sender, EventArgs e)
        {
            verifyMove(5, 4);
        }

        private void b5_5_Click(object sender, EventArgs e)
        {
            verifyMove(5, 5);
        }

        private void b5_6_Click(object sender, EventArgs e)
        {
            verifyMove(5, 6);
        }

        private void b5_7_Click(object sender, EventArgs e)
        {
            verifyMove(5, 7);
        }

        private void b5_8_Click(object sender, EventArgs e)
        {
            verifyMove(5, 8);
        }

        private void b5_9_Click(object sender, EventArgs e) //wrong title?
        {
            verifyMove(5, 9);
        }

        private void b5_10_Click(object sender, EventArgs e)
        {
            verifyMove(5, 10);
        }

        private void b5_11_Click(object sender, EventArgs e) //wrong title?
        {
            verifyMove(5, 11);
        }

        private void b5_12_Click(object sender, EventArgs e)
        {
            verifyMove(5, 12);
        }

        private void b5_13_Click(object sender, EventArgs e)
        {
            verifyMove(5, 13);
        }

        private void b5_14_Click(object sender, EventArgs e)
        {
            verifyMove(5, 14);
        }

        private void b6_0_Click(object sender, EventArgs e)
        {
            verifyMove(6, 0);
        }

        private void b6_1_Click(object sender, EventArgs e)
        {
            verifyMove(6, 1);
        }

        private void b6_2_Click(object sender, EventArgs e)
        {
            verifyMove(6, 2);
        }

        private void b6_3_Click(object sender, EventArgs e)
        {
            verifyMove(6, 3);
        }

        private void b6_4_Click(object sender, EventArgs e)
        {
            verifyMove(6, 4);
        }

        private void b6_5_Click(object sender, EventArgs e)
        {
            verifyMove(6, 5);
        }

        private void b6_6_Click(object sender, EventArgs e)
        {
            verifyMove(6, 6);
        }

        private void b6_7_Click(object sender, EventArgs e)
        {
            verifyMove(6, 7);
        }

        private void b6_8_Click(object sender, EventArgs e)
        {
            verifyMove(6, 8);
        }

        private void b6_9_Click(object sender, EventArgs e)
        {
            verifyMove(6, 9);
        }

        private void b6_10_Click(object sender, EventArgs e)
        {
            verifyMove(6, 10);
        }

        private void b6_11_Click(object sender, EventArgs e)
        {
            verifyMove(6, 11);
        }

        private void b6_12_Click(object sender, EventArgs e)
        {
            verifyMove(6, 12);
        }

        private void b6_13_Click(object sender, EventArgs e)
        {
            verifyMove(6, 13);
        }

        private void b6_14_Click(object sender, EventArgs e)
        {
            verifyMove(6, 14);
        }

        private void b7_0_Click(object sender, EventArgs e)
        {
            verifyMove(7, 0);
        }

        private void b7_1_Click(object sender, EventArgs e)
        {
            verifyMove(7, 1);
        }

        private void b7_2_Click(object sender, EventArgs e)
        {
            verifyMove(7, 2);
        }

        private void b7_3_Click(object sender, EventArgs e)
        {
            verifyMove(7, 3);
        }

        private void b7_4_Click(object sender, EventArgs e)
        {
            verifyMove(7, 4);
        }

        private void b7_5_Click(object sender, EventArgs e)
        {
            verifyMove(7, 5);
        }

        private void b7_6_Click(object sender, EventArgs e)
        {
            verifyMove(7, 6);
        }

        private void b7_7_Click(object sender, EventArgs e)
        {
            verifyMove(7, 7);
        }

        private void b7_8_Click(object sender, EventArgs e)
        {
            verifyMove(7, 8);
        }

        private void b7_9_Click(object sender, EventArgs e)
        {
            verifyMove(7, 9);
        }

        private void b7_10_Click(object sender, EventArgs e)
        {
            verifyMove(7, 10);
        }

        private void b7_11_Click(object sender, EventArgs e)
        {
            verifyMove(7, 11);
        }

        private void b7_12_Click(object sender, EventArgs e)
        {
            verifyMove(7, 12);
        }

        private void b7_13_Click(object sender, EventArgs e)
        {
            verifyMove(7, 13);
        }

        private void b7_14_Click(object sender, EventArgs e)
        {
            verifyMove(7, 14);
        }

        private void b8_0_Click(object sender, EventArgs e)
        {
            verifyMove(8, 0);
        }

        private void b8_1_Click(object sender, EventArgs e)
        {
            verifyMove(8, 1);
        }

        private void b8_2_Click(object sender, EventArgs e)
        {
            verifyMove(8, 2);
        }

        private void b8_3_Click(object sender, EventArgs e)
        {
            verifyMove(8, 3);
        }

        private void b8_4_Click(object sender, EventArgs e)
        {
            verifyMove(8, 4);
        }

        private void b8_5_Click(object sender, EventArgs e)
        {
            verifyMove(8, 5);
        }

        private void b8_6_Click(object sender, EventArgs e)
        {
            verifyMove(8, 6);
        }

        private void b8_7_Click(object sender, EventArgs e)
        {
            verifyMove(8, 7);
        }

        private void b8_8_Click(object sender, EventArgs e)
        {
            verifyMove(8, 8);
        }

        private void b8_9_Click(object sender, EventArgs e)
        {
            verifyMove(8, 9);
        }

        private void b8_10_Click(object sender, EventArgs e)
        {
            verifyMove(8, 10);
        }

        private void b8_11_Click(object sender, EventArgs e)
        {
            verifyMove(8, 11);
        }

        private void b8_12_Click(object sender, EventArgs e)
        {
            verifyMove(8, 12);
        }

        private void b8_13_Click(object sender, EventArgs e)
        {
            verifyMove(8, 13);
        }

        private void b8_14_Click(object sender, EventArgs e)
        {
            verifyMove(8, 14);
        }

        private void b9_0_Click(object sender, EventArgs e)
        {
            verifyMove(9, 0);
        }

        private void b9_1_Click(object sender, EventArgs e)
        {
            verifyMove(9, 1);
        }

        private void b9_2_Click(object sender, EventArgs e)
        {
            verifyMove(9, 2);
        }

        private void b9_3_Click(object sender, EventArgs e)
        {
            verifyMove(9, 3);
        }

        private void b9_4_Click(object sender, EventArgs e)
        {
            verifyMove(9, 4);
        }

        private void b9_5_Click(object sender, EventArgs e)
        {
            verifyMove(9, 5);
        }

        private void b9_6_Click(object sender, EventArgs e)
        {
            verifyMove(9, 6);
        }

        private void b9_7_Click(object sender, EventArgs e)
        {
            verifyMove(9, 7);
        }

        private void b9_8_Click(object sender, EventArgs e)
        {
            verifyMove(9, 8);
        }

        private void b9_9_Click(object sender, EventArgs e)
        {
            verifyMove(9, 9);
        }

        private void b9_10_Click(object sender, EventArgs e)
        {
            verifyMove(9, 10);
        }

        private void b9_11_Click(object sender, EventArgs e)
        {
            verifyMove(9, 11);
        }

        private void b9_12_Click(object sender, EventArgs e)
        {
            verifyMove(9, 12);
        }

        private void b9_13_Click(object sender, EventArgs e)
        {
            verifyMove(9, 13);
        }

        private void b9_14_Click(object sender, EventArgs e)
        {
            verifyMove(9, 14);
        }

        private void b10_0_Click(object sender, EventArgs e)
        {
            verifyMove(10, 0);
        }

        private void b10_1_Click(object sender, EventArgs e)
        {
            verifyMove(10, 1);
        }

        private void b10_2_Click(object sender, EventArgs e)
        {
            verifyMove(10, 2);
        }

        private void b10_3_Click(object sender, EventArgs e)
        {
            verifyMove(10, 3);
        }

        private void b10_4_Click(object sender, EventArgs e)
        {
            verifyMove(10, 4);
        }

        private void b10_5_Click(object sender, EventArgs e)
        {
            verifyMove(10, 5);
        }

        private void b10_6_Click(object sender, EventArgs e)
        {
            verifyMove(10, 6);
        }

        private void b10_7_Click(object sender, EventArgs e)
        {
            verifyMove(10, 7);
        }

        private void b10_8_Click(object sender, EventArgs e)
        {
            verifyMove(10, 8);
        }

        private void b10_9_Click(object sender, EventArgs e)
        {
            verifyMove(10, 9);
        }

        private void b10_10_Click(object sender, EventArgs e)
        {
            verifyMove(10, 10);
        }

        private void b10_11_Click(object sender, EventArgs e)
        {
            verifyMove(10, 11);
        }

        private void b10_12_Click(object sender, EventArgs e)
        {
            verifyMove(10, 12);
        }

        private void b10_13_Click(object sender, EventArgs e)
        {
            verifyMove(10, 13);
        }

        private void b10_14_Click(object sender, EventArgs e)
        {
            verifyMove(10, 14);
        }

        private void b11_0_Click(object sender, EventArgs e)
        {
            verifyMove(11, 0);
        }

        private void b11_1_Click(object sender, EventArgs e)
        {
            verifyMove(11, 1);
        }

        private void b11_2_Click(object sender, EventArgs e)
        {
            verifyMove(11, 2);
        }

        private void b11_3_Click(object sender, EventArgs e)
        {
            verifyMove(11, 3);
        }

        private void b11_4_Click(object sender, EventArgs e)
        {
            verifyMove(11, 4);
        }

        private void b11_5_Click(object sender, EventArgs e)
        {
            verifyMove(11, 5);
        }

        private void b11_6_Click(object sender, EventArgs e)
        {
            verifyMove(11, 6);
        }

        private void b11_7_Click(object sender, EventArgs e)
        {
            verifyMove(11, 7);
        }

        private void b11_8_Click(object sender, EventArgs e)
        {
            verifyMove(11, 8);
        }

        private void b11_9_Click(object sender, EventArgs e)
        {
            verifyMove(11, 9);
        }

        private void b11_10_Click(object sender, EventArgs e)
        {
            verifyMove(11, 10);
        }

        private void b11_11_Click(object sender, EventArgs e)
        {
            verifyMove(11, 11);
        }

        private void b11_12_Click(object sender, EventArgs e)
        {
            verifyMove(11, 12);
        }

        private void b11_13_Click(object sender, EventArgs e)
        {
            verifyMove(11, 13);
        }

        private void b11_14_Click(object sender, EventArgs e)
        {
            verifyMove(11, 14);
        }

        private void b12_0_Click(object sender, EventArgs e)
        {
            verifyMove(12, 0);
        }

        private void b12_1_Click(object sender, EventArgs e)
        {
            verifyMove(12, 1);
        }

        private void b12_2_Click(object sender, EventArgs e)
        {
            verifyMove(12, 2);
        }

        private void b12_3_Click(object sender, EventArgs e)
        {
            verifyMove(12, 3);
        }

        private void b12_4_Click(object sender, EventArgs e)
        {
            verifyMove(12, 4);
        }

        private void b12_5_Click(object sender, EventArgs e)
        {
            verifyMove(12, 5);
        }

        private void b12_6_Click(object sender, EventArgs e)
        {
            verifyMove(12, 6);
        }

        private void b12_7_Click(object sender, EventArgs e)
        {
            verifyMove(12, 7);
        }

        private void b12_8_Click(object sender, EventArgs e)
        {
            verifyMove(12, 8);
        }

        private void b12_9_Click(object sender, EventArgs e)
        {
            verifyMove(12, 9);
        }

        private void b12_10_Click(object sender, EventArgs e)
        {
            verifyMove(12, 10);
        }

        private void b12_11_Click(object sender, EventArgs e)
        {
            verifyMove(12, 11);
        }

        private void b12_12_Click(object sender, EventArgs e)
        {
            verifyMove(12, 12);
        }

        private void b12_13_Click(object sender, EventArgs e)
        {
            verifyMove(12, 13);
        }

        private void b12_14_Click(object sender, EventArgs e)
        {
            verifyMove(12, 14);
        }

        private void b13_0_Click(object sender, EventArgs e)
        {
            verifyMove(13, 0);
        }

        private void b13_1_Click(object sender, EventArgs e)
        {
            verifyMove(13, 1);
        }

        private void b13_2_Click(object sender, EventArgs e)
        {
            verifyMove(13, 2);
        }

        private void b13_3_Click(object sender, EventArgs e)
        {
            verifyMove(13, 3);
        }

        private void b13_4_Click(object sender, EventArgs e)
        {
            verifyMove(13, 4);
        }

        private void b13_5_Click(object sender, EventArgs e)
        {
            verifyMove(13, 5);
        }

        private void b13_6_Click(object sender, EventArgs e)
        {
            verifyMove(13, 6);
        }

        private void b13_7_Click(object sender, EventArgs e)
        {
            verifyMove(13, 7);
        }

        private void b13_8_Click(object sender, EventArgs e)
        {
            verifyMove(13, 8);
        }

        private void b13_9_Click(object sender, EventArgs e)
        {
            verifyMove(13, 9);
        }

        private void b13_10_Click(object sender, EventArgs e)
        {
            verifyMove(13, 10);
        }

        private void b13_11_Click(object sender, EventArgs e)
        {
            verifyMove(13, 11);
        }

        private void b13_12_Click(object sender, EventArgs e)
        {
            verifyMove(13, 12);
        }

        private void b13_13_Click(object sender, EventArgs e)
        {
            verifyMove(13, 13);
        }

        private void b13_14_Click(object sender, EventArgs e)
        {
            verifyMove(13, 14);
        }

        private void b14_0_Click(object sender, EventArgs e)
        {
            verifyMove(14, 0);
        }

        private void b14_1_Click(object sender, EventArgs e)
        {
            verifyMove(14, 1);
        }

        private void b14_2_Click(object sender, EventArgs e)
        {
            verifyMove(14, 2);
        }

        private void b14_3_Click(object sender, EventArgs e)
        {
            verifyMove(14, 3);
        }

        private void b14_4_Click(object sender, EventArgs e)
        {
            verifyMove(14, 4);
        }

        private void b14_5_Click(object sender, EventArgs e)
        {
            verifyMove(14, 5);
        }

        private void b14_6_Click(object sender, EventArgs e)
        {
            verifyMove(14, 6);
        }

        private void b14_7_Click(object sender, EventArgs e)
        {
            verifyMove(14, 7);
        }

        private void b14_8_Click(object sender, EventArgs e)
        {
            verifyMove(14, 8);
        }

        private void b14_9_Click(object sender, EventArgs e)
        {
            verifyMove(14, 9);
        }

        private void b14_10_Click(object sender, EventArgs e)
        {
            verifyMove(14, 10);
        }

        private void b14_11_Click(object sender, EventArgs e)
        {
            verifyMove(14, 11);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void b14_12_Click(object sender, EventArgs e)
        {
            verifyMove(14, 12);
        }

        private void b14_13_Click(object sender, EventArgs e)
        {
            verifyMove(14, 13);
        }

        private void b14_14_Click(object sender, EventArgs e)
        {
            verifyMove(14, 14);
        }
    }
}
