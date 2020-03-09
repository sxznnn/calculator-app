class calculator
{
	static void main (string[] args)
	{
		int a = 10;
		int b = 6 ;
		
		Console.Writeline("Hasil Penambahan: {0} + {1} = {2}", a, b, penambahan(a, b));
		Console.Writeline("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b));
		
		Console.Writeline("\nTekan Sembarang Key Untuk Keluar");
		Console.ReadKey();
	}

	static int penambahan (int a, int b)
	{
		return a + b;
	}
	static int pengurangan (int a, int b)
	{
		return a - b;
	}
}