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

        public void Load()
        {

        }
    }


}