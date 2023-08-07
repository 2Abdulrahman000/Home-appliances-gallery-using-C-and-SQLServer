namespace WindowsFormsApplication1
{
    partial class Goods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvg_products = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_daman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lab_letter = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_refersh = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_products
            // 
            this.dvg_products.AllowUserToAddRows = false;
            this.dvg_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_products.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_products.Location = new System.Drawing.Point(610, 233);
            this.dvg_products.Name = "dvg_products";
            this.dvg_products.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_products.RowTemplate.Height = 26;
            this.dvg_products.Size = new System.Drawing.Size(817, 567);
            this.dvg_products.TabIndex = 0;
            this.dvg_products.SelectionChanged += new System.EventHandler(this.dvg_products_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Location = new System.Drawing.Point(319, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(164, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txt_company
            // 
            this.txt_company.BackColor = System.Drawing.Color.Teal;
            this.txt_company.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_company.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_company.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_company.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_company.Location = new System.Drawing.Point(319, 228);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(233, 28);
            this.txt_company.TabIndex = 6;
            this.txt_company.Text = "Company";
            this.txt_company.Enter += new System.EventHandler(this.txt_company_Enter);
            this.txt_company.Leave += new System.EventHandler(this.txt_company_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(152, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Company";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Location = new System.Drawing.Point(319, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 1);
            this.panel2.TabIndex = 4;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.Teal;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_price.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_price.Location = new System.Drawing.Point(319, 302);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(233, 28);
            this.txt_price.TabIndex = 9;
            this.txt_price.Text = "Price";
            this.txt_price.Enter += new System.EventHandler(this.txt_price_Enter);
            this.txt_price.Leave += new System.EventHandler(this.txt_price_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(164, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Location = new System.Drawing.Point(319, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 1);
            this.panel3.TabIndex = 7;
            // 
            // txt_daman
            // 
            this.txt_daman.BackColor = System.Drawing.Color.Teal;
            this.txt_daman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_daman.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_daman.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_daman.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_daman.Location = new System.Drawing.Point(319, 378);
            this.txt_daman.Name = "txt_daman";
            this.txt_daman.Size = new System.Drawing.Size(233, 28);
            this.txt_daman.TabIndex = 12;
            this.txt_daman.Text = "Daman";
            this.txt_daman.Enter += new System.EventHandler(this.txt_daman_Enter);
            this.txt_daman.Leave += new System.EventHandler(this.txt_daman_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(164, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Daman";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Location = new System.Drawing.Point(319, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 1);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1452, 38);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 776);
            this.panel6.TabIndex = 14;
            // 
            // lab_letter
            // 
            this.lab_letter.AutoSize = true;
            this.lab_letter.Font = new System.Drawing.Font("Castellar", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_letter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_letter.Location = new System.Drawing.Point(853, 85);
            this.lab_letter.Name = "lab_letter";
            this.lab_letter.Size = new System.Drawing.Size(353, 40);
            this.lab_letter.TabIndex = 15;
            this.lab_letter.Text = "Products Menu";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Teal;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_name.Location = new System.Drawing.Point(319, 156);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 27);
            this.txt_name.TabIndex = 16;
            this.txt_name.Text = "Name";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter_2);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave_1);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Teal;
            this.btn_add.Location = new System.Drawing.Point(192, 508);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(142, 56);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Teal;
            this.btn_edit.Location = new System.Drawing.Point(410, 508);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(142, 56);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Teal;
            this.btn_delete.Location = new System.Drawing.Point(192, 685);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 56);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Teal;
            this.btn_home.Location = new System.Drawing.Point(410, 685);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(142, 56);
            this.btn_home.TabIndex = 20;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.White;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.Teal;
            this.btn_buy.Location = new System.Drawing.Point(301, 594);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(142, 56);
            this.btn_buy.TabIndex = 21;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.BackColor = System.Drawing.Color.Teal;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(828, 190);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(233, 32);
            this.txt_search.TabIndex = 22;
            this.txt_search.Text = "Search Here";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MintCream;
            this.panel7.Location = new System.Drawing.Point(828, 219);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 1);
            this.panel7.TabIndex = 8;
            // 
            // btn_refersh
            // 
            this.btn_refersh.BackColor = System.Drawing.Color.White;
            this.btn_refersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refersh.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refersh.ForeColor = System.Drawing.Color.Teal;
            this.btn_refersh.Location = new System.Drawing.Point(1272, 183);
            this.btn_refersh.Name = "btn_refersh";
            this.btn_refersh.Size = new System.Drawing.Size(155, 44);
            this.btn_refersh.TabIndex = 24;
            this.btn_refersh.Text = "Refresh";
            this.btn_refersh.UseVisualStyleBackColor = false;
            this.btn_refersh.Click += new System.EventHandler(this.btn_refersh_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Teal;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_id.Location = new System.Drawing.Point(319, 94);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 27);
            this.txt_id.TabIndex = 27;
            this.txt_id.Text = "ID";
            this.txt_id.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(164, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "ID";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MintCream;
            this.panel8.Location = new System.Drawing.Point(319, 124);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 1);
            this.panel8.TabIndex = 25;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Teal;
            this.btn_search.Location = new System.Drawing.Point(1089, 183);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 44);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(635, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Search Here";
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1425, 797);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btn_refersh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lab_letter);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_daman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Goods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods";
            this.Load += new System.EventHandler(this.Goods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_daman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab_letter;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_refersh;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
    }
}