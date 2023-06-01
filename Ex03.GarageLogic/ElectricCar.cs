using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class ElectricCar : ElectricVehicle
    {
        private readonly Car r_Car;
        internal ElectricCar(string i_ModeName, string i_LicenseNumber, float i_RemainingTimeOfEngineOperation, eCarColor i_Color, eNumberOfDors i_NumberOfDors) : base(i_ModeName, i_LicenseNumber, i_RemainingTimeOfEngineOperation)
        {
            r_Car = new Car(i_Color, i_NumberOfDors);
            m_MaxTimeOfEngineOperation = (float)5.2;
            
        }
    }
}
