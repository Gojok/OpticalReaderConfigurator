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
        const string connectText = "Connect";
        const string disConnectText = "Disconnect";
        bool buttonAplyStateConn = false;
        public Connection()
        {
            InitializeComponent();
            buttonApply.Text = connectText;
        }

        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(Program.transportLayerUart.getAvailablePortsName());
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (buttonAplyStateConn)
            {
                Program.transportLayerUart.disconnect();
                buttonAplyStateConn = false;
                comboBoxBoundRate.Enabled = true;
                comboBoxPort.Enabled = true;
                buttonApply.Text = connectText;

            } else
			{
                Program.transportLayerUart.disconnect();
                if (comboBoxPort.SelectedItem != null)
                {
                    Program.transportLayerUart.setPort(comboBoxPort.SelectedItem.ToString());
                }

                if (comboBoxBoundRate.SelectedItem != null)
                {
                    Program.transportLayerUart.setBaundRate(Int32.Parse(comboBoxBoundRate.SelectedItem.ToString()));
                }
                if (Program.transportLayerUart.connect())
                {
                    buttonAplyStateConn = true;
                    comboBoxBoundRate.Enabled = false;
                    comboBoxPort.Enabled = false;
                    labelError.Visible = false;
                    buttonApply.Text = disConnectText;

                }
                else
                {
                    buttonAplyStateConn = false;
                    buttonApply.Text = connectText;
                    labelError.Visible = true;
                }
            }
        }
    }
}
