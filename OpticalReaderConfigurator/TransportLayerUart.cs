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
        private bool _connect = false;
        private SerialPort _serialPort;
        private Timer _aTimer;

        private UInt32 timeLastTransaction = 0;
        private const UInt32 timeoutBreckConnection = 3000;
         

        public delegate void transportLayerBaseEvent();
        public event transportLayerBaseEvent connectEvent;
        public event transportLayerBaseEvent disconnectEvent;
        public event transportLayerBaseEvent portOpenEvent;
        
        

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

        public void connect()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                _aTimer.Start();
            }
        }

        public void disconnect()
        {
            if (_serialPort.IsOpen)
            {
                _aTimer.Stop();
                _serialPort.Close();
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

        private UInt32 getComPing()
        {
            return 0xF1000000;
        }

        private UInt32 getComMsg(UInt32 size)
        {
            return 0xF2FFFFFF & size;
        }

        private UInt32 getComOk()
        {
            return 0xF3000000;
        }

        private UInt32 getComFail()
        {
            return 0xF4000000;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
           
        }

        private void OnDataRecived(object sender, SerialDataReceivedEventArgs e)
        {

        }
    }
}
