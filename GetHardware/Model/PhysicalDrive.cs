using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHardware.Model
{
    public class PhysicalDrive : IDevice
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// In Gigabytes
        /// </summary>
        public decimal TotalMemory { get; private set; }
        public decimal UsedMemory { get; private set; }
        public decimal FreeMemory { get; private set; }
        public PhysicalDrive()
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
