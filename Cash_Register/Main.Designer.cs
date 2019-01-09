namespace Cash_Register
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodtxt = new System.Windows.Forms.TextBox();
            this.nanetxt = new System.Windows.Forms.TextBox();
            this.amountxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.jsonbtn = new System.Windows.Forms.Button();
            this.xmlbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.tblData = new System.Windows.Forms.DataGridView();
            this.productsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Cash_Register.AppData();
            this.productsDataTableAdapter = new Cash_Register.AppDataTableAdapters.ProductsDataTableAdapter();
            this.showbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(932, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "קוד פריט";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(936, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "שם פריט";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "כמות";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "מחיר לפריט";
            // 
            // barcodtxt
            // 
            this.barcodtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodtxt.Location = new System.Drawing.Point(755, 163);
            this.barcodtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barcodtxt.Name = "barcodtxt";
            this.barcodtxt.Size = new System.Drawing.Size(132, 22);
            this.barcodtxt.TabIndex = 1;
            // 
            // nanetxt
            // 
            this.nanetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nanetxt.Location = new System.Drawing.Point(755, 211);
            this.nanetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nanetxt.Name = "nanetxt";
            this.nanetxt.Size = new System.Drawing.Size(132, 22);
            this.nanetxt.TabIndex = 1;
            // 
            // amountxt
            // 
            this.amountxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountxt.Location = new System.Drawing.Point(755, 249);
            this.amountxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountxt.Name = "amountxt";
            this.amountxt.Size = new System.Drawing.Size(132, 22);
            this.amountxt.TabIndex = 1;
            // 
            // pricetxt
            // 
            this.pricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pricetxt.Location = new System.Drawing.Point(755, 294);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(132, 22);
            this.pricetxt.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addbtn.AutoEllipsis = true;
            this.addbtn.Location = new System.Drawing.Point(755, 336);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(249, 28);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "הכנס רשומה";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatebtn.Location = new System.Drawing.Point(755, 372);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(249, 28);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "עדכון רשומה";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletebtn.Location = new System.Drawing.Point(755, 408);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(249, 28);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "מחק רשומה";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // jsonbtn
            // 
            this.jsonbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jsonbtn.Location = new System.Drawing.Point(755, 485);
            this.jsonbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jsonbtn.Name = "jsonbtn";
            this.jsonbtn.Size = new System.Drawing.Size(249, 28);
            this.jsonbtn.TabIndex = 2;
            this.jsonbtn.Text = "Json יצוא נתונים ";
            this.jsonbtn.UseVisualStyleBackColor = true;
            this.jsonbtn.Click += new System.EventHandler(this.jsonbtn_Click);
            // 
            // xmlbtn
            // 
            this.xmlbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xmlbtn.Location = new System.Drawing.Point(755, 521);
            this.xmlbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xmlbtn.Name = "xmlbtn";
            this.xmlbtn.Size = new System.Drawing.Size(249, 28);
            this.xmlbtn.TabIndex = 2;
            this.xmlbtn.Text = "XML יצוא נתונים";
            this.xmlbtn.UseVisualStyleBackColor = true;
            this.xmlbtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "סה\"כ";
            // 
            // totaltxt
            // 
            this.totaltxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totaltxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totaltxt.Location = new System.Drawing.Point(552, 485);
            this.totaltxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(132, 22);
            this.totaltxt.TabIndex = 1;
            this.totaltxt.TextChanged += new System.EventHandler(this.totaltxt_TextChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitbtn.Location = new System.Drawing.Point(28, 490);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(105, 28);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "יציאה";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // tblData
            // 
            this.tblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblData.Location = new System.Drawing.Point(8, 107);
            this.tblData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblData.Name = "tblData";
            this.tblData.Size = new System.Drawing.Size(716, 346);
            this.tblData.TabIndex = 4;
            this.tblData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblData_CellClick);
            this.tblData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblData_CellContentClick);
            // 
            // productsDataBindingSource
            // 
            this.productsDataBindingSource.DataMember = "ProductsData";
            this.productsDataBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDataTableAdapter
            // 
            this.productsDataTableAdapter.ClearBeforeFill = true;
            // 
            // showbtn
            // 
            this.showbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showbtn.Location = new System.Drawing.Point(755, 107);
            this.showbtn.Margin = new System.Windows.Forms.Padding(4);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(132, 28);
            this.showbtn.TabIndex = 5;
            this.showbtn.Text = "הצג טבלה";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1049, 567);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.tblData);
            this.Controls.Add(this.xmlbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.jsonbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.amountxt);
            this.Controls.Add(this.nanetxt);
            this.Controls.Add(this.barcodtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox barcodtxt;
        private System.Windows.Forms.TextBox nanetxt;
        private System.Windows.Forms.TextBox amountxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button jsonbtn;
        private System.Windows.Forms.Button xmlbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridView tblData;
        private AppData appData;
        private System.Windows.Forms.BindingSource productsDataBindingSource;
        private AppDataTableAdapters.ProductsDataTableAdapter productsDataTableAdapter;
        private System.Windows.Forms.Button showbtn;
    }
}