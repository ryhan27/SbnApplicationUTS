namespace SampleUTS.Design
{
    partial class BuyerForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBuyerId = new TextBox();
            txtBuyerName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            btnAddBuyer = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvBuyer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuyer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 18);
            label1.TabIndex = 0;
            label1.Text = "BUYER MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Buyer Id ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 114);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Buyer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 152);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Email ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 193);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 240);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // txtBuyerId
            // 
            txtBuyerId.Location = new Point(182, 76);
            txtBuyerId.Name = "txtBuyerId";
            txtBuyerId.Size = new Size(190, 27);
            txtBuyerId.TabIndex = 6;
            // 
            // txtBuyerName
            // 
            txtBuyerName.Location = new Point(182, 114);
            txtBuyerName.Name = "txtBuyerName";
            txtBuyerName.Size = new Size(190, 27);
            txtBuyerName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(182, 193);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(190, 27);
            txtPhoneNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(179, 233);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(193, 27);
            txtAddress.TabIndex = 10;
            // 
            // btnAddBuyer
            // 
            btnAddBuyer.Location = new Point(39, 289);
            btnAddBuyer.Name = "btnAddBuyer";
            btnAddBuyer.Size = new Size(94, 29);
            btnAddBuyer.TabIndex = 11;
            btnAddBuyer.Text = "Add Buyer";
            btnAddBuyer.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(139, 289);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(239, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(339, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvBuyer
            // 
            dgvBuyer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuyer.Location = new Point(488, 72);
            dgvBuyer.Name = "dgvBuyer";
            dgvBuyer.RowHeadersWidth = 51;
            dgvBuyer.Size = new Size(508, 257);
            dgvBuyer.TabIndex = 15;
            // 
            // BuyerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 494);
            Controls.Add(dgvBuyer);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddBuyer);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtBuyerName);
            Controls.Add(txtBuyerId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuyerForm";
            Text = "BuyerForm";
            Load += BuyerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuyer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBuyerId;
        private TextBox txtBuyerName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private Button btnAddBuyer;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvBuyer;
    }
}