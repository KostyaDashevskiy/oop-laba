using OOP_laba_1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_3
{
    public class Tree
    {
        public int data { get; set;}
        public List<Tree> Trees;

        public Tree(int a)
        {
            data = a;
            Trees = new List<Tree>();   
        }

        public void Print()
        {
            Console.WriteLine(data);
            foreach (Tree t in Trees)
            {
                t.Print();
            }
        }
    }
}

