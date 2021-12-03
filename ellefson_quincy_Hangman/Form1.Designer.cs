
namespace ellefson_quincy_Hangman
{
    partial class Form1
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
            this.lblFeedback = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.letterGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.secretWord = new System.Windows.Forms.Label();
            this.hangmanPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(12, 108);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(164, 31);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Take a Guess!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guess a Letter:";
            // 
            // letterGuess
            // 
            this.letterGuess.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterGuess.Location = new System.Drawing.Point(194, 252);
            this.letterGuess.MaxLength = 1;
            this.letterGuess.Name = "letterGuess";
            this.letterGuess.Size = new System.Drawing.Size(100, 39);
            this.letterGuess.TabIndex = 3;
            this.letterGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(18, 296);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(129, 53);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // secretWord
            // 
            this.secretWord.AutoSize = true;
            this.secretWord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretWord.Location = new System.Drawing.Point(100, 164);
            this.secretWord.Name = "secretWord";
            this.secretWord.Size = new System.Drawing.Size(137, 31);
            this.secretWord.TabIndex = 7;
            this.secretWord.Text = "secretWord";
            // 
            // hangmanPicture
            // 
            this.hangmanPicture.Location = new System.Drawing.Point(379, 36);
            this.hangmanPicture.Name = "hangmanPicture";
            this.hangmanPicture.Size = new System.Drawing.Size(180, 274);
            this.hangmanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangmanPicture.TabIndex = 8;
            this.hangmanPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.hangmanPicture);
            this.Controls.Add(this.secretWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.letterGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFeedback);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox letterGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label secretWord;
        private System.Windows.Forms.PictureBox hangmanPicture;
    }
}

