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
            Cursor.Current = Cursors.WaitCursor;
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
                else if(Ret == -1)
                {
                    MessageBox.Show("Supplier unknown");
                }
                else if (Ret == -2)
                {
                    MessageBox.Show("Category unknown");
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
            Cursor.Current = Cursors.Default;
        }

        private void btnInsertForm_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = DataAccess.ProductDelete
                    (
                    Convert.ToInt32(txtProductIdentif.Text)
                    );
                if(Ret == 0)
                {
                    MessageBox.Show("Product deleted");
                }else if(Ret == -1)
                {
                    MessageBox.Show("Unable to delete product");
                }else if(Ret == -2)
                {
                    MessageBox.Show("Product does not exists");
                }
                else
                {
                    MessageBox.Show("Error " + Ret.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int Ret = DataAccess.ProductsUpdate
                    (
                      Convert.ToInt32(txtProductIdentif.Text)
                    , txtNaziv.Text
                    , Convert.ToInt32(txtSupplier.Text)
                    , Convert.ToInt32(txtCategory.Text)
                    , Convert.ToDecimal(txtUnitPrice.Text)
                    , chkDiscontinued.Checked
                    );
                Cursor.Current = Cursors.Default;
                if (Ret == 0)
                {
                    MessageBox.Show("Product updated!");
                }
                else if(Ret == -1)
                {
                    MessageBox.Show("Product does not exists");
                }
                else
                {
                    MessageBox.Show("Error: " + Ret.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
