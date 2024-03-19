namespace AdventureGame
{
    partial class AttackedEncounterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            attackedHealthNumlbl = new Label();
            attackedHealthlbl = new Label();
            closebtn = new Button();
            attackbtn = new Button();
            enemyHealthlbl = new Label();
            enemyHealthNumlbl = new Label();
            SuspendLayout();
            // 
            // attackedHealthNumlbl
            // 
            attackedHealthNumlbl.AutoSize = true;
            attackedHealthNumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attackedHealthNumlbl.ForeColor = Color.Red;
            attackedHealthNumlbl.Location = new Point(290, 191);
            attackedHealthNumlbl.Name = "attackedHealthNumlbl";
            attackedHealthNumlbl.Size = new Size(28, 21);
            attackedHealthNumlbl.TabIndex = 5;
            attackedHealthNumlbl.Text = "50";
            // 
            // attackedHealthlbl
            // 
            attackedHealthlbl.AutoSize = true;
            attackedHealthlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attackedHealthlbl.ForeColor = Color.Red;
            attackedHealthlbl.Location = new Point(219, 191);
            attackedHealthlbl.Name = "attackedHealthlbl";
            attackedHealthlbl.Size = new Size(65, 21);
            attackedHealthlbl.TabIndex = 4;
            attackedHealthlbl.Text = "Health:";
            // 
            // closebtn
            // 
            closebtn.AutoSize = true;
            closebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.Location = new Point(667, 393);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(75, 31);
            closebtn.TabIndex = 6;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // attackbtn
            // 
            attackbtn.AutoSize = true;
            attackbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attackbtn.ForeColor = Color.Red;
            attackbtn.Location = new Point(340, 257);
            attackbtn.Name = "attackbtn";
            attackbtn.Size = new Size(81, 31);
            attackbtn.TabIndex = 7;
            attackbtn.Text = "Attack";
            attackbtn.UseVisualStyleBackColor = true;
            attackbtn.Click += attackbtn_Click;
            // 
            // enemyHealthlbl
            // 
            enemyHealthlbl.AutoSize = true;
            enemyHealthlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enemyHealthlbl.ForeColor = Color.FromArgb(0, 192, 0);
            enemyHealthlbl.Location = new Point(421, 191);
            enemyHealthlbl.Name = "enemyHealthlbl";
            enemyHealthlbl.Size = new Size(121, 21);
            enemyHealthlbl.TabIndex = 8;
            enemyHealthlbl.Text = "Enemy Health:";
            // 
            // enemyHealthNumlbl
            // 
            enemyHealthNumlbl.AutoSize = true;
            enemyHealthNumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enemyHealthNumlbl.ForeColor = Color.FromArgb(0, 192, 0);
            enemyHealthNumlbl.Location = new Point(548, 191);
            enemyHealthNumlbl.Name = "enemyHealthNumlbl";
            enemyHealthNumlbl.Size = new Size(28, 21);
            enemyHealthNumlbl.TabIndex = 9;
            enemyHealthNumlbl.Text = "50";
            // 
            // AttackedEncounterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enemyHealthNumlbl);
            Controls.Add(enemyHealthlbl);
            Controls.Add(attackbtn);
            Controls.Add(closebtn);
            Controls.Add(attackedHealthNumlbl);
            Controls.Add(attackedHealthlbl);
            Name = "AttackedEncounterForm";
            Text = "AttackedEncounterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label attackedHealthNumlbl;
        private Label attackedHealthlbl;
        private Button closebtn;
        private Button attackbtn;
        private Label enemyHealthlbl;
        private Label enemyHealthNumlbl;
    }
}