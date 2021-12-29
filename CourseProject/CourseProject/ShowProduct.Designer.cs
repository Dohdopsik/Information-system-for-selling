namespace CourseProject
{
    partial class ShowProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.артикулТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Производитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ТипТовара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Add_button = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулТовараDataGridViewTextBoxColumn,
            this.названиеТовараDataGridViewTextBoxColumn,
            this.Производитель,
            this.ТипТовара,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 243);
            this.dataGridView1.TabIndex = 1;
            // 
            // артикулТовараDataGridViewTextBoxColumn
            // 
            this.артикулТовараDataGridViewTextBoxColumn.DataPropertyName = "АртикулТовара";
            this.артикулТовараDataGridViewTextBoxColumn.HeaderText = "АртикулТовара";
            this.артикулТовараDataGridViewTextBoxColumn.Name = "артикулТовараDataGridViewTextBoxColumn";
            // 
            // названиеТовараDataGridViewTextBoxColumn
            // 
            this.названиеТовараDataGridViewTextBoxColumn.DataPropertyName = "НазваниеТовара";
            this.названиеТовараDataGridViewTextBoxColumn.HeaderText = "НазваниеТовара";
            this.названиеТовараDataGridViewTextBoxColumn.Name = "названиеТовараDataGridViewTextBoxColumn";
            // 
            // Производитель
            // 
            this.Производитель.DataPropertyName = "Производитель";
            this.Производитель.HeaderText = "Производитель";
            this.Производитель.Name = "Производитель";
            // 
            // ТипТовара
            // 
            this.ТипТовара.DataPropertyName = "ТипТовара";
            this.ТипТовара.HeaderText = "ТипТовара";
            this.ТипТовара.Name = "ТипТовара";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CourseProject.Product);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(3, 261);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(133, 32);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Del_button
            // 
            this.Del_button.Location = new System.Drawing.Point(413, 261);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(133, 32);
            this.Del_button.TabIndex = 3;
            this.Del_button.Text = "Удалить";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(558, 375);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowProduct";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Производитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТипТовара;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Del_button;
    }
}