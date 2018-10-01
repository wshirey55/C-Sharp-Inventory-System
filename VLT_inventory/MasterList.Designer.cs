namespace VLT_inventory
{
    partial class MasterList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_itemBox = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.txt_manufacturerID = new System.Windows.Forms.TextBox();
            this.txt_itemDescription = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.vlt_inventoryDBDataSet = new VLT_inventory.vlt_inventoryDBDataSet();
            this.vltMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlt_MasterTableAdapter = new VLT_inventory.vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(262, 24);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(263, 20);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_itemBox);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 66);
            this.groupBox1.TabIndex = 4;
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
            this.cmb_itemBox.Location = new System.Drawing.Point(134, 24);
            this.cmb_itemBox.Name = "cmb_itemBox";
            this.cmb_itemBox.Size = new System.Drawing.Size(84, 21);
            this.cmb_itemBox.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(96, 204);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 31);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(395, 204);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(122, 31);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(668, 525);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(122, 31);
            this.btn_home.TabIndex = 8;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cost);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_remove);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_manufacturer);
            this.groupBox3.Controls.Add(this.txt_manufacturerID);
            this.groupBox3.Controls.Add(this.txt_itemDescription);
            this.groupBox3.Controls.Add(this.txt_itemID);
            this.groupBox3.Location = new System.Drawing.Point(24, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 252);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Info";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(96, 127);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(85, 20);
            this.txt_cost.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cost";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturer ID";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item ID";
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.Location = new System.Drawing.Point(374, 79);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.Size = new System.Drawing.Size(143, 20);
            this.txt_manufacturer.TabIndex = 8;
            // 
            // txt_manufacturerID
            // 
            this.txt_manufacturerID.Location = new System.Drawing.Point(374, 33);
            this.txt_manufacturerID.Name = "txt_manufacturerID";
            this.txt_manufacturerID.Size = new System.Drawing.Size(143, 20);
            this.txt_manufacturerID.TabIndex = 7;
            // 
            // txt_itemDescription
            // 
            this.txt_itemDescription.Location = new System.Drawing.Point(96, 82);
            this.txt_itemDescription.Name = "txt_itemDescription";
            this.txt_itemDescription.Size = new System.Drawing.Size(143, 20);
            this.txt_itemDescription.TabIndex = 6;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(96, 33);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(143, 20);
            this.txt_itemID.TabIndex = 4;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(628, 197);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(737, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 13);
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Text = "username";
            // 
            // MasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 568);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.groupBox1);
            this.Name = "MasterList";
            this.Text = "MasterList";
            this.Load += new System.EventHandler(this.MasterList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlt_inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vltMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ComboBox cmb_itemBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.TextBox txt_manufacturerID;
        private System.Windows.Forms.TextBox txt_itemDescription;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label5;
        private vlt_inventoryDBDataSet vlt_inventoryDBDataSet;
        private System.Windows.Forms.BindingSource vltMasterBindingSource;
        private vlt_inventoryDBDataSetTableAdapters.vlt_MasterTableAdapter vlt_MasterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_username;
    }
}