using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        Random s = new Random();
        int seed = 0;
        List<string> first = new List<string>() { "BOB1", "BOB2", "BOB3", "BOB4", "BOB5", "BOB6", "BOB7", "WF1", "WF2", "WF3", "WF4", "WF5", "WF6", "WF7", "JRB1", "JRB2", "JRB3", "JRB4", "JRB5", "JRB6", "JRB7", "CCM1", "CCM2", "CCM3", "CCM4", "CCM5", "CCM6", "CCM7",  "BBH1", "BBH2", "BBH3", "BBH4", "BBH5", "BBH6", "BBH7" };
        List<string> downstairs = new List<string>() { "HMC1", "HMC2", "HMC3", "HMC4", "HMC5", "HMC6", "HMC7", "SSL1", "SSL2", "SSL3", "SSL4", "SSL5", "SSL6", "SSL7", "LLL1", "LLL2", "LLL3", "LLL4", "LLL5", "LLL6", "LLL7", "DDD1", "DDD2", "DDD3", "DDD4", "DDD5", "DDD6", "DDD7" };
        List<string> upstairs = new List<string>() { "WDW1", "WDW2", "WDW3", "WDW4", "WDW5", "WDW6", "WDW7", "TTM1", "TTM2", "TTM3", "TTM4", "TTM5", "TTM6", "TTM7", "SL1", "SL2", "SL3", "SL4", "SL5", "SL6", "SL7", "THI1", "THI2", "THI3", "THI4", "THI5", "THI6", "THI7" };
        List<string> top = new List<string>() { "TTC1", "TTC2", "TTC3", "TTC4", "TTC5", "TTC6", "TTC7", "RR1", "RR2", "RR3", "RR4", "RR5", "RR6", "RR7" };
        List<string> bowserStars = new List<string>() { "BitDW", "BitFS", "BitS"};
        List<string> secretStars = new List<string>() { "SA", "PPSS1", "PPSS2", "WC", "VC", "MC", "AtC"};

        List<string> randomList = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void btnNewSeed_Click(object sender, EventArgs e)
        {
            if (chk16S.Checked)
            {
                seed = s.Next(0, 10000);
                nudSeed.Value = seed;
                combineLists();
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, 16);
                txtRando.Text = string.Join("-", randomList);
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
            if (chk16S.Checked)
            {
                seed = Convert.ToInt32(nudSeed.Value);
                combineLists();
                Shuffle(randomList, seed);
                randomList = randomList.GetRange(0, 16);
                txtRando.Text = string.Join("-", randomList);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratePatch_Click(object sender, EventArgs e)
        {

        }


    }



}
