using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal struct Truck
    {
        private readonly bool r_DoesItContainDengerousMaterials;
        private readonly float r_CargoTankVolume;

        internal Truck(bool i_DoesItContainDengerousMaterials, float i_Volume)
        {
            r_DoesItContainDengerousMaterials = i_DoesItContainDengerousMaterials;
            r_CargoTankVolume = i_Volume;
        }

        internal bool DoesItContainDengerousMaterials
        {
            get 
            { 
                return r_DoesItContainDengerousMaterials; 
            }
        }

        internal float CargoTankVolume
        {
            get 
            {
                return r_CargoTankVolume; 
            }
        }
    }
}
