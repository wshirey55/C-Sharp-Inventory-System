namespace VLT_inventory
{
    partial class ReceiveItem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_itemBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_itemDescription = new System.Windows.Forms.TextBox();
            this.txt_manufacturerID = new System.Windows.Forms.TextBox();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_amountRecieved = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_repaired = new System.Windows.Forms.RadioButton();
            this.rdo_damaged = new System.Windows.Forms.RadioButton();
            this.rdo_new = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.vlt_inventoryDBDataSet = new VLT_inventory.vlt_inventoryDBDataSet();
            this.vltMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlt_MasterTableAdapter = new VLT_inventory.vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountRecieved)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(232, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(288, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_itemBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(32, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmb_itemBox
            // 
            this.cmb_itemBox.FormattingEnabled = true;
            this.cmb_itemBox.Items.AddRange(new object[] {
            "Item ID",
            "Item Name",
            "Manufacturer",
            "Manufacturer ID",
            "Cost"});
            this.cmb_itemBox.Location = new System.Drawing.Point(126, 25);
            this.cmb_itemBox.Name = "cmb_itemBox";
            this.cmb_itemBox.Size = new System.Drawing.Size(97, 21);
            this.cmb_itemBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search By";
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(96, 33);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(143, 20);
            this.txt_itemID.TabIndex = 4;
            // 
            // txt_itemDescription
            // 
            this.txt_itemDescription.Location = new System.Drawing.Point(96, 82);
            this.txt_itemDescription.Name = "txt_itemDescription";
            this.txt_itemDescription.Size = new System.Drawing.Size(143, 20);
            this.txt_itemDescription.TabIndex = 6;
            // 
            // txt_manufacturerID
            // 
            this.txt_manufacturerID.Location = new System.Drawing.Point(374, 33);
            this.txt_manufacturerID.Name = "txt_manufacturerID";
            this.txt_manufacturerID.Size = new System.Drawing.Size(143, 20);
            this.txt_manufacturerID.TabIndex = 7;
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.Location = new System.Drawing.Point(374, 79);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.Size = new System.Drawing.Size(143, 20);
            this.txt_manufacturer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manufacturer";
            // 
            // num_amountRecieved
            // 
            this.num_amountRecieved.Location = new System.Drawing.Point(107, 134);
            this.num_amountRecieved.Name = "num_amountRecieved";
            this.num_amountRecieved.Size = new System.Drawing.Size(27, 20);
            this.num_amountRecieved.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount Recieved";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(434, 128);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 29);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Clear";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(301, 128);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(103, 29);
            this.btn_confirm.TabIndex = 16;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_repaired);
            this.groupBox2.Controls.Add(this.rdo_damaged);
            this.groupBox2.Controls.Add(this.rdo_new);
            this.groupBox2.Controls.Add(this.btn_confirm);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num_amountRecieved);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_manufacturer);
            this.groupBox2.Controls.Add(this.txt_manufacturerID);
            this.groupBox2.Controls.Add(this.txt_itemDescription);
            this.groupBox2.Controls.Add(this.txt_itemID);
            this.groupBox2.Location = new System.Drawing.Point(35, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 190);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // rdo_repaired
            // 
            this.rdo_repaired.AutoSize = true;
            this.rdo_repaired.Location = new System.Drawing.Point(173, 154);
            this.rdo_repaired.Name = "rdo_repaired";
            this.rdo_repaired.Size = new System.Drawing.Size(68, 17);
            this.rdo_repaired.TabIndex = 22;
            this.rdo_repaired.TabStop = true;
            this.rdo_repaired.Text = "Repaired";
            this.rdo_repaired.UseVisualStyleBackColor = true;
            // 
            // rdo_damaged
            // 
            this.rdo_damaged.AutoSize = true;
            this.rdo_damaged.Location = new System.Drawing.Point(173, 131);
            this.rdo_damaged.Name = "rdo_damaged";
            this.rdo_damaged.Size = new System.Drawing.Size(71, 17);
            this.rdo_damaged.TabIndex = 21;
            this.rdo_damaged.TabStop = true;
            this.rdo_damaged.Text = "Damaged";
            this.rdo_damaged.UseVisualStyleBackColor = true;
            // 
            // rdo_new
            // 
            this.rdo_new.AutoSize = true;
            this.rdo_new.Location = new System.Drawing.Point(173, 108);
            this.rdo_new.Name = "rdo_new";
            this.rdo_new.Size = new System.Drawing.Size(47, 17);
            this.rdo_new.TabIndex = 20;
            this.rdo_new.TabStop = true;
            this.rdo_new.Text = "New";
            this.rdo_new.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLT_inventory.Properties.Resources.logoedit;
            this.pictureBox1.Location = new System.Drawing.Point(35, 534);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 69);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(592, 574);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(81, 29);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // vlt_inventoryDBDataSet
            // 
            this.vlt_inventoryDBDataSet.DataSetName = "vlt_inventoryDBDataSet";
            this.vlt_inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vltMasterBindingSource
            // 
            this.vltMasterBindingSource.DataMember = "vlt_Master";
            this.vltMasterBindingSource.DataSource = this.vlt_inventoryDBDataSet;
            // 
            // vlt_MasterTableAdapter
            // 
            this.vlt_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 207);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(677, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 13);
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Text = "username";
            // 
            // ReceiveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 615);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceiveItem";
            this.Text = "ReceiveItem";
            this.Load += new System.EventHandler(this.ReceiveItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountRecieved)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_itemDescription;
        private System.Windows.Forms.TextBox txt_manufacturerID;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_amountRecieved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.RadioButton rdo_repaired;
        private System.Windows.Forms.RadioButton rdo_damaged;
        private System.Windows.Forms.RadioButton rdo_new;
        private System.Windows.Forms.Label label6;
        private vlt_inventoryDBDataSet vlt_inventoryDBDataSet;
        private System.Windows.Forms.BindingSource vltMasterBindingSource;
        private vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter vlt_MasterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_itemBox;
        private System.Windows.Forms.Label lbl_username;
    }
}