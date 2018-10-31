namespace PerfectSquares
{
    partial class frmPerfetSquares
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
            this.nudUserChoice = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // nudUserChoice
            // 
            this.nudUserChoice.Font = new System.Drawing.Font("Impact", 15F);
            this.nudUserChoice.ForeColor = System.Drawing.Color.DarkRed;
            this.nudUserChoice.Location = new System.Drawing.Point(139, 80);
            this.nudUserChoice.Name = "nudUserChoice";
            this.nudUserChoice.Size = new System.Drawing.Size(100, 32);
            this.nudUserChoice.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkRed;
            this.btnStart.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(139, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(92, 215);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(207, 95);
            this.lstPerfectSquares.TabIndex = 2;
            // 
            // frmPerfetSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 369);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudUserChoice);
            this.Name = "frmPerfetSquares";
            this.Text = "Perfect Squares by Valeria Veverita";
            ((System.ComponentModel.ISupportInitialize)(this.nudUserChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudUserChoice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstPerfectSquares;
    }
}

