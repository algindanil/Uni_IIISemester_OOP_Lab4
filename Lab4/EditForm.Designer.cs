namespace Lab4
{
    partial class EditForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(61, 86);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 29);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit Changes";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(61, 53);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(150, 27);
            this.inputBox.TabIndex = 1;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(61, 21);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(145, 20);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Input the New Value:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 155);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.submitButton);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private TextBox inputBox;
        private Label textLabel;
    }
}