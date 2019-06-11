using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }
    }

    public class List
    {
        private Node head;

        public Node Create(int n)
        {
            head = new Node(1);
            Node temp = head;
            int i = 2;
            while (i <= n)
            {
                temp=temp.next = new Node(i++);
            }
            temp.next = head;
            return head;
        }

        public int Delete(int m)
        {
            if ((head!=head.next))
            {
                int m1 = m - 1;
                int i = 1;
                while (i < m1)
                {
                    i++;
                    head = head.next;
                }
                head=head.next = head.next.next;
                this.Delete(m);
            }
            return head.data;
        }
    }
}
