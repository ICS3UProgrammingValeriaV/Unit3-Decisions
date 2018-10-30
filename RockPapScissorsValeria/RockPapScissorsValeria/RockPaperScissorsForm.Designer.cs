namespace RockPapScissorsValeria
{
    partial class frmRockPaperScissors
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.radScissorsUser = new System.Windows.Forms.RadioButton();
            this.radPaperUser = new System.Windows.Forms.RadioButton();
            this.radRockUser = new System.Windows.Forms.RadioButton();
            this.lblUserPoints = new System.Windows.Forms.Label();
            this.grbCompChoice = new System.Windows.Forms.GroupBox();
            this.lblCompPoints = new System.Windows.Forms.Label();
            this.radScissorsComp = new System.Windows.Forms.RadioButton();
            this.radPaperComp = new System.Windows.Forms.RadioButton();
            this.radRockComp = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbUser.SuspendLayout();
            this.grbCompChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.CausesValidation = false;
            this.grbUser.Controls.Add(this.lblUserPoints);
            this.grbUser.Controls.Add(this.radScissorsUser);
            this.grbUser.Controls.Add(this.radPaperUser);
            this.grbUser.Controls.Add(this.radRockUser);
            this.grbUser.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbUser.Location = new System.Drawing.Point(12, 12);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(182, 393);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "     User\'s Choice";
            this.grbUser.Enter += new System.EventHandler(this.grbUser_Enter);
            // 
            // radScissorsUser
            // 
            this.radScissorsUser.AutoSize = true;
            this.radScissorsUser.Image = global::RockPapScissorsValeria.Properties.Resources.Scissors;
            this.radScissorsUser.Location = new System.Drawing.Point(29, 285);
            this.radScissorsUser.Name = "radScissorsUser";
            this.radScissorsUser.Size = new System.Drawing.Size(114, 100);
            this.radScissorsUser.TabIndex = 2;
            this.radScissorsUser.TabStop = true;
            this.radScissorsUser.UseVisualStyleBackColor = true;
            this.radScissorsUser.CheckedChanged += new System.EventHandler(this.radScissorsUser_CheckedChanged);
            // 
            // radPaperUser
            // 
            this.radPaperUser.AutoSize = true;
            this.radPaperUser.Image = global::RockPapScissorsValeria.Properties.Resources.paper;
            this.radPaperUser.Location = new System.Drawing.Point(29, 179);
            this.radPaperUser.Name = "radPaperUser";
            this.radPaperUser.Size = new System.Drawing.Size(114, 100);
            this.radPaperUser.TabIndex = 1;
            this.radPaperUser.TabStop = true;
            this.radPaperUser.UseVisualStyleBackColor = true;
            this.radPaperUser.CheckedChanged += new System.EventHandler(this.radPaperUser_CheckedChanged);
            // 
            // radRockUser
            // 
            this.radRockUser.AutoSize = true;
            this.radRockUser.Image = global::RockPapScissorsValeria.Properties.Resources.rock3;
            this.radRockUser.Location = new System.Drawing.Point(29, 73);
            this.radRockUser.Name = "radRockUser";
            this.radRockUser.Size = new System.Drawing.Size(114, 100);
            this.radRockUser.TabIndex = 0;
            this.radRockUser.TabStop = true;
            this.radRockUser.UseVisualStyleBackColor = true;
            this.radRockUser.CheckedChanged += new System.EventHandler(this.radRockUser_CheckedChanged);
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserPoints.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUserPoints.Location = new System.Drawing.Point(52, 38);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(66, 25);
            this.lblUserPoints.TabIndex = 3;
            this.lblUserPoints.Text = "Points:";
            // 
            // grbCompChoice
            // 
            this.grbCompChoice.Controls.Add(this.lblCompPoints);
            this.grbCompChoice.Controls.Add(this.radScissorsComp);
            this.grbCompChoice.Controls.Add(this.radPaperComp);
            this.grbCompChoice.Controls.Add(this.radRockComp);
            this.grbCompChoice.Enabled = false;
            this.grbCompChoice.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbCompChoice.Location = new System.Drawing.Point(211, 12);
            this.grbCompChoice.Name = "grbCompChoice";
            this.grbCompChoice.Size = new System.Drawing.Size(231, 393);
            this.grbCompChoice.TabIndex = 4;
            this.grbCompChoice.TabStop = false;
            this.grbCompChoice.Text = "     Computer\'s Choice";
            // 
            // lblCompPoints
            // 
            this.lblCompPoints.AutoSize = true;
            this.lblCompPoints.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompPoints.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCompPoints.Location = new System.Drawing.Point(90, 38);
            this.lblCompPoints.Name = "lblCompPoints";
            this.lblCompPoints.Size = new System.Drawing.Size(66, 25);
            this.lblCompPoints.TabIndex = 3;
            this.lblCompPoints.Text = "Points:";
            // 
            // radScissorsComp
            // 
            this.radScissorsComp.AutoSize = true;
            this.radScissorsComp.Image = global::RockPapScissorsValeria.Properties.Resources.Scissors;
            this.radScissorsComp.Location = new System.Drawing.Point(64, 285);
            this.radScissorsComp.Name = "radScissorsComp";
            this.radScissorsComp.Size = new System.Drawing.Size(114, 100);
            this.radScissorsComp.TabIndex = 2;
            this.radScissorsComp.TabStop = true;
            this.radScissorsComp.UseVisualStyleBackColor = true;
            // 
            // radPaperComp
            // 
            this.radPaperComp.AutoSize = true;
            this.radPaperComp.Image = global::RockPapScissorsValeria.Properties.Resources.paper;
            this.radPaperComp.Location = new System.Drawing.Point(64, 179);
            this.radPaperComp.Name = "radPaperComp";
            this.radPaperComp.Size = new System.Drawing.Size(114, 100);
            this.radPaperComp.TabIndex = 1;
            this.radPaperComp.TabStop = true;
            this.radPaperComp.UseVisualStyleBackColor = true;
            // 
            // radRockComp
            // 
            this.radRockComp.AutoSize = true;
            this.radRockComp.Image = global::RockPapScissorsValeria.Properties.Resources.rock3;
            this.radRockComp.Location = new System.Drawing.Point(64, 73);
            this.radRockComp.Name = "radRockComp";
            this.radRockComp.Size = new System.Drawing.Size(114, 100);
            this.radRockComp.TabIndex = 0;
            this.radRockComp.TabStop = true;
            this.radRockComp.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(175, 411);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 50);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(465, 482);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbCompChoice);
            this.Controls.Add(this.grbUser);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors by Valeria V";
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbCompChoice.ResumeLayout(false);
            this.grbCompChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.RadioButton radRockUser;
        private System.Windows.Forms.RadioButton radPaperUser;
        private System.Windows.Forms.RadioButton radScissorsUser;
        private System.Windows.Forms.Label lblUserPoints;
        private System.Windows.Forms.GroupBox grbCompChoice;
        private System.Windows.Forms.Label lblCompPoints;
        private System.Windows.Forms.RadioButton radScissorsComp;
        private System.Windows.Forms.RadioButton radPaperComp;
        private System.Windows.Forms.RadioButton radRockComp;
        private System.Windows.Forms.Button btnPlay;
    }
}

