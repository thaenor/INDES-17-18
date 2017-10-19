namespace Calculator
{
    partial class Form1
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
            this.leftOperand = new System.Windows.Forms.TextBox();
            this.rightOperand = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.RadioButton();
            this.subtractionBtn = new System.Windows.Forms.RadioButton();
            this.multiplyBtn = new System.Windows.Forms.RadioButton();
            this.divisionBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.remainderBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftOperand
            // 
            this.leftOperand.Location = new System.Drawing.Point(12, 64);
            this.leftOperand.Name = "leftOperand";
            this.leftOperand.Size = new System.Drawing.Size(85, 20);
            this.leftOperand.TabIndex = 0;
            // 
            // rightOperand
            // 
            this.rightOperand.Location = new System.Drawing.Point(287, 64);
            this.rightOperand.Name = "rightOperand";
            this.rightOperand.Size = new System.Drawing.Size(85, 20);
            this.rightOperand.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.Location = new System.Drawing.Point(146, 66);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(72, 17);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.TabStop = true;
            this.AddBtn.Text = "+ Addition";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.AutoSize = true;
            this.subtractionBtn.Location = new System.Drawing.Point(146, 92);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(85, 17);
            this.subtractionBtn.TabIndex = 3;
            this.subtractionBtn.TabStop = true;
            this.subtractionBtn.Text = "- Subtraction";
            this.subtractionBtn.UseVisualStyleBackColor = true;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.AutoSize = true;
            this.multiplyBtn.Location = new System.Drawing.Point(146, 122);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(93, 17);
            this.multiplyBtn.TabIndex = 4;
            this.multiplyBtn.TabStop = true;
            this.multiplyBtn.Text = "* Multiplication";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            // 
            // divisionBtn
            // 
            this.divisionBtn.AutoSize = true;
            this.divisionBtn.Location = new System.Drawing.Point(13, 101);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(70, 17);
            this.divisionBtn.TabIndex = 5;
            this.divisionBtn.TabStop = true;
            this.divisionBtn.Text = "/ Division";
            this.divisionBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.remainderBtn);
            this.panel1.Controls.Add(this.divisionBtn);
            this.panel1.Location = new System.Drawing.Point(133, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 153);
            this.panel1.TabIndex = 6;
            // 
            // OperationLabel
            // 
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Location = new System.Drawing.Point(143, 45);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(48, 13);
            this.OperationLabel.TabIndex = 8;
            this.OperationLabel.Text = "Operator";
            // 
            // remainderBtn
            // 
            this.remainderBtn.AutoSize = true;
            this.remainderBtn.Location = new System.Drawing.Point(13, 128);
            this.remainderBtn.Name = "remainderBtn";
            this.remainderBtn.Size = new System.Drawing.Size(87, 17);
            this.remainderBtn.TabIndex = 6;
            this.remainderBtn.TabStop = true;
            this.remainderBtn.Text = "% Remainder";
            this.remainderBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Left Operand";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Right Operand";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 230);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Location = new System.Drawing.Point(115, 230);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.ReadOnly = true;
            this.expressionTextBox.Size = new System.Drawing.Size(165, 20);
            this.expressionTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Expression";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(16, 295);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(264, 20);
            this.resultTextBox.TabIndex = 15;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(297, 292);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Quit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expressionTextBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.rightOperand);
            this.Controls.Add(this.leftOperand);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftOperand;
        private System.Windows.Forms.TextBox rightOperand;
        private System.Windows.Forms.RadioButton AddBtn;
        private System.Windows.Forms.RadioButton subtractionBtn;
        private System.Windows.Forms.RadioButton multiplyBtn;
        private System.Windows.Forms.RadioButton divisionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.RadioButton remainderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox expressionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button exitBtn;
    }
}

