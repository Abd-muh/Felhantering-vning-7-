using System;

namespace Uppgift_PRO
{
    class Program
    {
        static void Main(string[] args)
        {
		
		try
	        {      
			Console.Write("Mata in start:");
			int start = int.Parse(Console.ReadLine());
			Console.Write("Mata in stop:");
			int stop = int.Parse(Console.ReadLine());
			Console.Write("mata in steg:");
			int steg = int.Parse(Console.ReadLine());

			

				for (int i = start; i<= stop; i = i + steg)
                {
				Console.WriteLine(i);
                }
			}
			catch (Exception e)
			{
				// "default" stället om inget annat matchaar
			}


			Console.ReadKey();
		}
    }
}
