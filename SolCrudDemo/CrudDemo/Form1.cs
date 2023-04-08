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
    public partial class Form1 : Form
    {
        clsDataAccess DataAccess = new clsDataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Validation
            if (txtNaziv.Text.Trim()=="")
            {
                MessageBox.Show("Enter product name");
                txtNaziv.Focus();
                return;
            }
            if (txtCategory.Text.Trim() == "")
            {
                MessageBox.Show("Enter categoryid");
                txtNaziv.Focus();

            }
            if (txtSupplier.Text.Trim() == "")
            {
                MessageBox.Show("Enter supplierid");
                txtNaziv.Focus();

            }
            if (txtUnitPrice.Text.Trim() == "")
            {
                MessageBox.Show("Enter unitprice");
                txtNaziv.Focus();

            }

            try
            {
                int Ret = DataAccess.ProductInsert
                    (
                    txtNaziv.Text
                    ,Convert.ToInt32(txtSupplier.Text)
                    ,Convert.ToInt32(txtCategory.Text)
                    ,Convert.ToDecimal(txtUnitPrice.Text)
                    ,chkDiscontinued.Checked
                    );
            
                if(Ret == 0)
                {
                    MessageBox.Show("Product added");
                }
                else
                {
                    MessageBox.Show("Error: " + Ret.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
