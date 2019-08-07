﻿using COMP123___S2019___ASSIGNMENT_5___ANDRE.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123___S2019___ASSIGNMENT_5___ANDRE.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new ProductModel())
            {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
                db.Dispose();
            }
            NextButton.Enabled = false;
        }

        private void ProdutDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Program.product.productID = short.Parse(ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
            Program.product.manufacturer = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();
            Program.product.condition = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[14].Value.ToString();
            Program.product.platform = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[16].Value.ToString();
            Program.product.OS = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[15].Value.ToString();
            Program.product.model = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
            Program.product.RAM_size = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[5].Value.ToString();
            Program.product.screensize = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[7].Value.ToString();
            Program.product.HDD_size = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[17].Value.ToString();
            Program.product.CPU_brand = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[10].Value.ToString();
            Program.product.CPU_number = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[13].Value.ToString();
            Program.product.GPU_Type = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[19].Value.ToString();
            Program.product.CPU_type = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[11].Value.ToString();
            Program.product.CPU_speed = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[12].Value.ToString();
            Program.product.webcam = ProductDataGridView.Rows[ProductDataGridView.CurrentCell.RowIndex].Cells[30].Value.ToString();

            NextButton.Enabled = true;
        }
    }
}
