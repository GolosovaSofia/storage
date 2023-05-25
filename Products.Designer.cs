namespace storage
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.life = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.give = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_allpr = new System.Windows.Forms.Button();
            this.del_pr = new System.Windows.Forms.Button();
            this.ad_pr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.del_f = new System.Windows.Forms.Button();
            this.v_filtr = new System.Windows.Forms.TextBox();
            this.filtr = new System.Windows.Forms.Button();
            this.count_of_products = new System.Windows.Forms.Label();
            this.v_escape = new System.Windows.Forms.TextBox();
            this.escape = new System.Windows.Forms.Button();
            this.del_esc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-5, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 6);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type,
            this.number,
            this.life,
            this.cost,
            this.give});
            this.dataGridView2.Location = new System.Drawing.Point(12, 49);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1029, 266);
            this.dataGridView2.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 130;
            // 
            // number
            // 
            this.number.HeaderText = "Количество";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 130;
            // 
            // life
            // 
            this.life.HeaderText = "Срок хранения(мес.)";
            this.life.MinimumWidth = 6;
            this.life.Name = "life";
            this.life.Width = 130;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость аренды";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.Width = 130;
            // 
            // give
            // 
            this.give.HeaderText = "Выдача товара";
            this.give.MinimumWidth = 6;
            this.give.Name = "give";
            this.give.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.give.Width = 123;
            // 
            // del_allpr
            // 
            this.del_allpr.BackColor = System.Drawing.Color.Red;
            this.del_allpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_allpr.ForeColor = System.Drawing.Color.Transparent;
            this.del_allpr.Location = new System.Drawing.Point(191, 457);
            this.del_allpr.Name = "del_allpr";
            this.del_allpr.Size = new System.Drawing.Size(124, 78);
            this.del_allpr.TabIndex = 3;
            this.del_allpr.Text = "Удалить  все позиции";
            this.del_allpr.UseVisualStyleBackColor = false;
            this.del_allpr.Click += new System.EventHandler(this.del_allpr_Click);
            // 
            // del_pr
            // 
            this.del_pr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.del_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_pr.ForeColor = System.Drawing.Color.Snow;
            this.del_pr.Location = new System.Drawing.Point(191, 374);
            this.del_pr.Name = "del_pr";
            this.del_pr.Size = new System.Drawing.Size(124, 78);
            this.del_pr.TabIndex = 4;
            this.del_pr.Text = "Удалить позицию";
            this.del_pr.UseVisualStyleBackColor = false;
            this.del_pr.Click += new System.EventHandler(this.del_pr_Click);
            // 
            // ad_pr
            // 
            this.ad_pr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ad_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ad_pr.Location = new System.Drawing.Point(49, 374);
            this.ad_pr.Name = "ad_pr";
            this.ad_pr.Size = new System.Drawing.Size(124, 77);
            this.ad_pr.TabIndex = 5;
            this.ad_pr.Text = "Добавить позицию";
            this.ad_pr.UseVisualStyleBackColor = false;
            this.ad_pr.Click += new System.EventHandler(this.ad_pr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество позиций:";
            // 
            // del_f
            // 
            this.del_f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.del_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_f.Location = new System.Drawing.Point(472, 457);
            this.del_f.Name = "del_f";
            this.del_f.Size = new System.Drawing.Size(131, 78);
            this.del_f.TabIndex = 5;
            this.del_f.Text = "Сбросить фильтрацию";
            this.del_f.UseVisualStyleBackColor = false;
            this.del_f.Click += new System.EventHandler(this.del_f_Click);
            // 
            // v_filtr
            // 
            this.v_filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v_filtr.Location = new System.Drawing.Point(342, 413);
            this.v_filtr.Name = "v_filtr";
            this.v_filtr.Size = new System.Drawing.Size(254, 27);
            this.v_filtr.TabIndex = 8;
            // 
            // filtr
            // 
            this.filtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtr.Location = new System.Drawing.Point(332, 457);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(134, 78);
            this.filtr.TabIndex = 5;
            this.filtr.Text = "Фильтровать по стоимости";
            this.filtr.UseVisualStyleBackColor = false;
            this.filtr.Click += new System.EventHandler(this.filtr_Click);
            // 
            // count_of_products
            // 
            this.count_of_products.AutoSize = true;
            this.count_of_products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.count_of_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_products.Location = new System.Drawing.Point(230, 334);
            this.count_of_products.Name = "count_of_products";
            this.count_of_products.Size = new System.Drawing.Size(23, 25);
            this.count_of_products.TabIndex = 9;
            this.count_of_products.Text = "0";
            // 
            // v_escape
            // 
            this.v_escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v_escape.Location = new System.Drawing.Point(670, 413);
            this.v_escape.Name = "v_escape";
            this.v_escape.Size = new System.Drawing.Size(254, 27);
            this.v_escape.TabIndex = 12;
            // 
            // escape
            // 
            this.escape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escape.Location = new System.Drawing.Point(665, 457);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(129, 78);
            this.escape.TabIndex = 10;
            this.escape.Text = "Поиск по типу";
            this.escape.UseVisualStyleBackColor = false;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // del_esc
            // 
            this.del_esc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.del_esc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_esc.Location = new System.Drawing.Point(800, 457);
            this.del_esc.Name = "del_esc";
            this.del_esc.Size = new System.Drawing.Size(133, 78);
            this.del_esc.TabIndex = 11;
            this.del_esc.Text = "Сбросить поиск";
            this.del_esc.UseVisualStyleBackColor = false;
            this.del_esc.Click += new System.EventHandler(this.del_esc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(337, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.edit.Location = new System.Drawing.Point(17, 457);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(156, 77);
            this.edit.TabIndex = 14;
            this.edit.Text = "Редактирование";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 562);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.v_escape);
            this.Controls.Add(this.escape);
            this.Controls.Add(this.del_esc);
            this.Controls.Add(this.count_of_products);
            this.Controls.Add(this.v_filtr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_allpr);
            this.Controls.Add(this.del_pr);
            this.Controls.Add(this.filtr);
            this.Controls.Add(this.del_f);
            this.Controls.Add(this.ad_pr);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имущество";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button del_allpr;
        private System.Windows.Forms.Button del_pr;
        private System.Windows.Forms.Button ad_pr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_f;
        private System.Windows.Forms.TextBox v_filtr;
        private System.Windows.Forms.Button filtr;
        private System.Windows.Forms.Label count_of_products;
        private System.Windows.Forms.TextBox v_escape;
        private System.Windows.Forms.Button escape;
        private System.Windows.Forms.Button del_esc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn life;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn give;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit;
    }
}