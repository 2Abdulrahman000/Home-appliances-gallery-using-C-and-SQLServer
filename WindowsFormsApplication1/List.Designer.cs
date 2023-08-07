namespace WindowsFormsApplication1
{
    partial class List
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
            this.btn_goods = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_slidein = new System.Windows.Forms.Button();
            this.pan_sidein = new System.Windows.Forms.Panel();
            this.tmslidein = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_goods
            // 
            this.btn_goods.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_goods.CausesValidation = false;
            this.btn_goods.FlatAppearance.BorderSize = 0;
            this.btn_goods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goods.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goods.ForeColor = System.Drawing.Color.MintCream;
            this.btn_goods.Location = new System.Drawing.Point(14, 145);
            this.btn_goods.Name = "btn_goods";
            this.btn_goods.Padding = new System.Windows.Forms.Padding(5);
            this.btn_goods.Size = new System.Drawing.Size(266, 63);
            this.btn_goods.TabIndex = 0;
            this.btn_goods.Text = "Products";
            this.btn_goods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_goods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_goods.UseVisualStyleBackColor = false;
            this.btn_goods.Click += new System.EventHandler(this.button1_Click);
            this.btn_goods.MouseLeave += new System.EventHandler(this.btn_goods_MouseLeave);
            this.btn_goods.MouseHover += new System.EventHandler(this.btn_goods_MouseHover);
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.MintCream;
            this.btn_buy.Location = new System.Drawing.Point(14, 372);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Padding = new System.Windows.Forms.Padding(5);
            this.btn_buy.Size = new System.Drawing.Size(266, 63);
            this.btn_buy.TabIndex = 2;
            this.btn_buy.Text = "Sales Invoice";
            this.btn_buy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            this.btn_buy.MouseLeave += new System.EventHandler(this.btn_buy_MouseLeave);
            this.btn_buy.MouseHover += new System.EventHandler(this.btn_buy_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.MintCream;
            this.btn_close.Location = new System.Drawing.Point(14, 504);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(2);
            this.btn_close.Size = new System.Drawing.Size(266, 63);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Exit";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_supplier.FlatAppearance.BorderSize = 0;
            this.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplier.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplier.ForeColor = System.Drawing.Color.MintCream;
            this.btn_supplier.Location = new System.Drawing.Point(14, 262);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Padding = new System.Windows.Forms.Padding(5);
            this.btn_supplier.Size = new System.Drawing.Size(266, 63);
            this.btn_supplier.TabIndex = 1;
            this.btn_supplier.Text = "supplier";
            this.btn_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplier.UseVisualStyleBackColor = false;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            this.btn_supplier.MouseLeave += new System.EventHandler(this.btn_supplier_MouseLeave);
            this.btn_supplier.MouseHover += new System.EventHandler(this.btn_supplier_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_slidein);
            this.panel1.Controls.Add(this.pan_sidein);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 675);
            this.panel1.TabIndex = 6;
            // 
            // btn_slidein
            // 
            this.btn_slidein.BackColor = System.Drawing.Color.Teal;
            this.btn_slidein.FlatAppearance.BorderSize = 0;
            this.btn_slidein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_slidein.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slidein.ForeColor = System.Drawing.Color.MintCream;
            this.btn_slidein.Location = new System.Drawing.Point(0, 0);
            this.btn_slidein.Name = "btn_slidein";
            this.btn_slidein.Size = new System.Drawing.Size(57, 71);
            this.btn_slidein.TabIndex = 2;
            this.btn_slidein.Text = "=";
            this.btn_slidein.UseVisualStyleBackColor = false;
            this.btn_slidein.Click += new System.EventHandler(this.btn_slidein_Click);
            // 
            // pan_sidein
            // 
            this.pan_sidein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pan_sidein.Location = new System.Drawing.Point(60, 3);
            this.pan_sidein.Name = "pan_sidein";
            this.pan_sidein.Size = new System.Drawing.Size(277, 672);
            this.pan_sidein.TabIndex = 1;
            // 
            // tmslidein
            // 
            this.tmslidein.Tick += new System.EventHandler(this.tmslidein_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_goods);
            this.panel2.Controls.Add(this.btn_supplier);
            this.panel2.Controls.Add(this.btn_buy);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Location = new System.Drawing.Point(58, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 675);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(81, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.images_jpeg_١٣;
            this.pictureBox1.Location = new System.Drawing.Point(346, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1294, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_goods;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pan_sidein;
        private System.Windows.Forms.Button btn_slidein;
        private System.Windows.Forms.Timer tmslidein;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}