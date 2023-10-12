namespace WindowsFormsApp1
{
    partial class information_student
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
            this.dgv_information_source = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_information_source)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_information_source
            // 
            this.dgv_information_source.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_information_source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_information_source.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.class_name});
            this.dgv_information_source.Location = new System.Drawing.Point(16, 276);
            this.dgv_information_source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_information_source.Name = "dgv_information_source";
            this.dgv_information_source.RowHeadersWidth = 51;
            this.dgv_information_source.Size = new System.Drawing.Size(632, 329);
            this.dgv_information_source.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(119, 40);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(392, 34);
            this.txt_search.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(375, 97);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 28);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Thêm";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(375, 140);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 28);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(375, 182);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(375, 230);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 28);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(548, 47);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(119, 103);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(191, 22);
            this.txt_id.TabIndex = 7;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 146);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 22);
            this.txt_name.TabIndex = 8;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(119, 188);
            this.txt_class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(191, 22);
            this.txt_class.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Class:";
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã sinh viên";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên sinh viên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.HeaderText = "Lớp";
            this.class_name.MinimumWidth = 6;
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // information_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_information_source);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "information_student";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.information_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_information_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_information_source;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
    }
}

