using OOP_laba_1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_3
{
    internal class Tree
    {
        public int Variable { get; set;}
        public List<Tree> Trees;

        public Tree(int a)
        {
            Variable = a;
            Trees = new List<Tree>();   
        }

        public void Print()
        {
            Console.WriteLine(Variable);
            foreach (Tree t in Trees)
            {
                t.Print();
            }
        }
    }
}

