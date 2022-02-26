using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticalReaderConfigurator
{
    public class TransportLayerUart
    {
        public TransportLayerUart()
        {

        }
        private bool connect = false;

        delegate void event();
        event AccountHandler Notify;

        public bool isConnect()
        {
            return connect;
        }


    }
}
