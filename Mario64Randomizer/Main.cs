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
using Mario64Randomizer.SM64;
using Mario64Randomizer.Parsers;
using System.IO;
using System.Reflection;
using Mario64Randomizer.patches;
using Mario64Randomizer.Helpers;
using System.Globalization;

namespace Mario64Randomizer
{
    public partial class Main : Form
    {
        private Random s = new Random();
        public int seed = 0;
        ROM rm;
        byte[] originalData;
        private string romName;

        //
        private Color colorMarioOveralls;
        private Color colorMarioGloves;
        private Color colorMarioShoes;
        private Color colorMarioCap;
        private Color colorMarioFace;
        private Color colorMarioHair;
        //
        public List<string> courseNames;
        public List<int> warpingBehaviours;
        public List<int> targetWarpBehaviours;
        public List<string> behavioursWithNames;
        public List<string> groundedWithNames;
        public List<string> warpingBehavioursWithNames;
        public List<string> removeAddresses;

        private List<string> first = new List<string>()
        {
            "BOB1: Big Bob-omb on the Summit", "BOB2: Footrace with Koopa the Quick", "BOB3: Shoot to the Island in the Sky", "BOB4: Find the 8 Red Coins", "BOB5: Mario Wings to the Sky", "BOB6: Behind Chain Chomp's Gate", "BOB7: 100 Coin Star",
            "WF1: Chip Off Whomp's Block", "WF2: To the Top of the Fortress", "WF3: Shoot into the Wild Blue", "WF4: Red Coins on the Floating Isle", "WF5: Fall onto the Caged Island", "WF6: Blast Away the Wall", "WF7: 100 Coin Star",
            "JRB1: Plunder in the Sunken Ship", "JRB2: Can the Eel Come Out to Play?", "JRB3: Treasure of the Ocean Cave", "JRB4: Red Coins on the Ship Afloat", "JRB5: Blast to the Stone Pillar", "JRB6: Through the Jet Stream", "JRB7: 100 Coin Star",
            "CCM1: Slip Slidin' Away", "CCM2: Li'l Penguin Lost", "CCM3: Big Penguin Race", "CCM4: Frosty Slide for 8 Red Coins", "CCM5: Snowman's Lost His Head", "CCM6: Wall Kicks Will Work", "CCM7: 100 Coin Star",
            "BBH1: Go on a Ghost Hunt", "BBH2: Ride Big Boo's Merry-Go-Round", "BBH3: Secret of the Haunted Books", "BBH4: Seek the 8 Red Coins", "BBH5: Big Boo's Balcony", "BBH6: Eye to Eye in the Secret Room", "BBH7: 100 Coin Star"
        };
        private List<string> downstairs = new List<string>()
        {
            "HMC1: Swimming Beast in the Cavern", "HMC2: Elevate for 8 Red Coins", "HMC3: Metal-Head Mario Can Move!", "HMC4: Navigating the Toxic Maze", "HMC5: A-Maze-Ing Emergency Exit", "HMC6: Watch for Rolling Rocks","HMC7: 100 Coin Star",
            "SSL1: In the Talons of the Big Bird", "SSL2: Shining Atop the Pyramid", "SSL3: Inside the Ancient Pyramid", "SSL4: Stand Tall on the Four Pillars", "SSL5: Free Flying for 8 Red Coins", "SSL6: Pyramid Puzzle", "SSL7: 100 Coin Star",
            "LLL1: Boil the Big Bully", "LLL2: Bully the Bullies", "LLL3: 8-Coin Puzzle with 15 Pieces", "LLL4: Red-Hot Log Rolling", "LLL5: Hot-Foot-It into the Volcano", "LLL6: Elevator Tour in the Volcano", "LLL7: 100 Coin Star",
            "DDD1: Board Bowser's Sub", "DDD2: Chests in the Current", "DDD3: Pole-Jumping for Red Coins", "DDD4: Through the Jet Stream", "DDD5: The Manta Ray's Reward", "DDD6: Collect the Caps...", "DDD7: 100 Coin Star"
        };
        private List<string> upstairs = new List<string>()
        {
            "SL1: Snowman's Big Head", "SL2: Chill with the Bully", "SL3: In the Deep Freeze", "SL4: Whirl from the Freezing Pond", "SL5: Shell Shreddin' for Red Coins", "SL6: Into the Igloo", "SL7: 100 Coin Star",
            "WDW1: Shocking Arrow Lifts!", "WDW2: Top o' the Town", "WDW3: Secrets in the Shallows & Sky", "WDW4: Express Elevator--Hurry Up!", "WDW5: Go to Town for Red Coins", "WDW6: Quick Race Through Downtown!", "WDW7: 100 Coin Star",
            "TTM1: Scale the Mountain", "TTM2: Mystery of the Monkey Cage", "TTM3: Scary 'Shrooms, Red Coins", "TTM4: Mysterious Mountainside", "TTM5: Breathtaking View from Bridge", "TTM6: Blast to the Lonely Mushroom", "TTM7: 100 Coin Star",
            "THI1: Pluck the Piranha Flower", "THI2: The Tip Top of the Huge Island", "THI3: Rematch with Koopa the Quick", "THI4: Five Itty Bitty Secrets", "THI5: Wiggler's Red Coins", "THI6: Make Wiggler Squirm", "THI7: 100 Coin Star"
        };
        private List<string> top = new List<string>()
        {
            "TTC1: Roll into the Cage", "TTC2: The Pit and the Pendulums", "TTC3: Get a Hand", "TTC4: Stomp on the Thwomp", "TTC5: Timed Jumps on Moving Bars", "TTC6: Stop Time for Red Coins", "TTC7: 100 Coin Star",
            "RR1: Cruiser Crossing the Rainbow", "RR2: The Big House in the Sky", "RR3: Coins Amassed in a Maze", "RR4: Swingin' in the Breeze", "RR5: Tricky Triangles!", "RR6: Somewhere Over the Rainbow", "RR7: 100 Coin Star"
        };

        private List<string> bowserStars = new List<string>() { "Bowser in the Dark World", "Bowser in the Fire Sea", "Bowser in the Sky" };
        private List<string> secretStars = new List<string>() { "The Secret Aquarium", "Princess's Secret Slide: ! Box", "Princess's Secret Slide: Timed Race", "Wing Cap", "Vanish Cap", "Metal Cap", "Over the Rainbows" };

        private List<string> toads = new List<string>() { "Downstairs Toad", "Upstairs Toad", "Top Toad" };
        private List<string> mips = new List<string>() { "Mips", "Mips" };

        private List<string> randomList = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            this.btnNewSeed.PerformClick();

            behavioursWithNames = Properties.Resources.notGrounded.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            groundedWithNames = Properties.Resources.groundedBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            warpingBehavioursWithNames = Properties.Resources.warpBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            warpingBehaviours = Properties.Resources.warpBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            targetWarpBehaviours = Properties.Resources.targetWarps.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            removeAddresses = new List<string>();

            for (int i = 0; i < chklbWarpList.Items.Count; i++)
            {                
                chklbWarpList.SetItemChecked(i, true);
            }
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                seed = s.Next(0, 1000000000);
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
            lvStars.Items.Clear();
            ImageList list = new ImageList();
            list.ImageSize = new Size(24, 24);
            list.ColorDepth = ColorDepth.Depth32Bit;
            list.Images.Add("blue", Mario64Randomizer.Properties.Resources.blueStar);
            list.Images.Add("gold", Mario64Randomizer.Properties.Resources.star);
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

        private void btnOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "ROM Files (*.z64)|*.z64";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalData = File.ReadAllBytes(openFileDialog.FileName);
                    if(originalData.Length > 8400000)
                    {
                        byte[] rmData = (byte[])originalData.Clone();

                        rm = new ROM(originalData);
                        romName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                        courseNames = getCourseNames();
                        updateWarpList();

                        MessageBox.Show("Your ROM was loaded!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Error: 8mb Vanilla not supported.\nDo you want to download the Patch?", "8mb Rom Detected", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("https://github.com/aGlitch/Mario-64-Randomizer/releases/download/1.0/Super.Mario.64.Random.bps");
                        }
                    }                    
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (rm != null)
            {
                rm = new ROM(originalData);

                if (chkRandomizeMusic.Checked)
                {
                    randomizeMusic();
                }
                if (chkRandomizeWarps.Checked)
                {
                    randomizeWarps();
                }
                if (chkRandomizeObjects.Checked)
                {
                    randomizeEnemies();
                }
                if (chkRandomizeMarioClothes.Checked)
                {
                    randomizeMarioClothes();
                }
                MessageBox.Show("Rom Randomized", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Open a ROM File First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void randomizeMarioClothes()
        {
            Random colorRandom = new Random(seed);

            if (pColorOveralls.BackColor != Color.White)
            {

                colorMarioOveralls = pColorOveralls.BackColor;
            }
            else
            {
                colorMarioOveralls = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                pColorOveralls.BackColor = colorMarioOveralls;
            }

            if (pColorCap.BackColor != Color.White)
            {
                colorMarioCap = pColorCap.BackColor;
            }
            else
            {
                colorMarioCap = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                pColorCap.BackColor = colorMarioCap;
            }

            if (chkRandomizeHair.Checked)
            {
                if (pColorHair.BackColor != Color.White)
                {
                    colorMarioHair = pColorHair.BackColor;
                }
                else
                {
                    colorMarioHair = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    pColorHair.BackColor = colorMarioHair;
                }
            }

            if (chkRandomizeSkin.Checked)
            {
                if (pColorFace.BackColor != Color.White)
                {
                    colorMarioFace = pColorFace.BackColor;
                }
                else
                {
                    colorMarioFace = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                    pColorFace.BackColor = colorMarioFace;
                }
            }


            if (pColorGloves.BackColor != Color.White)
            {
                colorMarioGloves = pColorGloves.BackColor;
            }
            else
            {
                colorMarioGloves = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                pColorGloves.BackColor = colorMarioGloves;
            }

            if (pColorShoes.BackColor != Color.White)
            {
                colorMarioShoes = pColorShoes.BackColor;
            }
            else
            {
                colorMarioShoes = Color.FromArgb(colorRandom.Next(256), colorRandom.Next(256), colorRandom.Next(256));
                pColorShoes.BackColor = colorMarioShoes;
            }

            SM64.MarioColor overallObject = new SM64.MarioColor(rm, 0x7EC20, colorMarioOveralls);
            overallObject.Write(rm);

            SM64.MarioColor capObject = new SM64.MarioColor(rm, 0x07EC40, colorMarioCap);
            capObject.Write(rm);

            SM64.MarioColor shoesObject = new SM64.MarioColor(rm, 0x07EC70, colorMarioShoes);
            shoesObject.Write(rm);

            SM64.MarioColor glovesObject = new SM64.MarioColor(rm, 0x07EC50, colorMarioGloves);
            glovesObject.Write(rm);

            if (chkRandomizeSkin.Checked)
            {
                SM64.MarioColor faceObject = new SM64.MarioColor(rm, 0x07EC98, colorMarioFace);
                faceObject.Write(rm);
            }
            if (chkRandomizeHair.Checked)
            {
                SM64.MarioColor hairObject = new SM64.MarioColor(rm, 0x07EC80, colorMarioHair);
                hairObject.Write(rm);
            }
        }

        private void randomizeEnemies()
        {
            List<int> removal = removeAddresses.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            foreach (LevelOffsetsDescription lod in LevelInfo.Description)
            {
                if (chklbWarpList.GetItemCheckState(lod.NaturalIndex) == CheckState.Unchecked)
                    continue;

                int addr = lod.LevelScriptEntryPoint;
                try
                {
                    IEnumerable<SM64.Object> allObjects = FindObjectsParser.FindObjects(rm, addr, lod.Level).Where(x => x.act != 0);

                    for (int area = 0; area < 8; area++)
                    {
                        List<SM64.Object> areaObjects = allObjects.Where(x => x.area == area).ToList();
                        if (areaObjects.Count == 0)
                            continue;

                        
                        IEnumerable<SM64.Object> groundedObjects = areaObjects.Where(x => x.status == ObjectStatus.Grounded);
                        groundedObjects = groundedObjects.Where(x => !removal.Any(y => x.addr == y));
                        IList<ObjectPosition> groundedList = groundedObjects.Select(x => x.position).ToList();

                        IEnumerable<SM64.Object> nonGroundedObjects = areaObjects.Where(x => x.status == ObjectStatus.NonGrounded);
                        nonGroundedObjects = nonGroundedObjects.Where(x => !removal.Any(y => x.addr == y));
                        IList<ObjectPosition> nonGroundedList = nonGroundedObjects.Select(x => x.position).ToList();                        

                        Shuffle(groundedList, seed);
                        Shuffle(nonGroundedList, seed);

                        IEnumerable<SM64.Object> shuffledGroundedObjects = groundedObjects.Zip(groundedList,
                            (obj, pos) => new SM64.Object(obj.area, obj.level, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));
                        IEnumerable<SM64.Object> shuffledNonGroundedObjects = nonGroundedObjects.Zip(nonGroundedList,
                            (obj, pos) => new SM64.Object(obj.area, obj.level, obj.act, obj.model, obj.bparams, obj.behaviour, pos, obj.rotation, obj.addr));

                        foreach (SM64.Object obj in shuffledGroundedObjects)
                            obj.Write(rm);
                        foreach (SM64.Object obj in shuffledNonGroundedObjects)
                            obj.Write(rm);
                    }
                }
                catch (Exception) { }
            }
        }

        private void randomizeWarps()
        {
            List<Warp> allWarps = new List<Warp>();
            List<Warp> targetWarps = new List<Warp>();
            List<int> removal = removeAddresses.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();

            foreach (LevelOffsetsDescription lod in LevelInfo.Description)
            {
                if (chklbWarpList.GetItemCheckState(lod.NaturalIndex) == CheckState.Unchecked)
                    continue;

                try
                {
                    int addr = lod.LevelScriptEntryPoint;

                    List<Warp> levelWarps = FindWarpsParser.FindWarps(rm, addr, lod.Level);
                    IEnumerable<Warp> whiteListedWarps = levelWarps.Where(x => x.area == 0xFF);
                    allWarps.AddRange(whiteListedWarps);

                    List<SM64.Object> levelObjects = FindObjectsParser.FindObjects(rm, addr, lod.Level);
                    List<SM64.Object> warpingObjects = levelObjects.Where(x => warpingBehaviours.Contains(x.behaviour)).ToList();
                    List<SM64.Object> targetWarpObjects = levelObjects.Where(x => targetWarpBehaviours.Contains(x.behaviour)).ToList();

                    // Check if warp object exists
                    for (int area = 0; area < 7; area++)
                    {
                        List<Warp> areaWarps = levelWarps.Where(x => x.area == area).ToList();
                        if (areaWarps.Count == 0)
                            continue;

                        {
                            List<SM64.Object> areaObjects = warpingObjects.Where(x => x.area == area).ToList();
                            List<Warp> warpingWarps = areaWarps.Where(a => areaObjects.Find(w => w.BParam2 == a.from.id) != null).ToList();
                            allWarps.AddRange(warpingWarps);
                        }

                        {
                            List<SM64.Object> areaObjects = targetWarpObjects.Where(x => x.area == area).ToList();
                            List<Warp> warpingWarps = areaWarps.Where(a => areaObjects.Find(w => w.BParam2 == a.from.id) != null).ToList();
                            targetWarps.AddRange(warpingWarps);
                        }
                    }
                }
                catch (Exception) { }
            }

            IEnumerable<Warp> warps = null;
            {
                // Drop all success/failure/invalid warps
                List<Warp> noDeathSuccessWarps = allWarps.Where(x => (x.from.id < 0xF0) & (x.to.id < 0xF0) & (x.to.course != 0x0)).ToList();
                List<Warp> validTargets = targetWarps.Where(x => x.from.id != 0xF0).ToList();

                // Drop warps that does not have target
                warps = noDeathSuccessWarps.Where(x => validTargets.Find(w => x.to.id == w.from.id && x.to.course == w.course) != null);

                // Drop warps by address
                warps = warps.Where(x => !removal.Any(y => x.addr == y));
            }

            if (!chkRandomizeHubs.Checked) // If Checked, randomize Warps that lead to Hubs
            {
                warps = warps.Where(x => (x.to.course != 0x06) & (x.to.course != 0x10) & (x.to.course != 0x1A));
            }

            // Pick warps between(outside) stages and inside stages
            // Outside warps logics
            {
                IEnumerable<Warp> outsideWarps = warps.Where(w => w.course != w.to.course);

                List<Warp> levelWarps = randomizePreparedWarps(outsideWarps).ToList();

                // Warps between levels should never warp on themselves or bad things will happen
                // For example if loop like c1->c2->c3 will become c1->c1 c2->c1 c3->c3 game might crash
                // This is greedy attempt to fix this
                while (true)
                {
                    List<Warp> brokenOutsideWarps = levelWarps.Where(w => w.course == w.to.course).ToList();
                    if (brokenOutsideWarps.Count == 0)
                        break;

                    // Try find replacement warp that is not broken
                    Warp brokenWarp = brokenOutsideWarps.First();
                    int brokenWarpId = levelWarps.FindIndex(w => w == brokenWarp);
                    int replacementWarpId = levelWarps.FindIndex(w => w.to.course != brokenWarp.course);
                    if (replacementWarpId == -1)
                        break;

                    Warp replacementWarp = levelWarps[replacementWarpId];

                    // Swap "to" in warps and be happy :)
                    Warp notBrokenWarp = new Warp(brokenWarp.area, brokenWarp.course, brokenWarp.from, replacementWarp.to, brokenWarp.addr);
                    Warp notReplacementWarp = new Warp(replacementWarp.area, replacementWarp.course, replacementWarp.from, brokenWarp.to, replacementWarp.addr);
                    levelWarps[replacementWarpId] = notReplacementWarp;
                    levelWarps[brokenWarpId] = notBrokenWarp;
                }
                applyWarps(randomizePreparedWarps(levelWarps), "out");
            }

            // Inside warps logics
            {
                IEnumerable<Warp> insideWarps = warps.Where(w => w.course == w.to.course);

                if (chkBoxMixWarps.CheckState == CheckState.Unchecked)
                {
                    if (chkRandomizeInsideWarps.Checked)
                    {
                        // n00b mode
                        foreach (LevelOffsetsDescription lod in LevelInfo.Description)
                        {
                            IEnumerable<Warp> levelWarps = insideWarps.Where(w => w.course == lod.Level);
                            applyWarps(randomizePreparedWarps(levelWarps), "in");
                        }
                    }
                }
                else
                {
                    // gamer mode
                    applyWarps(randomizePreparedWarps(insideWarps), "in");
                }
            }
        }

        public IEnumerable<Warp> randomizePreparedWarps(IEnumerable<Warp> warps)
        {
            IList<WarpTo> warpsTo = warps.Select(x => x.to).ToList();
            Shuffle(warpsTo, seed);

            return warps.Zip(warpsTo, (warp, to) => new Warp(warp.area, warp.course, warp.from, to, warp.addr));
        }

        public void applyWarps(IEnumerable<Warp> shuffledWarps, string debugName)
        {
            foreach (Warp warp in shuffledWarps)
                warp.Write(rm);

            if (chkWarpFile.Checked)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + romName + " - " + debugName + " - " + seed.ToString() + ".txt";

                using (StreamWriter sw = File.CreateText(path))
                {
                    courseNames = new List<string>();

                    for(int i = 0; i < chklbWarpList.Items.Count; i++) // Update the Course Name List
                    {
                        courseNames.Add(chklbWarpList.Items[i].ToString());
                    }                        

                    foreach (Warp warp in shuffledWarps)               
                        sw.WriteLine("*Warp Address: " + warp.addr.ToString() + "*  [ From Id: " + warp.from.id.ToString() + " -> To Id: " + warp.to.id.ToString() + " - Course: " + courseNames[LevelInfo.FindByLevel(warp.to.course).NaturalIndex] + ", Area: " + warp.to.area.ToString() + " ]");
                    
                }
            }
        }

        private void randomizeMusic()
        {
            List<Song> allSongs = new List<Song>();

            foreach (LevelOffsetsDescription lod in LevelInfo.Description)
            {
                if (chklbWarpList.GetItemCheckState(lod.NaturalIndex) == CheckState.Unchecked)
                    continue;

                int addr = lod.LevelScriptEntryPoint;
                try
                {
                    List<Song> levelSongs = FindSongsParser.FindSongs(rm, addr);
                    allSongs.AddRange(levelSongs);
                }
                catch (Exception) { }
            }

            IEnumerable<Song> songList = allSongs;

            IList<byte> seqList = songList.Select(x => x.seqNumber).ToList();

            Shuffle(seqList, seed);

            IEnumerable<Song> shuffledSongs = songList.Zip(seqList, (song, seqNumber) => new Song(seqNumber, song.addr, song.musicOffset));

            foreach (Song song in shuffledSongs)
            {
                song.Write(rm);
            }
        }

        private void btnSaveRom_Click(object sender, EventArgs e)
        {
            if (rm != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "ROM Files (*.z64)|*.z64";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = romName + " - " + seed.ToString();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, rm.rom);
                        if (chkWarpPatch.Checked)
                        {
                            Patch p = new Patch(AppDomain.CurrentDomain.BaseDirectory + "patches\\warpfadefix");
                            p.Apply(rm);
                            Patch.FixChksum(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Your ROM was saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Open a ROM File First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnColorOveralls_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioOveralls = cdClothes.Color;
                pColorOveralls.BackColor = cdClothes.Color;
            }
        }

        private void btnColorCapArms_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioCap = cdClothes.Color;
                pColorCap.BackColor = cdClothes.Color;
            }
        }

        private void btnColorGloves_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioGloves = cdClothes.Color;
                pColorGloves.BackColor = cdClothes.Color;
            }
        }

        private void btnColorShoes_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioShoes = cdClothes.Color;
                pColorShoes.BackColor = cdClothes.Color;
            }
        }

        private void btnColorFace_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioFace = cdClothes.Color;
                pColorFace.BackColor = cdClothes.Color;
            }
        }

        private void btnColorHair_Click(object sender, EventArgs e)
        {
            DialogResult result = cdClothes.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorMarioHair = cdClothes.Color;
                pColorHair.BackColor = cdClothes.Color;
            }
        }

        private void btnColorRestore_Click(object sender, EventArgs e)
        {
            colorMarioCap = Color.Empty;
            pColorCap.BackColor = Color.White;

            colorMarioFace = Color.Empty;
            pColorFace.BackColor = Color.White;

            colorMarioGloves = Color.Empty;
            pColorGloves.BackColor = Color.White;

            colorMarioHair = Color.Empty;
            pColorHair.BackColor = Color.White;

            colorMarioOveralls = Color.Empty;
            pColorOveralls.BackColor = Color.White;

            colorMarioShoes = Color.Empty;
            pColorShoes.BackColor = Color.White;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            combineLists();
            if (nudStarAmount.Value <= randomList.Count)
            {
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, Convert.ToInt32(nudStarAmount.Value));
                refreshCheckList();
            }
            else
            {
                MessageBox.Show("Error: The Number of Stars amount is higher than the Selected Star Set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }               

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Black;
            AboutDialog a = new AboutDialog();
            a.ShowDialog();
        }

        private void btnHelp_Hover(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Black;
        }

        private void btnHelp_Enter(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Black;
        }

        private void btnHelp_Down(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Black;
        }

        private void btnHelp_MouseDown(object sender, MouseEventArgs e)
        {
            btnHelp.BackColor = Color.Black;
        }

        private List<string> saveWarpList()
        {
            List<string> checksWithNames = new List<string>();
            for (int i = 0; i < chklbWarpList.Items.Count; i++)
            {
                checksWithNames.Add(chklbWarpList.Items[i].ToString() + " : " + (int)chklbWarpList.GetItemCheckState(i));
            }
            return checksWithNames;
        }

        private void loadWarpList(List<string> loadedChecks)
        {
            List<int> courses = loadedChecks.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[1].Trim(), 16)).ToList();

            for (int i = 0; i < chklbWarpList.Items.Count; i++)
            {
                chklbWarpList.SetItemCheckState(i, (CheckState)courses[i]);
            }                                
        }

        private void btnRestoreWarps_Click(object sender, EventArgs e)
        {
            for (int item = 0; item < chklbWarpList.Items.Count; item++)
            { 
                chklbWarpList.SetItemChecked(item, true);
            }                 
        }

        private List<string> getCourseNames()
        {
            const int levelNameTableStart = 0x813E6A;
            byte[] data = new byte[538];
            rm.ReadData(levelNameTableStart, data);
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            return n64Text.GetStrings(data).Select(r => currentCulture.TextInfo.ToTitleCase(r.ToLower()).TrimStart()).ToList();
        }

        private void updateWarpList()
        {
            int skipped = 0;
            for (int item = 0; item < courseNames.Count; item++)
            {
                Console.WriteLine(courseNames[item]);
                if (item < 15)
                {
                    chklbWarpList.Items[item] = (courseNames[item].Replace(':', ' '));
                    chklbWarpList.SetItemChecked(item, true);
                }
                else if(skipped < 3)
                {
                    chklbWarpList.Items[item + skipped] = (courseNames[item].Replace(':', ' '));
                    chklbWarpList.SetItemChecked(item + skipped, true);                
                    skipped++;
                }
                else if(item >= 18 & item < 24)
                {
                    chklbWarpList.Items[item + skipped] = (courseNames[item].Replace(':', ' '));
                    chklbWarpList.SetItemChecked(item + skipped, true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BehaviourForm beh = new BehaviourForm(0, behavioursWithNames);
            beh.ShowDialog();

            behavioursWithNames = beh.getNonGrounded();
        }

        private void btnEditGroundedObjects_Click(object sender, EventArgs e)
        {
            BehaviourForm beh = new BehaviourForm(1, groundedWithNames);
            beh.ShowDialog();

            groundedWithNames = beh.getGrounded();
        }

        private void btnEditWarpObjects_Click(object sender, EventArgs e)
        {
            BehaviourForm beh = new BehaviourForm(2, warpingBehavioursWithNames);
            beh.ShowDialog();

            warpingBehavioursWithNames = beh.getWarps();
            warpingBehaviours = warpingBehavioursWithNames.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
        }

        private void btnRemoveObjectAddress_Click(object sender, EventArgs e)
        {
            BehaviourForm beh = new BehaviourForm(3, removeAddresses);
            beh.ShowDialog();

            removeAddresses = beh.getRemoved();
        }

        private void btnSaveAllBehav_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (rm != null)
            {
                saveFileDialog.FileName = romName + " - Config";
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> allSettings = new List<string>();
                    allSettings.AddRange(saveWarpList());
                    allSettings.Add("---");
                    allSettings.AddRange(behavioursWithNames);
                    allSettings.Add("---");
                    allSettings.AddRange(groundedWithNames);
                    allSettings.Add("---");
                    allSettings.AddRange(warpingBehavioursWithNames);
                    allSettings.Add("---");
                    allSettings.AddRange(removeAddresses);

                    File.WriteAllLines(saveFileDialog.FileName, allSettings);
                    MessageBox.Show("Config Saved!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to Save!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private List<string> CutData(List<string> behavs, ref int lastIndex)
        {
            int last  = behavs.FindIndex(lastIndex, x => x == "---");
            if (last == -1)
                last = behavs.Count;

            int first = lastIndex;

            lastIndex = last + 1;
            return behavs.GetRange(first, last - first);
        }

        private void btnLoadAllBehav_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> settings = File.ReadAllLines(openFileDialog.FileName).ToList();

                    int index = 0;
                    loadWarpList(CutData(settings, ref index));
                    behavioursWithNames = CutData(settings, ref index);
                    groundedWithNames = CutData(settings, ref index);
                    warpingBehavioursWithNames = CutData(settings, ref index);
                    removeAddresses = CutData(settings, ref index);

                    warpingBehaviours = warpingBehavioursWithNames.Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
                    
                    SM64.Object.SetNonGroundedBehaviours(behavioursWithNames);
                    MessageBox.Show("Config Loaded!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to load!", "-_-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnRestoreBehaviours_Click(object sender, EventArgs e)
        {
            behavioursWithNames = Properties.Resources.notGrounded.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            groundedWithNames = Properties.Resources.groundedBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            warpingBehavioursWithNames = Properties.Resources.warpBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            warpingBehaviours = Properties.Resources.warpBehaviours.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            targetWarpBehaviours = Properties.Resources.targetWarps.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => Convert.ToInt32(x.Split(new char[] { ':' })[0].Trim(), 16)).ToList();
            removeAddresses = new List<string>();
        }
    }
}
