namespace ProductManagmentSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnShowAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            dataGridViewProducts = new DataGridView();
            btnAddProduct = new Button();
            btnSearchProduct = new Button();
            btnShowAll = new Button();
            nameLabel = new Label();
            priceLabel = new Label();
            categoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(326, 14);
            nameTextBox.Margin = new Padding(4, 3, 4, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(233, 23);
            nameTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(326, 56);
            priceTextBox.Margin = new Padding(4, 3, 4, 3);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(233, 23);
            priceTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Location = new Point(326, 101);
            categoryComboBox.Margin = new Padding(4, 3, 4, 3);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(233, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeColumns = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Enabled = false;
            dataGridViewProducts.Location = new Point(13, 186);
            dataGridViewProducts.Margin = new Padding(4, 3, 4, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.Size = new Size(546, 231);
            dataGridViewProducts.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(13, 145);
            btnAddProduct.Margin = new Padding(4, 3, 4, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(270, 35);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(289, 145);
            btnSearchProduct.Margin = new Padding(4, 3, 4, 3);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(270, 35);
            btnSearchProduct.TabIndex = 5;
            btnSearchProduct.Text = "Buscar Producto";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(13, 423);
            btnShowAll.Margin = new Padding(4, 3, 4, 3);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(546, 35);
            btnShowAll.TabIndex = 6;
            btnShowAll.Text = "Mostrar Todos";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(13, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(178, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Ingrese el Nombre del Producto:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(13, 64);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(278, 15);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Ingrese el precio base (sin impuestos) del producto:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(13, 109);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(183, 15);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Ingrese la categoría del producto:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 471);
            Controls.Add(categoryLabel);
            Controls.Add(priceLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(categoryComboBox);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(btnSearchProduct);
            Controls.Add(btnShowAll);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label nameLabel;
        private Label priceLabel;
        private Label categoryLabel;
    }

}