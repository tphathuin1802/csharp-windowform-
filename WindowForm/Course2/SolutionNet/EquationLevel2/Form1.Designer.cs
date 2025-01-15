namespace EquationLevel2
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
            txtResult = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnNext = new Button();
            btnSolve = new Button();
            txtCofB = new TextBox();
            txtCofA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCofC = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(170, 282);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(545, 53);
            txtResult.TabIndex = 16;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(33, 53, 85);
            label4.Location = new Point(61, 295);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 15;
            label4.Text = "Result";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(62, 88, 121);
            btnExit.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(539, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(176, 62);
            btnExit.TabIndex = 19;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(62, 88, 121);
            btnNext.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(342, 355);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(191, 62);
            btnNext.TabIndex = 18;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnSolve
            // 
            btnSolve.BackColor = Color.FromArgb(62, 88, 121);
            btnSolve.Font = new Font("SF Mono", 14.2574253F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.ForeColor = Color.Transparent;
            btnSolve.Location = new Point(170, 355);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(166, 62);
            btnSolve.TabIndex = 17;
            btnSolve.Text = "SOLVE";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // txtCofB
            // 
            txtCofB.Location = new Point(170, 143);
            txtCofB.Multiline = true;
            txtCofB.Name = "txtCofB";
            txtCofB.Size = new Size(545, 53);
            txtCofB.TabIndex = 14;
            // 
            // txtCofA
            // 
            txtCofA.Location = new Point(170, 65);
            txtCofA.Multiline = true;
            txtCofA.Name = "txtCofA";
            txtCofA.Size = new Size(545, 53);
            txtCofA.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(33, 53, 85);
            label3.Location = new Point(76, 154);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 13;
            label3.Text = "COF B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 53, 85);
            label2.Location = new Point(76, 74);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 11;
            label2.Text = "COF A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 53, 85);
            label1.Location = new Point(292, 22);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 10;
            label1.Text = "EQUATION LEVEL 2";
            label1.Click += label1_Click;
            // 
            // txtCofC
            // 
            txtCofC.Location = new Point(170, 209);
            txtCofC.Multiline = true;
            txtCofC.Name = "txtCofC";
            txtCofC.Size = new Size(545, 53);
            txtCofC.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(33, 53, 85);
            label5.Location = new Point(76, 220);
            label5.Name = "label5";
            label5.Size = new Size(88, 30);
            label5.TabIndex = 20;
            label5.Text = "COF C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCofC);
            Controls.Add(label5);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Label label4;
        private Button btnExit;
        private Button btnNext;
        private Button btnSolve;
        private TextBox txtCofB;
        private TextBox txtCofA;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCofC;
        private Label label5;
    }
}
