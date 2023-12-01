using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheiyvane pirveli ricxvi: ");

            int n1 = int.Parse(Console.ReadLine());

            Console.Write("sheiyvane meore ricxvi: ");

            int n2 = int.Parse(Console.ReadLine());

            Console.Write("sheiyvane mesame ricxvi: ");

            int n3 = int.Parse(Console.ReadLine());

            if(n1 >= n2 && n1 >= n3)
            {
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("pirveli ricxvi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n1 == n2)
                {
                    Console.WriteLine("pirveli da meore ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n1 == n3)
                {
                    Console.WriteLine("pirveli da mesame ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }
                
            }else if(n2 >= n1 && n2 >= n3)
            {
                if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine("meore ricxvi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n2 == n1)
                {
                    Console.WriteLine("meore da pirveli ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n2 == n3)
                {
                    Console.WriteLine("meore da mesame ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }
            }
            else if( n3 >= n1 && n3 >= n2)
            {
                if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine("mesame ricxvi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n3 == n1)
                {
                    Console.WriteLine("mesame da pirveli ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }

                if (n3 == n2)
                {
                    Console.WriteLine("mesame da meore ricxvebi maqsimaluria warmodgenil ricxvebs shoris");
                }
            }
        }
    }
}
