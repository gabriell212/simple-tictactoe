using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_LogicSphere
{
    public partial class frmPlayerPlayer : Form
    {
        // This list will stock the buttons assigned to the fields
        private List<Button> fields;

        // This will be used in checking whether the game has started or no
        private bool gameState = false; // True if the game started

        // These two variables will store the scores of both game's participants
        private ushort player1Score = 0;
        private ushort player2Score = 0;

        // This is used in checking whose turn it is
        private bool player1Turn = true; // True for X starting, False for O starting

        // This is used upon checking the win cases
        int[,] winCases = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 4, 8 }, { 2, 4, 6 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 } };

        // These are used in deciding the winner of a round
        private bool player1Win = false;//True if player 1 won
        private bool player2Win = false;//True if player 2 won

        // This is used for switching the symbol after a round ends
        private bool switchedPlayer = false;

        // This is used to check if the user is playing against another player or against the AI
        private bool vsPlayer = true;

        // This is used to switch between easy and hard AI
        private bool easyAI = true; // True if easy, False if hard

        // This is used to handle all hard AI's choice, because the first choice will always be the middle field
        private bool secondHardAIChoice = true;

        /*
         * The constructor which takes as a parameter a boolean value which decides if either the user is playing
         * against another player or against an AI.
         * Also, here I've created a list which stores all the buttons assigned to the fields.
         */
        public frmPlayerPlayer(bool vsPlayer)
        {
            InitializeComponent();

            // Enable Player vs Player mode
            this.vsPlayer = vsPlayer;
            if (vsPlayer)
            {
                btnEasyAI.Visible = false;
                btnHardAI.Visible = false;
            }
            btnEasyAI.Enabled = false;
            btnEasyAI.FlatAppearance.BorderSize = 3;

            // Store all the buttons for the table in a list
            fields = new List<Button>()
            {
                btnField1, btnField2, btnField3,
                btnField4, btnField5, btnField6,
                btnField7, btnField8, btnField9
            };

            // Add the "Click" event to all the buttons
            AddEventToButtons();
        }

        // Form's "Load" event. Prepares the game for the upcoming rounds.
        private void frmPlayerPlayer_Load(object sender, EventArgs e)
        {
            gameState = false;
            foreach (Button b in fields)
                b.Text = "";

            if (vsPlayer == false)
                lblPlayer2.Text = "AI";
        }

        // This function is called when clicking on the "Back" button. It will send the user back to the main menu.
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            var frmMain = new frmMainMenu();

            if (gameState == false)
                Program.SwitchMainForm(frmMain);
            else
            {
                DialogResult dr = MessageBox.Show("The game is running. Are you sure you want to return to the main menu?", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    Program.SwitchMainForm(frmMain);
            }
        }

        // This function is called when clicking on the "New game" button. It will start a new round.
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Restrict the player from starting a new round while one's ongoing
            if (gameState == false)
            {
                if (!IsBoardEmpty())
                {
                    ResetGame();
                    if (player1Turn == false && vsPlayer == false)
                    {
                        if (easyAI)
                            GetAIChoice();
                        else
                            fields[4].PerformClick();
                    }
                }
            }
            else
                MessageBox.Show("You cannot start a new game while you already are in a game!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // This function  is called when clicking on the "Reset scores" button. It will reset the scores, as the name says
        private void btnResetScores_Click(object sender, EventArgs e)
        {
            // Allow the operation only if the game is not ongoing
            if (gameState == false)
            {
                if (IsBoardEmpty())
                {
                    if (switchedPlayer)
                    {
                        SwitchPlayers();
                        lblTurn.Text = "Player 1's Turn";
                    }
                    lblPlayer1Score.Text = "0";
                    lblPlayer2Score.Text = "0";
                    player1Score = 0;
                    player2Score = 0;
                    MessageBox.Show("Action performed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Board has to be empty in order to reset scores", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("You cannot reset the scores while you are in game! Please finish the current game to perform this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // This function will switch the symbols at the end of the round
        private void SwitchPlayers()
        {
            switchedPlayer = !switchedPlayer;
            lblX.Text = switchedPlayer ? "O" : "X";
            lblO.Text = switchedPlayer ? "X" : "O";

            player1Turn = switchedPlayer ? false : true;
        }

        // This function will reset the game (the round, basically)
        private void ResetGame()
        {
            gameState = false;
            SwitchPlayers();
            foreach (Button b in fields)
            {
                b.Text = "";
                b.Enabled = true;
                b.BackColor = Color.FromArgb(168, 232, 249);
            }
            if (player1Turn)
                lblTurn.Text = "Player 1's Turn";
            else
                lblTurn.Text = "Player 2's Turn";
        }

        // This function will set the winner and add a point to his score
        private void SetWinnerScore()
        {
            foreach (Button b in fields)
                if (b.Enabled == true)
                    b.Enabled = false;

            gameState = false;
            if (player1Win == true)
            {
                player1Score++;
                lblPlayer1Score.Text = player1Score.ToString();
                lblTurn.Text = "Player 1 Won!";
                player1Win = false;
            }
            if (player2Win == true)
            {
                player2Score++;
                lblPlayer2Score.Text = player2Score.ToString();
                lblTurn.Text = "Player 2 Won!";
                player2Win = false;
            }
        }

        // This function handles the win cases
        private void CheckForWin()
        {
            int winIndex = -1;
            for (int i = 0; i < winCases.GetLength(0); i++)
            {
                bool gameWon = true;
                for (int j = 0; j < winCases.GetLength(1) - 1 && gameWon == true; j++)
                    if (fields[winCases[i, j]].Text != fields[winCases[i, j + 1]].Text)
                        gameWon = false;

                if (gameWon && fields[winCases[i, 0]].Text != "")
                {
                    winIndex = i;
                    string playerSymbol = switchedPlayer ? "O" : "X";
                    if (fields[winCases[i, 0]].Text == playerSymbol)
                        player1Win = true;
                    else
                        player2Win = true;
                }
            }

            // Handle the case where it's a tie
            if (player1Win == false && player2Win == false && !fields.Exists(IsEmpty))
            {
                lblTurn.Text = "It's a tie!";
                gameState = false;
                return;
            }

            // This will color the winning fields
            if (winIndex != -1)
                for (int j = 0; j < winCases.GetLength(1); j++)
                    fields[winCases[winIndex, j]].BackColor = Color.FromArgb(255, 186, 66);
            if (player1Win == true || player2Win == true)
                SetWinnerScore();
        }

        // This function checks if a button's text is empty and return a boolean value
        private bool IsEmpty(Button b)
        {
            return b.Text == "";
        }

        // This function checks if all the fields from the board are empty
        private bool IsBoardEmpty()
        {
            foreach (Button b in fields)
                if (b.Text != "")
                    return false;
            return true;
        }

        // This function adds the "click" event to the field buttons
        private void AddEventToButtons()
        {
            foreach (Button b in fields)
                b.Click += ButtonClick;
        }

        // This function will be executed when clicking on a field from the board
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            gameState = true;
            if (player1Turn == true)
            {
                button.Text = switchedPlayer ? "O" : "X";
                player1Turn = false;
                lblTurn.Text = vsPlayer ? "Player 2's Turn" : "AI's Turn";
            }
            else
            {
                button.Text = switchedPlayer ? "X" : "O";
                player1Turn = true;
                lblTurn.Text = "Player 1's Turn";
            }
            button.Enabled = false;
            CheckForWin();

            // AI's delay
            if (player1Turn == false && vsPlayer == false && gameState == true)
            {
                foreach (Button b in fields)
                    b.Enabled = false;
                tmrAITurn.Enabled = true;
            }
        }

        //Code below goes for AI

        // This function will get and manage the Easy AI's choice
        private void GetAIChoice()
        {
            List<int> emptyFieldsForAIChoice = new List<int>();
            for (int i = 0; i < fields.Count; i++)
                if (fields[i].Text == "")
                    emptyFieldsForAIChoice.Add(i);

            Random rnd = new Random();
            int chosenField = emptyFieldsForAIChoice[rnd.Next(emptyFieldsForAIChoice.Count)];

            fields[chosenField].PerformClick();
        }

        // This function will execute only when the timer started - it's just an delay for the AI
        private void tmrAITurn_Tick(object sender, EventArgs e)
        {
            foreach (Button b in fields)
                if (IsEmpty(b))
                    b.Enabled = true;

            if (easyAI)
                GetAIChoice();
            else
                GetHardAIChoice();
            tmrAITurn.Enabled = false;
        }

        // This function will get and manage  the Hard AI's choice (uses the min-max algorithm by the way)
        private void GetHardAIChoice()
        {
            string AISymbol = switchedPlayer ? "X" : "O";
            if(AISymbol=="X" && secondHardAIChoice==true)
            {
                GetAIChoice();
                secondHardAIChoice = false;
                return;
            }
            List<int> scoresList = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int maxScore = 0;
            for (int i = 0; i < winCases.GetLength(0); i++)
            {
                //score is 4 if AI wins
                //score is 3 if AI blocks player from winning
                //score is 2 if AI is playing aggressively(he wants to win no matter what)
                //score is 1 if AI is playing defensively(his aim is to always block the player)
                //score is 0 if there is nothing to do(winning or blocking)

                string caseContent = fields[winCases[i, 0]].Text + fields[winCases[i, 1]].Text + fields[winCases[i, 2]].Text;
                if (caseContent == "")
                    continue;
                if (caseContent == "XX" || caseContent == "OO")
                {
                    if (AISymbol == caseContent[0].ToString())
                    {
                        scoresList[i] = 4;
                        maxScore = 4;
                        break;
                    }
                    else
                        scoresList[i] = 3;
                }
                if (caseContent == "XO" || caseContent == "OX")
                    scoresList[i] = 1;
                if (caseContent == "X" || caseContent == "O")
                {
                    if (AISymbol == caseContent)//Agressive AI
                        scoresList[i] = AISymbol == "X" ? 2 : 1;
                    else
                        scoresList[i] = AISymbol == "X" ? 1 : 2;
                }
                if (scoresList[i] > maxScore)
                    maxScore = scoresList[i];
            }
            int j = 0;
            for (j = 0; j < scoresList.Count; j++)
                if (scoresList[j] == maxScore)
                    break;
            for (int i = 0; i < winCases.GetLength(1); i++)
                if (fields[winCases[j, i]].Text == "")
                {
                    fields[winCases[j, i]].PerformClick();
                    break;
                }
        }

        // This function will switch to the Easy AI mode
        private void btnEasyAI_Click(object sender, EventArgs e)
        {
            if (gameState == false)
            {
                easyAI = true;
                btnEasyAI.Enabled = false;
                btnEasyAI.FlatAppearance.BorderSize = 3;
                btnHardAI.FlatAppearance.BorderSize = 0;
                btnEasyAI.FlatAppearance.BorderColor = Color.White;
                btnHardAI.Enabled = true;
            }
        }

        // This function will switch to the Hard AI mode
        private void btnHardAI_Click(object sender, EventArgs e)
        {
            if (gameState == false)
            {
                easyAI = false;
                btnEasyAI.Enabled = true;
                btnEasyAI.FlatAppearance.BorderSize = 0;
                btnHardAI.FlatAppearance.BorderSize = 3;
                btnHardAI.FlatAppearance.BorderColor = Color.White;
                btnHardAI.Enabled = false;
            }
        }
    }
}
