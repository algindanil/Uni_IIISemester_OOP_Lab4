namespace Lab4
{
    partial class InputForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(51, 147);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(170, 29);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(51, 103);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(170, 27);
            this.inputBox.TabIndex = 1;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(51, 70);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(170, 20);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Enter the Author\'s Name";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 257);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.submitButton);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private TextBox inputBox;
        private Label instructionsLabel;
    }
}