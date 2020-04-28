using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using "PriorityQueuesProgram.cs";

namespace _438_IntelliBros
{
    public partial class GameBoard : Form

    {
        static Button[,] spaces = new Button[BOARDSIZE, BOARDSIZE]; // *** Use this array to modify button background colors/images/etc !!! *** //
        partial class PossibleMove : IComparable<PossibleMove> // Used to store a possible next move in the Priotity Queue
        {
            public int nextRow, nextColumn;
            public double priority; //small values are higher priority
            public PossibleMove()
            {

            }
            public PossibleMove(int row, int col, double priority)
            {
                nextRow = row;
                nextColumn = col;
                this.priority = priority;
            }

            //public override string ToString()
            //{
                //return "(" + lastName + ", " + priority.ToString("F1") + ")";
            //}

            public int CompareTo(PossibleMove other)
            {
                if (this.priority < other.priority) return -1;
                else if (this.priority > other.priority) return 1;
                else return 0;
            }
        }
        
        partial class Player 
        {
            //player type
            /*
             * 1 user
             * 2 shortest dist
             * 3 closest
             * 4 focus on largest available trash
             */
            public int row, col, score, capacity, type;
            public Player()
            {
                row = col = -1;
                score = capacity = 0;
                type = -1; //default user before selecting the actual type
            }

            public void reset()
            {
                score = capacity = 0;
                type = -1;
            }

            public void rmPos()
            {
                //make current player lose all button attributes
                spaces[row, col].Tag = null;
                spaces[row, col].BackgroundImage = null;
                spaces[row, col].BackColor = Color.LightGray;
            }

            public void moveTo(int newRow, int newCol)
            {
                row = newRow;
                col = newCol;
                spaces[row, col].Tag = "player";
            }

            public bool makeMove(int newRow, int newCol)
            {
                switch (type)
                {
                    case 1: //isNeightbor gets checked
                        break;
                    case 2:
                        //TODO find new values for newRow / newCol
                        //newRow = 5;
                        break;
                    case 3:
                        //TODO find new values for newRow / newCol (closest, aka greedy)
                        //++newRow;
                        //newCol = col + 1;
                        
                        break;
                    case 4:
                        break;

                    default:
                        break;
                }

                if (isNeighbor(newRow, newCol))
                {
                    if ((string)spaces[newRow, newCol].Tag == SMALL_TRASH_TAG)
                    {
                        addSmall();
                    }
                    else if ((string)spaces[newRow, newCol].Tag == MEDIUM_TRASH_TAG)
                    {
                        addMed();
                    }
                    else if ((string)spaces[newRow, newCol].Tag == LARGE_TRASH_TAG)
                    {
                        addLarge();
                    }
                    else if ((string)spaces[newRow, newCol].Tag == "mouse")
                    {
                        addMouse();
                        spaces[newRow, newCol].Tag = null;
                    }
                        
                    return true;
                }
                return false;
            }

            private void addSmall()
            {
                score += SMALL_TRASH_POINT_VAL;
                addCapacity(1);
            }

            private void addMed()
            {
                score += MEDIUM_TRASH_POINT_VAL;
                addCapacity(2);
            }

            private void addLarge()
            {
                score += LARGE_TRASH_POINT_VAL;
                addCapacity(3);
            }
            private void addMouse()
            {
                score += MOUSE_POINT_VAL;
                addCapacity(4);                
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
                    case 4:
                        addingCap = MOUSE_CAPACITY_VAL;
                        break;
                    default:
                        addingCap = 0;
                        break;
                }
                if (capacity + addingCap > MAX_CAPACITY)
                { // check to verify that player still has capacity space
                    MessageBox.Show("A player has exceeded their Capacity.", "Capacity Exceeded");
                    
                }
                else
                {
                    capacity += addingCap;
                }
            }

            private bool isNeighbor(int newRow, int newCol)
            {
                if (newRow < 0 || newCol < 0 || newRow == BOARDSIZE || newCol == BOARDSIZE || (string)spaces[newRow, newCol].Tag == "player")
                { // can't move to occupied space

                    if(newRow == BOARDSIZE || newCol == BOARDSIZE)
                    {
                        string error_msg = "A player made a wrong move into an out-of-bounds board space.\nGame over.";
                        //if ( currentTurn == 1) error_msg += "Entity 1 ";
                        //else error_msg += "Entity 2 ";

                        MessageBox.Show(error_msg,"Error");
                    }
                    return false; 
                } 
                return (Math.Abs(newRow - row) < 2 && Math.Abs(newCol - col) < 2);
            }
        }

        //player helpers
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

        //place player onto the board, default to start location
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
            Refresh();
            ++numTurns; // counter that keeps track of number of turns 
            if (!isTrashRemaining() || gameOver || P1.capacity > MAX_CAPACITY || P2.capacity > MAX_CAPACITY) determineWinner(); 
            else if (P2.type != 1) determineNextMove(); // i.e., if P2 isn't a human player, go ahead and move automatically
        }

        public void nextTurnIs_P2()
        {
            p2icon.BackColor = Color.LightGray;
            spaces[P2.row, P2.col].BackColor = Color.LightGray;

            p1icon.BackColor = Color.Green;
            spaces[P1.row, P1.col].BackColor = Color.Green;
            Refresh();
            ++numTurns; // counter that keeps track of number of turns

            Random rand_num = new Random(); //mouse generation/movement
            int rand = 0;
            rand = rand_num.Next(0, 5);
            if(!isMouseOnBoard())
            {
                if(rand == 0) // 20% chance of generating mouse on this player's turn
                {
                    generateMouse();
                }
            } else // there's a mouse in the game, need to move it and add trash where it was
            {
                if(rand_num.Next(0,2) == 0) // 50% chance of moving on this player's turn
                    moveMouse();
            }

            if (!isTrashRemaining() || gameOver || P1.capacity > MAX_CAPACITY || P2.capacity > MAX_CAPACITY) determineWinner();
            else if (P1.type != 1) determineNextMove(); // i.e., if P1 isn't a human player, go ahead and move automatically
        }


        private void E1_User_Click(object sender, EventArgs e)
        {
            P1.type = 1;
            if (P2.type != -1 && !game_started) button_Start.Enabled = true;
            E1_ShortestDist.Enabled = E1_Closest.Enabled = E1_BigTrashFirst.Enabled = false;
        }
        private void E2_User_Click(object sender, EventArgs e)
        {
            P2.type = 1;
            if (P1.type != -1 && !game_started) button_Start.Enabled = true;
            E2_ShortestDist.Enabled = E2_Closest.Enabled = E2_BigTrashFirst.Enabled = false;
        }
        private void E1_ShortestDist_Click(object sender, EventArgs e)
        {
            P1.type = 2;
            if (P2.type != -1 && !game_started) button_Start.Enabled = true;
            E1_User.Enabled = E1_Closest.Enabled = E1_BigTrashFirst.Enabled = false;
        }
        private void E2_ShortestDist_Click(object sender, EventArgs e)
        {
            P2.type = 2;
            if (P1.type != -1 && !game_started) button_Start.Enabled = true;
            E2_User.Enabled = E2_Closest.Enabled = E2_BigTrashFirst.Enabled = false;
        }
        private void E1_Closest_Click(object sender, EventArgs e)
        {
            P1.type = 3;
            if (P2.type != -1&& !game_started) button_Start.Enabled = true;
            E1_User.Enabled = E1_ShortestDist.Enabled = E1_BigTrashFirst.Enabled = false;
        }
        private void E2_Closest_Click(object sender, EventArgs e)
        {
            P2.type = 3;
            if (P1.type != -1 && !game_started) button_Start.Enabled = true;
            E2_User.Enabled = E2_ShortestDist.Enabled = E2_BigTrashFirst.Enabled = false;
        }
        private void E1_BigTrashFirst_Click(object sender, EventArgs e)
        {
            P1.type = 4;
            if (P2.type != -1 && !game_started) button_Start.Enabled = true;
            E1_User.Enabled = E1_ShortestDist.Enabled = E1_Closest.Enabled = false;
        }
        private void E2_BigTrashFirst_Click(object sender, EventArgs e)
        {
            P2.type = 4;
            if (P1.type != -1 && !game_started) button_Start.Enabled = true;
            E2_User.Enabled = E2_ShortestDist.Enabled = E2_Closest.Enabled = false;
        }

        
        Player P1 = new Player();
        Player P2 = new Player();
        int currentTurn = 1; // Keeps track of if player 1 or player 2 is currently playing/making a move
        bool gameOver = false;
        int numTurns = 0;
        bool mouseInGame = false;

        //change the starting positions
        const int p1_start_row = 7;
        const int p1_start_col = 0;
        const int p2_start_row = 7;
        const int p2_start_col = 14;
        int mouseRow = -1, mouseCol = -1;

        const int BOARDSIZE = 15; // The height/width of the board
        const int MAX_CAPACITY = 200; // Max cleaning capacity of the cats
        const int BUTTON_SIZE = 50;
        const int SMALL_TRASH_POINT_VAL = 2;
        const int MEDIUM_TRASH_POINT_VAL = 5;
        const int LARGE_TRASH_POINT_VAL = 10;
        const int MOUSE_POINT_VAL = 15;
        const int SMALL_TRASH_CAPACITY_VAL = 1;
        const int MEDIUM_TRASH_CAPACITY_VAL = 2;
        const int LARGE_TRASH_CAPACITY_VAL = 3;
        const int MOUSE_CAPACITY_VAL = 10;
        const string SMALL_TRASH_TAG = "SMALL";
        const string MEDIUM_TRASH_TAG = "MEDIUM";
        const string LARGE_TRASH_TAG = "LARGE";
        bool game_started = false; // if true, game is in progress

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


        public double BTF_heuristic(int nextRow, int nextCol)
        {
            if (currentTurn == 1) { // it is player 1's turn
                if(areSpacesNeighbors(P1.row, P1.col, nextRow, nextCol) && (string)spaces[nextRow, nextCol].Tag != "player")
                {
                    return 0.0;
                }


                return 100.0;
            } else // it is player 2's turn
            {
                if (areSpacesNeighbors(P2.row, P2.col, nextRow, nextCol) && (string)spaces[nextRow, nextCol].Tag != "player")
                {
                    return 0.0;
                }
                return 100.0;
            }
        }
        public void BigTrashFirst(ref int nextRow, ref int nextCol) // determines where to move next; utilizes Priority Queue
        {
            PriorityQueue<PossibleMove> pq = new PriorityQueue<PossibleMove>();
            PossibleMove [] move = new PossibleMove[226];
            int i = 0;
            for(int r = 0; r < BOARDSIZE; ++r)
            {
                for(int c = 0; c < BOARDSIZE; ++c)
                {
                    //move = new PossibleMove(nextRow, nextCol, BTF_heuristic(nextRow, nextCol));
                    move[i] = new PossibleMove();
                    move[i].priority = BTF_heuristic(nextRow, nextCol);

                    move[i].nextRow = nextRow; move[i].nextColumn = nextCol;

                    pq.Enqueue(move[i]);
                    ++i;
                }
            }
            PossibleMove move2 = pq.Dequeue();
            
            nextRow = move2.nextRow; nextCol = move2.nextColumn;
            //verifyMove(, nextCol); // make move
        }

        public void generateMouse()
        {
            Random rand_num = new Random();
            int rand = 0;
            rand = rand_num.Next(0, 2);
            if (rand == 0) mouseRow = 0; //only generate mouse on top or bottom of board
            else mouseRow = 14;

            do
            {
                mouseCol = rand_num.Next(0, 15);
            }
            while ((string)spaces[mouseRow, mouseCol].Tag != null);
            spaces[mouseRow, mouseCol].BackgroundImage = imageList1.Images[2];
            spaces[mouseRow, mouseCol].Tag = "mouse";
            mouseInGame = true;
        }
        public void moveMouse()
        {

            Random rand_num = new Random();
            int rand = 0, trashType = -1, newRow = -1, newCol = -1;
            rand = rand_num.Next(0, 6);
            if (rand == 0 || rand == 1 || rand == 2) trashType = 3; //small trash
            else if (rand == 3 || rand == 4) trashType = 4; //medium trash
            else trashType = 5; //large trash

            bool foundNewSpot = false;
            int iters = 0;
            while(!foundNewSpot && iters < 100)
            {
                newRow = mouseRow + rand_num.Next(-1, 2);
                newCol = mouseCol + rand_num.Next(-1, 2);
                foundNewSpot = isValidMouseMove(newRow, newCol);
                ++iters;
            }
            if (iters == 100) return; //mouse can't move, so just don't move this time.
            //have now found a new spot
            //if((string)spaces[mouseRow, mouseCol].Tag == )
            spaces[mouseRow, mouseCol].BackgroundImage = imageList1.Images[trashType];
            if (trashType == 3) spaces[mouseRow, mouseCol].Tag = SMALL_TRASH_TAG;
            else if (trashType == 4) spaces[mouseRow, mouseCol].Tag = MEDIUM_TRASH_TAG;
            else spaces[mouseRow, mouseCol].Tag = LARGE_TRASH_TAG;
            spaces[newRow, newCol].BackgroundImage = imageList1.Images[2]; //put mouse icon on new spot
            spaces[newRow, newCol].Tag = "mouse";
            mouseRow = newRow;
            mouseCol = newCol;


        }
        public bool isValidMouseMove(int newRow, int newCol)
        {
            if (newRow < 0 || newRow > 14 || newCol < 0 || newCol > 14) return false; //outside bounds of board
            else if (newRow == mouseRow && newCol == mouseCol) return false; //same as current spot
            //else if ((string)spaces[newRow, newCol].Tag == "player") return false;
            else if ((string)spaces[newRow, newCol].Tag != null) return false;
            else return true;
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

        public bool spaceContainsTrash(int row, int col)
        {
            if ((string)spaces[row, col].Tag == SMALL_TRASH_TAG || (string)spaces[row, col].Tag == MEDIUM_TRASH_TAG || (string)spaces[row, col].Tag == LARGE_TRASH_TAG)
            {
                return true;
            }
            else return false;
        }

        public bool isTrashRemaining()
        {
            for(int row = 0; row < BOARDSIZE; ++row)
            {
                for(int col = 0; col < BOARDSIZE; ++col)
                {
                    if((string)spaces[row, col].Tag == SMALL_TRASH_TAG || (string)spaces[row, col].Tag == MEDIUM_TRASH_TAG || (string)spaces[row, col].Tag == LARGE_TRASH_TAG) return true;  
                }
            }
            return false;
        }
        public bool isMouseOnBoard()
        {
            for (int row = 0; row < BOARDSIZE; ++row)
            {
                for (int col = 0; col < BOARDSIZE; ++col)
                {
                    if ((string)spaces[row, col].Tag == "mouse") return true;
                }
            }
            return false;
        }
        public void determineWinner()
        {
            if(P1.score > P2.score)
            {
                p1icon.BackColor = Color.Gold;
                spaces[P1.row, P1.col].BackColor = Color.Gold;
                p2icon.BackColor = Color.LightGray;
                spaces[P2.row, P2.col].BackColor = Color.LightGray;
                MessageBox.Show("Player 1 wins!", "Winner");
            } else if(P2.score > P1.score)
            {
                p2icon.BackColor = Color.Gold;
                spaces[P2.row, P2.col].BackColor = Color.Gold;
                p1icon.BackColor = Color.LightGray;
                spaces[P1.row, P1.col].BackColor = Color.LightGray;
                MessageBox.Show("Player 2 wins!", "Winner");
            } else
            {
                p1icon.BackColor = Color.Gold;
                spaces[P1.row, P1.col].BackColor = Color.Gold;
                p2icon.BackColor = Color.Gold;
                spaces[P2.row, P2.col].BackColor = Color.Gold;
                MessageBox.Show("Tie!","Winner");
            }
            gameOver = true;
        }
        public int distBetweenSpaces(int row1, int col1, int row2, int col2)
        {
            if(row1 != row2 && col1 != col2) return (Math.Abs(row1 - row2) + Math.Abs(col1 - col2) - 1); // the -1 allows for some diagonal movement
            return (Math.Abs(row1 - row2) + Math.Abs(col1 - col2));
        }
        public bool areSpacesNeighbors(int row1, int col1, int row2, int col2)
        {
            return (Math.Abs(row1 - row2) < 2 && Math.Abs(col1 - col2) < 2);
        }
        public void determineNextMove() // AI's turn to move. Determine next move for current player.
        {
            if(currentTurn == 1)
            {
                switch(P1.type)
                {
                    case 2:
                        break;
                    case 3: // move to closest space with trash (aka Greedy)
                        int currRow = P1.row, currCol = P1.col, newRow = -1, newCol = -1, dist = 100;
                        for(int i = 0; i < BOARDSIZE; ++i)
                        {
                            for(int j = 0; j < BOARDSIZE; ++j)
                            {
                                if( spaceContainsTrash(i, j) && distBetweenSpaces(currRow, currCol, i, j) < dist)
                                {
                                    dist = distBetweenSpaces(currRow, currCol, i, j);
                                    newRow = i;
                                    newCol = j;
                                }                                
                            }                            
                        }
                        string msg = "Found nearest trash at row " + newRow.ToString() + ", col " + newCol.ToString();
                        //MessageBox.Show(msg, "Next Move");
                        if (areSpacesNeighbors(currRow, currCol, newRow, newCol)) verifyMove(newRow, newCol);
                        else
                        {
                            if (newRow < currRow)
                            {
                                if ((string)spaces[currRow - 1, currCol].Tag != "player") verifyMove(currRow - 1, currCol);
                                else if (currCol > 0) verifyMove(currRow - 1, currCol - 1);
                                else verifyMove(currRow - 1, currCol + 1);
                            }
                            else if (newRow > currRow)
                            {
                                if ((string)spaces[currRow + 1, currCol].Tag != "player") verifyMove(currRow + 1, currCol);
                                else if (currCol > 0) verifyMove(currRow + 1, currCol - 1);
                                else verifyMove(currRow + 1, currCol + 1);
                            }

                            else if (newCol < currCol)
                            {
                                if ((string)spaces[currRow, currCol - 1].Tag != "player") verifyMove(currRow, currCol - 1);
                                else if (currRow > 0) verifyMove(currRow - 1, currCol - 1);
                                else verifyMove(currRow + 1, currCol - 1);
                            }
                            else
                            {
                                if ((string)spaces[currRow, currCol + 1].Tag != "player") verifyMove(currRow, currCol + 1);
                                else if (currRow > 0) verifyMove(currRow - 1, currCol + 1);
                                else verifyMove(currRow + 1, currCol + 1);
                            }
                        }
                        break;
                    case 4: // prefer big trash first
                        int nextRow = -1, nextCol = -1;
                        BigTrashFirst(ref nextRow, ref nextCol);
                        verifyMove(nextRow, nextCol);
                        
                        break;
                    default:
                        break;
                }
            } else
            {
                switch (P2.type)
                {
                    case 2:
                        break;
                    case 3:
                        int currRow = P2.row, currCol = P2.col, newRow = -1, newCol = -1, dist = 100;
                        for (int i = 0; i < BOARDSIZE; ++i)
                        {
                            for (int j = 0; j < BOARDSIZE; ++j)
                            {
                                if (spaceContainsTrash(i, j) && distBetweenSpaces(currRow, currCol, i, j) < dist)
                                {
                                    dist = distBetweenSpaces(currRow, currCol, i, j);
                                    newRow = i;
                                    newCol = j;
                                }

                            }

                        }
                        string msg = "Found nearest trash at row " + newRow.ToString() + ", col " + newCol.ToString();
                        //MessageBox.Show(msg, "Next Move");
                        if (areSpacesNeighbors(currRow, currCol, newRow, newCol)) verifyMove(newRow, newCol);
                        else
                        {
                            if (newRow < currRow)
                            {
                                if ((string)spaces[currRow - 1, currCol].Tag != "player") verifyMove(currRow - 1, currCol);
                                else if (currCol > 0) verifyMove(currRow - 1, currCol - 1);
                                else verifyMove(currRow - 1, currCol + 1);
                            }
                            else if (newRow > currRow)
                            {
                                if ((string)spaces[currRow + 1, currCol].Tag != "player") verifyMove(currRow + 1, currCol);
                                else if (currCol > 0) verifyMove(currRow + 1, currCol - 1);
                                else verifyMove(currRow + 1, currCol + 1);
                            }

                            else if (newCol < currCol)
                            {
                                if ((string)spaces[currRow, currCol - 1].Tag != "player") verifyMove(currRow, currCol - 1);
                                else if (currRow > 0) verifyMove(currRow - 1, currCol - 1);
                                else verifyMove(currRow + 1, currCol - 1);
                            }
                            else
                            {
                                if ((string)spaces[currRow, currCol + 1].Tag != "player") verifyMove(currRow, currCol + 1);
                                else if (currRow > 0) verifyMove(currRow - 1, currCol + 1);
                                else verifyMove(currRow + 1, currCol + 1);
                            }
                        }
                        /*else
                        {
                            if (newRow < currRow) verifyMove(currRow - 1, currCol);
                            else if (newRow > currRow) verifyMove(currRow + 1, currCol);
                            else if (newCol < currCol) verifyMove(currRow, currCol - 1);
                            else verifyMove(currRow, currCol + 1);
                        }*/
                        break;
                    case 4: // prefer big trash first
                        int nextRow = -1, nextCol = -1;
                        BigTrashFirst(ref nextRow, ref nextCol);
                        verifyMove(nextRow, nextCol);
                        break;
                    default:
                        break;
                }
            }
        }
        
        public void verifyMove(int newRow, int newCol) {
            if (P1.row != -1 && P1.col != -1 && P2.row != -1 && P2.col != -1)
            {
                if (currentTurn == 1)
                {
                    if (P1.makeMove(newRow, newCol))
                    {
                        //rm current postion image, color, tag
                        P1.rmPos();

                        //updates P1 image and location
                        P1_PutImageLoc(newRow, newCol);

                        P1_updateLabels();


                         // SAVE HERE 
                        currentTurn = 2;
                        nextTurnIs_P1();
                    }
                }
                else
                {
                    if (P2.makeMove(newRow, newCol))
                    {
                        //rm current postion image, color, tag
                        P2.rmPos();

                        //updates P2 image and location
                        P2_PutImageLoc(newRow, newCol);

                        P2_updateLabels();


                        // SAVE HERE

                        currentTurn = 1;
                        nextTurnIs_P2();
                    }
                }
            }
        }

        public void button_Start_Click(object sender, EventArgs e)
        {
            //if (P1.row == -1 || P1.col == -1 || P2.row == -1 || P2.col == -1) { button_Reset_Click(sender, e); }
            button_Start.Enabled = false;
            clearBoard();
            P1_PutImageLoc();
            P2_PutImageLoc();
            currentTurn = 1;
            gameOver = mouseInGame = false;
            numTurns = 0;

            

            //P1.reset();
            //P2.reset();

            P1_updateLabels();
            P2_updateLabels();
            generateTrash();
            Refresh();
            game_started = true;
            if (currentTurn == 1)
            {
                nextTurnIs_P2();
            }
            else
            {
                nextTurnIs_P1();
            }
        }

        public void button_Reset_Click(object sender, EventArgs e)
        {
            clearBoard();
            gameOver = false;
            gameOver = mouseInGame = false;
            numTurns = 0;
            /*
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
            */
            P1.reset();
            P2.reset();
            game_started = false;

            P1_updateLabels();
            P2_updateLabels();
            p1icon.BackColor = Color.LightGray;
            p2icon.BackColor = Color.LightGray;

            E1_Closest.Enabled = E1_ShortestDist.Enabled = E1_User.Enabled = E1_BigTrashFirst.Enabled = true; // reset option buttons to be enabled
            E2_Closest.Enabled = E2_ShortestDist.Enabled = E2_User.Enabled = E2_BigTrashFirst.Enabled = true;
            button_Start.Enabled = false;
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
            if(!gameOver) verifyMove(row, col);
        }

 
    }
}