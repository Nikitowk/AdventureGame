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

        public int playerHealth = 100;
        public int playerdmg = 10;
        public int balance = 0;
        public int steps = 0;
        public AdventureForm()
        {
            InitializeComponent();
            healthNumlbl.Text = playerHealth.ToString();
        }

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
            steps++;
            stepsCountlbl.Text = steps.ToString();
            counter.Next(1, 11);
            string enc;
            if (counter.Next(1, 11) > 5)
            {
                enc = Encounters.CheckEncounter();

                if (enc.Equals("Attacked"))
                {
                    checknumlbl.Text = enc;
                    AttackedEncounterForm aef = new AttackedEncounterForm(this);
                    aef.Visible = true;
                    moneyNumlbl.Text = balance.ToString();
                }
                if (enc.Equals("Found a Town"))
                {
                    checknumlbl.Text = enc;
                }
                if (enc.Equals("Found a Cave"))
                {
                    checknumlbl.Text = enc;
                }
                else if(enc.Equals("No Encounter"))
                {
                    checknumlbl.Text = enc;
                }
            }
        }
    }
}
