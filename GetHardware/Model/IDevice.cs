using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHardware.Model
{
    public interface IDevice
    {
        /// <summary>
        /// Full name of the device
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Full name of manufacturer company
        /// </summary>
        string Manufacturer { get; set; }
        /// <summary>
        /// Collects information about computer and sets properties such as Name, Manufacturer, etc.
        /// Called in constructor
        /// </summary>
        void CollectInfo();
        /// <summary>
        /// Returns string with all information about device
        /// </summary>
        /// <returns></returns>
        string GetInfo();
    }
}
