using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using "PriorityQueuesProgram.cs";

namespace _438_IntelliBros
{
    public partial class GameBoard : Form
    {
        const int p1_start_row = 7;
        const int p1_start_col = 0;
        const int p2_start_row = 7;
        const int p2_start_col = 14;

        static int turnTime = 5;
        static int ticks = turnTime;
        static int numTurns = 0;
        static int trashRemaining = 0;
        static bool mouseInGame = false;
        static bool game_started = false;
        static bool currentTurnIsP1 = true;
        static bool gameOver = false;
        static string log = "";

        const int BOARDSIZE = 15; // The height/width of the board
        const int MAX_CAPACITY = 200;
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

        //Classes
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

            public int CompareTo(PossibleMove other)
            {
                if (this.priority < other.priority) return -1;
                else if (this.priority > other.priority) return 1;
                else return 0;
            }
        }

        class Entity
        {
            public int row, col;
            public Entity()
            {
                row = col = -1;
            }
            public Entity(int r, int c)
            {
                row = r; col = c;
            }

            public void MoveTo(int r, int c)
            {
                row = r; col = c;
            }

            public bool isValidMoveTo(int newRow, int newCol)
            {
                if ((newRow < 0) || (newRow > BOARDSIZE - 1) || (newCol < 0) || (newCol > BOARDSIZE - 1)
                   || (newRow == row && newCol == col) //same as current spot
                   || (string)spaces[newRow, newCol].Tag != null)
                    return false;
                else return true;
            }
        }

        class Mouse : Entity
        {
            public Mouse()
            {
                row = col = 1;
            }

            public void Move_Or_Generate()
            {
                Random rand_num = new Random(); //mouse generation/movement
                int rand = 0;
                rand = rand_num.Next(0, 5);

                if (!mouseInGame)
                {
                    if (rand == 0) // 20% chance of generating mouse
                    {
                        generateMouse();
                    }
                }
                else // there's a mouse in the game, need to move it and add trash where it was
                {
                    if (rand_num.Next(0, 2) == 0) // 50% chance of moving on this player's turn
                        moveMouse();
                }
            }

            private void generateMouse()
            {
                Random rand_num = new Random();
                int rand = 0;
                rand = rand_num.Next(0, 2);
                if (rand == 0) row = 0; //only generate mouse on top or bottom of board
                else row = 14;

                do
                {
                    col = rand_num.Next(0, BOARDSIZE);
                }
                while ((string)spaces[row, col].Tag != null);
                spaces[row, col].BackgroundImage = imageList1.Images[2];
                spaces[row, col].Tag = "mouse";
                mouseInGame = true;
            }

            private void moveMouse()
            {
                Random rand_num = new Random();
                int rand = 0, trashType = -1, newRow = -1, newCol = -1;
                rand = rand_num.Next(0, 6);
                if (rand == 0 || rand == 1 || rand == 2) trashType = 3; //small trash
                else if (rand == 3 || rand == 4) trashType = 4; //medium trash
                else trashType = 5; //large trash

                bool foundNewSpot = false;
                int iters = 0;
                while (!foundNewSpot && iters < 100)
                {
                    newRow = row + rand_num.Next(-1, 2);
                    newCol = col + rand_num.Next(-1, 2);
                    foundNewSpot = isValidMoveTo(newRow, newCol);
                    ++iters;
                }
                if (iters == 100) return; //mouse can't move, so just don't move this time.
                                          //have now found a new spot
                                          //if((string)spaces[mouseRow, mouseCol].Tag == )

                spaces[row, col].BackgroundImage = imageList1.Images[trashType];
                if (trashType == 3) spaces[row, col].Tag = SMALL_TRASH_TAG;
                else if (trashType == 4) spaces[row, col].Tag = MEDIUM_TRASH_TAG;
                else spaces[row, col].Tag = LARGE_TRASH_TAG;

                MoveTo(newRow, newCol);
                spaces[row, col].BackgroundImage = imageList1.Images[2]; //put mouse icon on new spot
                spaces[row, col].Tag = "mouse";
            }
        }

        class Player : Entity
        {
            public int score, capacity, type;

            public Player()
            {
                score = capacity = 0;
                type = -1; //default user before selecting the actual type
            }

            public Player(int r, int c)
            {
                row = r; col = c;
                score = capacity = 0;
                type = -1; //default user before selecting the actual type
            }

            public void reset()
            {
                score = capacity = 0;
                type = -1;
                spaces[row, col].BackColor = Color.LightGray;
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
                moveTo(newRow, newCol);
                spaces[row, col].Tag = "player";
            }

            public void decide()
            {
                switch (type)
                {
                    case 1:
                        int temp_r = row;
                        int temp_c = col;
                        //wait for the user to decide
                        while (temp_r == row && temp_c == col)
                        {
                            Thread.Sleep(1000);
                        }
                        break;
                    case 2:

                        break;
                    case 3:
                        greedy();
                        break;
                    case 4:
                        int nextRow = -1, nextCol = -1;
                        BigTrashFirst(ref nextRow, ref nextCol);
                        break;
                    default:
                        break;
                }
            }

            public void absorbPoints(int newRow, int newCol)
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
            }
            //private Player methods
            private void addSmall()
            {
                score += SMALL_TRASH_POINT_VAL;
                addCapacity_returns_PlayerHasMaxCap(1);
            }

            private void addMed()
            {
                score += MEDIUM_TRASH_POINT_VAL;
                addCapacity_returns_PlayerHasMaxCap(2);
            }

            private void addLarge()
            {
                score += LARGE_TRASH_POINT_VAL;
                addCapacity_returns_PlayerHasMaxCap(3);
            }
            private void addMouse()
            {
                score += MOUSE_POINT_VAL;
                addCapacity_returns_PlayerHasMaxCap(4);
            }

            private bool addCapacity_returns_PlayerHasMaxCap(int type) //small / med / large
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
                    return true;
                }
                else
                {
                    capacity += addingCap;
                    return false;
                }
            }

            private void greedy()
            {
                int currRow = row, currCol = col, newRow = -1, newCol = -1, dist = 100;
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
                if (areSpacesNeighbors(currRow, currCol, newRow, newCol)) isValidMoveTo(newRow, newCol);
                else
                {
                    if (newRow < currRow)
                    {
                        if ((string)spaces[currRow - 1, currCol].Tag != "player") isValidMoveTo(currRow - 1, currCol);
                        else if (currCol > 0) isValidMoveTo(currRow - 1, currCol - 1);
                        else isValidMoveTo(currRow - 1, currCol + 1);
                    }
                    else if (newRow > currRow)
                    {
                        if ((string)spaces[currRow + 1, currCol].Tag != "player") isValidMoveTo(currRow + 1, currCol);
                        else if (currCol > 0) isValidMoveTo(currRow + 1, currCol - 1);
                        else isValidMoveTo(currRow + 1, currCol + 1);
                    }

                    else if (newCol < currCol)
                    {
                        if ((string)spaces[currRow, currCol - 1].Tag != "player") isValidMoveTo(currRow, currCol - 1);
                        else if (currRow > 0) isValidMoveTo(currRow - 1, currCol - 1);
                        else isValidMoveTo(currRow + 1, currCol - 1);
                    }
                    else
                    {
                        if ((string)spaces[currRow, currCol + 1].Tag != "player") isValidMoveTo(currRow, currCol + 1);
                        else if (currRow > 0) isValidMoveTo(currRow - 1, currCol + 1);
                        else isValidMoveTo(currRow + 1, currCol + 1);
                    }
                }
            }

            public void BigTrashFirst(ref int nextRow, ref int nextCol) // determines where to move next; utilizes Priority Queue
            {
                PriorityQueue<PossibleMove> pq = new PriorityQueue<PossibleMove>();
                PossibleMove[] move = new PossibleMove[10];
                int i = 0;
                int otherPlayer_row;
                int otherPlayer_col;
                if (currentTurnIsP1) { otherPlayer_row = P2.row; otherPlayer_col = P2.col; }
                else { otherPlayer_row = P1.row; otherPlayer_col = P1.col; }
                {
                    for (int r = row - 1; r <= row + 1; ++r)
                    {
                        for (int c = col - 1; c <= col + 1; ++c) //only consider moving to a neighboring space
                        {
                            if (row == r && col == c || otherPlayer_row == r && otherPlayer_col == c) { }
                            else if (r < 0 || c < 0 || r >= BOARDSIZE || c >= BOARDSIZE) { } //out of bounds of board
                            else if ((string)spaces[r, c].Tag == LARGE_TRASH_TAG || (string)spaces[r, c].Tag == "mouse")
                            {
                                nextRow = r; nextCol = c; return;
                            }
                        }
                    }
                    for (int r = row - 1; r <= row + 1; ++r)
                    {
                        for (int c = col - 1; c <= col + 1; ++c) //only consider moving to a neighboring space
                        {
                            if (row == r && col == c || otherPlayer_row == r && otherPlayer_col == c) { }
                            else if (r < 0 || c < 0 || r >= BOARDSIZE || c >= BOARDSIZE) { } //out of bounds of board                       
                            else if ((string)spaces[r, c].Tag == MEDIUM_TRASH_TAG)
                            {
                                nextRow = r; nextCol = c; return;
                            }

                        }
                    }
                    for (int r = row - 1; r <= row + 1; ++r)
                    {
                        for (int c = col - 1; c <= col + 1; ++c) //only consider moving to a neighboring space
                        {
                            if (row == r && col == c || otherPlayer_row == r && otherPlayer_col == c) { }
                            else if (r < 0 || c < 0 || r >= BOARDSIZE || c >= BOARDSIZE) { } //out of bounds of board                       
                            else if ((string)spaces[r, c].Tag == SMALL_TRASH_TAG)
                            {
                                nextRow = r; nextCol = c; return;
                            }

                        }
                    }
                    for (int r = row - 1; r <= row + 1; ++r)
                    {
                        for (int c = col - 1; c <= col + 1; ++c) //only consider moving to a neighboring space
                        {
                            if (row == r && col == c || otherPlayer_row == r && otherPlayer_col == c) { }
                            else if (r < 0 || c < 0 || r >= BOARDSIZE || c >= BOARDSIZE) { } //out of bounds of board                       
                            else
                            {
                                move[i] = new PossibleMove(r, c, BTF_heuristic(r, c));
                                //move[i].priority = BTF_heuristic(r, c);
                                //move[i].nextRow = r; move[i].nextColumn = c;
                                pq.Enqueue(move[i]);
                                ++i;
                            }

                        }
                    }
                }
                PossibleMove move2 = pq.Dequeue();
                string msg = "moving to row " + move2.nextRow + ", col " + move2.nextColumn;
                //MessageBox.Show(msg, "move");
                nextRow = move2.nextRow; nextCol = move2.nextColumn;
            }
        }
        //Classes

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

        public void next_P1_Set_Colors()
        {
            p1icon.BackColor = Color.LightGray;
            spaces[P1.row, P1.col].BackColor = Color.LightGray;

            p2icon.BackColor = Color.Green;
            spaces[P2.row, P2.col].BackColor = Color.Green;
            Refresh();
        }

        public void next_P2_Set_Colors()
        {
            p2icon.BackColor = Color.LightGray;
            spaces[P2.row, P2.col].BackColor = Color.LightGray;

            p1icon.BackColor = Color.Green;
            spaces[P1.row, P1.col].BackColor = Color.Green;
            Refresh();
        }
        //player helpers

        static Button[,] spaces = new Button[BOARDSIZE, BOARDSIZE];
        //Player
        static Player P1 = new Player();
        static Player P2 = new Player();
        static Mouse Mouse1 = new Mouse();

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

        //buttons
        public void button_Start_Click(object sender, EventArgs e)
        {
            button_IncTimer.Enabled = false;
            button_DecTimer.Enabled = false;
            button_Start.Enabled = false;
            clearBoard();
            P1_PutImageLoc();
            P2_PutImageLoc();
            gameOver = mouseInGame = false;
            currentTurnIsP1 = true;
            numTurns = 0;

            P1_updateLabels();
            P2_updateLabels();
            generateTrash();
            Refresh();
            game_started = true;
            while (!gameOver || trashRemaining != 0)
            {
                P1.decide();
                P2.decide();
                Mouse1.Move_Or_Generate();
            }
            determineWinner();
        }

        public void button_Reset_Click(object sender, EventArgs e)
        {
            clearBoard();
            gameOver = false;
            gameOver = mouseInGame = game_started = false;
            numTurns = 0;

            P1.reset();
            P2.reset();
            P1_updateLabels();
            P2_updateLabels();

            E1_Closest.Enabled = E1_ShortestDist.Enabled = E1_User.Enabled = E1_BigTrashFirst.Enabled = true; // reset option buttons to be enabled
            E2_Closest.Enabled = E2_ShortestDist.Enabled = E2_User.Enabled = E2_BigTrashFirst.Enabled = true;
            button_Start.Enabled = false;
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //find the button based on its location
            //row = 731 + (col * BUTTON_SIZE)
            //col = 29 + (row * BUTTON_SIZE)

            int newX = b.Location.X;
            int newY = b.Location.Y;

            int row = (newY - 29) / BUTTON_SIZE;
            int col = (newX - 731) / BUTTON_SIZE;
            if (!gameOver)
            {
                if (currentTurnIsP1) { P1.isValidMoveTo(row, col); }
                else { P2.isValidMoveTo(row, col); }
            }
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
            if (P2.type != -1 && !game_started) button_Start.Enabled = true;
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

        private void button_IncTimer_Click(object sender, EventArgs e)
        {
            ++ticks;
            label_Timer.Text = ticks.ToString();
        }

        private void button_DecTimer_Click(object sender, EventArgs e)
        {
            if (ticks > 0) { --ticks; }
            label_Timer.Text = ticks.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks == 0) { currentTurnIsP1 = !currentTurnIsP1; }
            else
            {
                --ticks;
                label_Timer.Text = ticks.ToString();
            }
        }
        //buttons

        static public int distBetweenSpaces(int row1, int col1, int row2, int col2)
        {
            if (row1 != row2 && col1 != col2) return (Math.Abs(row1 - row2) + Math.Abs(col1 - col2) - 1); // the -1 allows for some diagonal movement
            return (Math.Abs(row1 - row2) + Math.Abs(col1 - col2));
        }
        static public bool areSpacesNeighbors(int row1, int col1, int row2, int col2)
        {
            return (Math.Abs(row1 - row2) < 2 && Math.Abs(col1 - col2) < 2);
        }

        public void determineWinner()
        {
            if (P1.score > P2.score)
            {
                p1icon.BackColor = Color.Gold;
                spaces[P1.row, P1.col].BackColor = Color.Gold;
                p2icon.BackColor = Color.LightGray;
                spaces[P2.row, P2.col].BackColor = Color.LightGray;
                MessageBox.Show("Player 1 wins!", "Winner");
            }
            else if (P2.score > P1.score)
            {
                p2icon.BackColor = Color.Gold;
                spaces[P2.row, P2.col].BackColor = Color.Gold;
                p1icon.BackColor = Color.LightGray;
                spaces[P1.row, P1.col].BackColor = Color.LightGray;
                MessageBox.Show("Player 2 wins!", "Winner");
            }
            else
            {
                p1icon.BackColor = Color.Gold;
                spaces[P1.row, P1.col].BackColor = Color.Gold;
                p2icon.BackColor = Color.Gold;
                spaces[P2.row, P2.col].BackColor = Color.Gold;
                MessageBox.Show("Tie!", "Winner");
            }
            //output log
            File.WriteAllText(@"./end.log", log);

            gameOver = true;
        }

        static public void clearBoard() //removes images, colors, tags
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

        static public bool spaceContainsTrash(int row, int col)
        {
            if ((string)spaces[row, col].Tag == SMALL_TRASH_TAG || (string)spaces[row, col].Tag == MEDIUM_TRASH_TAG || (string)spaces[row, col].Tag == LARGE_TRASH_TAG)
            {
                return true;
            }
            else return false;
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
                            ++trashRemaining;
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
        static public double BTF_heuristic(int nextRow, int nextCol)
        {
            double lt_coef = 0.3, mt_coef = 0.6, st_coef = 0.9;
            double h_val = 0.0;
            double distToNearestLT = 100, distToNearestMT = 100, distToNearestST = 100;
            //double constant = 2.0;
            //if(nextRow < 0 || nextCol < 0 || nextRow >= BOARDSIZE || nextCol >= BOARDSIZE) { } //out of bounds of board

            //find distance between given space and nearest large, medium, and small trashes
            for (int i = 0; i < BOARDSIZE; i++)
            {
                for (int j = 0; j < BOARDSIZE; j++)
                {
                    if ((string)spaces[i, j].Tag == LARGE_TRASH_TAG && distBetweenSpaces(nextRow, nextCol, i, j) < distToNearestLT)
                    {
                        distToNearestLT = distBetweenSpaces(nextRow, nextCol, i, j);
                    }
                    if ((string)spaces[i, j].Tag == MEDIUM_TRASH_TAG && distBetweenSpaces(nextRow, nextCol, i, j) < distToNearestMT)
                    {
                        distToNearestMT = distBetweenSpaces(nextRow, nextCol, i, j);
                    }
                    if ((string)spaces[i, j].Tag == SMALL_TRASH_TAG && distBetweenSpaces(nextRow, nextCol, i, j) < distToNearestST)
                    {
                        distToNearestST = distBetweenSpaces(nextRow, nextCol, i, j);
                    }

                }
            }
            distToNearestLT *= lt_coef;
            distToNearestMT *= mt_coef;
            distToNearestST *= st_coef;
            if (distToNearestLT <= distToNearestMT && distToNearestLT <= distToNearestST) return distToNearestLT;
            else if (distToNearestMT <= distToNearestLT && distToNearestMT <= distToNearestST) return distToNearestMT;
            else return distToNearestST;

        }

        static public string stateString()
        {
            string tmp = "Turn: " + numTurns + "\n";
            tmp += "Player 1 Score: " + P1.score + "\n";
            tmp += "Player 1 Capacity: " + P1.capacity + "\n";
            tmp += "Player 2 Score: " + P2.score + "\n";
            tmp += "Player 2 Capacity: " + P2.capacity + "\n";
            tmp += "Board:\n";
            for (int i = 0; i < BOARDSIZE; i++)
            {
                for (int j = 0; j < BOARDSIZE; j++)
                {
                    if ((string)spaces[i, j].Tag == "player")
                    {
                        if (P1.row == i && P1.col == j)
                        {
                            tmp += "A ";
                        }
                        else
                        {
                            tmp += "B ";
                        }
                    }
                    else if ((string)spaces[i, j].Tag == "mouse")
                    {
                        tmp += "M ";
                    }
                    else if ((string)spaces[i, j].Tag == SMALL_TRASH_TAG)
                    {
                        tmp += "1 ";
                    }
                    else if ((string)spaces[i, j].Tag == MEDIUM_TRASH_TAG)
                    {
                        tmp += "2 ";
                    }
                    else if ((string)spaces[i, j].Tag == LARGE_TRASH_TAG)
                    {
                        tmp += "3 ";
                    }
                    else
                    {
                        tmp += "_ ";
                    }
                }
                tmp += "\n";
            }
            tmp += "\n";

            return tmp;
        }

    }
}