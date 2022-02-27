using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports

namespace OpticalReaderConfigurator
{
    public class TransportLayerUart
    {
        private bool _connect = false;
        private SerialPort _serialPort;
        public delegate void connDisconEvent();
        public event connDisconEvent connectEv;
        public event connDisconEvent disconnectEv;

        public TransportLayerUart()
        {

        }
        
        public bool isConnect()
        {
            return _connect;
        }

        public void connect()
        {

        }

        public void disconnect()
        {

        }

        public void setSettings()
        {

        }



    }
}
