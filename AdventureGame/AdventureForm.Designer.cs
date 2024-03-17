


namespace AdventureGame
{
    partial class AdventureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExitGame = new Button();
            btnInventory = new Button();
            SuspendLayout();
            // 
            // btnExitGame
            // 
            btnExitGame.AutoSize = true;
            btnExitGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitGame.Location = new Point(694, 400);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(94, 38);
            btnExitGame.TabIndex = 0;
            btnExitGame.Text = "Exit";
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += this.btnExitGame_Click;
            // 
            // btnInventory
            // 
            btnInventory.AutoSize = true;
            btnInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.Blue;
            btnInventory.Location = new Point(342, 294);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(114, 38);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += this.btnInventory_Click;
            // 
            // AdventureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInventory);
            Controls.Add(btnExitGame);
            Name = "AdventureForm";
            Text = "Adventure Game";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button btnExitGame;
        private Button btnInventory;
    }
}
