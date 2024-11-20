using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign6
{
    public partial class Assigment6 : Form
    {
        protected HockeyPlayer[] players;

        private int playerCount = 0;

        public Assigment6()
        {
            InitializeComponent();
            players = new HockeyPlayer[30];
        }

       
        public class HockeyPlayer
        {
            public string PlayerName { get; }
            public int JerseyNumber {  get; }
            public int GoalsScored {  get; set; }

            public HockeyPlayer(string playerName, int jerseyNumber, int goalsScored)
            {
                PlayerName = playerName;
                JerseyNumber = jerseyNumber;
                GoalsScored = goalsScored;
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            string playerName = nameBox.Text;
            int jerseyNumber;
            int goalsScored;
            if(!int.TryParse(jerseyNumberBox.Text,out jerseyNumber) || !int.TryParse(goalsScoredBox.Text, out goalsScored))
            {
                MessageBox.Show("Please enry valid numbers for Jersey Number or Goals Scored");
                return;
            }
            HockeyPlayer newPlayer = new HockeyPlayer(playerName, jerseyNumber, goalsScored);
            players[playerCount] = newPlayer;
            playerCount++;

            nameBox.Clear();
            goalsScoredBox.Clear();
            jerseyNumberBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayBox.Clear();

            foreach (var player in players)
            {
                if (player != null)
                {
                    displayBox.AppendText(String.Format("Name: {0,-15}   Jersey Number: {1,-5}   " +
                    "Goals Scored: {2}\n\n", player.PlayerName, player.JerseyNumber, player.GoalsScored));
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
