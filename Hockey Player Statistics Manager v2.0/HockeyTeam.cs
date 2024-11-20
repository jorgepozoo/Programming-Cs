using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign7
{
    public partial class Assigment7 : Form
    {        
        protected HockeyPlayer[] players;

        private int playerCount = 0;

        public Assigment7()
        {
            InitializeComponent();
            players = new HockeyPlayer[30];
                      
        }


        public class HockeyPlayer : IComparable<HockeyPlayer>

        {
            public string PlayerName { get; }
            public int JerseyNumber { get; }
            public int GoalsScored { get; set; }

            public HockeyPlayer(string playerName, int jerseyNumber, int goalsScored)
            {
                PlayerName = playerName;
                JerseyNumber = jerseyNumber;
                GoalsScored = goalsScored;
            }
            public override string ToString()
            {
                return String.Format("{0,-65} {1,-10} {2}\n\n", PlayerName, JerseyNumber, GoalsScored);
            }
            public int CompareTo(HockeyPlayer temp)
            {

                if (temp == null)
                {
                    return 1;
                }
                return PlayerName.CompareTo(temp.PlayerName);
            }
            public class CompareByJerseyNumber : IComparer<HockeyPlayer>
            {
                public int Compare(HockeyPlayer x, HockeyPlayer y)
                {
                    if (x == null && y == null)
                    {
                        return 0; 
                    }
                    else if (x == null)
                    {
                        return -1;                     }
                    else if (y == null)
                    {
                        return 1; 
                    }

                    
                    return x.JerseyNumber.CompareTo(y.JerseyNumber);
                }
            }
            public class CompareByGoals : IComparer<HockeyPlayer>
            {
                public int Compare(HockeyPlayer x, HockeyPlayer y)
                {
                    if (x == null && y == null)
                    {
                        return 0;
                    }
                    else if (x == null)
                    {
                        return -1; 
                    }
                    else if (y == null)
                    {
                        return 1; 
                    }
                    
                    return x.GoalsScored.CompareTo(y.GoalsScored);
                }
            }
            public static string GetPlayersAsString(IEnumerable<HockeyPlayer> players)
            {
                if (players == null)
                {
                    return ""; // Otra lógica que desees aplicar si la colección es null
                }

                string result = "";
                foreach (var player in players)
                {
                    if (player != null)
                    {
                        result += player.ToString();
                    }
                }
                return result;
            }
        }
        private void clearFields()
        {
            nameBox.Clear();
            jerseyNumberBox.Clear();
            goalsScoredBox.Clear();
        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            string playerName = nameBox.Text;
            int jerseyNumber;
            int goalsScored;
            if (!int.TryParse(jerseyNumberBox.Text, out jerseyNumber) || !int.TryParse(goalsScoredBox.Text, out goalsScored))
            {
                MessageBox.Show("Please enter valid numbers for Jersey Number or Goals Scored");
                return;
            }
            if (playerCount < players.Length)
            {
                HockeyPlayer newPlayer = new HockeyPlayer(playerName, jerseyNumber, goalsScored);
                players[playerCount] = newPlayer;
                playerCount++;
                displayListBox.Items.Add(newPlayer);
                clearFields();
            }
            else
            {
                MessageBox.Show("Maximum number of players reached.");
            }


        }        
        private void displayListBox_DoubleClick(object sender, EventArgs e)
        {
            if (displayListBox.SelectedItem != null)
            {
                HockeyPlayer selectedPlayer = (HockeyPlayer)displayListBox.SelectedItem;
                nameBox.Text = selectedPlayer.PlayerName;
                jerseyNumberBox.Text = selectedPlayer.JerseyNumber.ToString();
                goalsScoredBox.Text = selectedPlayer.GoalsScored.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (displayListBox.SelectedItem != null)
            {
                string playerName = nameBox.Text;
                int jerseyNumber, goalsScored;

                if (!int.TryParse(jerseyNumberBox.Text, out jerseyNumber) || !int.TryParse(goalsScoredBox.Text, out goalsScored))
                {
                    MessageBox.Show("Please enter valid numbers for Jersey Number or Goals Scored");
                    return;
                }

                HockeyPlayer updatedPlayer = new HockeyPlayer(playerName, jerseyNumber, goalsScored);
                int selectedIndex = displayListBox.SelectedIndex;
                
                displayListBox.Items.RemoveAt(selectedIndex);
                displayListBox.Items.Insert(selectedIndex, updatedPlayer);
                
                clearFields();
            }
        }
        private void sortButton_Click(object sender, EventArgs e)
        {

            if (nameRadioButton.Checked)
            {
                Array.Sort(players);
            }
            else if (numberRadioButton.Checked)
            {
                Array.Sort(players, new HockeyPlayer.CompareByJerseyNumber());
            }
            else if (goalsRadioButton.Checked)
            {
                Array.Sort(players, new HockeyPlayer.CompareByGoals());
            }

            if (reverseCheckBox.Checked)
            {
                Array.Reverse(players);
            }

            displayListBox.Items.Clear();

            foreach (var player in players)
            {
                if (player != null)
                {
                    displayListBox.Items.Add(player);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        displayListBox.Items.Add(line);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
                    {
                        foreach (var item in displayListBox.Items)
                        {
                            file.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("File saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the file: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }
    }
}
