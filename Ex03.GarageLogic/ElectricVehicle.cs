using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class ElectricVehicle : Vehicle
    {
        private float m_RemainingTimeOfEngineOperation;
        protected float m_MaxTimeOfEngineOperation;

        internal ElectricVehicle(string i_ModeName, string i_LicenseNumber, float i_RemainingTimeOfEngineOperation) : base(i_ModeName, i_LicenseNumber)
        {
            m_RemainingTimeOfEngineOperation = i_RemainingTimeOfEngineOperation;
            m_RemainingEnergyPercentage = m_RemainingTimeOfEngineOperation / m_MaxTimeOfEngineOperation * 100;
        }

        //internal float RemainingTime
        //{
        //    get 
        //    { 
        //        return m_RemainingTimeOfEngineOperation; 
        //    }

        //    set
        //    {
        //        m_RemainingTimeOfEngineOperation = value;
        //        m_RemainingEnergyPercentage = m_RemainingTimeOfEngineOperation / m_MaxTimeOfEngineOperation * 100;
        //    }
        //}

        internal void Recharge(float i_HoursToAdd)
        {
            if ((m_RemainingTimeOfEngineOperation + i_HoursToAdd) < m_MaxTimeOfEngineOperation)
            {
                m_RemainingTimeOfEngineOperation += i_HoursToAdd;
                m_RemainingEnergyPercentage = m_RemainingTimeOfEngineOperation / m_MaxTimeOfEngineOperation * 100;
            }

            //add else with exception!!
        }

    }
}
