
namespace Kafule
{
    partial class Main
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
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewWaiter = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnDeleteWaiter = new System.Windows.Forms.Button();
            this.btnAllWaiters = new System.Windows.Forms.Button();
            this.btnAddNewArticle = new System.Windows.Forms.Button();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.lblWaiterName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(699, 189);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Tag = " ";
            this.label2.Text = "Waiter code :";
            // 
            // btnAddNewWaiter
            // 
            this.btnAddNewWaiter.Location = new System.Drawing.Point(919, 12);
            this.btnAddNewWaiter.Name = "btnAddNewWaiter";
            this.btnAddNewWaiter.Size = new System.Drawing.Size(129, 25);
            this.btnAddNewWaiter.TabIndex = 7;
            this.btnAddNewWaiter.Text = "Add new waiter";
            this.btnAddNewWaiter.UseVisualStyleBackColor = true;
            this.btnAddNewWaiter.Click += new System.EventHandler(this.btnAddNewWaiter_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(306, 803);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 30);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(421, 803);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(109, 30);
            this.btnBill.TabIndex = 9;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWaiter
            // 
            this.btnDeleteWaiter.Location = new System.Drawing.Point(1054, 12);
            this.btnDeleteWaiter.Name = "btnDeleteWaiter";
            this.btnDeleteWaiter.Size = new System.Drawing.Size(129, 25);
            this.btnDeleteWaiter.TabIndex = 10;
            this.btnDeleteWaiter.Text = "Delete waiter";
            this.btnDeleteWaiter.UseVisualStyleBackColor = true;
            this.btnDeleteWaiter.Click += new System.EventHandler(this.btnDeleteWaiter_Click);
            // 
            // btnAllWaiters
            // 
            this.btnAllWaiters.Location = new System.Drawing.Point(919, 43);
            this.btnAllWaiters.Name = "btnAllWaiters";
            this.btnAllWaiters.Size = new System.Drawing.Size(264, 25);
            this.btnAllWaiters.TabIndex = 11;
            this.btnAllWaiters.Text = "All waiters";
            this.btnAllWaiters.UseVisualStyleBackColor = true;
            this.btnAllWaiters.Click += new System.EventHandler(this.btnAllWaiters_Click);
            // 
            // btnAddNewArticle
            // 
            this.btnAddNewArticle.Location = new System.Drawing.Point(919, 74);
            this.btnAddNewArticle.Name = "btnAddNewArticle";
            this.btnAddNewArticle.Size = new System.Drawing.Size(264, 27);
            this.btnAddNewArticle.TabIndex = 12;
            this.btnAddNewArticle.Text = "Add new article";
            this.btnAddNewArticle.UseVisualStyleBackColor = true;
            this.btnAddNewArticle.Click += new System.EventHandler(this.btnAddNewArticle_Click);
            // 
            // dgvArticles
            // 
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Article,
            this.Quantity,
            this.Price,
            this.Sum});
            this.dgvArticles.Location = new System.Drawing.Point(306, 217);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.RowHeadersWidth = 51;
            this.dgvArticles.RowTemplate.Height = 24;
            this.dgvArticles.Size = new System.Drawing.Size(877, 580);
            this.dgvArticles.TabIndex = 14;
            // 
            // lblWaiterName
            // 
            this.lblWaiterName.AutoSize = true;
            this.lblWaiterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiterName.Location = new System.Drawing.Point(313, 104);
            this.lblWaiterName.Name = "lblWaiterName";
            this.lblWaiterName.Size = new System.Drawing.Size(154, 29);
            this.lblWaiterName.TabIndex = 15;
            this.lblWaiterName.Text = "WaiterName";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(988, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 58);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(318, 137);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 28);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewDelete
            // 
            this.btnViewDelete.Location = new System.Drawing.Point(919, 104);
            this.btnViewDelete.Name = "btnViewDelete";
            this.btnViewDelete.Size = new System.Drawing.Size(264, 27);
            this.btnViewDelete.TabIndex = 18;
            this.btnViewDelete.Text = "View/Delete article";
            this.btnViewDelete.UseVisualStyleBackColor = true;
            this.btnViewDelete.Click += new System.EventHandler(this.btnViewDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Controls.Add(this.lbTables);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 580);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(6, 543);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(276, 31);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Add";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.ItemHeight = 16;
            this.lbTables.Location = new System.Drawing.Point(6, 21);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(276, 516);
            this.lbTables.TabIndex = 0;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.lbTables_SelectedIndexChanged);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(18, 802);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(276, 31);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(907, 803);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(276, 31);
            this.btnAddArticle.TabIndex = 20;
            this.btnAddArticle.Text = "Add";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(569, 12);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(148, 25);
            this.btnDailyReport.TabIndex = 21;
            this.btnDailyReport.Text = "Daily report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 50;
            // 
            // Article
            // 
            this.Article.HeaderText = "Article name";
            this.Article.MinimumWidth = 6;
            this.Article.Name = "Article";
            this.Article.Width = 280;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Sum";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kafule.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1195, 842);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewDelete);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWaiterName);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.btnAddNewArticle);
            this.Controls.Add(this.btnAllWaiters);
            this.Controls.Add(this.btnDeleteWaiter);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAddNewWaiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewWaiter;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnDeleteWaiter;
        private System.Windows.Forms.Button btnAllWaiters;
        private System.Windows.Forms.Button btnAddNewArticle;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Label lblWaiterName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}