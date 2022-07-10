using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Node
    {
        public int key;
        public string name;
        public Node next;
        //Hash Table'da array içinde gösterici olarak tutulan düğüm
        public Node()
        {
            this.next = null;
        }
        //Hash Table'da array dışında linked list olarak tutulan düğüm
        public Node(int key, string name)
        {
            this.key = key;
            this.name = name;
            this.next = null;
        }
    }
}
