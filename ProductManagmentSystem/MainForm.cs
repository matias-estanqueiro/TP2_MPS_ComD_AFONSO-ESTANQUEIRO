using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManagmentSystem.Services;
using ProductManagmentSystem.Models;

namespace ProductManagmentSystem
{
    public partial class MainForm : Form
    {
        private ProductManager productManager = new ProductManager();

        public MainForm()
        {
            InitializeComponent();
            categoryComboBox.Items.AddRange(new string[] { "Electrónica", "Alimentos" });
            categoryComboBox.SelectedIndex = 1;
            UpdateProductGrid();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price) && categoryComboBox.SelectedItem != null)
            {
                string category = categoryComboBox.SelectedItem.ToString();
                try
                {
                    productManager.AddProduct(name, price, category);
                    MessageBox.Show("El producto fue registrado exitosamente", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateProductGrid();
                    nameTextBox.Clear();
                    priceTextBox.Clear();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los valores ingresados no son correctos", "ERROR EN REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchName = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del producto a buscar:", "BUSCAR PRODUCTO");
            if (searchName == string.Empty) return;

            Product product = productManager.FindProductByName(searchName);
            if (product != null)
            {
                dataGridViewProducts.DataSource = new List<Product> { product };
            }
            else
            {
                MessageBox.Show("El producto no se encuentra registrado.", "ERROR EN BÚSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateProductGrid();
        }

        private void UpdateProductGrid()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productManager.GetAllProducts();
        }
    }

}
