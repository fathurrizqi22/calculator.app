using System;

namespace Calculator{
	public class Calculator{
		public void Main(string[] args){
			int a;
			int b;
			int pil;
			
			Console.writeLine("Pilihan menu Calculator \n");
			Console.writeLine("1. Penambahan \n");
			Console.writeLine("2. Pengurangan \n");
			Console.writeLine("3. Perkalian \n");
			Console.writeLine("4. Pembagian \n");
			Console.writeLine("Masukkanpilihan menu : ");
			pil = Convert.ToInt32(Console.ReadLine());
			
			Console.writeLine("Masukkan nilai A : ");
			a = Convert.ToInt32(Console.ReadLine());
			
			Console.writeLine("Masukkan nilai B : ");
			b = Convert.ToInt32(Console.ReadLine());
			
			if(pil == 1){
				Console.writeLine("Hasil Penambahan: {0} + {1} = {2}", a,b, Penambahan(a,b));
			}
			if(pil == 2){
			    Console.writeLine("Hasil Pengurangan: {0} - {1} = {2}", a,b, Pengurangan(a,b));
			}
			if(pil == 3){
			    Console.writeLine("Hasil Pengurangan: {0} * {1} = {2}", a,b, Perkalian(a,b));
			}
			if(pil == 4){
			    Console.writeLine("Hasil Pengurangan: {0} / {1} = {2}", a,b, Pembagian(a,b));
			}
		}
		
		static int Penambahan(int a, int b){
			return a + b;
		}
		static int Pengurangan(int a, int b){
			return a - b;
		}
		static int Perkalian(int a, int b){
			return a * b;
		}
		static int Pembagian(int a, int b){
			return a / b;
		}
	}	
}