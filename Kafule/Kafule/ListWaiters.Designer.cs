
namespace Kafule
{
    partial class ListWaiters
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
            this.lbAllWaiters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeeWaiter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllWaiters
            // 
            this.lbAllWaiters.FormattingEnabled = true;
            this.lbAllWaiters.ItemHeight = 16;
            this.lbAllWaiters.Location = new System.Drawing.Point(12, 34);
            this.lbAllWaiters.Name = "lbAllWaiters";
            this.lbAllWaiters.Size = new System.Drawing.Size(330, 404);
            this.lbAllWaiters.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of all waiters";
            // 
            // btnSeeWaiter
            // 
            this.btnSeeWaiter.Location = new System.Drawing.Point(12, 444);
            this.btnSeeWaiter.Name = "btnSeeWaiter";
            this.btnSeeWaiter.Size = new System.Drawing.Size(156, 25);
            this.btnSeeWaiter.TabIndex = 2;
            this.btnSeeWaiter.Text = "See Waiter";
            this.btnSeeWaiter.UseVisualStyleBackColor = true;
            this.btnSeeWaiter.Click += new System.EventHandler(this.btnSeeWaiter_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(188, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 25);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ListWaiters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 480);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSeeWaiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAllWaiters);
            this.Name = "ListWaiters";
            this.Text = "ListWaiters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllWaiters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeeWaiter;
        private System.Windows.Forms.Button btnBack;
    }
}