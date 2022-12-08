using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class InputForm : Form
    {
        private string[] instructions = { "Enter Faculty", "Enter the Faculty Departament",
            "Enter the Faculty Branch", "Enter Departament", "Enter Laboratory", "Enter the Post", "Enter the Office Entry Date",
            "Enter the Office Departure Date", "Enter the Research Title", "Enter the Customer's Name", 
            "Enter the Customer's Address", "Enter the Customer's Authority", "Enter the Customer's Field of Operations"
        };

        private int counter = 0; // To navigate through instructions & fields 

        private DateTime entry; 

        private DateTime departure;

        private string post;

        private ScientificResearch research = new ScientificResearch(); 

        private MainForm mainform;
        public InputForm(MainForm form)
        {
            InitializeComponent();
            this.mainform = form;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    if (inputBox.Text != "")
                    {
                        research.AuthorName = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 1:
                    if (inputBox.Text != "")
                    {
                        research.Faculty = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 2:
                    if (inputBox.Text != "")
                    {
                        research.FacultyDepartament = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 3:
                    if (inputBox.Text != "")
                    {
                        research.FacultyBranch = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 4:
                    if (inputBox.Text != "")
                    {
                        research.Departament = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 5:
                    if (inputBox.Text != "")
                    {
                        research.Laboratory = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 6:
                    if (inputBox.Text != "")
                    {
                        post = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 7:
                    if (Helper.isValidDateTime(inputBox.Text))
                    {
                        entry = DateTime.Parse(inputBox.Text);
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                        break;
                    }
                    break;
                case 8:
                    if (Helper.isValidDateTime(inputBox.Text))
                    {
                        departure = DateTime.Parse(inputBox.Text);
                        research.Post = ScientificResearch.GeneratePost(post, entry, departure);
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                        break;
                    }
                    break;
                case 9:
                    if (inputBox.Text != "")
                    {
                        research.ResearchTitle = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 10:
                    if (inputBox.Text != "")
                    {
                        research.Customer = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 11:
                    if (inputBox.Text != "")
                    {
                        research.CustomerAddress = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 12:
                    if (inputBox.Text != "")
                    {
                        research.CustomerAuthority = inputBox.Text;
                        inputBox.Clear();
                        instructionsLabel.Text = instructions[counter++];
                    }
                    break;
                case 13:
                    if (inputBox.Text != "")
                    {
                        research.CustomerFieldOfOperations = inputBox.Text;
                        mainform.AddItemToTable(research);
                        this.Close();
                    }
                    break;
            }
        }
    }
}
