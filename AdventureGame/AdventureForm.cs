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
        private Encounters encounters = new Encounters();
        public AdventureForm()
        {
            InitializeComponent();

            this.die = new RandomGenerator();
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
            counter.Next(1, 11);
            string enc;
            if (counter.Next(1, 11) > 5)
            {
                enc = Encounters.CheckEncounter();

                if (enc.Equals("Attacked"))
                {
                    checknumlbl.Text = enc;
                }
                else 
                {
                    checknumlbl.Text = "waiting";
                }
            }
        }
    }
}
