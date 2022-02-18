using System;

namespace ProvaPresencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] numeros = new int[8];

			for (int p = 0; p < numeros.Length; p++)
			{
				Console.Write("Digite um número: ");
				numeros[p] = Convert.ToInt32(Console.ReadLine());
			}

			if (numeros[0] == numeros[1] && numeros[0] == numeros[2] && numeros[0] == numeros[3] && numeros[0] == numeros[4]
				&& numeros[0] == numeros[5] && numeros[0] == numeros[6] && numeros[0] == numeros[7])
			{
				Console.WriteLine(numeros[0] + " Aparece 8 vezes ");
				Console.ReadLine();
			}

			else if (numeros[0] != numeros[1] && numeros[1] != numeros[2] && numeros[2] != numeros[3] && numeros[3] != numeros[4]
				&& numeros[4] != numeros[5] && numeros[5] != numeros[6] && numeros[6] != numeros[7])
			{
				Console.WriteLine(numeros[0] + " Aparece uma vez\n " + numeros[1] + " Aparece uma vez\n " + numeros[2] + " Aparece uma vez\n " +
					numeros[3] + " Aparece uma vez\n " + numeros[4] + " Aparece uma vez\n " + numeros[5] + " Aparece uma vez\n " + numeros[6] +
					" Aparece uma vez\n " + numeros[7] + " Aparece uma vez\n ");
			}
			
			Array.Sort(numeros);
			Console.Write("\n\n");
			foreach (int p in numeros) Console.WriteLine(p);
		}        
    }
}
