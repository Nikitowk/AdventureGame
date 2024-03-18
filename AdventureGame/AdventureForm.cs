using System.Collections;
using System.Xml.Xsl;

namespace AdventureGame
{
    /// <summary>
    /// Created by Kiernan Nikitow 3/17/2024
    /// 
    /// This adventure game is to assist me in learning the c# language along with my college course
    /// as of the date listed above. I am taking reference from the tabletop game Dungeons & Dragons 
    /// because it is a game that I enjoy playing and with my current skillset and knowledge, what
    /// I feel will aid me best in my learning experience.
    /// </summary>
    public partial class AdventureForm : Form
    {
        private RandomGenerator die = new RandomGenerator();
        public AdventureForm()
        {
            InitializeComponent();

            this.die = new RandomGenerator();
        }
        private int steps = 0;
        private bool encounter = false;
        private bool walking = false;
        private int encounterNum;
        private Random counter = new Random();

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm invform = new InventoryForm();
            invform.Visible = true;
        }

        private void walkbtn_Click(object sender, EventArgs e)
        {
            ArrayList checkNum = new ArrayList();
            checkNum.Add(96);
            checkNum.Add(97);
            checkNum.Add(98);
            checkNum.Add(99);
            checkNum.Add(100);

            walking = true;
            while (walking == true)
            {
                int countNum = counter.Next(1,60);
                while (!checkNum.Contains(countNum))
                {
                    countNum = counter.Next(1,60);
                    walkbtn.Enabled = false;
                    steps++;
                    if (checkNum.Contains(countNum)) 
                    { 
                        encounter = true;
                    }
                }
                if (encounter == true) break;
            }
            walkbtn.Enabled = true;
        }
    }
}
