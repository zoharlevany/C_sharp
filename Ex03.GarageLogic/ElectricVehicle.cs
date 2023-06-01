﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal abstract class ElectricVehicle : Vehicle
    {
        private float m_RemainingTimeOfEngineOperation;
        protected readonly float r_MaxTimeOfEngineOperation;

        public ElectricVehicle(string i_ModeName, string i_LicenseNumber, float i_RemainingTimeOfEngineOperation) : base(i_ModeName, i_LicenseNumber)
        {
            m_RemainingTimeOfEngineOperation = i_RemainingTimeOfEngineOperation;
        }

        internal float RemainingTime
        {
            get 
            { 
                return m_RemainingTimeOfEngineOperation; 
            }

            set
            {
                m_RemainingTimeOfEngineOperation = value;
            }
        }
        
    }
}
