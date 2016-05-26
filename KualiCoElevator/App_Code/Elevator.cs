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
        public enum Direction
        {
            Up,
            Down,
            Stopped
        }
        public enum Mode //not a boolean, just in acse there are other states I have not thought of ... like Executive/Express?
        {
            Maintenance,
            Operational
        }
        #endregion

        #region Private Properties
        private int m_iMinFLoor = 1; //specified in spec
        private int m_iMaxFloor = 10; //default value
        private int m_iCurrentFloor = 1;//start on ground floor
        private int[] m_aDestinationFloors; //no destinations
        private bool m_bIsEmpty = true;//assume empty
        private DoorStates m_CurrentDoorState = DoorStates.Closed;
        private Direction m_CurrentDirection = Direction.Stopped;
        private Mode m_CurrentMode = Mode.Operational;

        private int m_iTotalTrips = 0;//brand-new
        private int m_iTotalFloors = 0;//brand-new

        #endregion

        #region Public Properties



        public bool isMoving
        {
            get
            {
                //if it has a destination, it needs to be moving towards that destination
                bool bRet = false;
                if ((m_aDestinationFloors == null || m_aDestinationFloors.Length == 0)) bRet = true; //helper prop, looks at Destination floors. If none, is empty
                return bRet;
            }
        }
        public int MinFLoor
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

        public int MaxFloor
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

        public int CurrentFloor
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

        public int[] DestinationFloors
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

        public bool IsEmpty
        {
            //was calculating this, but needs to be tracked
            //when there are no destinations and the door has closed it is empty. 
            //It is still empty until it has recieved a destination AND opened its doors
            get

            {
                return m_bIsEmpty;
            }

            set
            {
                m_bIsEmpty = value;
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

        public Direction CurrentDirection
        {
            get
            {
                return m_CurrentDirection;
            }

            set
            {
                m_CurrentDirection = value;
            }
        }

        public Mode CurrentMode
        {
            get
            {
                return m_CurrentMode;
            }

            set
            {
                m_CurrentMode = value;
            }
        }

        public int TotalTrips
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

        public int TotalFloors
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

        #region Constructors
        public Elevator()
        {
        }

        public Elevator(int MaxFloor)
        {
            m_iMaxFloor = MaxFloor;
        }
        #endregion

        #region Public Functions
        public void SetDestination(int Floor)
        {

        }
        #endregion

        #region Private Functions
        private void Move()
        {
            //How long does it take to move from floor to floor?
            //What is our next Destination, Wat is our Direction
            //track floors passed


        }
        #endregion
    }
}