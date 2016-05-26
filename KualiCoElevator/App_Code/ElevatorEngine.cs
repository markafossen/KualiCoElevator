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


            //Return the elevator called

            return null;
        }
        #endregion

    }


}