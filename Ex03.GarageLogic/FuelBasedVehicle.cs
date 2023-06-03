using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class FuelBasedVehicle : Vehicle
    {
        protected eFuelType m_FuelType;
        private float m_CurrentAmountOfFuel;
        protected float m_MaxAmountOfFuel;

        internal FuelBasedVehicle(string i_ModeName, string i_LicenseNumber, float i_CurrentAmountOfFuel) : base(i_ModeName, i_LicenseNumber)
        {
            m_CurrentAmountOfFuel = i_CurrentAmountOfFuel;
            m_RemainingEnergyPercentage = m_CurrentAmountOfFuel / m_MaxAmountOfFuel * 100;
        }

        //internal float CurrentAmountOfFuel
        //{
        //    get 
        //    { 
        //        return m_CurrentAmountOfFuel; 
        //    }


        //    set
        //    {
        //        m_CurrentAmountOfFuel = value;
        //        m_RemainingEnergyPercentage = m_CurrentAmountOfFuel / m_MaxAmountOfFuel * 100;
        //    }
        //}

        internal eFuelType FuelType
        {
            get 
            { 
                return m_FuelType; 
            }
        }

        internal void Refueling(float i_FuelToAdd, eFuelType i_FuelType)
        {
            if (i_FuelType == m_FuelType)
            {
                if ((m_CurrentAmountOfFuel + i_FuelToAdd) < m_MaxAmountOfFuel)
                {
                    m_CurrentAmountOfFuel += i_FuelToAdd;
                    m_RemainingEnergyPercentage = m_CurrentAmountOfFuel / m_MaxAmountOfFuel * 100;
                }
            }

            //add elses with exceptions!!!!
        }
    }
}
