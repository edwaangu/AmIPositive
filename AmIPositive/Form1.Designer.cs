
namespace AmIPositive
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
            this.inputAnIntegerLabel = new System.Windows.Forms.Label();
            this.negativeNumberOutput = new System.Windows.Forms.Label();
            this.divisibleBy7Output = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputAnIntegerLabel
            // 
            this.inputAnIntegerLabel.AutoSize = true;
            this.inputAnIntegerLabel.Location = new System.Drawing.Point(49, 50);
            this.inputAnIntegerLabel.Name = "inputAnIntegerLabel";
            this.inputAnIntegerLabel.Size = new System.Drawing.Size(81, 13);
            this.inputAnIntegerLabel.TabIndex = 0;
            this.inputAnIntegerLabel.Text = "Input an integer";
            // 
            // negativeNumberOutput
            // 
            this.negativeNumberOutput.AutoSize = true;
            this.negativeNumberOutput.Location = new System.Drawing.Point(49, 159);
            this.negativeNumberOutput.Name = "negativeNumberOutput";
            this.negativeNumberOutput.Size = new System.Drawing.Size(0, 13);
            this.negativeNumberOutput.TabIndex = 1;
            // 
            // divisibleBy7Output
            // 
            this.divisibleBy7Output.AutoSize = true;
            this.divisibleBy7Output.Location = new System.Drawing.Point(49, 206);
            this.divisibleBy7Output.Name = "divisibleBy7Output";
            this.divisibleBy7Output.Size = new System.Drawing.Size(0, 13);
            this.divisibleBy7Output.TabIndex = 2;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(216, 47);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(65, 20);
            this.inputBox.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(216, 86);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(65, 40);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.divisibleBy7Output);
            this.Controls.Add(this.negativeNumberOutput);
            this.Controls.Add(this.inputAnIntegerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputAnIntegerLabel;
        private System.Windows.Forms.Label negativeNumberOutput;
        private System.Windows.Forms.Label divisibleBy7Output;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButton;
    }
}

