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
        private List<int> m_DestinationFloors; //no destinations
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
                //for convience. just look at the enum. if not stopped, it's moving
                bool bRet = true;
                if (m_CurrentDirection == Direction.Stopped) bRet = false;
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

        public List<int> DestinationFloors
        {
            get
            {
                return m_DestinationFloors;
            }

            set
            {
                m_DestinationFloors = value;
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
            m_DestinationFloors.Add(Floor);
        }
        #endregion

        #region Private Functions
        private void Move()
        {
            //How long does it take to move from floor to floor?
            //Do We Have a destination? If not don't move, and be stopped.
            if ((m_DestinationFloors == null || m_DestinationFloors.Count == 0))
            {
                m_CurrentDirection = Direction.Stopped;
            }
            else //if we do have a destination
            {
                //What is our Direction

                //What is our next Destination,

            }


            ///The elevator should keep track of how many trips it has made, 
            ///and how many floors it has passed. The elevator should go into 
            ///maintenance mode after 100 trips, and stop functioning until serviced, 
            ///therefore not be available for elevator calls.

            //track trips, send into maintenance when empty and stopped(?) and currently operational
            //still need to define trips as opposed to floors.
                if (m_iTotalTrips >= 100)
            {
                if ((m_bIsEmpty) && (m_CurrentDirection == Direction.Stopped) && (m_CurrentMode == Mode.Operational)
                {
                    m_CurrentDoorState = DoorStates.Closed; //close the doors
                    m_CurrentMode = Mode.Maintenance;//put it in maintenance
                    m_DestinationFloors.Add(1);

                }
            }

        }
        #endregion
    }
}