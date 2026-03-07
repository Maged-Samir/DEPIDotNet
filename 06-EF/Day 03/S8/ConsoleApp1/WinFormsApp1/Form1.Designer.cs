namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Add = new Button();
            txt_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_age = new TextBox();
            txt_address = new TextBox();
            dataGridView1 = new DataGridView();
            btn_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(27, 383);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(102, 39);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(104, 51);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(304, 27);
            txt_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(105, 96);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(303, 27);
            txt_age.TabIndex = 5;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(104, 141);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(303, 27);
            txt_address.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(424, 357);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(153, 383);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(108, 39);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(861, 450);
            Controls.Add(btn_edit);
            Controls.Add(dataGridView1);
            Controls.Add(txt_address);
            Controls.Add(txt_age);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(btn_Add);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Add;
        private TextBox txt_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_age;
        private TextBox txt_address;
        private DataGridView dataGridView1;
        private Button btn_edit;
    }
}
