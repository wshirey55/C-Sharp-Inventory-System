namespace VLT_inventory
{
    partial class UseItem
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
            this.components = new System.ComponentModel.Container();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_useItem = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.txt_manufacturerID = new System.Windows.Forms.TextBox();
            this.txt_itemDescription = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.num_amountUsed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.vlt_inventoryDataSet = new VLT_inventory.vlt_inventoryDataSet();
            this.partsMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parts_masterTableAdapter = new VLT_inventory.vlt_inventoryDataSetTableAdapters.parts_masterTableAdapter();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_useItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(54, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(217, 20);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(299, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 31);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // data_useItem
            // 
            this.data_useItem.AllowUserToAddRows = false;
            this.data_useItem.AllowUserToDeleteRows = false;
            this.data_useItem.AutoGenerateColumns = false;
            this.data_useItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_useItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.partSerialDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.data_useItem.DataSource = this.partsMasterBindingSource;
            this.data_useItem.Location = new System.Drawing.Point(23, 105);
            this.data_useItem.Name = "data_useItem";
            this.data_useItem.Size = new System.Drawing.Size(580, 172);
            this.data_useItem.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 5;
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.Location = new System.Drawing.Point(395, 89);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.Size = new System.Drawing.Size(166, 20);
            this.txt_manufacturer.TabIndex = 6;
            // 
            // txt_manufacturerID
            // 
            this.txt_manufacturerID.Location = new System.Drawing.Point(395, 36);
            this.txt_manufacturerID.Name = "txt_manufacturerID";
            this.txt_manufacturerID.Size = new System.Drawing.Size(166, 20);
            this.txt_manufacturerID.TabIndex = 7;
            // 
            // txt_itemDescription
            // 
            this.txt_itemDescription.Location = new System.Drawing.Point(97, 88);
            this.txt_itemDescription.Name = "txt_itemDescription";
            this.txt_itemDescription.Size = new System.Drawing.Size(166, 20);
            this.txt_itemDescription.TabIndex = 8;
            // 
            // txt_itemID
            // 
            this.txt_itemID.AutoSize = true;
            this.txt_itemID.Location = new System.Drawing.Point(43, 39);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(41, 13);
            this.txt_itemID.TabIndex = 9;
            this.txt_itemID.Text = "Item ID";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(6, 91);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(83, 13);
            this.lable5.TabIndex = 10;
            this.lable5.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manufactuer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_confirm);
            this.groupBox2.Controls.Add(this.num_amountUsed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lable5);
            this.groupBox2.Controls.Add(this.txt_itemID);
            this.groupBox2.Controls.Add(this.txt_itemDescription);
            this.groupBox2.Controls.Add(this.txt_manufacturerID);
            this.groupBox2.Controls.Add(this.txt_manufacturer);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(27, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 187);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(473, 141);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 31);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(346, 141);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(88, 31);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // num_amountUsed
            // 
            this.num_amountUsed.Location = new System.Drawing.Point(97, 141);
            this.num_amountUsed.Name = "num_amountUsed";
            this.num_amountUsed.Size = new System.Drawing.Size(37, 20);
            this.num_amountUsed.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount Used";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLT_inventory.Properties.Resources.logoedit;
            this.pictureBox1.Location = new System.Drawing.Point(32, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 69);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(515, 539);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(88, 31);
            this.btn_home.TabIndex = 16;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // vlt_inventoryDataSet
            // 
            this.vlt_inventoryDataSet.DataSetName = "vlt_inventoryDataSet";
            this.vlt_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsMasterBindingSource
            // 
            this.partsMasterBindingSource.DataMember = "parts master";
            this.partsMasterBindingSource.DataSource = this.vlt_inventoryDataSet;
            // 
            // parts_masterTableAdapter
            // 
            this.parts_masterTableAdapter.ClearBeforeFill = true;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "Part ID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "Part Name";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Part Name";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            // 
            // partSerialDataGridViewTextBoxColumn
            // 
            this.partSerialDataGridViewTextBoxColumn.DataPropertyName = "Part Serial";
            this.partSerialDataGridViewTextBoxColumn.HeaderText = "Part Serial";
            this.partSerialDataGridViewTextBoxColumn.Name = "partSerialDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // UseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 582);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.data_useItem);
            this.Controls.Add(this.groupBox1);
            this.Name = "UseItem";
            this.Text = "Use Item";
            this.Load += new System.EventHandler(this.UseItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_useItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_useItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.TextBox txt_manufacturerID;
        private System.Windows.Forms.TextBox txt_itemDescription;
        private System.Windows.Forms.Label txt_itemID;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.NumericUpDown num_amountUsed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private vlt_inventoryDataSet vlt_inventoryDataSet;
        private System.Windows.Forms.BindingSource partsMasterBindingSource;
        private vlt_inventoryDataSetTableAdapters.parts_masterTableAdapter parts_masterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}