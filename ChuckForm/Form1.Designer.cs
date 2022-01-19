
namespace ChuckForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getJokeBtn
            // 
            this.getJokeBtn.Location = new System.Drawing.Point(218, 72);
            this.getJokeBtn.Name = "getJokeBtn";
            this.getJokeBtn.Size = new System.Drawing.Size(176, 34);
            this.getJokeBtn.TabIndex = 0;
            this.getJokeBtn.Text = "More memes m9";
            this.getJokeBtn.UseVisualStyleBackColor = true;
            this.getJokeBtn.Click += new System.EventHandler(this.getJokeBtn_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(366, 196);
            this.jokeBox.Multiline = true;
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(214, 187);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get some memes at the button m8";
            this.jokeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 408);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.getJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getJokeBtn;
        private System.Windows.Forms.TextBox jokeBox;
    }
}

