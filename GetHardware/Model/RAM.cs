using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHardware.Model
{
    public class RAM : IDevice
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// In Megabytes
        /// </summary>
        public int Memory { get; private set; }
        public RAM()
        {
            CollectInfo();
        }
        public void CollectInfo()
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
