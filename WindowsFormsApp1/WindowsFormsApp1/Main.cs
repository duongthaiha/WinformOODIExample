using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private readonly DatabaseOperations _databaseOperations;

        public Main()
        {
            InitializeComponent();
        }

        public Main(DatabaseOperations databaseOperations) : this()
        {
            _databaseOperations = databaseOperations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _databaseOperations.AddOperation();
        }
    }
}
