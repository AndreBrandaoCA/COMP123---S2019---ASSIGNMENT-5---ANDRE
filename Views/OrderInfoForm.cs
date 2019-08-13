using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123___S2019___ASSIGNMENT_5___ANDRE.Views
{
    public partial class OrderInfoForm : Form
    {
        const decimal SALETAX = 0.13m;
        public OrderInfoForm()
        {
            InitializeComponent();
        }

        private void OrderInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide(); 
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying from us. \nYou will soon receive an email with detailed information about your order.",
                        "Order placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.startForm.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void OrderInfoForm_Activated(object sender, EventArgs e)
        {
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
            WebCamTextBox.Text = Program.product.webcam.ToString();
            PriceTextBox.Text = Program.product.cost.ToString();
            SalesTaxTextBox.Text = (Program.product.cost * SALETAX).ToString();
            TotalTextBox.Text = (Program.product.cost.Value * (1 + SALETAX)).ToString();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}
