namespace InventoryManagementSystem
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            dgvInventory = new DataGridView();
            btnUpdate = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 56);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 1;
            label3.Text = "Quantity";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(109, 96);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(281, 96);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(80, 31);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(384, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(77, 31);
            txtPrice.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(613, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(109, 133);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.Size = new Size(498, 318);
            dgvInventory.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(613, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(613, 225);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 34);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(dgvInventory);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private DataGridView dgvInventory;
        private Button btnUpdate;
        private Button btnSearch;
    }
}