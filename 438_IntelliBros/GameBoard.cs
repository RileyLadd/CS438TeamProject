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
        static Button[,] spaces = new Button[BOARDSIZE, BOARDSIZE]; // *** Use this array to modify button background colors/images/etc !!! *** //

        class Player
        {
            public int row, col, score, capacity;
            public Player()
            {
                row = col = -1;
                score = capacity = 0;
            }

            public void reset()
            {
                score = capacity = 0;
            }

            public void addSmall()
            {
                score += SMALL_TRASH_POINT_VAL;
                addCapacity(1);
            }

            public void addMed()
            {
                score += MEDIUM_TRASH_POINT_VAL;
                addCapacity(2);
            }

            public void addLarge()
            {
                score += LARGE_TRASH_POINT_VAL;
                addCapacity(3);
            }

            private void addCapacity(int type) //small / med / large
            {
                int addingCap;
                switch (type)
                {
                    case 1:
                        addingCap = SMALL_TRASH_CAPACITY_VAL;
                        break;
                    case 2:
                        addingCap = MEDIUM_TRASH_CAPACITY_VAL;
                        break;
                    case 3:
                        addingCap = LARGE_TRASH_CAPACITY_VAL;
                        break;
                    default:
                        addingCap = 0;
                        break;
                }
                if (capacity + addingCap > MAX_CAPACITY)
                { // check to verify that player still has capacity space
                    MessageBox.Show("TODO: Capacity exceeded. \nGame should end here and player with most points wins.", "Error");
                }
                else
                {
                    capacity += addingCap;
                }
            }

            public void rmImg()
            {
                //make current player lose its image and color
                spaces[row, col].BackgroundImage = null;
                spaces[row, col].BackColor = Color.LightGray;
            }

            public void moveTo(int newRow, int newCol)
            {
                row = newRow;
                col = newCol;
            }
        }

        Player P1 = new Player();
        Player P2 = new Player();
        int currentTurn = 1; // Keeps track of if player 1 or player 2 is currently playing/making a move

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
                    tempButton.Location = new Point(731 + (col * BUTTON_SIZE), 29 + (row * BUTTON_SIZE));
                    tempButton.BackColor = Color.LightGray;
                    tempButton.AutoSize = false;
                    tempButton.BackgroundImageLayout = ImageLayout.Stretch;
                    tempButton.Click += button_Click;

                    //tempButton.Text = row.ToString() + ", " + col.ToString(); debugger for (col * BUTTON_SIZE), 29 + (row * BUTTON_SIZE)

                    spaces[row, col] = tempButton;
                    this.Controls.Add(spaces[row, col]);
                }
            }
        }

        public void generateTrash() // Called when beginning a new game. Uses random num generator to scatter trash across board
        {
            Random rand_num = new Random();
            int rand = 0;
            for (int i = 0; i < BOARDSIZE; ++i)
            {
                for (int j = 0; j < BOARDSIZE; ++j)
                {
                    if (!(i == P1.row && j == P1.col) && !(i == P2.row && j == P2.col)) // Don't spawn trash on players
                    {
                        rand = rand_num.Next(0, 4); // generates num between 0 and 3. only spawn trash if num is 3. 25% trash rate across board.
                        //spaces[i, j].BackColor = Color.LightGray;
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
            if (newRow == P1.row && newCol == P1.col) { return false; } // can't "move" to same space
            if (newRow == P2.row && newCol == P2.col) { return false; } // can't sit on another player's space

            if (currentTurn == 1)
            {
                return (Math.Abs(newRow - P1.row) < 2 && Math.Abs(newCol - P1.col) < 2);
            }
            else // it is player 2's turn
            {
                return (Math.Abs(newRow - P2.row) < 2 && Math.Abs(newCol - P2.col) < 2);
            }
        }

        public void makeMove(int newRow, int newCol)
        {
            if (currentTurn == 1)   //P1
            {
                if ((string)spaces[newRow, newCol].Tag == SMALL_TRASH_TAG)
                {
                    P1.addSmall();
                }
                else if ((string)spaces[newRow, newCol].Tag == MEDIUM_TRASH_TAG)
                {
                    P1.addMed();
                }
                else if ((string)spaces[newRow, newCol].Tag == LARGE_TRASH_TAG)
                {
                    P1.addLarge();
                }
                //rm current postion image and color
                P1.rmImg();

                //updates P1 image and location
                P1_PutImageLoc(newRow, newCol);
            }
            else // it is player 2's turn
            {
                if ((string)spaces[newRow, newCol].Tag == SMALL_TRASH_TAG)
                {
                    P2.addSmall();
                }
                else if ((string)spaces[newRow, newCol].Tag == MEDIUM_TRASH_TAG)
                {
                    P2.addMed();
                }
                else if ((string)spaces[newRow, newCol].Tag == LARGE_TRASH_TAG)
                {
                    P2.addLarge();
                }
                //rm current postion image and color
                P2.rmImg();

                //updates P2 image and location
                P2_PutImageLoc(newRow, newCol);
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

        public void nextTurn() // changes the currentTurn field to next player
        {
            if (currentTurn == 1)
            {
                currentTurn = 2;
                //update P1 values
                P1_updateLabels();

                nextTurnIs_P1();
            }
            else
            {
                currentTurn = 1;
                //update P2 values
                P2_updateLabels();

                nextTurnIs_P2();
            }
        }

        public void button_Start_Click(object sender, EventArgs e)
        {
            if (P1.row == -1 || P1.col == -1 || P2.row == -1 || P2.col == 1) { button_Reset_Click(sender, e); }
            
            generateTrash();
        }

        public void button_Reset_Click(object sender, EventArgs e)
        {
            clearBoard();

            P1_PutImageLoc();
            P2_PutImageLoc();

            if (currentTurn == 1)
            {
                nextTurnIs_P2();
            }
            else
            {
                nextTurnIs_P1();
            }

            P1.reset();
            P2.reset();

            P1_updateLabels();
            P2_updateLabels();
        }

        public void clearBoard() //removes images, colors, tags
        {
            for (int row = 0; row < BOARDSIZE; ++row)
            {
                for (int col = 0; col < BOARDSIZE; ++col)
                {
                    spaces[row, col].BackgroundImage = null;
                    spaces[row, col].BackColor = Color.LightGray;
                    spaces[row, col].Tag = null;
                }
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //find the button based on its location
            //row = (731 + (col * BUTTON_SIZE)
            //col = 29 + (row * BUTTON_SIZE)

            int newX = b.Location.X;
            int newY = b.Location.Y;

            int row = (newY - 29) / BUTTON_SIZE;
            int col = (newX - 731) / BUTTON_SIZE;

            verifyMove(row, col);
        }

        public void P1_updateLabels()
        {
            p1capacity_label.Text = P1.capacity.ToString();
            p1points_label.Text = P1.score.ToString();
        }

        public void P2_updateLabels()
        {
            p2capacity_label.Text = P2.capacity.ToString();
            p2points_label.Text = P2.score.ToString();
        }

        //default to start
        public void P1_PutImageLoc(int row = p1_start_row, int col = p1_start_col)
        {
            P1.moveTo(row, col);
            spaces[row, col].BackgroundImage = imageList1.Images[0]; // place Player 1 on the board
        }

        public void P2_PutImageLoc(int row = p2_start_row, int col = p2_start_col)
        {
            P2.moveTo(row, col);
            spaces[row, col].BackgroundImage = imageList1.Images[1]; // place Player 2 on the board
        }

        public void nextTurnIs_P1()
        {
            p1icon.BackColor = Color.LightGray;
            spaces[P1.row, P1.col].BackColor = Color.LightGray;

            p2icon.BackColor = Color.Green;
            spaces[P2.row, P2.col].BackColor = Color.Green;
        }

        public void nextTurnIs_P2()
        {
            p2icon.BackColor = Color.LightGray;
            spaces[P2.row, P2.col].BackColor = Color.LightGray;

            p1icon.BackColor = Color.Green;
            spaces[P1.row, P1.col].BackColor = Color.Green;
        }
    }
}