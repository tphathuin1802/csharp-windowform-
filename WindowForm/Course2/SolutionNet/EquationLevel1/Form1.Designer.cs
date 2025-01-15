namespace EquationLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCofA = new TextBox();
            txtCofB = new TextBox();
            btnSolve = new Button();
            btnNext = new Button();
            btnExit = new Button();
            label4 = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 53, 85);
            label1.Location = new Point(296, 30);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "EQUATION LEVEL 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 53, 85);
            label2.Location = new Point(54, 105);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 1;
            label2.Text = "COF A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(33, 53, 85);
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 3;
            label3.Text = "COF B";
            // 
            // txtCofA
            // 
            txtCofA.Location = new Point(148, 96);
            txtCofA.Multiline = true;
            txtCofA.Name = "txtCofA";
            txtCofA.Size = new Size(545, 53);
            txtCofA.TabIndex = 2;
            txtCofA.TextChanged += txtCofA_TextChanged;
            // 
            // txtCofB
            // 
            txtCofB.Location = new Point(148, 174);
            txtCofB.Multiline = true;
            txtCofB.Name = "txtCofB";
            txtCofB.Size = new Size(545, 53);
            txtCofB.TabIndex = 4;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = Color.FromArgb(62, 88, 121);
            btnSolve.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.ForeColor = Color.Transparent;
            btnSolve.Location = new Point(148, 324);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(166, 62);
            btnSolve.TabIndex = 7;
            btnSolve.Text = "SOLVE";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(62, 88, 121);
            btnNext.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(320, 324);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(191, 62);
            btnNext.TabIndex = 8;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(62, 88, 121);
            btnExit.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(517, 324);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 62);
            btnExit.TabIndex = 9;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(33, 53, 85);
            label4.Location = new Point(39, 259);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 5;
            label4.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(148, 251);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(545, 53);
            txtResult.TabIndex = 6;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 239, 231);
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnNext);
            Controls.Add(btnSolve);
            Controls.Add(txtCofB);
            Controls.Add(txtCofA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(216, 196, 182);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EQUATION LEVEL 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCofA;
        private TextBox txtCofB;
        private Button btnSolve;
        private Button btnNext;
        private Button btnExit;
        private Label label4;
        private TextBox txtResult;
    }
}
