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
                //Q -- Does it matter if it's empty, really?
                if ((e.IsEmpty) && (e.CurrentFloor == WhichFloor))
                    {
                        e.SetDestination(WhichFloor);
                        calledElevator = e;
                    }
                    //is a moving elevator going to pass? (Moving up to higher floor, or down to lower
                    else if (((e.CurrentDirection == Elevator.Direction.Up) && (e.NextFloor >= WhichFloor)) || ((e.CurrentDirection == Elevator.Direction.Down) && (e.NextFloor <= WhichFloor)))
                    {
                        e.SetDestination(WhichFloor);
                        calledElevator = e;
                    }
                }
            }
            //Return the elevator called

            return calledElevator;
        }
        #endregion

    }


}