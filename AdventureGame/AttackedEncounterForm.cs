using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class AttackedEncounterForm : Form
    {
        private AdventureForm adventureForm;
        private int enemyHealth;
        private int enemyDmg;

        public int moneyGained = 0;
        public int updatedHealth = 0;
        public int healthbeforeclose = 0;
        public AttackedEncounterForm(AdventureForm adventureForm)
        {
            Encounters encounters = new Encounters();
            InitializeComponent();
            this.adventureForm = adventureForm;
            enemyHealth = encounters.enemyhealth;
            enemyDmg = encounters.enemydmg;
            attackedHealthNumlbl.Text = adventureForm.playerHealth.ToString();
            enemyHealthNumlbl.Text = enemyHealth.ToString();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void attackbtn_Click(object sender, EventArgs e)
        {
            enemyHealth -= adventureForm.playerdmg;
            enemyHealthNumlbl.Text = enemyHealth.ToString();
            adventureForm.playerHealth -= enemyDmg;
            attackedHealthNumlbl.Text = adventureForm.playerHealth.ToString();

            if (adventureForm.playerHealth <= 0) 
            {
                System.Windows.Forms.MessageBox.Show("You have died.");
                System.Environment.Exit(0);
            }
            else if (enemyHealth <= 0)
            {
                System.Windows.Forms.MessageBox.Show("You have defeated the enemy!\n" + "You have gained 5 gold.");
                adventureForm.balance += 5;
                Close();
            }
        }
    }
}
