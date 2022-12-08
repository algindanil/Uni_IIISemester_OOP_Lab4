using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Lab4
{
    public class ScientificResearch
    {
        [JsonIgnore]
        private static int counter = 0;
        [JsonIgnore]
        public int id { get; }
        public string AuthorName { get; set; }
        public string Faculty { get; set; }
        public string FacultyDepartament { get; set; }
        public string FacultyBranch { get; set; }
        public string Departament { get; set; }
        public string Laboratory { get; set; }
        public string Post { get; set; }
        public string ResearchTitle { get; set; }
        public string Customer { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAuthority { get; set; }
        public string CustomerFieldOfOperations { get; set; }

        public ScientificResearch()
        {
            AuthorName = "";
            Faculty = "";
            FacultyDepartament = "";
            FacultyBranch = "";
            Departament = "";
            Laboratory = "";
            Post = "";
            ResearchTitle = "";
            Customer = "";
            CustomerAddress = "";
            CustomerAuthority = "";
            CustomerFieldOfOperations = "";
            id = ScientificResearch.counter++;
        }

        public ScientificResearch(string authorName, string faculty, string facultyDepartament, string facultyBranch, string departament, string laboratory, string post, DateTime postStartDate, DateTime postEndDate, string researchTitle, string customer, string customerAddress, string customerAuthority, string customerFieldOfOperations)
        {
            AuthorName = authorName;
            Faculty = faculty;
            FacultyDepartament = facultyDepartament;
            FacultyBranch = facultyBranch;
            Departament = departament;
            Laboratory = laboratory;
            Post = post + " (" + postStartDate.ToString() + " - " + postEndDate.ToString() + ")";
            ResearchTitle = researchTitle;
            Customer = customer;
            CustomerAddress = customerAddress;
            CustomerAuthority = customerAuthority;
            CustomerFieldOfOperations = customerFieldOfOperations;
            id = ScientificResearch.counter++;
        }

        public ScientificResearch(string authorName, string faculty, string facultyDepartament, string facultyBranch, string departament, string laboratory, string post, string researchTitle, string customer, string customerAddress, string customerAuthority, string customerFieldOfOperations)
        {
            AuthorName = authorName;
            Faculty = faculty;
            FacultyDepartament = facultyDepartament;
            FacultyBranch = facultyBranch;
            Departament = departament;
            Laboratory = laboratory;
            Post = post;
            ResearchTitle = researchTitle;
            Customer = customer;
            CustomerAddress = customerAddress;
            CustomerAuthority = customerAuthority;
            CustomerFieldOfOperations = customerFieldOfOperations;
            id = ScientificResearch.counter++;
        }

        public static string GeneratePost(string post, DateTime entry, DateTime departure)
        {
            return post + " (" + entry.ToString("dd-mm-yyyy") + " - " + departure.ToString("dd-mm-yyyy") + ")";
        }
    }
}
