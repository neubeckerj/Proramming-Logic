using System;


namespace Lab2
{
     public class LinkedList
    {
         private Node root;
         private Node last;
         private int size;


        public void add(String letter)
        {
            if (size == 0)
            {
                root = new Node(letter);
                last = root;
            }
            else
            {
                last.setNext(new Node(letter));
                last = last.getNext(); 
            }
            size++;
        }

        public Node getRoot()
        {
            return root;
        }

        public int getSize()
        {
            return size;
        }
    }
}
