using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Policy;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private bool isCurrentProjectSaved = false;             // determines whether the current table was exported to a file
        public bool listInSortingMode = false;                      // determines whether the list is currently sorted in alphabetical order
        public bool listInAuthorSearchMode = false;
        public bool listInIdSearchMode = false;

        public BindingList<ScientificResearch> mainDataList = new BindingList<ScientificResearch>();
        public BindingList<ScientificResearch> dataListForSortingMode = new BindingList<ScientificResearch>();

        public string authorSearchCriteria { get; set; }
        public int idSearchCriteria { get; set; }

        public MainForm()
        {
            InitializeComponent();
            dataTable.DataSource = mainDataList;
            
            dataTable.ReadOnly = true;
        }

        public void AddItemToTable(ScientificResearch research) // Just adds an item to the BindingList so that it can remain private
        {
            this.mainDataList.Add(research);
            if (listInAuthorSearchMode && research.AuthorName == authorSearchCriteria)
            {
                this.dataListForSortingMode.Add(research);
            }

            if (listInSortingMode)
            {
                List<ScientificResearch> sortedList = Helper.sortMainList(mainDataList);
                dataListForSortingMode.Clear();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    dataListForSortingMode.Add(sortedList[i]);
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e) // Displays info
        {
            InfoForm info = new InfoForm();
            info.ShowDialog();
        }

        private void addElementButton_Click_1(object sender, EventArgs e) // Manual addition to the current table
        {
            InputForm inputForm = new InputForm(this);
            inputForm.ShowDialog();
        }

        private void ImportButton_Click(object sender, EventArgs e) // Imports & deserializes a new table from a .json file 
        {
            if (!isCurrentProjectSaved && mainDataList.Count > 0)
            {
                DialogResult res = MessageBox.Show("Поточну таблицю буде знищено після відкриття нового файлу! Бажаєте її зберегти?", "Увага",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Helper.SaveFile(mainDataList);
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                List<ScientificResearch> list = Helper.GetObjectsListFromJsonFile(fs);
                if (list.Count > 0) // If the json file was faulty or empty, the previous table remains in place & is not wiped
                {
                    mainDataList.Clear();
                    foreach(var sr in list)
                    {
                        mainDataList.Add(sr);
                    }
                    isCurrentProjectSaved = true;
                }
            }
            else
            {
                MessageBox.Show("Error! Couldn't Deserialize the .json File. Please Choose a Valid Data Set");
            }
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            Helper.SaveFile(mainDataList);
            isCurrentProjectSaved = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainDataList.ListChanged += MainDataList_ListChanged;
            dataListForSortingMode.ListChanged += DataListForSortingMode_ListChanged;
        }

        private void MainDataList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            isCurrentProjectSaved = false;

        }

        private void DataListForSortingMode_ListChanged(object? sender, ListChangedEventArgs e)
        {
            isCurrentProjectSaved = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isCurrentProjectSaved && mainDataList.Count > 0)
            {
                DialogResult res = MessageBox.Show("Поточну таблицю буде знищено після відкриття нового файлу! Бажаєте її зберегти?", "Увага",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    Helper.SaveFile(mainDataList);
                }
            }
        }

        private void dataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(listInSortingMode || listInAuthorSearchMode || listInIdSearchMode))
            {
                if (e.Button == MouseButtons.Right)
                {
                    int index = e.RowIndex;
                    if (index >= 0)
                    {
                        mainDataList.RemoveAt(index);
                    }
                }
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    int index = e.RowIndex;
                    if (index >= 0)
                    {
                        int deletedItemId = dataListForSortingMode[e.RowIndex].id;
                        for (int i = 0; i < mainDataList.Count; i++)
                        {
                            if (mainDataList[i].id == deletedItemId)
                            {
                                mainDataList.RemoveAt(i);
                            }
                        }
                        dataListForSortingMode.RemoveAt(index);
                    }
                }
            }
        }

        private void dataTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(listInSortingMode || listInAuthorSearchMode || listInIdSearchMode))
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != 0)
                {
                    EditForm edit = new EditForm(this, e.RowIndex, e.ColumnIndex);
                    edit.ShowDialog();
                }
            }
            else
            {
                EditForm edit = new EditForm(this, e.RowIndex, e.ColumnIndex);
                edit.ShowDialog();

                int editedItemId = dataListForSortingMode[e.RowIndex].id;
                for (int i = 0; i < mainDataList.Count; i++)
                {
                    if (mainDataList[i].id == editedItemId)
                    {
                        switch (e.ColumnIndex)
                        {
                            case 1:
                                mainDataList[i].AuthorName = dataListForSortingMode[e.RowIndex].AuthorName;
                                break;
                            case 2:
                                mainDataList[i].Faculty = dataListForSortingMode[e.RowIndex].Faculty;
                                break;
                            case 3:
                                mainDataList[i].FacultyDepartament = dataListForSortingMode[e.RowIndex].FacultyDepartament;
                                break;
                            case 4:
                                mainDataList[i].FacultyBranch = dataListForSortingMode[e.RowIndex].FacultyBranch;
                                break;
                            case 5:
                                mainDataList[i].Departament = dataListForSortingMode[e.RowIndex].Departament;
                                break;
                            case 6:
                                mainDataList[i].Laboratory = dataListForSortingMode[e.RowIndex].Laboratory;
                                break;
                            case 7:
                                mainDataList[i].Post = dataListForSortingMode[e.RowIndex].Post;
                                break;
                            case 8:
                                mainDataList[i].ResearchTitle = dataListForSortingMode[e.RowIndex].ResearchTitle;
                                break;
                            case 9:
                                mainDataList[i].Customer = dataListForSortingMode[e.RowIndex].Customer;
                                break;
                            case 10:
                                mainDataList[i].CustomerAddress = dataListForSortingMode[e.RowIndex].CustomerAddress;
                                break;
                            case 11:
                                mainDataList[i].CustomerAuthority = dataListForSortingMode[e.RowIndex].CustomerAuthority;
                                break;
                            case 12:
                                mainDataList[i].CustomerFieldOfOperations = dataListForSortingMode[e.RowIndex].CustomerFieldOfOperations;
                                break;
                        }
                    }
                }
            }
        }

        private void sortByAuthorNameButton_Click(object sender, EventArgs e)
        {
            if (!listInSortingMode)
            {
                List<ScientificResearch> sortedList = Helper.sortMainList(mainDataList);
                listInSortingMode = true;
                sortByAuthorNameButton.Text = "Unsort";

                dataListForSortingMode.Clear();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    dataListForSortingMode.Add(sortedList[i]);
                }

                dataTable.DataSource = dataListForSortingMode;
            }
            else
            {
                dataTable.DataSource = mainDataList;
                listInSortingMode = false;
                sortByAuthorNameButton.Text = "Sort By Author Name (A-Z)";
            }
        }

        private void searchByFacultyButton_Click(object sender, EventArgs e)
        {
            if (!listInAuthorSearchMode)
            {
                var form = new inputSearchCriteria(this);
                form.ShowDialog();
                List<ScientificResearch> sortedList = Helper.searchByAuthor(mainDataList, authorSearchCriteria);
                listInAuthorSearchMode = true;
                searchByAuthorButton.Text = "Back to Original List";

                dataListForSortingMode.Clear();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    dataListForSortingMode.Add(sortedList[i]);
                }

                dataTable.DataSource = dataListForSortingMode;
            }
            else
            {
                dataTable.DataSource = mainDataList;
                listInAuthorSearchMode = false;
                searchByAuthorButton.Text = "Search by Author Name";
            }
        }

        private void searchByIdButton_Click(object sender, EventArgs e)
        {
            if (!listInIdSearchMode)
            {
                var form = new inputIdSearchCriteria(this);
                form.ShowDialog();
                List<ScientificResearch> sortedList = Helper.searchById(mainDataList, idSearchCriteria);
                listInIdSearchMode = true;
                searchByIdButton.Text = "Back to Original List";

                dataListForSortingMode.Clear();
                for (int i = 0; i < sortedList.Count; i++)
                {
                    dataListForSortingMode.Add(sortedList[i]);
                }

                dataTable.DataSource = dataListForSortingMode;
            }
            else
            {
                dataTable.DataSource = mainDataList;
                listInIdSearchMode = false;
                searchByIdButton.Text = "Search by id";
            }
        }

       
    }
}