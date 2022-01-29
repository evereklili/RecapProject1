using System;
using System.Linq;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load eventine gideriz. bu bir eventter. biz ona kayıt oluyoruz 
            //orname dapar, adonet kütüphanesi, kullanılsa  da ben entityframework kullanacağım. 
            ListCategories();
            NewMethod();
        }

        private void NewMethod()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();

            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";

            }
        }

        private void ListProducsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToString();
            }
        }

        private void gbxCategory_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {

                ListProducsByCategory(Convert.ToInt16(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }
    }
}
