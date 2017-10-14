namespace Domotica02
{
    partial class DomoticaFormWindow
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
            this.wcLuz = new System.Windows.Forms.PictureBox();
            this.salaLuz = new System.Windows.Forms.PictureBox();
            this.quartoLuz = new System.Windows.Forms.PictureBox();
            this.cozinhaLuz = new System.Windows.Forms.PictureBox();
            this.escadasLuz = new System.Windows.Forms.PictureBox();
            this.wcAlarm = new System.Windows.Forms.PictureBox();
            this.salaAlarm = new System.Windows.Forms.PictureBox();
            this.quartoAlarm = new System.Windows.Forms.PictureBox();
            this.cozinhaAlarm = new System.Windows.Forms.PictureBox();
            this.escadasAlarm = new System.Windows.Forms.PictureBox();
            this.firstStove = new System.Windows.Forms.PictureBox();
            this.secondStove = new System.Windows.Forms.PictureBox();
            this.thirdStove = new System.Windows.Forms.PictureBox();
            this.fourthStove = new System.Windows.Forms.PictureBox();
            this.ThermometerQuarto = new System.Windows.Forms.PictureBox();
            this.ThermometerCosinha = new System.Windows.Forms.PictureBox();
            this.ThermometerSala = new System.Windows.Forms.PictureBox();
            this.TemperaturaSala = new System.Windows.Forms.Label();
            this.TemperaturaQuarto = new System.Windows.Forms.Label();
            this.TemperaturaCozinha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WcSwitch = new System.Windows.Forms.Button();
            this.RoomSwitch = new System.Windows.Forms.Button();
            this.BedroomSwitch = new System.Windows.Forms.Button();
            this.KitchenSwitch = new System.Windows.Forms.Button();
            this.StairsSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wcLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cozinhaLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escadasLuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wcAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cozinhaAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escadasAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstStove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondStove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdStove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthStove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerQuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerCosinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerSala)).BeginInit();
            this.SuspendLayout();
            // 
            // wcLuz
            // 
            this.wcLuz.BackgroundImage = global::Domotica02.Properties.Resources.LUZON;
            this.wcLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wcLuz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wcLuz.Location = new System.Drawing.Point(316, 158);
            this.wcLuz.Margin = new System.Windows.Forms.Padding(0);
            this.wcLuz.Name = "wcLuz";
            this.wcLuz.Size = new System.Drawing.Size(85, 85);
            this.wcLuz.TabIndex = 1;
            this.wcLuz.TabStop = false;
            this.wcLuz.Click += new System.EventHandler(this.MudarLuzWC);
            // 
            // salaLuz
            // 
            this.salaLuz.BackgroundImage = global::Domotica02.Properties.Resources.LUZON;
            this.salaLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salaLuz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.salaLuz.Location = new System.Drawing.Point(676, 124);
            this.salaLuz.Margin = new System.Windows.Forms.Padding(0);
            this.salaLuz.Name = "salaLuz";
            this.salaLuz.Size = new System.Drawing.Size(85, 85);
            this.salaLuz.TabIndex = 2;
            this.salaLuz.TabStop = false;
            this.salaLuz.Click += new System.EventHandler(this.MudarLuzSala);
            // 
            // quartoLuz
            // 
            this.quartoLuz.BackgroundImage = global::Domotica02.Properties.Resources.LUZON;
            this.quartoLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quartoLuz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quartoLuz.Location = new System.Drawing.Point(888, 200);
            this.quartoLuz.Margin = new System.Windows.Forms.Padding(0);
            this.quartoLuz.Name = "quartoLuz";
            this.quartoLuz.Size = new System.Drawing.Size(85, 85);
            this.quartoLuz.TabIndex = 3;
            this.quartoLuz.TabStop = false;
            this.quartoLuz.Click += new System.EventHandler(this.MudarLuzQuarto);
            // 
            // cozinhaLuz
            // 
            this.cozinhaLuz.BackgroundImage = global::Domotica02.Properties.Resources.LUZON;
            this.cozinhaLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cozinhaLuz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cozinhaLuz.Location = new System.Drawing.Point(442, 493);
            this.cozinhaLuz.Margin = new System.Windows.Forms.Padding(0);
            this.cozinhaLuz.Name = "cozinhaLuz";
            this.cozinhaLuz.Size = new System.Drawing.Size(85, 85);
            this.cozinhaLuz.TabIndex = 4;
            this.cozinhaLuz.TabStop = false;
            this.cozinhaLuz.Click += new System.EventHandler(this.MudarLuzCozinha);
            // 
            // escadasLuz
            // 
            this.escadasLuz.BackgroundImage = global::Domotica02.Properties.Resources.LUZON;
            this.escadasLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.escadasLuz.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.escadasLuz.Location = new System.Drawing.Point(977, 493);
            this.escadasLuz.Margin = new System.Windows.Forms.Padding(0);
            this.escadasLuz.Name = "escadasLuz";
            this.escadasLuz.Size = new System.Drawing.Size(85, 85);
            this.escadasLuz.TabIndex = 5;
            this.escadasLuz.TabStop = false;
            this.escadasLuz.Click += new System.EventHandler(this.MudarLuzEscadas);
            // 
            // wcAlarm
            // 
            this.wcAlarm.BackgroundImage = global::Domotica02.Properties.Resources.alarmeoff;
            this.wcAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wcAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wcAlarm.Image = global::Domotica02.Properties.Resources.alarmeoff;
            this.wcAlarm.Location = new System.Drawing.Point(190, 189);
            this.wcAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.wcAlarm.Name = "wcAlarm";
            this.wcAlarm.Size = new System.Drawing.Size(102, 56);
            this.wcAlarm.TabIndex = 6;
            this.wcAlarm.TabStop = false;
            this.wcAlarm.Click += new System.EventHandler(this.WcAlarm_Click);
            // 
            // salaAlarm
            // 
            this.salaAlarm.BackgroundImage = global::Domotica02.Properties.Resources.alarmeoff;
            this.salaAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salaAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.salaAlarm.Image = global::Domotica02.Properties.Resources.alarmeoff;
            this.salaAlarm.Location = new System.Drawing.Point(509, 189);
            this.salaAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.salaAlarm.Name = "salaAlarm";
            this.salaAlarm.Size = new System.Drawing.Size(102, 56);
            this.salaAlarm.TabIndex = 7;
            this.salaAlarm.TabStop = false;
            this.salaAlarm.Click += new System.EventHandler(this.SalaAlarm_Click);
            // 
            // quartoAlarm
            // 
            this.quartoAlarm.BackgroundImage = global::Domotica02.Properties.Resources.alarmeoff;
            this.quartoAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quartoAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quartoAlarm.Image = global::Domotica02.Properties.Resources.alarmeoff;
            this.quartoAlarm.Location = new System.Drawing.Point(977, 262);
            this.quartoAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.quartoAlarm.Name = "quartoAlarm";
            this.quartoAlarm.Size = new System.Drawing.Size(102, 56);
            this.quartoAlarm.TabIndex = 8;
            this.quartoAlarm.TabStop = false;
            this.quartoAlarm.Click += new System.EventHandler(this.QuartoAlarm_Click);
            // 
            // cozinhaAlarm
            // 
            this.cozinhaAlarm.BackgroundImage = global::Domotica02.Properties.Resources.alarmeoff;
            this.cozinhaAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cozinhaAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cozinhaAlarm.Image = global::Domotica02.Properties.Resources.alarmeoff;
            this.cozinhaAlarm.Location = new System.Drawing.Point(561, 524);
            this.cozinhaAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.cozinhaAlarm.Name = "cozinhaAlarm";
            this.cozinhaAlarm.Size = new System.Drawing.Size(102, 56);
            this.cozinhaAlarm.TabIndex = 9;
            this.cozinhaAlarm.TabStop = false;
            this.cozinhaAlarm.Click += new System.EventHandler(this.CozinhaAlarm_Click);
            // 
            // escadasAlarm
            // 
            this.escadasAlarm.BackgroundImage = global::Domotica02.Properties.Resources.alarmeoff;
            this.escadasAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.escadasAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.escadasAlarm.Image = global::Domotica02.Properties.Resources.alarmeoff;
            this.escadasAlarm.Location = new System.Drawing.Point(811, 493);
            this.escadasAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.escadasAlarm.Name = "escadasAlarm";
            this.escadasAlarm.Size = new System.Drawing.Size(102, 56);
            this.escadasAlarm.TabIndex = 10;
            this.escadasAlarm.TabStop = false;
            this.escadasAlarm.Click += new System.EventHandler(this.EscadasAlarm_Click);
            // 
            // firstStove
            // 
            this.firstStove.Image = global::Domotica02.Properties.Resources.fogao0;
            this.firstStove.Location = new System.Drawing.Point(189, 424);
            this.firstStove.Margin = new System.Windows.Forms.Padding(0);
            this.firstStove.Name = "firstStove";
            this.firstStove.Size = new System.Drawing.Size(64, 55);
            this.firstStove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstStove.TabIndex = 11;
            this.firstStove.TabStop = false;
            this.firstStove.Click += new System.EventHandler(this.FirstStove_Click);
            // 
            // secondStove
            // 
            this.secondStove.Image = global::Domotica02.Properties.Resources.fogao0;
            this.secondStove.Location = new System.Drawing.Point(253, 424);
            this.secondStove.Margin = new System.Windows.Forms.Padding(0);
            this.secondStove.Name = "secondStove";
            this.secondStove.Size = new System.Drawing.Size(64, 55);
            this.secondStove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondStove.TabIndex = 12;
            this.secondStove.TabStop = false;
            this.secondStove.Click += new System.EventHandler(this.SecondStove_Click);
            // 
            // thirdStove
            // 
            this.thirdStove.Image = global::Domotica02.Properties.Resources.fogao0;
            this.thirdStove.Location = new System.Drawing.Point(189, 479);
            this.thirdStove.Margin = new System.Windows.Forms.Padding(0);
            this.thirdStove.Name = "thirdStove";
            this.thirdStove.Size = new System.Drawing.Size(64, 55);
            this.thirdStove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdStove.TabIndex = 13;
            this.thirdStove.TabStop = false;
            this.thirdStove.Click += new System.EventHandler(this.ThirdStove_Click);
            // 
            // fourthStove
            // 
            this.fourthStove.Image = global::Domotica02.Properties.Resources.fogao0;
            this.fourthStove.Location = new System.Drawing.Point(253, 479);
            this.fourthStove.Margin = new System.Windows.Forms.Padding(0);
            this.fourthStove.Name = "fourthStove";
            this.fourthStove.Size = new System.Drawing.Size(64, 55);
            this.fourthStove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourthStove.TabIndex = 14;
            this.fourthStove.TabStop = false;
            this.fourthStove.Click += new System.EventHandler(this.FourthStove_Click);
            // 
            // ThermometerQuarto
            // 
            this.ThermometerQuarto.Image = global::Domotica02.Properties.Resources.tempcold;
            this.ThermometerQuarto.Location = new System.Drawing.Point(1008, 152);
            this.ThermometerQuarto.Name = "ThermometerQuarto";
            this.ThermometerQuarto.Size = new System.Drawing.Size(85, 74);
            this.ThermometerQuarto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThermometerQuarto.TabIndex = 15;
            this.ThermometerQuarto.TabStop = false;
            this.ThermometerQuarto.Click += new System.EventHandler(this.ThermometerQuarto_Click);
            // 
            // ThermometerCosinha
            // 
            this.ThermometerCosinha.Image = global::Domotica02.Properties.Resources.tempcold;
            this.ThermometerCosinha.Location = new System.Drawing.Point(676, 524);
            this.ThermometerCosinha.Name = "ThermometerCosinha";
            this.ThermometerCosinha.Size = new System.Drawing.Size(85, 74);
            this.ThermometerCosinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThermometerCosinha.TabIndex = 16;
            this.ThermometerCosinha.TabStop = false;
            this.ThermometerCosinha.Click += new System.EventHandler(this.ThermometerCosinha_Click);
            // 
            // ThermometerSala
            // 
            this.ThermometerSala.Image = global::Domotica02.Properties.Resources.tempcold;
            this.ThermometerSala.Location = new System.Drawing.Point(676, 246);
            this.ThermometerSala.Name = "ThermometerSala";
            this.ThermometerSala.Size = new System.Drawing.Size(85, 74);
            this.ThermometerSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThermometerSala.TabIndex = 17;
            this.ThermometerSala.TabStop = false;
            this.ThermometerSala.Click += new System.EventHandler(this.ThermometerSala_Click);
            // 
            // TemperaturaSala
            // 
            this.TemperaturaSala.AutoSize = true;
            this.TemperaturaSala.Location = new System.Drawing.Point(702, 218);
            this.TemperaturaSala.Name = "TemperaturaSala";
            this.TemperaturaSala.Size = new System.Drawing.Size(36, 25);
            this.TemperaturaSala.TabIndex = 18;
            this.TemperaturaSala.Text = "18";
            // 
            // TemperaturaQuarto
            // 
            this.TemperaturaQuarto.AutoSize = true;
            this.TemperaturaQuarto.Location = new System.Drawing.Point(1026, 124);
            this.TemperaturaQuarto.Name = "TemperaturaQuarto";
            this.TemperaturaQuarto.Size = new System.Drawing.Size(36, 25);
            this.TemperaturaQuarto.TabIndex = 19;
            this.TemperaturaQuarto.Text = "18";
            // 
            // TemperaturaCozinha
            // 
            this.TemperaturaCozinha.AutoSize = true;
            this.TemperaturaCozinha.Location = new System.Drawing.Point(702, 493);
            this.TemperaturaCozinha.Name = "TemperaturaCozinha";
            this.TemperaturaCozinha.Size = new System.Drawing.Size(36, 25);
            this.TemperaturaCozinha.TabIndex = 20;
            this.TemperaturaCozinha.Text = "18";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // WcSwitch
            // 
            this.WcSwitch.Location = new System.Drawing.Point(189, 280);
            this.WcSwitch.Name = "WcSwitch";
            this.WcSwitch.Size = new System.Drawing.Size(80, 38);
            this.WcSwitch.TabIndex = 21;
            this.WcSwitch.Text = "On/Off";
            this.WcSwitch.UseVisualStyleBackColor = true;
            this.WcSwitch.Click += new System.EventHandler(this.WcSwitch_Click);
            // 
            // RoomSwitch
            // 
            this.RoomSwitch.Location = new System.Drawing.Point(495, 282);
            this.RoomSwitch.Name = "RoomSwitch";
            this.RoomSwitch.Size = new System.Drawing.Size(90, 38);
            this.RoomSwitch.TabIndex = 22;
            this.RoomSwitch.Text = "On/Off";
            this.RoomSwitch.UseVisualStyleBackColor = true;
            this.RoomSwitch.Click += new System.EventHandler(this.RoomSwitch_Click);
            // 
            // BedroomSwitch
            // 
            this.BedroomSwitch.Location = new System.Drawing.Point(811, 282);
            this.BedroomSwitch.Name = "BedroomSwitch";
            this.BedroomSwitch.Size = new System.Drawing.Size(80, 38);
            this.BedroomSwitch.TabIndex = 23;
            this.BedroomSwitch.Text = "On/Off";
            this.BedroomSwitch.UseVisualStyleBackColor = true;
            this.BedroomSwitch.Click += new System.EventHandler(this.BedroomSwitch_Click);
            // 
            // KitchenSwitch
            // 
            this.KitchenSwitch.Location = new System.Drawing.Point(681, 413);
            this.KitchenSwitch.Name = "KitchenSwitch";
            this.KitchenSwitch.Size = new System.Drawing.Size(80, 38);
            this.KitchenSwitch.TabIndex = 24;
            this.KitchenSwitch.Text = "On/Off";
            this.KitchenSwitch.UseVisualStyleBackColor = true;
            this.KitchenSwitch.Click += new System.EventHandler(this.KitchenSwitch_Click);
            // 
            // StairsSwitch
            // 
            this.StairsSwitch.Location = new System.Drawing.Point(799, 568);
            this.StairsSwitch.Name = "StairsSwitch";
            this.StairsSwitch.Size = new System.Drawing.Size(80, 38);
            this.StairsSwitch.TabIndex = 25;
            this.StairsSwitch.Text = "On/Off";
            this.StairsSwitch.UseVisualStyleBackColor = true;
            this.StairsSwitch.Click += new System.EventHandler(this.StairsSwitch_Click);
            // 
            // DomoticaFormWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Domotica02.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1257, 618);
            this.Controls.Add(this.StairsSwitch);
            this.Controls.Add(this.KitchenSwitch);
            this.Controls.Add(this.BedroomSwitch);
            this.Controls.Add(this.RoomSwitch);
            this.Controls.Add(this.WcSwitch);
            this.Controls.Add(this.TemperaturaCozinha);
            this.Controls.Add(this.TemperaturaQuarto);
            this.Controls.Add(this.TemperaturaSala);
            this.Controls.Add(this.ThermometerSala);
            this.Controls.Add(this.ThermometerCosinha);
            this.Controls.Add(this.ThermometerQuarto);
            this.Controls.Add(this.fourthStove);
            this.Controls.Add(this.thirdStove);
            this.Controls.Add(this.secondStove);
            this.Controls.Add(this.firstStove);
            this.Controls.Add(this.escadasAlarm);
            this.Controls.Add(this.cozinhaAlarm);
            this.Controls.Add(this.quartoAlarm);
            this.Controls.Add(this.salaAlarm);
            this.Controls.Add(this.wcAlarm);
            this.Controls.Add(this.escadasLuz);
            this.Controls.Add(this.cozinhaLuz);
            this.Controls.Add(this.quartoLuz);
            this.Controls.Add(this.salaLuz);
            this.Controls.Add(this.wcLuz);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DomoticaFormWindow";
            this.Text = "Domotica_INDES";
            ((System.ComponentModel.ISupportInitialize)(this.wcLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cozinhaLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escadasLuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wcAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cozinhaAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escadasAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstStove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondStove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdStove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthStove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerQuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerCosinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox wcLuz;
        private System.Windows.Forms.PictureBox salaLuz;
        private System.Windows.Forms.PictureBox quartoLuz;
        private System.Windows.Forms.PictureBox cozinhaLuz;
        private System.Windows.Forms.PictureBox escadasLuz;
        private System.Windows.Forms.PictureBox wcAlarm;
        private System.Windows.Forms.PictureBox salaAlarm;
        private System.Windows.Forms.PictureBox quartoAlarm;
        private System.Windows.Forms.PictureBox cozinhaAlarm;
        private System.Windows.Forms.PictureBox escadasAlarm;
        private System.Windows.Forms.PictureBox firstStove;
        private System.Windows.Forms.PictureBox secondStove;
        private System.Windows.Forms.PictureBox thirdStove;
        private System.Windows.Forms.PictureBox fourthStove;
        private System.Windows.Forms.PictureBox ThermometerQuarto;
        private System.Windows.Forms.PictureBox ThermometerCosinha;
        private System.Windows.Forms.PictureBox ThermometerSala;
        private System.Windows.Forms.Label TemperaturaSala;
        private System.Windows.Forms.Label TemperaturaQuarto;
        private System.Windows.Forms.Label TemperaturaCozinha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button WcSwitch;
        private System.Windows.Forms.Button RoomSwitch;
        private System.Windows.Forms.Button BedroomSwitch;
        private System.Windows.Forms.Button KitchenSwitch;
        private System.Windows.Forms.Button StairsSwitch;
    }
}

