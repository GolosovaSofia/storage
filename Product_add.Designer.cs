namespace storage
{
    partial class Product_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_add));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_id = new System.Windows.Forms.TextBox();
            this.add_type = new System.Windows.Forms.ComboBox();
            this.add_number = new System.Windows.Forms.TextBox();
            this.add_cost = new System.Windows.Forms.TextBox();
            this.add_life = new System.Windows.Forms.TextBox();
            this.add_give = new System.Windows.Forms.ComboBox();
            this.addpr_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(154, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(154, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Срок хранения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(597, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "месяцев";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(154, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Стоимость аренды";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(154, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Выдача товара";
            // 
            // add_id
            // 
            this.add_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_id.Location = new System.Drawing.Point(395, 50);
            this.add_id.Name = "add_id";
            this.add_id.Size = new System.Drawing.Size(196, 27);
            this.add_id.TabIndex = 1;
            // 
            // add_type
            // 
            this.add_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_type.FormattingEnabled = true;
            this.add_type.Items.AddRange(new object[] {
            "универсальное",
            "хрупкое",
            "скоропортящееся",
            "острое",
            "тяжелое"});
            this.add_type.Location = new System.Drawing.Point(395, 94);
            this.add_type.Name = "add_type";
            this.add_type.Size = new System.Drawing.Size(196, 28);
            this.add_type.TabIndex = 2;
            // 
            // add_number
            // 
            this.add_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_number.Location = new System.Drawing.Point(395, 145);
            this.add_number.Name = "add_number";
            this.add_number.Size = new System.Drawing.Size(196, 27);
            this.add_number.TabIndex = 1;
            // 
            // add_cost
            // 
            this.add_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_cost.Location = new System.Drawing.Point(395, 254);
            this.add_cost.Name = "add_cost";
            this.add_cost.Size = new System.Drawing.Size(196, 27);
            this.add_cost.TabIndex = 1;
            // 
            // add_life
            // 
            this.add_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_life.Location = new System.Drawing.Point(395, 199);
            this.add_life.Name = "add_life";
            this.add_life.Size = new System.Drawing.Size(196, 27);
            this.add_life.TabIndex = 1;
            // 
            // add_give
            // 
            this.add_give.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_give.FormattingEnabled = true;
            this.add_give.Items.AddRange(new object[] {
            "выдан",
            "не выдан"});
            this.add_give.Location = new System.Drawing.Point(395, 302);
            this.add_give.Name = "add_give";
            this.add_give.Size = new System.Drawing.Size(196, 28);
            this.add_give.TabIndex = 2;
            // 
            // addpr_button
            // 
            this.addpr_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addpr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addpr_button.Location = new System.Drawing.Point(323, 398);
            this.addpr_button.Name = "addpr_button";
            this.addpr_button.Size = new System.Drawing.Size(147, 77);
            this.addpr_button.TabIndex = 3;
            this.addpr_button.Text = "Добавить позицию";
            this.addpr_button.UseVisualStyleBackColor = false;
            this.addpr_button.Click += new System.EventHandler(this.addpr_button_Click);
            // 
            // Product_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 562);
            this.Controls.Add(this.addpr_button);
            this.Controls.Add(this.add_give);
            this.Controls.Add(this.add_type);
            this.Controls.Add(this.add_cost);
            this.Controls.Add(this.add_life);
            this.Controls.Add(this.add_number);
            this.Controls.Add(this.add_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая позиция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_id;
        private System.Windows.Forms.ComboBox add_type;
        private System.Windows.Forms.TextBox add_number;
        private System.Windows.Forms.TextBox add_cost;
        private System.Windows.Forms.TextBox add_life;
        private System.Windows.Forms.ComboBox add_give;
        private System.Windows.Forms.Button addpr_button;
    }
}