using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class EditForm : Form
    {
        private MainForm mainForm;
        private int rowIndex;
        private int columnIndex;
        public EditForm(MainForm f, int row, int column)
        {
            InitializeComponent();
            mainForm = f;
            rowIndex = row;
            columnIndex = column;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!mainForm.listInSortingMode)
            {
                switch (columnIndex)
                {
                    case 1:
                        mainForm.mainDataList[rowIndex].AuthorName = inputBox.Text;
                        break;
                    case 2:
                        mainForm.mainDataList[rowIndex].Faculty = inputBox.Text;
                        break;
                    case 3:
                        mainForm.mainDataList[rowIndex].FacultyDepartament = inputBox.Text;
                        break;
                    case 4:
                        mainForm.mainDataList[rowIndex].FacultyBranch = inputBox.Text;
                        break;
                    case 5:
                        mainForm.mainDataList[rowIndex].Departament = inputBox.Text;
                        break;
                    case 6:
                        mainForm.mainDataList[rowIndex].Laboratory = inputBox.Text;
                        break;
                    case 7:
                        mainForm.mainDataList[rowIndex].Post = inputBox.Text;
                        break;
                    case 8:
                        mainForm.mainDataList[rowIndex].ResearchTitle = inputBox.Text;
                        break;
                    case 9:
                        mainForm.mainDataList[rowIndex].Customer = inputBox.Text;
                        break;
                    case 10:
                        mainForm.mainDataList[rowIndex].CustomerAddress = inputBox.Text;
                        break;
                    case 11:
                        mainForm.mainDataList[rowIndex].CustomerAuthority = inputBox.Text;
                        break;
                    case 12:
                        mainForm.mainDataList[rowIndex].CustomerFieldOfOperations = inputBox.Text;
                        break;
                }
            }
            else
            {
                switch (columnIndex)
                {
                    case 1:
                        mainForm.dataListForSortingMode[rowIndex].AuthorName = inputBox.Text;
                        break;
                    case 2:
                        mainForm.dataListForSortingMode[rowIndex].Faculty = inputBox.Text;
                        break;
                    case 3:
                        mainForm.dataListForSortingMode[rowIndex].FacultyDepartament = inputBox.Text;
                        break;
                    case 4:
                        mainForm.dataListForSortingMode[rowIndex].FacultyBranch = inputBox.Text;
                        break;
                    case 5:
                        mainForm.dataListForSortingMode[rowIndex].Departament = inputBox.Text;
                        break;
                    case 6:
                        mainForm.dataListForSortingMode[rowIndex].Laboratory = inputBox.Text;
                        break;
                    case 7:
                        mainForm.dataListForSortingMode[rowIndex].Post = inputBox.Text;
                        break;
                    case 8:
                        mainForm.dataListForSortingMode[rowIndex].ResearchTitle = inputBox.Text;
                        break;
                    case 9:
                        mainForm.dataListForSortingMode[rowIndex].Customer = inputBox.Text;
                        break;
                    case 10:
                        mainForm.dataListForSortingMode[rowIndex].CustomerAddress = inputBox.Text;
                        break;
                    case 11:
                        mainForm.dataListForSortingMode[rowIndex].CustomerAuthority = inputBox.Text;
                        break;
                    case 12:
                        mainForm.dataListForSortingMode[rowIndex].CustomerFieldOfOperations = inputBox.Text;
                        break;
                }
            }
            this.Close();
        }

        
    }
}
