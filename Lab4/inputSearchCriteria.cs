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
    public partial class inputSearchCriteria : Form
    {
        private MainForm mainform;
        public inputSearchCriteria(MainForm f)
        {
            InitializeComponent();
            mainform = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                mainform.authorSearchCriteria = textBox1.Text;
                this.Close();
            }
        }
    }
}
