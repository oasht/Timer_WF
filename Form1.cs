using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_stop.Enabled = false;
            bt_start.Enabled = false;
            timer.Tick += new EventHandler(ShowTimer);
        }


        private void ShowTimer(object sender, EventArgs e)
        {
            if (counter.Value > 0)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"tick.wav");
                player.Play();
                counter.Value--;
            }
            else if (counter.Value < 1)
            {
                timer.Stop();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"beeper.wav");
                player.Play();
                DialogResult res = MessageBox.Show("Таймер остановлен", "Таймер", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    player.Stop();
                }
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"button.wav");
            player.Play();
            if (counter.Value > 0)
            {
                bt_stop.Enabled = true;
                bt_start.Enabled = false;
                timer.Start();

            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"button.wav");
            player.Play();
            timer.Stop();
            MessageBox.Show($"Таймер остановлен раньше времени на {counter.Value.ToString()} секунд(ы)", "Таймер");
            bt_stop.Enabled = false;
        }

        private void counter_ValueChanged(object sender, EventArgs e)
        {
            if (counter.Value >= 1)
                bt_start.Enabled = true;
            else
                bt_start.Enabled = false;
        }
    }
}
