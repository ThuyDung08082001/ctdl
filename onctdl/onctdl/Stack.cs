using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Stack
    {

        private Node first;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }


        }


        public Stack()
        {
            this.count = 0;
        }




        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.Count == 0)
            {
                this.first = node;
            }
            else
            {
                node.Next = this.first;
                this.first = node;
            }
            this.count++;
        }


        public int Peek()
        {
            return this.first.Value;
        }


        public int Pop()
        {
            int value = this.first.Value;
            this.first = this.first.Next;
            this.count--;
            return value;
        }


        public void Clear()
        {
            this.first = null;
            this.count = 0;
        }


        public Person Find(string name)
        {
            Person ps = null;

            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Equals(name))
                {
                    ps = i.Value;
                    break;
                }
            }

            return ps;
        }


        public Person FindLast(string name)
        {
            Person ps = null;

            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Equals(name))
                {
                    ps = i.Value;
                }
            }

            return ps;
        }


        public void BubbleSort()
        {
            for (Node i = this.first; i != null; i = i.Next)
            {
                for (Node j = this.first; j.Next != null; j = j.Next)
                {
                    if (j.Value > j.Next.Value)
                    {
                        Swap(ref j, ref j.Next);
                    }
                }
            }
        }


        public void InterchangeSort()
        {
            for (Node i = this.first; i.Next != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value > i.Value)
                    {
                        Swap(ref j, ref i);
                    }
                }
            }
        }


        private void Swap(ref Node node1, ref Node node2)
        {
            int value = node1.Value;
            node1.Value = node2.Value;
            node2.Value = value;
        }

        public void Show()
        {
            for (Node i = this.first; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine($"count: {this.Count}");
        }
    }
}
