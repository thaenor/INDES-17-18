using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domotica02
{
    public partial class DomoticaFormWindow : Form
    {
        Boolean wc = true,
            wcA = false,
            sala = true,
            salaA = false,
            quarto = true,
            quartoA = false,
            escadas = true,
            escadasA = false,
            cozinha = true,
            cozinhaA = false,
            thermometerSala = false,
            thermometerQuarto = false,
            thermometerCosinha = false;
        int stove1 = 0,
            stove2 = 0,
            stove3 = 0,
            stove4 = 0;


        private int SwitchStove (int stoveLevel, PictureBox targetStove)
        {
            stoveLevel = stoveLevel == 5 ? stoveLevel = 0 : stoveLevel;
            int newLevel = stoveLevel + 1;
            switch (newLevel)
            {
                case 1:
                    targetStove.Image = Properties.Resources.fogao0;
                    break;
                case 2:
                    targetStove.Image = Properties.Resources.fogao1;
                    break;
                case 3:
                    targetStove.Image = Properties.Resources.fogao2;
                    break;
                case 4:
                    targetStove.Image = Properties.Resources.fogao3;
                    break;
            }
            return newLevel;
        }

        private Boolean SwitchLight (Boolean lightState, PictureBox targetLight)
        {
            Boolean newState = !lightState;
            if (newState)
            {
                targetLight.BackgroundImage = Properties.Resources.LUZON;
            } else
            {
                targetLight.BackgroundImage = Properties.Resources.LUZ_OFF;
            }
            return newState;
        }

        private Boolean SwitchAlarm (Boolean alarmState, PictureBox targetAlarm)
        {
            Boolean newState = !alarmState;
            if (newState)
            {
                targetAlarm.BackgroundImage = Properties.Resources.alarmeon;
            }
            else
            {
                targetAlarm.BackgroundImage = Properties.Resources.alarmeoff;
            }
            return newState;
        }

        private Boolean SwitchThermometer (Boolean thermState, PictureBox target)
        {
            Boolean newState = !thermState;
            if (newState)
            {
                target.Image = Properties.Resources.temphot;
            }
            else
            {
                target.Image = Properties.Resources.tempcold;
            }
            return newState;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (thermometerSala)
            {
                TemperaturaSala.Text = (Int32.Parse(TemperaturaSala.Text) + 1).ToString();
                if(Int32.Parse(TemperaturaSala.Text) > 35) { EmmitAlarm(); }
            }
            else
            {
                TemperaturaSala.Text = (Int32.Parse(TemperaturaSala.Text) - 1).ToString();
            }

            if (thermometerQuarto)
            {
                TemperaturaQuarto.Text = (Int32.Parse(TemperaturaQuarto.Text) + 1).ToString();
                if (Int32.Parse(TemperaturaQuarto.Text) > 35) { EmmitAlarm(); }
            }
            else
            {
                TemperaturaQuarto.Text = (Int32.Parse(TemperaturaQuarto.Text) - 1).ToString();
            }

            if (thermometerCosinha)
            {
                TemperaturaCozinha.Text = (Int32.Parse(TemperaturaCozinha.Text) + 1).ToString();
                if (Int32.Parse(TemperaturaCozinha.Text) > 35) { EmmitAlarm(); }
            }
            else
            {
                TemperaturaCozinha.Text = (Int32.Parse(TemperaturaCozinha.Text) - 1).ToString();
            }
        }

        private void EmmitAlarm()
        {
            wcA = false;
            quartoA = false;
            salaA = false;
            escadasA = false;
            cozinhaA = false;

            SwitchAlarm(wcA, wcAlarm);
            SwitchAlarm(quartoA, quartoAlarm);
            SwitchAlarm(salaA, salaAlarm);
            SwitchAlarm(escadasA, escadasAlarm);
            SwitchAlarm(cozinhaA, cozinhaAlarm);
        }

        private void ThermometerSala_Click(object sender, EventArgs e) => thermometerSala = SwitchThermometer(thermometerSala, ThermometerSala);

        private void ThermometerQuarto_Click(object sender, EventArgs e) => thermometerQuarto = SwitchThermometer(thermometerQuarto, ThermometerQuarto);

        private void ThermometerCosinha_Click(object sender, EventArgs e) => thermometerCosinha = SwitchThermometer(thermometerCosinha, ThermometerCosinha);

        private void WcSwitch_Click(object sender, EventArgs e)
        {
            wc = SwitchLight(wc, wcLuz);
            wcA = SwitchAlarm(wcA, wcAlarm);
        }

        private void RoomSwitch_Click(object sender, EventArgs e)
        {
            sala = SwitchLight(sala, salaLuz);
            salaA = SwitchAlarm(salaA, salaAlarm);
            thermometerSala = SwitchThermometer(thermometerSala, ThermometerSala);
        }

        private void BedroomSwitch_Click(object sender, EventArgs e)
        {
            quarto = SwitchLight(quarto, quartoLuz);
            quartoA = SwitchAlarm(quartoA, quartoAlarm);
            thermometerQuarto = SwitchThermometer(thermometerQuarto, ThermometerQuarto);
        }

        private void KitchenSwitch_Click(object sender, EventArgs e)
        {
            cozinha = SwitchLight(cozinha, cozinhaLuz);
            cozinhaA = SwitchAlarm(cozinhaA, cozinhaAlarm);
            thermometerCosinha = SwitchThermometer(thermometerCosinha, ThermometerCosinha);
        }

        private void StairsSwitch_Click(object sender, EventArgs e)
        {
            escadas = SwitchLight(escadas, escadasLuz);
            escadasA = SwitchAlarm(escadasA, escadasAlarm);
        }

        private void SalaAlarm_Click(object sender, EventArgs e) => salaA = SwitchAlarm(salaA, salaAlarm);

        private void QuartoAlarm_Click(object sender, EventArgs e) => quartoA = SwitchAlarm(quartoA, quartoAlarm);

        private void EscadasAlarm_Click(object sender, EventArgs e) => escadasA = SwitchAlarm(escadasA, escadasAlarm);

        private void WcAlarm_Click(object sender, EventArgs e) => wcA = SwitchAlarm(wcA, wcAlarm);

        private void MudarLuzQuarto(object sender, EventArgs e) => quarto = SwitchLight(quarto, quartoLuz);

        private void MudarLuzEscadas(object sender, EventArgs e) => escadas = SwitchLight(escadas, escadasLuz);

        private void CozinhaAlarm_Click(object sender, EventArgs e) => cozinhaA = SwitchAlarm(cozinhaA, cozinhaAlarm);

        private void MudarLuzCozinha(object sender, EventArgs e) => cozinha = SwitchLight(cozinha, cozinhaLuz);

        public DomoticaFormWindow() => InitializeComponent();

        private void MudarLuzWC(object sender, EventArgs e) => wc = SwitchLight(wc, wcLuz);

        private void MudarLuzSala(object sender, EventArgs e) => sala = SwitchLight(sala, salaLuz);

        private void FirstStove_Click(object sender, EventArgs e) => stove1 = SwitchStove(stove1, firstStove);

        private void SecondStove_Click(object sender, EventArgs e) => stove2 = SwitchStove(stove2, secondStove);

        private void ThirdStove_Click(object sender, EventArgs e) => stove3 = SwitchStove(stove3, thirdStove);

        private void FourthStove_Click(object sender, EventArgs e) => stove4 = SwitchStove(stove4, fourthStove);
    }
}
