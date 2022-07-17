using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparison
    {
        int A1;
        int A2;
        int B1;
        int B2;
        double Length_AB;

        public void LineLength()
        {
            
            Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            //Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            Console.WriteLine("Enter X,Y Co_Ordinates of the Poin 2: ");
            //Console.WriteLine("Enter X,Y Co_Ordinates of the Poin 2: ");
            Console.WriteLine("Enter X,Y Co_Ordinates of the Line 1: ");
            Console.WriteLine("Enter X,Y Co_Ordinates of the Line 2: ");
            Console.Write("Enter Value A1: ");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B1: ");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value A2: ");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B2: ");
            B2 = Convert.ToInt32(Console.ReadLine());
            Length_AB = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            Console.WriteLine("Length of Value is : " + Length_AB);
            Console.WriteLine("==================================================================================");
        }
    }
    
}









