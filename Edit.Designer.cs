namespace storage
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.add_give = new System.Windows.Forms.ComboBox();
            this.add_type = new System.Windows.Forms.ComboBox();
            this.add_cost = new System.Windows.Forms.TextBox();
            this.add_life = new System.Windows.Forms.TextBox();
            this.add_number = new System.Windows.Forms.TextBox();
            this.add_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edpr_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_give
            // 
            this.add_give.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_give.FormattingEnabled = true;
            this.add_give.Items.AddRange(new object[] {
            "выдан",
            "не выдан"});
            this.add_give.Location = new System.Drawing.Point(399, 300);
            this.add_give.Name = "add_give";
            this.add_give.Size = new System.Drawing.Size(196, 28);
            this.add_give.TabIndex = 14;
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
            this.add_type.Location = new System.Drawing.Point(399, 92);
            this.add_type.Name = "add_type";
            this.add_type.Size = new System.Drawing.Size(196, 28);
            this.add_type.TabIndex = 15;
            // 
            // add_cost
            // 
            this.add_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_cost.Location = new System.Drawing.Point(399, 252);
            this.add_cost.Name = "add_cost";
            this.add_cost.Size = new System.Drawing.Size(196, 27);
            this.add_cost.TabIndex = 10;
            // 
            // add_life
            // 
            this.add_life.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_life.Location = new System.Drawing.Point(399, 197);
            this.add_life.Name = "add_life";
            this.add_life.Size = new System.Drawing.Size(196, 27);
            this.add_life.TabIndex = 11;
            // 
            // add_number
            // 
            this.add_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_number.Location = new System.Drawing.Point(399, 143);
            this.add_number.Name = "add_number";
            this.add_number.Size = new System.Drawing.Size(196, 27);
            this.add_number.TabIndex = 12;
            // 
            // add_id
            // 
            this.add_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_id.Location = new System.Drawing.Point(399, 48);
            this.add_id.Name = "add_id";
            this.add_id.Size = new System.Drawing.Size(196, 27);
            this.add_id.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(601, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "месяцев";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(158, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Выдача товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(158, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стоимость аренды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(158, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Срок хранения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(158, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(158, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // edpr_button
            // 
            this.edpr_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.edpr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edpr_button.Location = new System.Drawing.Point(319, 375);
            this.edpr_button.Name = "edpr_button";
            this.edpr_button.Size = new System.Drawing.Size(200, 88);
            this.edpr_button.TabIndex = 16;
            this.edpr_button.Text = "Редактировать позицию";
            this.edpr_button.UseVisualStyleBackColor = false;
            this.edpr_button.Click += new System.EventHandler(this.edpr_button_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 562);
            this.Controls.Add(this.edpr_button);
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
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox add_give;
        private System.Windows.Forms.ComboBox add_type;
        private System.Windows.Forms.TextBox add_cost;
        private System.Windows.Forms.TextBox add_life;
        private System.Windows.Forms.TextBox add_number;
        private System.Windows.Forms.TextBox add_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edpr_button;
    }
}