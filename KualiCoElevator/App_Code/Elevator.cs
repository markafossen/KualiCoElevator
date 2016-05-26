using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KualiCoElevator
{
    public class Elevator
    {
        #region Enums
        public enum DoorStates
        {
            Open,
            Closed
        }
        #endregion

        #region Private Properties
        private int m_iMinFLoor = 1; //specified in spec
        private int m_iMaxFloor = 10; //default value
        private int m_iCurrentFloor = 1;//start on ground floor
        private int[] m_aDestinationFloors; //no destinations
        private DoorStates m_CurrentDoorState = DoorStates.Closed;

        private int m_iTotalTrips = 0;//brand-new
        private int m_iTotalFloors = 0;//brand-new

        #endregion

        #region Public Properties

        public bool isEmpty
        {
            get 
            {
                bool bRet = false;
                if ((m_aDestinationFloors == null || m_aDestinationFloors.Length == 0)) bRet = true; //helper prop, looks at Destination floors. If none, is empty
                return bRet;
            }
        }

        public int IMinFLoor
        {
            get
            {
                return m_iMinFLoor;
            }

            set
            {
                m_iMinFLoor = value;
            }
        }

        public int IMaxFloor
        {
            get
            {
                return m_iMaxFloor;
            }

            set
            {
                m_iMaxFloor = value;
            }
        }

        public int ICurrentFloor
        {
            get
            {
                return m_iCurrentFloor;
            }

            set
            {
                m_iCurrentFloor = value;
            }
        }

        public int[] ADestinationFloors
        {
            get
            {
                return m_aDestinationFloors;
            }

            set
            {
                m_aDestinationFloors = value;
            }
        }

        public DoorStates CurrentDoorState
        {
            get
            {
                return m_CurrentDoorState;
            }

            set
            {
                m_CurrentDoorState = value;
            }
        }

        public int ITotalTrips
        {
            get
            {
                return m_iTotalTrips;
            }

            set
            {
                m_iTotalTrips = value;
            }
        }

        public int ITotalFloors
        {
            get
            {
                return m_iTotalFloors;
            }

            set
            {
                m_iTotalFloors = value;
            }
        }
        #endregion


    }
}