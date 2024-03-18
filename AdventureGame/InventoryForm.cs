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
    /// <summary>
    /// Inventory Class to keep manage and keep track of the players' inventory
    /// during their adventures. Can hold a max of 10 items, when that happens
    /// the player must decide whether they want to keep the items they have
    /// or get rid of any items in their inventory.
    /// </summary>
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        List<string> inventoryList = new List<string>(10);
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
