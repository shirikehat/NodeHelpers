﻿using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        public static bool IsExist(Node<ShabatRecievers> node, int day, int month, int year)
        {
            while (node != null)
            {
                if(node.GetValue().GetDay()==day && node.GetValue().GetMonth() == month && node.GetValue().GetYear() == year)
                    return true;
                node = node.GetNext();
            }
            return false;
        }


        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }
    }
}