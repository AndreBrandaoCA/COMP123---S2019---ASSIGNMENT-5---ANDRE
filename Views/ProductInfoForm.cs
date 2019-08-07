using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123___S2019___ASSIGNMENT_5___ANDRE.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderInfoForm.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }


        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIdTextBox.Text = Program.product.productID.ToString();
            CostTextBox.Text = Program.product.cost.ToString();
            ManufacturerTextBox.Text = Program.product.manufacturer.ToString();
            ConditionTextBox.Text = Program.product.condition.ToString();
            PlatformTextBox.Text = Program.product.platform.ToString();
            OSTextBox.Text = Program.product.OS.ToString();
            ModelTextBox.Text = Program.product.model.ToString();
            MemoryTextBox.Text = Program.product.RAM_size.ToString();
            LCDSizeTextBox.Text = Program.product.screensize.ToString();
            HDDTextBox.Text = Program.product.HDD_size.ToString();
            CPUBrandTextBox.Text = Program.product.CPU_brand.ToString();
            CPUNumberTextBox.Text = Program.product.CPU_number.ToString();
            GPUTypeTextBox.Text = Program.product.GPU_Type.ToString();
            CPUTypeTextBox.Text = Program.product.CPU_type.ToString();
            CPUSpeedTextBox.Text = Program.product.CPU_speed.ToString();
            WebcamTextBox.Text = Program.product.webcam.ToString();
        }
    }
}
