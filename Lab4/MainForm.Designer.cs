namespace Lab4
{
    partial class MainForm
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.FileSaveButton = new System.Windows.Forms.Button();
            this.addElementButton = new System.Windows.Forms.Button();
            this.sortByAuthorNameButton = new System.Windows.Forms.Button();
            this.searchByAuthorButton = new System.Windows.Forms.Button();
            this.searchByIdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToOrderColumns = true;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(29, 83);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 29;
            this.dataTable.Size = new System.Drawing.Size(976, 647);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTable_CellMouseClick);
            this.dataTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTable_CellMouseDoubleClick);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(29, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(94, 29);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "See Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(151, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(94, 29);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Location = new System.Drawing.Point(251, 12);
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(94, 29);
            this.FileSaveButton.TabIndex = 3;
            this.FileSaveButton.Text = "Save to File";
            this.FileSaveButton.UseVisualStyleBackColor = true;
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // addElementButton
            // 
            this.addElementButton.Location = new System.Drawing.Point(911, 12);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(94, 29);
            this.addElementButton.TabIndex = 4;
            this.addElementButton.Text = "Add Data";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click_1);
            // 
            // sortByAuthorNameButton
            // 
            this.sortByAuthorNameButton.Location = new System.Drawing.Point(29, 48);
            this.sortByAuthorNameButton.Name = "sortByAuthorNameButton";
            this.sortByAuthorNameButton.Size = new System.Drawing.Size(205, 29);
            this.sortByAuthorNameButton.TabIndex = 5;
            this.sortByAuthorNameButton.Text = "Sort By Author Name (A-Z)";
            this.sortByAuthorNameButton.UseVisualStyleBackColor = true;
            this.sortByAuthorNameButton.Click += new System.EventHandler(this.sortByAuthorNameButton_Click);
            // 
            // searchByAuthorButton
            // 
            this.searchByAuthorButton.Location = new System.Drawing.Point(240, 48);
            this.searchByAuthorButton.Name = "searchByAuthorButton";
            this.searchByAuthorButton.Size = new System.Drawing.Size(148, 29);
            this.searchByAuthorButton.TabIndex = 6;
            this.searchByAuthorButton.Text = "Search By Author";
            this.searchByAuthorButton.UseVisualStyleBackColor = true;
            this.searchByAuthorButton.Click += new System.EventHandler(this.searchByFacultyButton_Click);
            // 
            // searchByIdButton
            // 
            this.searchByIdButton.Location = new System.Drawing.Point(394, 48);
            this.searchByIdButton.Name = "searchByIdButton";
            this.searchByIdButton.Size = new System.Drawing.Size(137, 29);
            this.searchByIdButton.TabIndex = 7;
            this.searchByIdButton.Text = "Search by id";
            this.searchByIdButton.UseVisualStyleBackColor = true;
            this.searchByIdButton.Click += new System.EventHandler(this.searchByIdButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 763);
            this.Controls.Add(this.searchByIdButton);
            this.Controls.Add(this.searchByAuthorButton);
            this.Controls.Add(this.sortByAuthorNameButton);
            this.Controls.Add(this.addElementButton);
            this.Controls.Add(this.FileSaveButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.dataTable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP Lab 4 by Danylo Algin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataTable;
        private Button InfoButton;
        private Button ImportButton;
        private Button FileSaveButton;
        private Button addElementButton;
        private Button sortByAuthorNameButton;
        private Button searchByAuthorButton;
        private Button searchByIdButton;
    }
}