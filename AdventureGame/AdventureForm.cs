namespace AdventureGame
{
    public partial class AdventureForm : Form
    {
        public AdventureForm()
        {
            InitializeComponent();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
