namespace COMP123___S2019___ASSIGNMENT_5___ANDRE
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProdutDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductSelectionLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(358, 505);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(204, 44);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(568, 505);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(204, 44);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProdutDataGridView
            // 
            this.ProdutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutDataGridView.Location = new System.Drawing.Point(13, 53);
            this.ProdutDataGridView.Name = "ProdutDataGridView";
            this.ProdutDataGridView.Size = new System.Drawing.Size(759, 435);
            this.ProdutDataGridView.TabIndex = 4;
            // 
            // ProductSelectionLable
            // 
            this.ProductSelectionLable.AutoSize = true;
            this.ProductSelectionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectionLable.Location = new System.Drawing.Point(13, 13);
            this.ProductSelectionLable.Name = "ProductSelectionLable";
            this.ProductSelectionLable.Size = new System.Drawing.Size(481, 31);
            this.ProductSelectionLable.TabIndex = 5;
            this.ProductSelectionLable.Text = "Please select one product from the list:";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ProductSelectionLable);
            this.Controls.Add(this.ProdutDataGridView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Store - Select Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.DataGridView ProdutDataGridView;
        private System.Windows.Forms.Label ProductSelectionLable;
    }
}