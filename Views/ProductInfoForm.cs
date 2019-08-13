using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        public void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductInfoOpenFileDialog.FileName = "ProductInfo.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open the  streawm for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductInfoOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
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


                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductInfoSaveFileDialog.FileName = "ProductInfo.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductInfoSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write content - string type - to the file
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.cost.ToString());
                    outputStream.WriteLine(Program.product.manufacturer.ToString());
                    outputStream.WriteLine(Program.product.condition.ToString());
                    outputStream.WriteLine(Program.product.platform.ToString());
                    outputStream.WriteLine(Program.product.OS.ToString());
                    outputStream.WriteLine(Program.product.model.ToString());
                    outputStream.WriteLine(Program.product.RAM_size.ToString());
                    outputStream.WriteLine(Program.product.screensize.ToString());
                    outputStream.WriteLine(Program.product.HDD_size.ToString());
                    outputStream.WriteLine(Program.product.CPU_brand.ToString());
                    outputStream.WriteLine(Program.product.CPU_number.ToString());
                    outputStream.WriteLine(Program.product.GPU_Type.ToString());
                    outputStream.WriteLine(Program.product.CPU_type.ToString());
                    outputStream.WriteLine(Program.product.CPU_speed.ToString());
                    outputStream.WriteLine(Program.product.webcam.ToString());

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
