using System;


namespace Lab2
{
     public class Node
    {
         private String value;
        private Node next;

        public Node(string value) 
        {
            this.value = value;
        }

        public Node getNext()
        {
            return next;
        }

        public void setNext(Node node)
        {
            next = node;
        }
        public String getValue()
        {
            return value;
        }

        public void setValue(String letter)
        {
            value = letter;
        }
        



    }
}
