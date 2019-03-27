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
        private Random s = new Random();
        private List<string> randomList = new List<string>();
        private int seed = 0;

        private List<string> first = new List<string>()
        {
            "BOB1: Big Bob-omb on the Summit",
            "BOB2: Footrace with Koopa the Quick",
            "BOB3: Shoot to the Island in the Sky",
            "BOB4: Find the 8 Red Coins",
            "BOB5: Mario Wings to the Sky",
            "BOB6: Behind Chain Chomp's Gate",
            "BOB7",
            "WF1: Chip Off Whomp's Block",
            "WF2: To the Top of the Fortress",
            "WF3: Shoot into the Wild Blue",
            "WF4: Red Coins on the Floating Isle",
            "WF5: Fall onto the Caged Island",
            "WF6: Blast Away the Wall",
            "WF7",
            "JRB1: Plunder in the Sunken Ship",
            "JRB2: Can the Eel Come Out to Play?",
            "JRB3: Treasure of the Ocean Cave",
            "JRB4: Red Coins on the Ship Afloat",
            "JRB5: Blast to the Stone Pillar",
            "JRB6: Through the Jet Stream",
            "JRB7",
            "CCM1: Slip Slidin' Away",
            "CCM2: Li'l Penguin Lost",
            "CCM3: Big Penguin Race",
            "CCM4: Frosty Slide for 8 Red Coins",
            "CCM5: Snowman's Lost His Head",
            "CCM6: Wall Kicks Will Work",
            "CCM7",
            "BBH1: Go on a Ghost Hunt",
            "BBH2: Ride Big Boo's Merry-Go-Round",
            "BBH3: Secret of the Haunted Books",
            "BBH4: Seek the 8 Red Coins",
            "BBH5: Big Boo's Balcony",
            "BBH6: Eye to Eye in the Secret Room",
            "BBH7"
        };
        private List<string> downstairs = new List<string>()
        {
            "HMC1: Swimming Beast in the Cavern",
            "HMC2: Elevate for 8 Red Coins",
            "HMC3: Metal-Head Mario Can Move!",
            "HMC4: Navigating the Toxic Maze",
            "HMC5: A-Maze-Ing Emergency Exit",
            "HMC6: Watch for Rolling Rocks",
            "HMC7",
            "SSL1: In the Talons of the Big Bird",
            "SSL2: Shining Atop the Pyramid",
            "SSL3: Inside the Ancient Pyramid",
            "SSL4: Stand Tall on the Four Pillars",
            "SSL5: Free Flying for 8 Red Coins",
            "SSL6: Pyramid Puzzle", "SSL7",
            "LLL1: Boil the Big Bully",
            "LLL2: Bully the Bullies",
            "LLL3: 8-Coin Puzzle with 15 Pieces",
            "LLL4: Red-Hot Log Rolling",
            "LLL5: Hot-Foot-It into the Volcano",
            "LLL6: Elevator Tour in the Volcano",
            "LLL7",
            "DDD1: Board Bowser's Sub",
            "DDD2: Chests in the Current",
            "DDD3: Pole-Jumping for Red Coins",
            "DDD4: Through the Jet Stream",
            "DDD5: The Manta Ray's Reward",
            "DDD6: Collect the Caps...",
            "DDD7"
        };
        private List<string> upstairs = new List<string>()
        {
            "SL1: Snowman's Big Head",
            "SL2: Chill with the Bully",
            "SL3: In the Deep Freeze",
            "SL4: Whirl from the Freezing Pond",
            "SL5: Shell Shreddin' for Red Coins",
            "SL6: Into the Igloo", "SL7",
            "WDW1: Shocking Arrow Lifts!",
            "WDW2: Top o' the Town",
            "WDW3: Secrets in the Shallows & Sky",
            "WDW4: Express Elevator--Hurry Up!",
            "WDW5: Go to Town for Red Coins",
            "WDW6: Quick Race Through Downtown!",
            "WDW7",
            "TTM1: Scale the Mountain",
            "TTM2: Mystery of the Monkey Cage",
            "TTM3: Scary 'Shrooms, Red Coins",
            "TTM4: Mysterious Mountainside",
            "TTM5: Breathtaking View from Bridge",
            "TTM6: Blast to the Lonely Mushroom",
            "TTM7",
            "THI1: Pluck the Piranha Flower",
            "THI2: The Tip Top of the Huge Island",
            "THI3: Rematch with Koopa the Quick",
            "THI4: Five Itty Bitty Secrets",
            "THI5: Wiggler's Red Coins",
            "THI6: Make Wiggler Squirm",
            "THI7"
        };
        private List<string> top = new List<string>()
        {
            "TTC1: Roll into the Cage",
            "TTC2: The Pit and the Pendulums",
            "TTC3: Get a Hand",
            "TTC4: Stomp on the Thwomp",
            "TTC5: Timed Jumps on Moving Bars",
            "TTC6: Stop Time for Red Coins",
            "TTC7",
            "RR1: Cruiser Crossing the Rainbow",
            "RR2: The Big House in the Sky",
            "RR3: Coins Amassed in a Maze",
            "RR4: Swingin' in the Breeze",
            "RR5: Tricky Triangles!",
            "RR6: Somewhere Over the Rainbow",
            "RR7"
        };
        private List<string> bowserStars = new List<string>()
        {
            "Bowser in the Dark World",
            "Bowser in the Fire Sea",
            "Bowser in the Sky"
        };
        private List<string> secretStars = new List<string>()
        {
            "The Secret Aquarium",
            "The Princess's Secret Slide: Box",
            "The Princess's Secret Slide: Time",
            "Wing Cap",
            "Vanish Cap",
            "Metal Cap",
            "Over the Rainbows"
        };

        public Main()
        {
            InitializeComponent();
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            seed = s.Next(0, 160000);
            nudSeed.Value = seed;
            combineLists();
            Shuffle(randomList, seed);
            setOutputList();
            refreshCheckList();
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
            chkLsStars.ClearSelected();
            ((ListBox)chkLsStars).DataSource = randomList;
        }

        public void combineLists()
        {
            randomList = new List<string>();

            if (chkFirst.Checked)
            {
                randomList.AddRange(first);
            }
            if (chkDownstairs.Checked)
            {
                randomList.AddRange(downstairs);
            }
            if (chkUpstairs.Checked)
            {
                randomList.AddRange(upstairs);
            }
            if (chkTop.Checked)
            {
                randomList.AddRange(top);
            }
            if (chkBowserStars.Checked)
            {
                randomList.AddRange(bowserStars);
            }
            if (chkSecretStars.Checked)
            {
                randomList.AddRange(secretStars);
            }
        }

        private void btnEnterSeed_Click(object sender, EventArgs e)
        {
            seed = Convert.ToInt32(nudSeed.Value);
            combineLists();
            Shuffle(randomList, seed);
            setOutputList();
            refreshCheckList();
        }

        private void setOutputList()
        {
            // Check that randomList.Count >= nudStarAmount.Value
            // Without this check, there will be a System.ArgumentException 

            // The only time this needs to run is if the following condition is true.
            // Otherwise, without this if, the above bug would occure.
            // This is but one possibly solution. You may wish to alert the user that
            // they will not be running their desired number of stars. If that is the case,
            // simply make an else statement with extra code.
            if (randomList.Count > nudStarAmount.Value)
            {
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
            }
        }
    }
}
