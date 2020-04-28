using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		
		static void gameDoanSo()
		{
			Console.OutputEncoding = Encoding.UTF8;
			Random rd = new Random();
			int soCuaMay = rd.Next(501);
			int soNguoiDoan;
			int soLanDoan = 0;
			Console.WriteLine("Hãy đoán một số");
			while (true)
			{
				soNguoiDoan = int.Parse(Console.ReadLine());
				soLanDoan++;
				Console.WriteLine("Bạn đã đoán {0} lần", soLanDoan);
				if (soNguoiDoan == soCuaMay)
				{
					Console.WriteLine("Chúc mừng bạn đã đoán đúng, số của máy là: {0}", soCuaMay);
					break;
				}
				if (soNguoiDoan > soCuaMay)
				{
					Console.WriteLine("Số của bạn > số của máy");
				}
				else
				{
					Console.WriteLine("Số của bạn < số của máy");
				}
				if (soLanDoan == 7)
				{
					Console.WriteLine("GAMEOVER, Số của máy là: {0}", soCuaMay);
					break;
				}
			}
		}

		static void Main(string[] args)
		{
			while (true)
			{
				gameDoanSo();
				Console.WriteLine("Bạn có muốn chơi tiếp không? (y/n): ");
				string a = Console.ReadLine();
				if (a == "n")
				{
					break;
				}
			}
			Console.ReadLine();
		}
		
	}
}

