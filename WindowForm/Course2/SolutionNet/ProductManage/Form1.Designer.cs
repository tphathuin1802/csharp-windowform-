namespace ProductManage
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtCode = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNewSave = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            lvProduct = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            sYSTEMToolStripMenuItem = new ToolStripMenuItem();
            menuSystemSaveBinary = new ToolStripMenuItem();
            menuSystemReadBinary = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuSystemExit = new ToolStripMenuItem();
            menuSystemReadJsonFile = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 53, 85);
            label1.Location = new Point(283, 39);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 11;
            label1.Text = "PRODUCT MANAGEMENT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("SF Mono", 14.2574253F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(33, 53, 85);
            groupBox1.Location = new Point(26, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(810, 279);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETAIL";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(241, 211);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(539, 31);
            txtPrice.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 214);
            label4.Name = "label4";
            label4.Size = new Size(166, 24);
            label4.TabIndex = 14;
            label4.Text = "PRODUCT PRICE";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(241, 155);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(539, 31);
            txtQuantity.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 158);
            label3.Name = "label3";
            label3.Size = new Size(202, 24);
            label3.TabIndex = 12;
            label3.Text = "PRODUCT QUANTITY";
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(539, 31);
            txtName.TabIndex = 11;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 109);
            label2.Name = "label2";
            label2.Size = new Size(154, 24);
            label2.TabIndex = 10;
            label2.Text = "PRODUCT NAME";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(241, 59);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(539, 31);
            txtCode.TabIndex = 9;
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 62);
            label5.Name = "label5";
            label5.Size = new Size(154, 24);
            label5.TabIndex = 8;
            label5.Text = "PRODUCT CODE";
            label5.Click += label5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnNewSave);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("SF Mono", 14.2574253F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(33, 53, 85);
            groupBox2.Location = new Point(26, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(810, 107);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "FUNCTION";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(62, 88, 121);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(616, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 55);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(62, 88, 121);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(427, 30);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(149, 55);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnNewSave
            // 
            btnNewSave.BackColor = Color.FromArgb(62, 88, 121);
            btnNewSave.ForeColor = Color.White;
            btnNewSave.Location = new Point(241, 30);
            btnNewSave.Name = "btnNewSave";
            btnNewSave.Size = new Size(149, 55);
            btnNewSave.TabIndex = 5;
            btnNewSave.Text = "NEW SAVE";
            btnNewSave.UseVisualStyleBackColor = false;
            btnNewSave.Click += btnNewSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(62, 88, 121);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(45, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 55);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThemmoi_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lvProduct);
            groupBox3.Font = new Font("SF Mono", 14.2574253F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(26, 492);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(810, 322);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "LIST OF PRODUCTS";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lvProduct
            // 
            lvProduct.BorderStyle = BorderStyle.FixedSingle;
            lvProduct.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvProduct.Dock = DockStyle.Fill;
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            lvProduct.Location = new Point(3, 27);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(804, 292);
            lvProduct.TabIndex = 0;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PRODUCT CODE";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PRODUCT NAME";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRODUCT QUANTITY";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "PRODUCT PRICE";
            columnHeader4.Width = 300;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(17, 17);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(62, 88, 121);
            menuStrip1.ImageScalingSize = new Size(17, 17);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sYSTEMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(859, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // sYSTEMToolStripMenuItem
            // 
            sYSTEMToolStripMenuItem.BackColor = Color.FromArgb(216, 196, 182);
            sYSTEMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuSystemSaveBinary, menuSystemReadBinary, toolStripSeparator1, menuSystemExit, menuSystemReadJsonFile });
            sYSTEMToolStripMenuItem.Font = new Font("SF Mono", 12.1188116F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sYSTEMToolStripMenuItem.ForeColor = Color.FromArgb(33, 53, 85);
            sYSTEMToolStripMenuItem.Name = "sYSTEMToolStripMenuItem";
            sYSTEMToolStripMenuItem.Size = new Size(87, 24);
            sYSTEMToolStripMenuItem.Text = "SYSTEM";
            sYSTEMToolStripMenuItem.Click += sYSTEMToolStripMenuItem_Click;
            // 
            // menuSystemSaveBinary
            // 
            menuSystemSaveBinary.Name = "menuSystemSaveBinary";
            menuSystemSaveBinary.Size = new Size(234, 24);
            menuSystemSaveBinary.Text = "SAVE BINARY";
            // 
            // menuSystemReadBinary
            // 
            menuSystemReadBinary.Name = "menuSystemReadBinary";
            menuSystemReadBinary.Size = new Size(234, 24);
            menuSystemReadBinary.Text = "READ BINARY";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(231, 6);
            // 
            // menuSystemExit
            // 
            menuSystemExit.Name = "menuSystemExit";
            menuSystemExit.Size = new Size(234, 24);
            menuSystemExit.Text = "EXIT";
            menuSystemExit.Click += eXITToolStripMenuItem_Click;
            // 
            // menuSystemReadJsonFile
            // 
            menuSystemReadJsonFile.Name = "menuSystemReadJsonFile";
            menuSystemReadJsonFile.Size = new Size(234, 24);
            menuSystemReadJsonFile.Text = "READ JSON FILE";
            menuSystemReadJsonFile.Click += menuSystemReadJsonFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 231);
            ClientSize = new Size(859, 848);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtCode;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNewSave;
        private Button btnAdd;
        private GroupBox groupBox3;
        private ListView lvProduct;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sYSTEMToolStripMenuItem;
        private ToolStripMenuItem menuSystemSaveBinary;
        private ToolStripMenuItem menuSystemReadBinary;
        private ToolStripMenuItem menuSystemExit;
        private ToolStripMenuItem menuSystemReadJsonFile;
        private ToolStripSeparator toolStripSeparator1;
    }
}
