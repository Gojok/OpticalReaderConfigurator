using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;

namespace OpticalReaderConfigurator
{
    public class TransportLayerUart
    {
        private enum Commands : UInt32
        {
            CommPing = 0xF1000000,
            CommMsg = 0xF2000000,
            CommOk = 0xF3000000,
            CommFail = 0xF4000000,
            CommReadLine = 0xF5000000
        }


        private bool _connect = false;
        private bool _isReciv = false;
        private SerialPort _serialPort;
        private Timer _aTimer;

        private UInt32 _timeLastTransaction = 0;
        private const UInt32 _timeoutBreckConnection = 3000;

        private byte[] _recivBuf;

        

        public delegate void transportLayerBaseEvent();
        public delegate void transportLayerRecivLineEvent(string line);
        public event transportLayerBaseEvent connectEvent;
        public event transportLayerBaseEvent disconnectEvent;
        public event transportLayerBaseEvent portOpenEvent;
        public event transportLayerRecivLineEvent recivlineEvent;


        public TransportLayerUart()
        {
            _aTimer = new Timer(100);
            _aTimer.AutoReset = true;
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.Enabled = true;

            _serialPort = new SerialPort();
            _serialPort.BaudRate = 115200;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataReceived += OnDataRecived;
        }
        


        public bool isConnect()
        {
            return _connect;
        }

        public bool connect()
        {
            if (!_serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Open();
                }
                catch
                {
                    return false;
                }
                _serialPort.ReceivedBytesThreshold = 4;
                trigPortOpenEvent();
                _aTimer.Start(); 
            }
            return true;
        }

        public void disconnect()
        {
            if (_serialPort.IsOpen)
            {
                _aTimer.Stop();
                _serialPort.Close();
                trigDisconnectEvent();
            }
        }

        public void setBaundRate(int baudRate)
        {
            _serialPort.BaudRate = baudRate;
        }

        public void setPort(string port)
        {
            _serialPort.PortName = port;
        }

        public string[] getAvailablePortsName()
        {
            return SerialPort.GetPortNames();
        }

        private void trigPortOpenEvent()
		{
			if (portOpenEvent != null)
			{
                portOpenEvent();
            }
		}

        private void trigDisconnectEvent()
        {
            if (disconnectEvent != null)
            {
                disconnectEvent();
            }
        }

        private void trigConnectEvent()
        {
            if (connectEvent != null)
            {
                connectEvent();
            }
        }

        private void onRecivLine(string line)
		{
            if (recivlineEvent != null)
			{
                recivlineEvent(line);
            }
		}

        private UInt32 getComPing()
        {
            return (UInt32)Commands.CommPing;
        }

        private UInt32 getComMsg(UInt32 size)
        {
            return (UInt32)Commands.CommMsg | (0x00FFFFFF & size);
        }

        private UInt32 getComOk()
        {
            return (UInt32)Commands.CommOk;
        }

        private UInt32 getComFail()
        {
            return (UInt32)Commands.CommFail;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            LogicCore();
        }

        private void OnDataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            _recivBuf = new byte[_serialPort.ReceivedBytesThreshold];
            _serialPort.Read(_recivBuf, 0, _serialPort.ReceivedBytesThreshold);
            string gg = System.Text.Encoding.UTF8.GetString(_recivBuf);
            Console.WriteLine(gg);
            _isReciv = true;
        }

        private void LogicCore()
        {
			if (_isReciv)
			{
                Commands command = (Commands)BitConverter.ToUInt32(_recivBuf, 0);
                switch (command)
				{
                    case Commands.CommOk:

                        break;
                    case Commands.CommFail:

                        break;
                    case Commands.CommMsg:

                        break;
                    case Commands.CommPing:

                        break;
                    case Commands.CommReadLine:

                        break;
                }
                _isReciv = false;

            }
        }
    }
}
