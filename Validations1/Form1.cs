using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validations1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = new Regex(@"^\d\d$");
            var b = r.IsMatch("0136");
            var arr = r.Matches("0136");
            var match = r.Match("0136");

            var student = new Student();
            if (!txtFirstName.Text.IsValidName()) MessageBox.Show("Fisrt name not valid!!");


            student.FirstName = txtFirstName.Text;
        }
    }
}
