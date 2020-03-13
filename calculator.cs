/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Pilih Menu Calculator :");
            
            Console.WriteLine();
			
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            
            Console.WriteLine();
            
            Console.Write("Input nomor menu [1..4] : ");
            int nomor = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

			if(nomor==1)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				int c = a + b;
				Console.WriteLine();
                Console.WriteLine("Hasil Pemanbahan = {0}", c);
			}
			else if(nomor==2)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				int c = a - b;
				Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan = {0}", c);
            }
			else if(nomor==3)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				int c = a * b;
				Console.WriteLine();
                Console.WriteLine("Hasil Perkalian = {0}", c);
            }
			else if(nomor==4)
			{
				Console.Write("Input Nilai a = ");
				int a = int.Parse(Console.ReadLine());
				Console.Write("Input Nilai b = ");
				int b = Convert.ToInt32(Console.ReadLine());
				int c = a / b;
				Console.WriteLine();
                Console.WriteLine("Hasil Pembagian = {0}", c);
			}
			else
            {
                Console.WriteLine("Maaf, Menu yang Anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan Sembarang Untuk Keluar.");
            Console.ReadKey();
        }
    }
}