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
        private const decimal _SALETAX = 0.13m;
        public OrderInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide(); 
        }
        /// <summary>
        /// This is the event handler for FinishButton_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for buying with us. \n\nYour order will be processed in the next 7-10 business days.",
                        "Order placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for ExitToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for PrintToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your form was sent to the printer", "Printing...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This is the event handler for OrderInfoForm_Activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            PriceTextBox.Text = String.Format("${0:0.00}", Program.product.cost);
            SalesTaxTextBox.Text = String.Format("${0:0.00}", (Program.product.cost * _SALETAX));
            TotalTextBox.Text = String.Format("${0:0.00}", (Program.product.cost.Value * (1 + _SALETAX)));
        }
        /// <summary>
        /// This is the event handler for AboutToolStripMenuItem1_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// This is the event handler for BackToolStripMenuItem1_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}
