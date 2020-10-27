using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace HuffmanCodes
{
    class Huffman
    {
        private Node HT;                          //Huffman tree to create codes and decode text
        private Dictionary<char, String> D;         //Dictionary to encode text

        //Constructor
        public Huffman(String S)
        {

        }

        //Return the frequency of each character in the given text
        private int[] AnalyzeText(String S)
        {
            return null;
        }

        //Build a Huffman tree based on the character frequencies greater than 0(invoked by Huffman)
        private void Build(int[] F)
        {
            //PriorityQueue<LinkedListNode> PQ;
        }

        //Create the codes of 0s and 1s for each character by traversing the Huffman tree(invoked by Huffman)
        //Stores the codes in Dictionary D using the char as the key
        private void CreateCodes()
        {

        }

        //Encode the given text and return a string of 0s and 1s
        public String Encode(String S)
        {
            return null;
        }

        //Decode the given string of 0s and 1s and return the original text
        public string Decode(String S)
        {
            return null;
        }
    }
}
