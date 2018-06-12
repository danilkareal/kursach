namespace kursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Insert_Click = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_вид = new System.Windows.Forms.TextBox();
            this.textBox_един = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BNT_Seach = new System.Windows.Forms.Button();
            this.textBox_рекорд = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // BTN_Insert_Click
            // 
            this.BTN_Insert_Click.Location = new System.Drawing.Point(71, 359);
            this.BTN_Insert_Click.Name = "BTN_Insert_Click";
            this.BTN_Insert_Click.Size = new System.Drawing.Size(80, 31);
            this.BTN_Insert_Click.TabIndex = 1;
            this.BTN_Insert_Click.Text = "INSERT";
            this.BTN_Insert_Click.UseVisualStyleBackColor = true;
            this.BTN_Insert_Click.Click += new System.EventHandler(this.BTN_Insert_Click_Click_1);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(157, 359);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(80, 31);
            this.BTN_Update.TabIndex = 2;
            this.BTN_Update.Text = "UPDATE";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(243, 359);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(80, 31);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "DELETE";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(95, 124);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(32, 22);
            this.textBox_id.TabIndex = 4;
            this.textBox_id.Text = "1";
            this.textBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_вид
            // 
            this.textBox_вид.Location = new System.Drawing.Point(119, 164);
            this.textBox_вид.Name = "textBox_вид";
            this.textBox_вид.Size = new System.Drawing.Size(100, 22);
            this.textBox_вид.TabIndex = 5;
            // 
            // textBox_един
            // 
            this.textBox_един.Location = new System.Drawing.Point(119, 192);
            this.textBox_един.Name = "textBox_един";
            this.textBox_един.Size = new System.Drawing.Size(100, 22);
            this.textBox_един.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "вид_спорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ед_изм";
            // 
            // BNT_Seach
            // 
            this.BNT_Seach.Location = new System.Drawing.Point(133, 124);
            this.BNT_Seach.Name = "BNT_Seach";
            this.BNT_Seach.Size = new System.Drawing.Size(75, 23);
            this.BNT_Seach.TabIndex = 10;
            this.BNT_Seach.Text = "Find";
            this.BNT_Seach.UseVisualStyleBackColor = true;
            this.BNT_Seach.Click += new System.EventHandler(this.BNT_Seach_Click);
            // 
            // textBox_рекорд
            // 
            this.textBox_рекорд.Location = new System.Drawing.Point(119, 220);
            this.textBox_рекорд.Name = "textBox_рекорд";
            this.textBox_рекорд.Size = new System.Drawing.Size(100, 22);
            this.textBox_рекорд.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "рекорд";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_рекорд);
            this.Controls.Add(this.BNT_Seach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_един);
            this.Controls.Add(this.textBox_вид);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Insert_Click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Insert_Click;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_вид;
        private System.Windows.Forms.TextBox textBox_един;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BNT_Seach;
        private System.Windows.Forms.TextBox textBox_рекорд;
        private System.Windows.Forms.Label label4;
    }
}

