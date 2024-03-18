


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
            healthlbl = new Label();
            healthNumlbl = new Label();
            moneylbl = new Label();
            moneyNumlbl = new Label();
            walkbtn = new Button();
            stepslbl = new Label();
            stepsCountlbl = new Label();
            checknumlbl = new Label();
            SuspendLayout();
            // 
            // btnExitGame
            // 
            btnExitGame.AutoSize = true;
            btnExitGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExitGame.Location = new Point(607, 300);
            btnExitGame.Margin = new Padding(3, 2, 3, 2);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(82, 31);
            btnExitGame.TabIndex = 0;
            btnExitGame.Text = "Exit";
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // btnInventory
            // 
            btnInventory.AutoSize = true;
            btnInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.Blue;
            btnInventory.Location = new Point(294, 261);
            btnInventory.Margin = new Padding(3, 2, 3, 2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(100, 31);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // healthlbl
            // 
            healthlbl.AutoSize = true;
            healthlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            healthlbl.ForeColor = Color.Red;
            healthlbl.Location = new Point(34, 23);
            healthlbl.Name = "healthlbl";
            healthlbl.Size = new Size(65, 21);
            healthlbl.TabIndex = 2;
            healthlbl.Text = "Health:";
            // 
            // healthNumlbl
            // 
            healthNumlbl.AutoSize = true;
            healthNumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            healthNumlbl.ForeColor = Color.Red;
            healthNumlbl.Location = new Point(105, 23);
            healthNumlbl.Name = "healthNumlbl";
            healthNumlbl.Size = new Size(28, 21);
            healthNumlbl.TabIndex = 3;
            healthNumlbl.Text = "50";
            // 
            // moneylbl
            // 
            moneylbl.AutoSize = true;
            moneylbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moneylbl.ForeColor = Color.FromArgb(0, 192, 0);
            moneylbl.Location = new Point(34, 54);
            moneylbl.Name = "moneylbl";
            moneylbl.Size = new Size(67, 21);
            moneylbl.TabIndex = 4;
            moneylbl.Text = "Money:";
            // 
            // moneyNumlbl
            // 
            moneyNumlbl.AutoSize = true;
            moneyNumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moneyNumlbl.ForeColor = Color.FromArgb(0, 192, 0);
            moneyNumlbl.Location = new Point(105, 54);
            moneyNumlbl.Name = "moneyNumlbl";
            moneyNumlbl.Size = new Size(19, 21);
            moneyNumlbl.TabIndex = 5;
            moneyNumlbl.Text = "0";
            // 
            // walkbtn
            // 
            walkbtn.AutoSize = true;
            walkbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            walkbtn.ForeColor = Color.Blue;
            walkbtn.Location = new Point(294, 212);
            walkbtn.Name = "walkbtn";
            walkbtn.Size = new Size(75, 35);
            walkbtn.TabIndex = 6;
            walkbtn.Text = "Walk";
            walkbtn.UseVisualStyleBackColor = true;
            walkbtn.Click += walkbtn_Click;
            // 
            // stepslbl
            // 
            stepslbl.AutoSize = true;
            stepslbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stepslbl.ForeColor = Color.Fuchsia;
            stepslbl.Location = new Point(34, 85);
            stepslbl.Name = "stepslbl";
            stepslbl.Size = new Size(55, 21);
            stepslbl.TabIndex = 7;
            stepslbl.Text = "Steps:";
            // 
            // stepsCountlbl
            // 
            stepsCountlbl.AutoSize = true;
            stepsCountlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stepsCountlbl.ForeColor = Color.Fuchsia;
            stepsCountlbl.Location = new Point(105, 85);
            stepsCountlbl.Name = "stepsCountlbl";
            stepsCountlbl.Size = new Size(19, 21);
            stepsCountlbl.TabIndex = 8;
            stepsCountlbl.Text = "0";
            // 
            // checknumlbl
            // 
            checknumlbl.AutoSize = true;
            checknumlbl.Location = new Point(310, 150);
            checknumlbl.Name = "checknumlbl";
            checknumlbl.Size = new Size(32, 15);
            checknumlbl.TabIndex = 9;
            checknumlbl.Text = "num";
            // 
            // AdventureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(checknumlbl);
            Controls.Add(stepsCountlbl);
            Controls.Add(stepslbl);
            Controls.Add(walkbtn);
            Controls.Add(moneyNumlbl);
            Controls.Add(moneylbl);
            Controls.Add(healthNumlbl);
            Controls.Add(healthlbl);
            Controls.Add(btnInventory);
            Controls.Add(btnExitGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdventureForm";
            Text = "Adventure Game";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Button btnExitGame;
        private Button btnInventory;
        private Label healthlbl;
        private Label healthNumlbl;
        private Label moneylbl;
        private Label moneyNumlbl;
        private Button walkbtn;
        private Label stepslbl;
        private Label stepsCountlbl;
        private Label checknumlbl;
    }
}
