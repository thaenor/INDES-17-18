﻿namespace Casino
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.Label();
            this.SecondNumber = new System.Windows.Forms.Label();
            this.ThirdNumber = new System.Windows.Forms.Label();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.ResultDisplay = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.CurrentMoney = new System.Windows.Forms.Label();
            this.CurrentBet = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place your bet (€):";
            // 
            // FirstNumber
            // 
            this.FirstNumber.AutoSize = true;
            this.FirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumber.Location = new System.Drawing.Point(315, 270);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 110);
            this.FirstNumber.TabIndex = 1;
            this.FirstNumber.Text = "0";
            this.FirstNumber.Visible = false;
            // 
            // SecondNumber
            // 
            this.SecondNumber.AutoSize = true;
            this.SecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNumber.Location = new System.Drawing.Point(468, 270);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 110);
            this.SecondNumber.TabIndex = 2;
            this.SecondNumber.Text = "0";
            this.SecondNumber.Visible = false;
            this.SecondNumber.Click += new System.EventHandler(this.SecondNumber_Click);
            // 
            // ThirdNumber
            // 
            this.ThirdNumber.AutoSize = true;
            this.ThirdNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThirdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdNumber.Location = new System.Drawing.Point(621, 270);
            this.ThirdNumber.Name = "ThirdNumber";
            this.ThirdNumber.Size = new System.Drawing.Size(100, 110);
            this.ThirdNumber.TabIndex = 3;
            this.ThirdNumber.Text = "0";
            this.ThirdNumber.Visible = false;
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLbl.Location = new System.Drawing.Point(12, 554);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(328, 67);
            this.MoneyLbl.TabIndex = 4;
            this.MoneyLbl.Text = "money (€) :";
            // 
            // ResultDisplay
            // 
            this.ResultDisplay.AutoSize = true;
            this.ResultDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultDisplay.Location = new System.Drawing.Point(12, 621);
            this.ResultDisplay.Name = "ResultDisplay";
            this.ResultDisplay.Size = new System.Drawing.Size(0, 33);
            this.ResultDisplay.TabIndex = 5;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(315, 433);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(406, 71);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // CurrentMoney
            // 
            this.CurrentMoney.AutoSize = true;
            this.CurrentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoney.Location = new System.Drawing.Point(346, 554);
            this.CurrentMoney.Name = "CurrentMoney";
            this.CurrentMoney.Size = new System.Drawing.Size(95, 67);
            this.CurrentMoney.TabIndex = 7;
            this.CurrentMoney.Text = "20";
            // 
            // CurrentBet
            // 
            this.CurrentBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet.Location = new System.Drawing.Point(315, 165);
            this.CurrentBet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CurrentBet.Name = "CurrentBet";
            this.CurrentBet.Size = new System.Drawing.Size(406, 62);
            this.CurrentBet.TabIndex = 8;
            this.CurrentBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Casino.Properties.Resources.apple1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(315, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Casino.Properties.Resources.apple1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(468, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 110);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Casino.Properties.Resources.apple1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(621, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 110);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CurrentBet);
            this.Controls.Add(this.CurrentMoney);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.ResultDisplay);
            this.Controls.Add(this.MoneyLbl);
            this.Controls.Add(this.ThirdNumber);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNumber;
        private System.Windows.Forms.Label SecondNumber;
        private System.Windows.Forms.Label ThirdNumber;
        private System.Windows.Forms.Label MoneyLbl;
        private System.Windows.Forms.Label ResultDisplay;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label CurrentMoney;
        private System.Windows.Forms.NumericUpDown CurrentBet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

