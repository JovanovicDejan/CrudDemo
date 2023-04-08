using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDemo
{
    public partial class Form2 : Form
    {
        int custid;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int custid)
        {
            this.custid = custid;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
