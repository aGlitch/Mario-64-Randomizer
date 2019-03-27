using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Mario64Randomizer
{
    public partial class Main : Form
    {
        Random s = new Random();
        int seed = 0;
        List<string> first = new List<string>()
        {
            "BOB1: Big Bob-omb on the Summit", "BOB2: Footrace with Koopa the Quick", "BOB3: Shoot to the Island in the Sky", "BOB4: Find the 8 Red Coins", "BOB5: Mario Wings to the Sky", "BOB6: Behind Chain Chomp's Gate", "BOB: 100 Coin Star",
            "WF1: Chip Off Whomp's Block", "WF2: To the Top of the Fortress", "WF3: Shoot into the Wild Blue", "WF4: Red Coins on the Floating Isle", "WF5: Fall onto the Caged Island", "WF6: Blast Away the Wall", "WF: 100 Coin Star",
            "JRB1: Plunder in the Sunken Ship", "JRB2: Can the Eel Come Out to Play?", "JRB3: Treasure of the Ocean Cave", "JRB4: Red Coins on the Ship Afloat", "JRB5: Blast to the Stone Pillar", "JRB6: Through the Jet Stream", "JRB: 100 Coin Star",
            "CCM1: Slip Slidin' Away", "CCM2: Li'l Penguin Lost", "CCM3: Big Penguin Race", "CCM4: Frosty Slide for 8 Red Coins", "CCM5: Snowman's Lost His Head", "CCM6: Wall Kicks Will Work", "CCM: 100 Coin Star",
            "BBH1: Go on a Ghost Hunt", "BBH2: Ride Big Boo's Merry-Go-Round", "BBH3: Secret of the Haunted Books", "BBH4: Seek the 8 Red Coins", "BBH5: Big Boo's Balcony", "BBH6: Eye to Eye in the Secret Room", "BBH: 100 Coin Star"
        };
        List<string> downstairs = new List<string>()
        {
            "HMC1: Swimming Beast in the Cavern", "HMC2: Elevate for 8 Red Coins", "HMC3: Metal-Head Mario Can Move!", "HMC4: Navigating the Toxic Maze", "HMC5: A-Maze-Ing Emergency Exit", "HMC6: Watch for Rolling Rocks","HMC: 100 Coin Star",
            "SSL1: In the Talons of the Big Bird", "SSL2: Shining Atop the Pyramid", "SSL3: Inside the Ancient Pyramid", "SSL4: Stand Tall on the Four Pillars", "SSL5: Free Flying for 8 Red Coins", "SSL6: Pyramid Puzzle", "SSL: 100 Coin Star",
            "LLL1: Boil the Big Bully", "LLL2: Bully the Bullies", "LLL3: 8-Coin Puzzle with 15 Pieces", "LLL4: Red-Hot Log Rolling", "LLL5: Hot-Foot-It into the Volcano", "LLL6: Elevator Tour in the Volcano", "LLL: 100 Coin Star",
            "DDD1: Board Bowser's Sub", "DDD2: Chests in the Current", "DDD3: Pole-Jumping for Red Coins", "DDD4: Through the Jet Stream", "DDD5: The Manta Ray's Reward", "DDD6: Collect the Caps...", "DDD: 100 Coin Star"
        };
        List<string> upstairs = new List<string>()
        {
            "SL1: Snowman's Big Head", "SL2: Chill with the Bully", "SL3: In the Deep Freeze", "SL4: Whirl from the Freezing Pond", "SL5: Shell Shreddin' for Red Coins", "SL6: Into the Igloo", "SL: 100 Coin Star",
            "WDW1: Shocking Arrow Lifts!", "WDW2: Top o' the Town", "WDW3: Secrets in the Shallows & Sky", "WDW4: Express Elevator--Hurry Up!", "WDW5: Go to Town for Red Coins", "WDW6: Quick Race Through Downtown!", "WDW: 100 Coin Star",
            "TTM1: Scale the Mountain", "TTM2: Mystery of the Monkey Cage", "TTM3: Scary 'Shrooms, Red Coins", "TTM4: Mysterious Mountainside", "TTM5: Breathtaking View from Bridge", "TTM6: Blast to the Lonely Mushroom", "TTM: 100 Coin Star",
            "THI1: Pluck the Piranha Flower", "THI2: The Tip Top of the Huge Island", "THI3: Rematch with Koopa the Quick", "THI4: Five Itty Bitty Secrets", "THI5: Wiggler's Red Coins", "THI6: Make Wiggler Squirm", "THI: 100 Coin Star"
        };
        List<string> top = new List<string>()
        {
            "TTC1: Roll into the Cage", "TTC2: The Pit and the Pendulums", "TTC3: Get a Hand", "TTC4: Stomp on the Thwomp", "TTC5: Timed Jumps on Moving Bars", "TTC6: Stop Time for Red Coins", "TTC: 100 Coin Star",
            "RR1: Cruiser Crossing the Rainbow", "RR2: The Big House in the Sky", "RR3: Coins Amassed in a Maze", "RR4: Swingin' in the Breeze", "RR5: Tricky Triangles!", "RR6: Somewhere Over the Rainbow", "RR: 100 Coin Star"
        };
        List<string> bowserStars = new List<string>() { "Bowser in the Dark World", "Bowser in the Fire Sea", "Bowser in the Sky" };
        List<string> secretStars = new List<string>() { "The Secret Aquarium", "Princess's Secret Slide: ! Box", "Princess's Secret Slide: Timed Race", "Wing Cap", "Vanish Cap", "Metal Cap", "Over the Rainbows" };

        List<string> toads = new List<string>() { "Downstairs Toad", "Upstairs Toad", "Top Toad"};
        List<string> mips = new List<string>() { "Mips", "Mips" };

        List<string> randomList = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                seed = s.Next(0, 160000);
                nudSeed.Value = seed;

                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Star Amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Shuffle<T>(IList<T> list, int seed)
        {
            var rng = new Random(seed);
            int n = list.Count;

            for (int i = n; i > 1; i--)
            {
                int pos = rng.Next(i);
                var x = list[i - 1];
                list[i - 1] = list[pos];
                list[pos] = x;
            }
        }

        public void refreshCheckList()
        {
            //chkLsStars.ClearSelected();
            lvStars.Items.Clear();
            ImageList list = new ImageList();
            list.ImageSize = new Size(24, 24);
            list.ColorDepth = ColorDepth.Depth32Bit;
            list.Images.Add("blue", Image.FromFile("images/blueStar.png"));
            list.Images.Add("gold", Image.FromFile("images/star.png"));
            lvStars.LargeImageList = list;

            for (int i = 0; i < randomList.Count; i++)
            {
                ListViewItem l = new ListViewItem();
                l.Text = randomList[i].ToString();
                l.ImageIndex = 0;
                lvStars.Items.Add(l);                
            }
        }

        public void combineLists()
        {
            randomList = new List<string>();
            if (chkFirst.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(first);
                }
                else
                {
                    randomList.AddRange(first.Except(first.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
            }
            if (chkDownstairs.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(downstairs);
                }
                else
                {
                    randomList.AddRange(downstairs.Except(downstairs.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
                
            }
            if (chkUpstairs.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(upstairs);
                }
                else
                {
                    randomList.AddRange(upstairs.Except(upstairs.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }
            }
            if (chkTop.Checked)
            {
                if (chk100CS.Checked)
                {
                    randomList.AddRange(top);
                }
                else
                {
                    randomList.AddRange(top.Except(top.Where((t, i) => ((i + 1) % 7) == 0).ToList()));
                }                
            }
            if (chkBowserStars.Checked)
            {
                randomList.AddRange(bowserStars);
            }
            if (chkSecretStars.Checked)
            {
                randomList.AddRange(secretStars);
            }
            if (chkToads.Checked)
            {
                randomList.AddRange(toads);
            }
            if (chkMips.Checked)
            {
                randomList.AddRange(mips);
            }
        }

        private void btnEnterSeed_Click(object sender, EventArgs e)
        {

            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                seed = Convert.ToInt32(nudSeed.Value);
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Number of Stars amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lvStars_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                if (e.Item.ImageKey == "gold")
                {
                    e.Item.ImageKey = "blue";
                    e.Item.Selected = false;
                }
                else
                {
                    e.Item.ImageKey = "gold";
                    e.Item.Selected = false;
                }
            }
        }      
    }
}
