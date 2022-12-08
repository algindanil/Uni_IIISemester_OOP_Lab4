using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.ComponentModel;

namespace Lab4
{
    public class Helper
    {
        public static bool isInteger(string valueToTest)
        {
            return int.TryParse(valueToTest, out int n);
        } 

        public static bool isDouble(string valueToTest)
        {
            return (double.TryParse(valueToTest, out double d) && !Double.IsNaN(d) && !Double.IsInfinity(d));
        }

        public static bool isValidDateTime(string valueToTest)
        {
            return DateTime.TryParse(valueToTest, out DateTime d);
        } 

        public static List<ScientificResearch> GetObjectsListFromJsonFile(FileStream filename) // For convenient deserialization
        {

            List<ScientificResearch> researches = new List<ScientificResearch>();

            try
            {
                researches = JsonSerializer.Deserialize<List<ScientificResearch>>(filename);
            }
            catch (JsonException)
            {
                MessageBox.Show("Error! Couldn't Deserialize the .json File. Please Choose a Valid Data Set");
            }
            //researches = JsonSerializer.Deserialize<List<ScientificResearch>>(filename);

            return researches;
        }

        public static void SaveFile(BindingList<ScientificResearch> mainDataList)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.FileName = "Scientific Researches Table";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fs);
                Helper.SerializeIntoFile(sw, mainDataList);

                fs.Close();
                sw.Close();
            }
        }

        public static void SerializeIntoFile(StreamWriter sw, BindingList<ScientificResearch> list)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };

            foreach(ScientificResearch sr in list)
            {
                sw.Write(JsonSerializer.Serialize<ScientificResearch>(sr, options));
            }
            sw.Flush();
            sw.Close();
        }

        public static List<ScientificResearch> sortMainList(BindingList<ScientificResearch> list)
        {
            
            var sortedList = (from obj in list
                              orderby obj.AuthorName ascending
                              select obj).ToList<ScientificResearch>();
            return sortedList;
        }

        public static List<ScientificResearch> searchByAuthor(BindingList<ScientificResearch> list, string criteria)
        {
            var sortedList = (from obj in list
                              where (obj.AuthorName == criteria)
                              select obj).ToList();
            return sortedList;
        }

        public static List<ScientificResearch> searchById(BindingList<ScientificResearch> list, int criteria)
        {
            var sortedList = (from obj in list
                              where (obj.id == criteria)
                              select obj).ToList();
            return sortedList;
        }
    }
}
