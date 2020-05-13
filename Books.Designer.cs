namespace MoserPereiraLab4
{
    partial class Books
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
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label onHandQuantityLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productCodeLabel2 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new MoserPereiraLab4.BooksDataSet();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.unitPriceLabel1 = new System.Windows.Forms.Label();
            this.onHandQuantityLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.cboLanquage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.productsTableAdapter = new MoserPereiraLab4.BooksDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new MoserPereiraLab4.BooksDataSetTableAdapters.TableAdapterManager();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picLast = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.PictureBox();
            this.picFirst = new System.Windows.Forms.PictureBox();
            productCodeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            onHandQuantityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(8, 23);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(56, 19);
            productCodeLabel.TabIndex = 0;
            productCodeLabel.Text = "Code:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 51);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(47, 19);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Title:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(8, 116);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(54, 19);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "Price:";
            // 
            // onHandQuantityLabel
            // 
            onHandQuantityLabel.AutoSize = true;
            onHandQuantityLabel.Location = new System.Drawing.Point(8, 143);
            onHandQuantityLabel.Name = "onHandQuantityLabel";
            onHandQuantityLabel.Size = new System.Drawing.Size(59, 19);
            onHandQuantityLabel.TabIndex = 6;
            onHandQuantityLabel.Text = "Stock:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productCodeLabel2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblTotalStock);
            this.groupBox1.Controls.Add(this.lblAvgPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(productCodeLabel);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionLabel1);
            this.groupBox1.Controls.Add(unitPriceLabel);
            this.groupBox1.Controls.Add(this.unitPriceLabel1);
            this.groupBox1.Controls.Add(onHandQuantityLabel);
            this.groupBox1.Controls.Add(this.onHandQuantityLabel1);
            this.groupBox1.Location = new System.Drawing.Point(20, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(365, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // productCodeLabel2
            // 
            this.productCodeLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productCodeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeLabel2.Location = new System.Drawing.Point(70, 23);
            this.productCodeLabel2.Name = "productCodeLabel2";
            this.productCodeLabel2.Size = new System.Drawing.Size(100, 23);
            this.productCodeLabel2.TabIndex = 13;
            this.productCodeLabel2.Text = "label5";
            this.productCodeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.booksDataSet;
            this.productsBindingSource.CurrentChanged += new System.EventHandler(this.productsBindingSource_CurrentChanged);
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(230, 189);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalStock.Location = new System.Drawing.Point(126, 206);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(70, 21);
            this.lblTotalStock.TabIndex = 11;
            this.lblTotalStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAvgPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvgPrice.Location = new System.Drawing.Point(126, 178);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(70, 21);
            this.lblAvgPrice.TabIndex = 10;
            this.lblAvgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Avg Price:";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(70, 51);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(275, 60);
            this.descriptionLabel1.TabIndex = 3;
            this.descriptionLabel1.Text = "label1";
            // 
            // unitPriceLabel1
            // 
            this.unitPriceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.unitPriceLabel1.Location = new System.Drawing.Point(70, 116);
            this.unitPriceLabel1.Name = "unitPriceLabel1";
            this.unitPriceLabel1.Size = new System.Drawing.Size(100, 23);
            this.unitPriceLabel1.TabIndex = 5;
            this.unitPriceLabel1.Text = "label1";
            this.unitPriceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // onHandQuantityLabel1
            // 
            this.onHandQuantityLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onHandQuantityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "OnHandQuantity", true));
            this.onHandQuantityLabel1.Location = new System.Drawing.Point(70, 143);
            this.onHandQuantityLabel1.Name = "onHandQuantityLabel1";
            this.onHandQuantityLabel1.Size = new System.Drawing.Size(100, 23);
            this.onHandQuantityLabel1.TabIndex = 7;
            this.onHandQuantityLabel1.Text = "label1";
            this.onHandQuantityLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudMax);
            this.groupBox2.Controls.Add(this.nudMin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAverage);
            this.groupBox2.Controls.Add(this.cboLanquage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(421, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(227, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(54, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 42);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "→";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(148, 186);
            this.nudMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(64, 26);
            this.nudMax.TabIndex = 5;
            this.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMax.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(13, 186);
            this.nudMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(64, 26);
            this.nudMin.TabIndex = 4;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock Between:";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(54, 97);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(135, 42);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "> &Avg Price";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // cboLanquage
            // 
            this.cboLanquage.FormattingEnabled = true;
            this.cboLanquage.Items.AddRange(new object[] {
            "ASP.NET",
            "C#",
            "Cobol",
            "Java",
            "VB"});
            this.cboLanquage.Location = new System.Drawing.Point(9, 50);
            this.cboLanquage.Name = "cboLanquage";
            this.cboLanquage.Size = new System.Drawing.Size(203, 27);
            this.cboLanquage.TabIndex = 1;
            this.cboLanquage.SelectedIndexChanged += new System.EventHandler(this.cboLanquage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Language:";
            // 
            // lblNavigation
            // 
            this.lblNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNavigation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.lblNavigation.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNavigation.Location = new System.Drawing.Point(122, 9);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(160, 34);
            this.lblNavigation.TabIndex = 13;
            this.lblNavigation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoiceLineItemsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.OrderOptionsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MoserPereiraLab4.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // picNext
            // 
            this.picNext.Image = global::MoserPereiraLab4.Properties.Resources.arrowNext;
            this.picNext.Location = new System.Drawing.Point(298, 9);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(35, 34);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 17;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picLast
            // 
            this.picLast.Image = global::MoserPereiraLab4.Properties.Resources.arrowLast;
            this.picLast.Location = new System.Drawing.Point(349, 9);
            this.picLast.Name = "picLast";
            this.picLast.Size = new System.Drawing.Size(35, 34);
            this.picLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLast.TabIndex = 16;
            this.picLast.TabStop = false;
            this.picLast.Click += new System.EventHandler(this.picLast_Click);
            // 
            // picPrev
            // 
            this.picPrev.Image = global::MoserPereiraLab4.Properties.Resources.arrowPrev;
            this.picPrev.Location = new System.Drawing.Point(71, 9);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(35, 34);
            this.picPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrev.TabIndex = 15;
            this.picPrev.TabStop = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // picFirst
            // 
            this.picFirst.Image = global::MoserPereiraLab4.Properties.Resources.arrowFirst;
            this.picFirst.Location = new System.Drawing.Point(20, 9);
            this.picFirst.Name = "picFirst";
            this.picFirst.Size = new System.Drawing.Size(35, 34);
            this.picFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirst.TabIndex = 14;
            this.picFirst.TabStop = false;
            this.picFirst.Click += new System.EventHandler(this.picFirst_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 330);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picLast);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.picFirst);
            this.Controls.Add(this.lblNavigation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books by Fernando";
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private BooksDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label unitPriceLabel1;
        private System.Windows.Forms.Label onHandQuantityLabel1;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label productCodeLabel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.ComboBox cboLanquage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picFirst;
        private System.Windows.Forms.PictureBox picPrev;
        private System.Windows.Forms.PictureBox picLast;
        private System.Windows.Forms.PictureBox picNext;
    }
}