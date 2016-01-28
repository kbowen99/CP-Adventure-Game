using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    public partial class frm_AdventureGame : Form
    {
        //variables
        bool sword = false;
        bool pineapple = false;
        bool bow = false;
        public frm_AdventureGame()
        {
            InitializeComponent();
            //local init
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //make buttons invisible at start
            btn_topLeft.Visible = false;
            btn_topRight.Visible = false;
            btn_bottomLeft.Visible = false;
            btn_BottomRight.Visible = false;
            lbl_Pineapple.Visible = false;
            lbl_bow.Visible = false;
            lbl_sword.Visible = false;
            lbl_inventory.Visible = false;
        }

        private void btn_bigButton_Click(object sender, EventArgs e)
        {
            if (btn_bigButton.Text == "Start Adventure")
            {
                //one time use button, sets up buttons & makes visible
                MessageBox.Show("You have awaken within a mystical forest, which path do you wish to choose?", "Your Adventure");
                pic_Game.Image = Properties.Resources.SceneSelector;
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;


            }
            else if (btn_bigButton.Text == "Use Combo Attack")
            {
                //Combo attack code
                MessageBox.Show("You have epically defeated the boss");
                pic_Game.Image = Properties.Resources.Win;
                btn_topLeft.Text = "Quit";
                btn_topRight.Text = "Play Again";
                btn_bottomLeft.Text = " ";
                btn_BottomRight.Text = " ";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
                btn_bigButton.Visible = false;

            }
            else
            {
                //safety net, in case something breaks
                MessageBox.Show("Looks like you broke something....");
                MessageBox.Show("The program will now Regenerate");
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }

        }

        private void btn_topLeft_Click(object sender, EventArgs e)
        {
            if (btn_topLeft.Text == "North" && pineapple == false)
            {
                //Pineapple button menu
                MessageBox.Show("A pineapple appears in front of you! What do you do?");
                btn_topLeft.Text = "Cower in Fear";
                btn_topRight.Text = "Take the Pineapple";
                btn_bottomLeft.Text = "Kill the Pineapple";
                btn_BottomRight.Text = " ";
                btn_BottomRight.Visible = false;
                pic_Game.Image = Properties.Resources.CanadianNorthPineapples;
            }else if (btn_topLeft.Text == "Cower in Fear")
            {
                //cawer in fear main menu code
                pic_Game.Image = Properties.Resources.SceneSelector;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                MessageBox.Show("You run away in fear back to where you started");
            }
            else if (btn_topLeft.Text == "North" && pineapple == true)
            {
                //prevents multiple pineapples
                MessageBox.Show("You have already gone North.");
            }
            else if (btn_topLeft.Text == "Take the bow and arrows")
            {
                //updates inv, main menu
                pic_Game.Image = Properties.Resources.SceneSelector;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_topRight.Visible = true;
                btn_bottomLeft.Text = "East";
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Text = "West";
                btn_BottomRight.Visible = true;
                lbl_bow.Visible = true;
                bow = true;

            }
            else if (btn_topLeft.Text == "Eat the gelatin")
            {
                //Sword, main menu
                MessageBox.Show("You eat your way to the middle of the gelatin, and find a sword!");
                lbl_sword.Visible = true;
                pic_Game.Image = Properties.Resources.SceneSelector;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Text = "West";
                btn_BottomRight.Visible = true;
                sword = true;
            }
            else if (btn_topLeft.Text == "Use Bow")
            {
                //attack using bow (boss), Win Menu
                MessageBox.Show("You have barely defeated the boss");
                pic_Game.Image = Properties.Resources.Win;
                btn_topLeft.Text = "Quit";
                btn_topRight.Text = "Play Again";
                btn_bottomLeft.Text = " ";
                btn_BottomRight.Text = " ";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
            }
            else if (btn_topLeft.Text == "Quit")
            {
                //Quit Code
                this.Close();
            }
            else
            {
                //safety net
                MessageBox.Show("Looks like you broke something....");
                MessageBox.Show("The program will now Regenerate");
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }
        }

        private void btn_topRight_Click(object sender, EventArgs e)
        {
            if (btn_topRight.Text == "Take the Pineapple" && pineapple == false)
            {
                //Update pineapple inv, main menu
                lbl_Pineapple.Visible = true;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Visible = true;
                btn_BottomRight.Text = "West";
                pic_Game.Image = Properties.Resources.SceneSelector;
                pineapple = true;
            }
            else if (btn_topRight.Text == "Take the Pineapple" && pineapple == true)
            {
                //prevent pineapple duplication
                MessageBox.Show("You already stole it");
            }
            else if (btn_topRight.Text == "Cower in fear")
            {
                //standard runaway, main menu
                pic_Game.Image = Properties.Resources.SceneSelector;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
            }
            else if (btn_topRight.Text == "South")
            {
                //Boss Menu
                pic_Game.Image = Properties.Resources.Boss;
                MessageBox.Show("You have encountered the boss, what will you do now?");
                btn_topLeft.Text = "Cower in Fear";
                btn_topRight.Text = "Fight the Boss";
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
                btn_bottomLeft.Text = "";
                btn_BottomRight.Text = "";

            }
            else if (btn_topRight.Text == "Fight the Boss")
            {
                //Boss Attack Menu
                //all buttons set
                btn_bigButton.Text = "Use Combo Attack";
                btn_topLeft.Text = "Use Bow";
                btn_topRight.Text = "Use Sword";
                btn_topLeft.Visible = false;
                btn_topRight.Visible = false;
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
                btn_bigButton.Visible = false;
                //buttons only usable if in inventory (Variables)
                if (sword == true)
                {
                    btn_topRight.Visible = true;
                }
                if (bow == true)
                {
                    btn_topLeft.Visible = true;
                }
                if (bow == true && sword == true)
                {
                    btn_bigButton.Visible = true;
                }
                if (bow == false && sword == false)
                {
                    //in case someone (shea) tries to kill boss with pineapple
                    //Imcompetency == Inadequacy
                    MessageBox.Show("You are incompetently prepared to fight");
                    lbl_inventory.Visible = true;
                    btn_bigButton.Visible = false;
                    btn_bigButton.Text = "";
                    btn_topLeft.Text = "North";
                    btn_topRight.Text = "South";
                    btn_bottomLeft.Text = "East";
                    btn_BottomRight.Text = "West";
                    btn_topLeft.Visible = true;
                    btn_topRight.Visible = true;
                    btn_bottomLeft.Visible = true;
                    btn_BottomRight.Visible = true;
                    pic_Game.Image = Properties.Resources.SceneSelector;
                }
            }
            else if (btn_topRight.Text == "Use Sword")
            {
                //attack using sword
                MessageBox.Show("You have barely defeated the boss");
                pic_Game.Image = Properties.Resources.Win;
                btn_topLeft.Text = "Quit";
                btn_topRight.Text = "Play Again";
                btn_bottomLeft.Text = " ";
                btn_BottomRight.Text = " ";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
            }
            else if (btn_topRight.Text == "Play Again")
            {
                //regenerates main menu, sets all variables false, hides inv
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;

            }
            else
            {
                //safety net
                MessageBox.Show("Looks like you broke something....");
                MessageBox.Show("The program will now Regenerate");
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }

        }

        private void btn_bottomLeft_Click(object sender, EventArgs e)
        {
            if (btn_bottomLeft.Text == "Kill the Pineapple" && sword == true)
            {
                //kill pineapple with sword, main menu
                //"The Pineapple" is capitalised because it is a proper noun (the enemy)
                MessageBox.Show("You killed The Pineapple with your sword, surely nothing can stop you now");
                lbl_Pineapple.Text = "Pineapple Chunks";
                lbl_Pineapple.Visible = true;
                pineapple = true;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }
            else if (btn_bottomLeft.Text == "Kill the Pineapple" && bow == true)
            {
                //kill Pineapple with bow, main menu
                MessageBox.Show("You killed The Pineapple with your bow and arrows, surely nothing can stop you now.", "Pineapples");
                lbl_Pineapple.Text = "Holy Pineapple";
                lbl_Pineapple.Visible = true;
                pineapple = true;
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }
            else if (btn_bottomLeft.Text == "Kill the Pineapple")
            {
                //kill fail (no weapon), main menu
                MessageBox.Show("You hit the pineapple with your bare hand, the pineapple is stronger");
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                pic_Game.Image = Properties.Resources.SceneSelector;

            }
            else if (btn_bottomLeft.Text == "East" && bow == false)
            {
                //get bow from creepy guy menu
                pic_Game.Image = Properties.Resources.constitutionalEastCreepyGuy;
                MessageBox.Show("There is a creepy old guy in a van at the end of the path. He offers you a bow and some arrows.");
                btn_topLeft.Text = "Take the bow and arrows";
                btn_bottomLeft.Visible = false;
                btn_topRight.Visible = false;
                btn_BottomRight.Visible = false;
            }
            else if (btn_bottomLeft.Text == "East" && bow == true)
            {
                //prevent duplication
                MessageBox.Show("The creepy old guy has left to somebody else's adventure game");
            }
            else
            {
                //safety net
                MessageBox.Show("Looks like you broke something....");
                MessageBox.Show("The program will now Regenerate");
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }
        }

        private void btn_BottomRight_Click(object sender, EventArgs e)
        {
            if (btn_BottomRight.Text == "West" && sword == false)
            {
                //sword get menu
                MessageBox.Show("You walk down the path to find a large brick of gelatin.");
                pic_Game.Image = Properties.Resources.WildWestGelatin;
                btn_topLeft.Text = "Eat the gelatin";
                btn_topRight.Text = "Cower in fear";
                btn_bottomLeft.Visible = false;
                btn_BottomRight.Visible = false;
            }
            else if (btn_BottomRight.Text == "West" && sword == true)
            {
                //prevents multiple swords
                MessageBox.Show("You have already eaten your share of gelatin");
            }
            else
            {
                //safety net
                MessageBox.Show("Looks like you broke something....");
                MessageBox.Show("The program will now Regenerate");
                lbl_inventory.Visible = true;
                btn_bigButton.Visible = false;
                btn_bigButton.Text = "";
                btn_topLeft.Text = "North";
                btn_topRight.Text = "South";
                btn_bottomLeft.Text = "East";
                btn_BottomRight.Text = "West";
                btn_topLeft.Visible = true;
                btn_topRight.Visible = true;
                btn_bottomLeft.Visible = true;
                btn_BottomRight.Visible = true;
                lbl_Pineapple.Visible = false;
                lbl_bow.Visible = false;
                lbl_sword.Visible = false;
                pineapple = false;
                bow = false;
                sword = false;
                pic_Game.Image = Properties.Resources.SceneSelector;
            }
        }
    }
}
//Written By Kurtis Bowen & Matt Pitstick
//Beta Tested by Shea & Kyle
//Inspired By Mr. Miller
//Licensed and released by GPL V3
//Made Possible By Microsoft Visual Studio
//An extension of Microsoft Windows