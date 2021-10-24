using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHardware.Model
{
    public class CPU : IDevice
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// In MHz
        /// </summary>
        public int Frequency { get; private set; }
        public int AmountOfCores { get; private set; }
        public CPU()
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
