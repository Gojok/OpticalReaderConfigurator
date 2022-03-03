using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalReaderConfigurator
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            buttonApply.Text = "Connect";
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(Program.transportLayerUart.getAvailablePortsName());
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedItem != null)
            {
                Program.transportLayerUart.setPort(comboBoxPort.SelectedItem.ToString());
            }
            
            if(comboBoxBoundRate.SelectedItem != null)
            {
                Program.transportLayerUart.setBaundRate(Int32.Parse(comboBoxBoundRate.SelectedItem.ToString()));
            }
        }
    }
}
