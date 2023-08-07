namespace WindowsFormsApplication1
{
    partial class SalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoice));
            this.btn_refersh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_daman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvg_sales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lab_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_sales)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refersh
            // 
            this.btn_refersh.BackColor = System.Drawing.Color.White;
            this.btn_refersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refersh.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refersh.ForeColor = System.Drawing.Color.Teal;
            this.btn_refersh.Location = new System.Drawing.Point(1134, 170);
            this.btn_refersh.Name = "btn_refersh";
            this.btn_refersh.Size = new System.Drawing.Size(155, 44);
            this.btn_refersh.TabIndex = 47;
            this.btn_refersh.Text = "Refresh";
            this.btn_refersh.UseVisualStyleBackColor = false;
            this.btn_refersh.Click += new System.EventHandler(this.btn_refersh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Teal;
            this.btn_search.Location = new System.Drawing.Point(941, 170);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 44);
            this.btn_search.TabIndex = 46;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MintCream;
            this.panel7.Location = new System.Drawing.Point(676, 213);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 1);
            this.panel7.TabIndex = 32;
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteCustomSource.AddRange(new string[] {
            "مكنسة",
            "مضرب بيض",
            "خلاط",
            "عصارة",
            "شفاط",
            "غلاية",
            "مروحة",
            "مفرمة",
            "مكواة",
            "فرن كهربى",
            "محضرة",
            "بوتجاز",
            "سخان",
            "غسالة",
            "مبرد مياه",
            "تكيف",
            "فرن",
            "غسالة اطباق",
            "تلاجة",
            "شاشة",
            "مايكروويف",
            "شواية",
            "مقلاة",
            "عجان",
            "كيتشن ماشين",
            "ديب فريزر",
            "ريسيفر",
            "دش",
            "بلاى ستيشن",
            "كمبيوتر",
            "فلتر ",
            "صاعق للناموس",
            "ترابيزة مكواة",
            "مضرب نسكافية",
            "مطحنة"});
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.BackColor = System.Drawing.Color.Teal;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_search.Location = new System.Drawing.Point(676, 184);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 23);
            this.txt_search.TabIndex = 45;
            this.txt_search.Text = "Search Here";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Teal;
            this.btn_home.Location = new System.Drawing.Point(133, 514);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(196, 56);
            this.btn_home.TabIndex = 43;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.White;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.Teal;
            this.btn_bill.Location = new System.Drawing.Point(386, 414);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(170, 56);
            this.btn_bill.TabIndex = 42;
            this.btn_bill.Text = "New Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.BackColor = System.Drawing.Color.White;
            this.btn_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discount.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discount.ForeColor = System.Drawing.Color.Teal;
            this.btn_discount.Location = new System.Drawing.Point(134, 414);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(195, 56);
            this.btn_discount.TabIndex = 41;
            this.btn_discount.Text = "Discount";
            this.btn_discount.UseVisualStyleBackColor = false;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Teal;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_name.Location = new System.Drawing.Point(284, 108);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(233, 27);
            this.txt_name.TabIndex = 39;
            this.txt_name.Text = "Name";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(847, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 48);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sales Menu";
            // 
            // txt_daman
            // 
            this.txt_daman.BackColor = System.Drawing.Color.Teal;
            this.txt_daman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_daman.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_daman.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_daman.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_daman.Location = new System.Drawing.Point(284, 258);
            this.txt_daman.Name = "txt_daman";
            this.txt_daman.Size = new System.Drawing.Size(233, 28);
            this.txt_daman.TabIndex = 37;
            this.txt_daman.Text = "Daman";
            this.txt_daman.Enter += new System.EventHandler(this.txt_daman_Enter);
            this.txt_daman.Leave += new System.EventHandler(this.txt_daman_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(129, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Daman";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Location = new System.Drawing.Point(284, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 1);
            this.panel4.TabIndex = 35;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.Teal;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_price.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_price.Location = new System.Drawing.Point(284, 182);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(233, 28);
            this.txt_price.TabIndex = 34;
            this.txt_price.Text = "Price";
            this.txt_price.Enter += new System.EventHandler(this.txt_price_Enter);
            this.txt_price.Leave += new System.EventHandler(this.txt_price_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(129, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Location = new System.Drawing.Point(284, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 1);
            this.panel3.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(129, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Location = new System.Drawing.Point(284, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 26;
            // 
            // dvg_sales
            // 
            this.dvg_sales.AllowUserToAddRows = false;
            this.dvg_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_sales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_sales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvg_sales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_sales.Location = new System.Drawing.Point(590, 220);
            this.dvg_sales.MultiSelect = false;
            this.dvg_sales.Name = "dvg_sales";
            this.dvg_sales.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_sales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvg_sales.RowTemplate.Height = 26;
            this.dvg_sales.Size = new System.Drawing.Size(778, 545);
            this.dvg_sales.TabIndex = 25;
            this.dvg_sales.SelectionChanged += new System.EventHandler(this.dvg_sales_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Location = new System.Drawing.Point(1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 45);
            this.panel2.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MintCream;
            this.panel5.Location = new System.Drawing.Point(1, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 760);
            this.panel5.TabIndex = 0;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.White;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.Teal;
            this.btn_pdf.Location = new System.Drawing.Point(386, 514);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(170, 56);
            this.btn_pdf.TabIndex = 50;
            this.btn_pdf.Text = "Save ";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.lab_total);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(209, 621);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(248, 113);
            this.panel12.TabIndex = 56;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total.ForeColor = System.Drawing.Color.Azure;
            this.lab_total.Location = new System.Drawing.Point(89, 62);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(81, 36);
            this.lab_total.TabIndex = 1;
            this.lab_total.Text = "0.00";
            this.lab_total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(79, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // SalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1369, 771);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_refersh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.btn_discount);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_daman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg_sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesInvoice";
            this.Load += new System.EventHandler(this.SalesInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_sales)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refersh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_daman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvg_sales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}