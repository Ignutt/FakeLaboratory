using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    public enum DeviceType
    {
        Android,
        IoS
    }

    [Serializable]
    public struct Data
    {
        public DeviceType device;
        public string mac;
        public float diskSize;
        public int activeSesions;
    }
}
