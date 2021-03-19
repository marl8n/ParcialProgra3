using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialProgra3
{
    public partial class Form1 : Form
    {

        Library lib = new Library();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            lib.CreateLoan(
                new models.Student(
                    tbIdStudent.Text
                    ),
                new models.Book(
                    tbIdBook.Text
                    ),
                dtpLoan.Value,
                dtpReturn.Value
                );
        }
    }
}
