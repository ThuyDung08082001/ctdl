using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Queue
    {

        private Node first;
        private Node last;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }

        }


        public Queue()
        {
            this.count = 0;
        }


        public void EnQueue(int value)
        {
            Node node = new Node(value);
            if (this.Count == 0)
            {
                this.first = node;
                this.last = node;
            }
            else
            {
                this.last.Next = node;
                this.last = node;
            }
            this.count++;
        }


        public int Peek()
        {
            return this.first.Value;
        }


        public int DeQueue()
        {
            int value = this.first.Value;
            this.first = this.first.Next;
            this.count--;
            return value;
        }


        public void Clear()
        {
            this.first = null;
            this.last = null;
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
                    if (j.Value < j.Next.Value)
                    {
                        Swap(ref j, ref j);
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
                    if (j.Value < i.Value)
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
            Console.WriteLine($"count: {this.count}");
        }
        public Queue Finds(string name)
        {
            Queue queue = null;
            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Equals(name))
                {
                    queue = i.Value;
                }
            }
            return queue;
        }
    }
}
