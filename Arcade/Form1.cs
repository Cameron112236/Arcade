using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Arcade
{
    public partial class arcadeGame : Form
    {
        public arcadeGame()
        {
            InitializeComponent();
            gameStarts.Visible = false;
        }
   
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 
            buttonStart.Visible = false;
            gameStarts.Visible = true;

            SoundPlayer pingplayer = new SoundPlayer(Properties.Resources.ping);
            pingplayer.Play();
            Refresh();
            Thread.Sleep(1000);

            pingplayer.Play();
            gameStarts.Text = "Starts in: 2";
            Refresh();
            Thread.Sleep(1000);

            pingplayer.Play();
            gameStarts.Text = "Starts in: 1";
            Refresh();
            Thread.Sleep(1000);

            this.BackColor = Color.Green;
            gameStarts.Text = "Go!!";
            SoundPlayer arcadeStartplayer = new SoundPlayer(Properties.Resources.arcadeStart);
            arcadeStartplayer.Play();
        }
    }
}
