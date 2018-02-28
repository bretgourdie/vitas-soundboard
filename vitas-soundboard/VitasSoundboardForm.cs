using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;

namespace vitas_soundboard
{
    public partial class VitasSoundboardForm : Form
    {
        private string initialPath = "wavs";
        private AudioFileReader audioFileReader;
        private WaveOutEvent waveOutEvent;

        public VitasSoundboardForm()
        {
            InitializeComponent();
            displaySounds(initialPath);
        }

        private void displaySounds(string directory)
        {
            var sfi = new SoundFileInfo(directory);

            var files = sfi.GetFiles();

            foreach(var file in files)
            {
                mainTabPageFlowLayoutPanel.Controls.Add(
                    getButton(file.Name, file.FullName));
            }
        }

        private Button getButton(string label, string file)
        {
            var button = new Button();
            button.Text = label;
            button.Tag = file;
            button.Click += Button_Click;
            button.AutoSize = true;
            return button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            var fileName = (string)clickedButton.Tag;

            if (waveOutEvent == null)
            {
                waveOutEvent = new WaveOutEvent();
            }

            if (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Stop();
            }

            audioFileReader = new AudioFileReader(fileName);
            waveOutEvent.Init(audioFileReader);

            waveOutEvent.Play();
        }
    }
}
