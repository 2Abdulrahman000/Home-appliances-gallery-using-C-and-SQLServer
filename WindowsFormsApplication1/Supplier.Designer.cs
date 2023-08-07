namespace WindowsFormsApplication1
{
    partial class Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_refersh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_client = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_rest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvg_supplier = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lab_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lab_pay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lab_reset = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_supplier)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refersh
            // 
            this.btn_refersh.BackColor = System.Drawing.Color.White;
            this.btn_refersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refersh.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refersh.ForeColor = System.Drawing.Color.Teal;
            this.btn_refersh.Location = new System.Drawing.Point(1232, 162);
            this.btn_refersh.Name = "btn_refersh";
            this.btn_refersh.Size = new System.Drawing.Size(155, 44);
            this.btn_refersh.TabIndex = 49;
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
            this.btn_search.Location = new System.Drawing.Point(1049, 161);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 44);
            this.btn_search.TabIndex = 48;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MintCream;
            this.panel7.Location = new System.Drawing.Point(736, 204);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 1);
            this.panel7.TabIndex = 32;
            // 
            // txt_search
            // 
            this.txt_search.AutoCompleteCustomSource.AddRange(new string[] {
            "Abdo Elkaabany",
            "Sharif",
            "Eldesoky",
            "Ibrahim ",
            "sakr",
            "Fawzi Gaber"});
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.BackColor = System.Drawing.Color.Teal;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_search.Location = new System.Drawing.Point(736, 175);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 23);
            this.txt_search.TabIndex = 47;
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
            this.btn_home.Location = new System.Drawing.Point(334, 666);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(142, 56);
            this.btn_home.TabIndex = 45;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Teal;
            this.btn_delete.Location = new System.Drawing.Point(118, 666);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 56);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Teal;
            this.btn_edit.Location = new System.Drawing.Point(334, 576);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(142, 56);
            this.btn_edit.TabIndex = 43;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Teal;
            this.btn_add.Location = new System.Drawing.Point(118, 576);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(142, 56);
            this.btn_add.TabIndex = 42;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_client
            // 
            this.txt_client.BackColor = System.Drawing.Color.Teal;
            this.txt_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_client.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_client.Location = new System.Drawing.Point(280, 132);
            this.txt_client.Name = "txt_client";
            this.txt_client.Size = new System.Drawing.Size(233, 27);
            this.txt_client.TabIndex = 41;
            this.txt_client.Text = "Client";
            this.txt_client.Enter += new System.EventHandler(this.txt_client_Enter);
            this.txt_client.Leave += new System.EventHandler(this.txt_client_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(834, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 40);
            this.label5.TabIndex = 40;
            this.label5.Text = "Supplier Menu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Location = new System.Drawing.Point(-134, -39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1452, 38);
            this.panel5.TabIndex = 38;
            // 
            // txt_rest
            // 
            this.txt_rest.BackColor = System.Drawing.Color.Teal;
            this.txt_rest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rest.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_rest.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rest.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_rest.Location = new System.Drawing.Point(280, 354);
            this.txt_rest.Name = "txt_rest";
            this.txt_rest.Size = new System.Drawing.Size(233, 28);
            this.txt_rest.TabIndex = 37;
            this.txt_rest.Text = "Rest";
            this.txt_rest.Enter += new System.EventHandler(this.txt_rest_Enter);
            this.txt_rest.Leave += new System.EventHandler(this.txt_rest_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(139, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Rest";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.Location = new System.Drawing.Point(280, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 1);
            this.panel4.TabIndex = 35;
            // 
            // txt_pay
            // 
            this.txt_pay.BackColor = System.Drawing.Color.Teal;
            this.txt_pay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pay.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pay.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pay.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_pay.Location = new System.Drawing.Point(280, 278);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(233, 28);
            this.txt_pay.TabIndex = 34;
            this.txt_pay.Text = "Payment";
            this.txt_pay.Enter += new System.EventHandler(this.txt_pay_Enter);
            this.txt_pay.Leave += new System.EventHandler(this.txt_pay_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(113, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Payment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Location = new System.Drawing.Point(280, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 1);
            this.panel3.TabIndex = 31;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.Teal;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_total.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_total.Location = new System.Drawing.Point(280, 204);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(233, 28);
            this.txt_total.TabIndex = 30;
            this.txt_total.Text = "Total";
            this.txt_total.Enter += new System.EventHandler(this.txt_total_Enter);
            this.txt_total.Leave += new System.EventHandler(this.txt_total_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(125, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Location = new System.Drawing.Point(280, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 1);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Location = new System.Drawing.Point(280, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 1);
            this.panel1.TabIndex = 26;
            // 
            // dvg_supplier
            // 
            this.dvg_supplier.AllowUserToAddRows = false;
            this.dvg_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_supplier.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvg_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_supplier.Location = new System.Drawing.Point(562, 220);
            this.dvg_supplier.MultiSelect = false;
            this.dvg_supplier.Name = "dvg_supplier";
            this.dvg_supplier.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_supplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvg_supplier.RowTemplate.Height = 26;
            this.dvg_supplier.Size = new System.Drawing.Size(843, 457);
            this.dvg_supplier.TabIndex = 25;
            this.dvg_supplier.SelectionChanged += new System.EventHandler(this.dvg_supplier_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MintCream;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1463, 42);
            this.panel6.TabIndex = 50;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Honeydew;
            this.panel8.Location = new System.Drawing.Point(12, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(108, 778);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MintCream;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(105, 868);
            this.panel9.TabIndex = 51;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.White;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.Teal;
            this.btn_pdf.Location = new System.Drawing.Point(118, 758);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(142, 60);
            this.btn_pdf.TabIndex = 52;
            this.btn_pdf.Text = "Save as File";
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MintCream;
            this.panel10.Controls.Add(this.lab_total);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(622, 680);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 113);
            this.panel10.TabIndex = 53;
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total.ForeColor = System.Drawing.Color.Teal;
            this.lab_total.Location = new System.Drawing.Point(32, 55);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(81, 36);
            this.lab_total.TabIndex = 1;
            this.lab_total.Text = "0.00";
            this.lab_total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(55, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SpringGreen;
            this.panel11.Controls.Add(this.lab_pay);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(897, 680);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(221, 113);
            this.panel11.TabIndex = 54;
            // 
            // lab_pay
            // 
            this.lab_pay.AutoSize = true;
            this.lab_pay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pay.ForeColor = System.Drawing.Color.Azure;
            this.lab_pay.Location = new System.Drawing.Point(33, 55);
            this.lab_pay.Name = "lab_pay";
            this.lab_pay.Size = new System.Drawing.Size(81, 36);
            this.lab_pay.TabIndex = 1;
            this.lab_pay.Text = "0.00";
            this.lab_pay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(28, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Payment";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.lab_reset);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(1171, 680);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(216, 113);
            this.panel12.TabIndex = 55;
            // 
            // lab_reset
            // 
            this.lab_reset.AutoSize = true;
            this.lab_reset.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_reset.ForeColor = System.Drawing.Color.Azure;
            this.lab_reset.Location = new System.Drawing.Point(18, 55);
            this.lab_reset.Name = "lab_reset";
            this.lab_reset.Size = new System.Drawing.Size(81, 36);
            this.lab_reset.TabIndex = 1;
            this.lab_reset.Text = "0.00";
            this.lab_reset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(55, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rest";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(275, 430);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(238, 24);
            this.date.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(139, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Date";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Teal;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_id.Location = new System.Drawing.Point(275, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 27);
            this.txt_id.TabIndex = 60;
            this.txt_id.Text = "ID";
            this.txt_id.Enter += new System.EventHandler(this.txt_id_Enter);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(139, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 29);
            this.label9.TabIndex = 59;
            this.label9.Text = "ID";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MintCream;
            this.panel13.Location = new System.Drawing.Point(275, 102);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(233, 1);
            this.panel13.TabIndex = 58;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1406, 838);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_refersh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_client);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_rest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg_supplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_supplier)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
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
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_client;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_rest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvg_supplier;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lab_pay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lab_reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
    }
}