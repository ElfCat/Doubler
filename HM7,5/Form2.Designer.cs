namespace HM7_5
{
    partial class Form2
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
            this.tBoxGuess = new System.Windows.Forms.Label();
            this.tboxAnswer = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxGuess
            // 
            this.tBoxGuess.AutoSize = true;
            this.tBoxGuess.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tBoxGuess.Location = new System.Drawing.Point(69, 61);
            this.tBoxGuess.Name = "tBoxGuess";
            this.tBoxGuess.Size = new System.Drawing.Size(397, 24);
            this.tBoxGuess.TabIndex = 0;
            this.tBoxGuess.Text = "Guess a number in the minimum number of moves";
            // 
            // tboxAnswer
            // 
            this.tboxAnswer.Enabled = false;
            this.tboxAnswer.Location = new System.Drawing.Point(181, 132);
            this.tboxAnswer.Name = "tboxAnswer";
            this.tboxAnswer.Size = new System.Drawing.Size(100, 27);
            this.tboxAnswer.TabIndex = 2;
            this.tboxAnswer.TextChanged += new System.EventHandler(this.tboxAnswer_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(194, 165);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(161, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(142, 23);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate Number";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 259);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tboxAnswer);
            this.Controls.Add(this.tBoxGuess);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.24F);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tBoxGuess;
        private System.Windows.Forms.TextBox tboxAnswer;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnGen;
    }
}