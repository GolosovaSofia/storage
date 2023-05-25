namespace storage
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.count_of_users = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del_allpr = new System.Windows.Forms.Button();
            this.del_us = new System.Windows.Forms.Button();
            this.ad_us = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fam,
            this.name,
            this.phone,
            this.creditc});
            this.dataGridView1.Location = new System.Drawing.Point(94, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // fam
            // 
            this.fam.HeaderText = "Фамилия";
            this.fam.MinimumWidth = 6;
            this.fam.Name = "fam";
            this.fam.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 126;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // creditc
            // 
            this.creditc.HeaderText = "Номер кредитной карты";
            this.creditc.MinimumWidth = 6;
            this.creditc.Name = "creditc";
            this.creditc.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-5, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 6);
            this.panel1.TabIndex = 3;
            // 
            // count_of_users
            // 
            this.count_of_users.AutoSize = true;
            this.count_of_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.count_of_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_users.Location = new System.Drawing.Point(325, 353);
            this.count_of_users.Name = "count_of_users";
            this.count_of_users.Size = new System.Drawing.Size(23, 25);
            this.count_of_users.TabIndex = 14;
            this.count_of_users.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество позиций:";
            // 
            // del_allpr
            // 
            this.del_allpr.BackColor = System.Drawing.Color.Red;
            this.del_allpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_allpr.ForeColor = System.Drawing.Color.Transparent;
            this.del_allpr.Location = new System.Drawing.Point(631, 394);
            this.del_allpr.Name = "del_allpr";
            this.del_allpr.Size = new System.Drawing.Size(124, 78);
            this.del_allpr.TabIndex = 10;
            this.del_allpr.Text = "Удалить  все позиции";
            this.del_allpr.UseVisualStyleBackColor = false;
            this.del_allpr.Click += new System.EventHandler(this.del_allpr_Click);
            // 
            // del_us
            // 
            this.del_us.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.del_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_us.ForeColor = System.Drawing.Color.Snow;
            this.del_us.Location = new System.Drawing.Point(489, 394);
            this.del_us.Name = "del_us";
            this.del_us.Size = new System.Drawing.Size(124, 78);
            this.del_us.TabIndex = 11;
            this.del_us.Text = "Удалить позицию";
            this.del_us.UseVisualStyleBackColor = false;
            this.del_us.Click += new System.EventHandler(this.del_us_Click);
            // 
            // ad_us
            // 
            this.ad_us.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ad_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ad_us.Location = new System.Drawing.Point(345, 394);
            this.ad_us.Name = "ad_us";
            this.ad_us.Size = new System.Drawing.Size(124, 77);
            this.ad_us.TabIndex = 12;
            this.ad_us.Text = "Добавить позицию";
            this.ad_us.UseVisualStyleBackColor = false;
            this.ad_us.Click += new System.EventHandler(this.ad_us_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 562);
            this.Controls.Add(this.count_of_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_allpr);
            this.Controls.Add(this.del_us);
            this.Controls.Add(this.ad_us);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label count_of_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_allpr;
        private System.Windows.Forms.Button del_us;
        private System.Windows.Forms.Button ad_us;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditc;
    }
}