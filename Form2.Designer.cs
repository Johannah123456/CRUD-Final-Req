namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dtpBirthdate = new DateTimePicker();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtTitle = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgwCustomers = new DataGridView();
            textBox4 = new TextBox();
            txtSearch = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Playfair Display Medium", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 0;
            label1.Text = "Basic CRUD";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(dtpBirthdate);
            panel1.Controls.Add(txtCountry);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 343);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(246, 257);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 32);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGreen;
            btnUpdate.Location = new Point(130, 257);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 32);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Info;
            btnInsert.Location = new Point(15, 257);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(99, 32);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(95, 126);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(240, 23);
            dtpBirthdate.TabIndex = 12;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(95, 204);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(240, 23);
            txtCountry.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(95, 164);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(240, 23);
            txtCity.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(95, 88);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(240, 23);
            txtTitle.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 17);
            txtID.Name = "txtID";
            txtID.Size = new Size(240, 23);
            txtID.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 209);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 5;
            label7.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 169);
            label6.Name = "label6";
            label6.Size = new Size(35, 18);
            label6.TabIndex = 4;
            label6.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 131);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 3;
            label5.Text = "Birthdate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 93);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 2;
            label4.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // dgwCustomers
            // 
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Location = new Point(424, 51);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.RowTemplate.Height = 25;
            dgwCustomers.Size = new Size(462, 356);
            dgwCustomers.TabIndex = 2;
            dgwCustomers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(546, 17);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 17;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ImageAlign = ContentAlignment.MiddleLeft;
            txtSearch.Location = new Point(471, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(58, 18);
            txtSearch.TabIndex = 16;
            txtSearch.Text = "Search";
            txtSearch.Click += label8_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(897, 419);
            Controls.Add(textBox4);
            Controls.Add(txtSearch);
            Controls.Add(dgwCustomers);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DateTimePicker dtpBirthdate;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtTitle;
        private TextBox txtName;
        private TextBox txtID;
        private Label label7;
        private DataGridView dgwCustomers;
        private TextBox textBox4;
        private Label txtSearch;
    }
}