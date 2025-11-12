using System;

namespace Workshop3
{
   class Program
    {
        static void Main(String[] args)
        {
            Operators op = new Operators();
            op.Addition(10, 5);
            op.Subtractation(10, 5);
            op.Multiply(10, 5);
            op.Divide(10, 5);
            op.OddEvenFinder(7);
            op.OddEvenFinder(8);
        }
        
    }

}
