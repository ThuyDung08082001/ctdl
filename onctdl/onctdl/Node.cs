using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Node
    {
        private int value;
        private Node next;

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public Node(int value)
        {
            this.Value = value;
        }
    
    }
}
