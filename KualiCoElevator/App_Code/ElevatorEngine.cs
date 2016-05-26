using System;
using System.Collections.Generic;
using System.Collections;

namespace KualiCoElevator
{
    public class ElevatorEngine: CollectionBase, IEnumerable<Elevator>
    {
        public Elevator this[int index]
        {
            get
            {
                return (Elevator)this.List[index];
            }
            set
            {
                this.List[index] = value;
            }

        }

        public new IEnumerator<Elevator> GetEnumerator()
        {
            foreach (Elevator product in this.List)
            {
                yield return product;
            }
        }

        public void Load(int Elevators, int Floors)
        {
            for (int i = 1; i <= Elevators; i++)
            {
                Elevator newElevator = new Elevator(Floors);
                this.List.Add(newElevator);
            }
        }

        #region Public Functions
        public Elevator CallElevator(int WhichFloor)
        {
            ///When an elevator request is made, the unoccupied elevator closest to it will answer
            ///the call, unless an occupied elevator is moving and will pass that floor on its way. 
            ///The exception is that if an unoccupied elevator is already stopped at that floor, 
            ///then it will always have the highest priority answering that call.
            Elevator calledElevator = null;

            //look through all elevators
            foreach (Elevator e in this.List)
            {
                //only check in-service elevators
                if (e.CurrentMode == Elevator.Mode.Operational)
                {
                    //is an empty elevator stopped at that floor
                    //Q -- Does it matter if it's empty, really? Can't we open a full elevator?
                    if ((e.IsEmpty) && (e.CurrentFloor == WhichFloor))
                    {
                        calledElevator = e;
                    }
                    //is a moving elevator going to pass? (Moving up to higher floor, or down to lower)
                    //TODO - This does not guarantee the closest moving
                    else if (((e.CurrentDirection == Elevator.Direction.Up) && (e.NextFloor >= WhichFloor)) || ((e.CurrentDirection == Elevator.Direction.Down) && (e.NextFloor <= WhichFloor)))
                    {
                        calledElevator = e;
                    }
                 }
            }

            if (calledElevator == null)
            {
                calledElevator = getClosestUnoccupiedElevator();
            }


            //set the destination
            calledElevator.SetDestination(WhichFloor);

            //Return the elevator called
            return calledElevator;
        }

        private Elevator getClosestUnoccupiedElevator()
        {
            //TODO -- loop through unoccupied and find closest
            throw new NotImplementedException();
        }
        #endregion

    }


}