using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public Image ProductImage
        {
            get { return pictureBoxProduct.Image; }
            set { pictureBoxProduct.Image = value; }
        }

        public string ProductCategory
        {
            get { return lblCategory.Text; }
            set { lblCategory.Text = "Category: " + value; }
        }

        public bool IsExpiring
        {
            set { lblWarning.Text = value ? "# About to expire!" : ""; }
        }
    }

}
