namespace VLT_inventory
{
    partial class Home
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
            this.btn_useItem = new System.Windows.Forms.Button();
            this.btn_recieveItem = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_masterList = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_useItem
            // 
            this.btn_useItem.Location = new System.Drawing.Point(35, 57);
            this.btn_useItem.Name = "btn_useItem";
            this.btn_useItem.Size = new System.Drawing.Size(90, 36);
            this.btn_useItem.TabIndex = 0;
            this.btn_useItem.Text = "Use Item";
            this.btn_useItem.UseVisualStyleBackColor = true;
            // 
            // btn_recieveItem
            // 
            this.btn_recieveItem.Location = new System.Drawing.Point(271, 57);
            this.btn_recieveItem.Name = "btn_recieveItem";
            this.btn_recieveItem.Size = new System.Drawing.Size(90, 36);
            this.btn_recieveItem.TabIndex = 1;
            this.btn_recieveItem.Text = "Recieve Item";
            this.btn_recieveItem.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(35, 219);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(90, 36);
            this.btn_reports.TabIndex = 2;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_masterList
            // 
            this.btn_masterList.Location = new System.Drawing.Point(156, 219);
            this.btn_masterList.Name = "btn_masterList";
            this.btn_masterList.Size = new System.Drawing.Size(90, 36);
            this.btn_masterList.TabIndex = 3;
            this.btn_masterList.Text = "Master List";
            this.btn_masterList.UseVisualStyleBackColor = true;
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(271, 219);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(90, 36);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VLT_inventory.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(108, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_masterList);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_recieveItem);
            this.Controls.Add(this.btn_useItem);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_useItem;
        private System.Windows.Forms.Button btn_recieveItem;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_masterList;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}