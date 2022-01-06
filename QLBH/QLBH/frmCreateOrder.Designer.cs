
namespace QLBH
{
    partial class frmCreateOrder
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.buyDate = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tbCreateOrder = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tbCreateOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(146, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(217, 26);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 15);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(47, 20);
            this.ID.TabIndex = 1;
            this.ID.Text = "Code";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(12, 47);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(113, 20);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "Phone number";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(146, 41);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 26);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // buyDate
            // 
            this.buyDate.AutoSize = true;
            this.buyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyDate.Location = new System.Drawing.Point(12, 79);
            this.buyDate.Name = "buyDate";
            this.buyDate.Size = new System.Drawing.Size(72, 20);
            this.buyDate.TabIndex = 4;
            this.buyDate.Text = "Buy date";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(12, 111);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 20);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(146, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(217, 26);
            this.txtTotal.TabIndex = 4;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(403, 91);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 32);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tbCreateOrder
            // 
            this.tbCreateOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbCreateOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCreateOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.phoneNum,
            this.dateBuy,
            this.totalOrder});
            this.tbCreateOrder.Location = new System.Drawing.Point(-1, 137);
            this.tbCreateOrder.Name = "tbCreateOrder";
            this.tbCreateOrder.Size = new System.Drawing.Size(803, 315);
            this.tbCreateOrder.TabIndex = 9;
            this.tbCreateOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCreateOrder_CellClick);
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            // 
            // phoneNum
            // 
            this.phoneNum.HeaderText = "Phone number";
            this.phoneNum.Name = "phoneNum";
            // 
            // dateBuy
            // 
            this.dateBuy.HeaderText = "Buy date";
            this.dateBuy.Name = "dateBuy";
            // 
            // totalOrder
            // 
            this.totalOrder.HeaderText = "Total";
            this.totalOrder.Name = "totalOrder";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(403, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(403, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(146, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 26);
            this.dateTimePicker.TabIndex = 3;
            // 
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCreateOrder);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.buyDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateOrder";
            this.Text = "frmCreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.tbCreateOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label buyDate;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView tbCreateOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}