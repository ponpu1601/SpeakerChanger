using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;

namespace SpeakerChanger
{
    public partial class MainForm : Form
    {
        private CoreAudioController AC = new CoreAudioController();

        private IEnumerable<CoreAudioDevice> CADs;



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            CADs = AC.GetDevices(DeviceType.Playback, DeviceState.Active);
            foreach (var dev in CADs)
            {
                var item = new ToolStripMenuItem();
                item.Tag = dev;
                item.Text = dev.Name;
                this.ChangerContextMenu.Items.Add(item);
                
            }
            this.ChangerIcon.Visible = true;

        }

        private string ClickedItemName;
        private void Item_Click(object sender, ToolStripItemClickedEventArgs e)
        {

            ClickedItemName = e.ClickedItem.Text;
                var nowDev = AC.GetDefaultDevice(DeviceType.Playback, Role.Console);
            if (e.ClickedItem.Text == nowDev.Name)
                return;
            var sel = CADs.Where(IsSameName);
            AC.SetDefaultDevice(sel.First());
        }


        private bool IsSameName(CoreAudioDevice Dev)
        {
            return (ClickedItemName==Dev.Name);
        }
        
        private void ChangerIcon_Click(object sender, EventArgs e)
        {
            var nowDev = AC.GetDefaultDevice(DeviceType.Playback, Role.Console);

            foreach (var dev in CADs)
            {
                if (dev != nowDev)
                {
                    AC.SetDefaultDevice(dev);
                    return;
                }
            }
        }
    }


}
