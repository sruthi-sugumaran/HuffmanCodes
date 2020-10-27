using System;
using System.Collections.Generic;
using System.Text;

namespace HuffmanCodes
{
    class Node : IComparable
    {
        public char Character { get; set; }
        public int Frequency { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(char character, int frequency, Node left, Node right)
        {
            Character = character;
            Frequency = frequency;
            Left = left;
            Right = right;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
