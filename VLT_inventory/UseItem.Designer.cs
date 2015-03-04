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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_itemBox = new System.Windows.Forms.ComboBox();
            this.vltMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlt_inventoryDBDataSet = new VLT_inventory.vlt_inventoryDBDataSet();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.txt_manufacturerID = new System.Windows.Forms.TextBox();
            this.txt_itemDescription = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_repaired = new System.Windows.Forms.RadioButton();
            this.rdo_damaged = new System.Windows.Forms.RadioButton();
            this.rdo_new = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.num_amountUsed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.vlt_MasterTableAdapter = new VLT_inventory.vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vltMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(196, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(217, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_itemBox);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 64);
            this.groupBox1.TabIndex = 3;
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
            this.cmb_itemBox.Location = new System.Drawing.Point(54, 26);
            this.cmb_itemBox.Name = "cmb_itemBox";
            this.cmb_itemBox.Size = new System.Drawing.Size(116, 21);
            this.cmb_itemBox.TabIndex = 1;
            // 
            // vltMasterBindingSource
            // 
            this.vltMasterBindingSource.DataMember = "vlt_Master";
            this.vltMasterBindingSource.DataSource = this.vlt_inventoryDBDataSet;
            // 
            // vlt_inventoryDBDataSet
            // 
            this.vlt_inventoryDBDataSet.DataSetName = "vlt_inventoryDBDataSet";
            this.vlt_inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(97, 36);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(166, 20);
            this.txt_itemID.TabIndex = 5;
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
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(43, 39);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 13);
            this.lable1.TabIndex = 9;
            this.lable1.Text = "Item ID";
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
            this.groupBox2.Controls.Add(this.rdo_repaired);
            this.groupBox2.Controls.Add(this.rdo_damaged);
            this.groupBox2.Controls.Add(this.rdo_new);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_confirm);
            this.groupBox2.Controls.Add(this.num_amountUsed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lable5);
            this.groupBox2.Controls.Add(this.lable1);
            this.groupBox2.Controls.Add(this.txt_itemDescription);
            this.groupBox2.Controls.Add(this.txt_manufacturerID);
            this.groupBox2.Controls.Add(this.txt_manufacturer);
            this.groupBox2.Controls.Add(this.txt_itemID);
            this.groupBox2.Location = new System.Drawing.Point(27, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 187);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // rdo_repaired
            // 
            this.rdo_repaired.AutoSize = true;
            this.rdo_repaired.Location = new System.Drawing.Point(178, 160);
            this.rdo_repaired.Name = "rdo_repaired";
            this.rdo_repaired.Size = new System.Drawing.Size(68, 17);
            this.rdo_repaired.TabIndex = 19;
            this.rdo_repaired.TabStop = true;
            this.rdo_repaired.Text = "Repaired";
            this.rdo_repaired.UseVisualStyleBackColor = true;
            // 
            // rdo_damaged
            // 
            this.rdo_damaged.AutoSize = true;
            this.rdo_damaged.Location = new System.Drawing.Point(178, 137);
            this.rdo_damaged.Name = "rdo_damaged";
            this.rdo_damaged.Size = new System.Drawing.Size(71, 17);
            this.rdo_damaged.TabIndex = 18;
            this.rdo_damaged.TabStop = true;
            this.rdo_damaged.Text = "Damaged";
            this.rdo_damaged.UseVisualStyleBackColor = true;
            // 
            // rdo_new
            // 
            this.rdo_new.AutoSize = true;
            this.rdo_new.Location = new System.Drawing.Point(178, 114);
            this.rdo_new.Name = "rdo_new";
            this.rdo_new.Size = new System.Drawing.Size(47, 17);
            this.rdo_new.TabIndex = 17;
            this.rdo_new.TabStop = true;
            this.rdo_new.Text = "New";
            this.rdo_new.UseVisualStyleBackColor = true;
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
            // vlt_MasterTableAdapter
            // 
            this.vlt_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // vltMasterBindingSource1
            // 
            this.vltMasterBindingSource1.DataMember = "vlt_Master";
            this.vltMasterBindingSource1.DataSource = this.vlt_inventoryDBDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 173);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // UseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UseItem";
            this.Text = "Use Item";
            this.Load += new System.EventHandler(this.UseItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.TextBox txt_manufacturerID;
        private System.Windows.Forms.TextBox txt_itemDescription;
        private System.Windows.Forms.Label lable1;
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
        private System.Windows.Forms.RadioButton rdo_repaired;
        private System.Windows.Forms.RadioButton rdo_damaged;
        private System.Windows.Forms.RadioButton rdo_new;
        private vlt_inventoryDBDataSet vlt_inventoryDBDataSet;
        private System.Windows.Forms.BindingSource vltMasterBindingSource;
        private vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter vlt_MasterTableAdapter;
        private System.Windows.Forms.ComboBox cmb_itemBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource vltMasterBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}