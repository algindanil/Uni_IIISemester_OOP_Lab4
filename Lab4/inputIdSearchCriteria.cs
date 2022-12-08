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
    public partial class inputIdSearchCriteria : Form
    {
        private MainForm form;
        public inputIdSearchCriteria(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && Helper.isInteger(textBox1.Text))
            {
                form.idSearchCriteria = int.Parse(textBox1.Text);
                this.Close();
            }
        }
    }
}
