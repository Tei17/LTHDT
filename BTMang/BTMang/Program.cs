using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMang
{
	class Program
	{
		/// <summary>
		/// Tạo mảng M có n phần tử, sau đó:
		/// 1) Nhập giá trị ngẫu nhiên cho các phần tử trong mảng M
		/// 2) Xuất các giá trị trong mảng
		/// 3) Đảo ngược mảng
		/// 4) Sắp xếp mảng 
		/// 5) Tỉnh tổng các phần tử trong mảng
		/// 6) Tìm kiếm mảng
		/// </summary>
		static void Mang1chieu()
		{
			Console.WriteLine("Nhập số phần tử trong mảng: ");
			int n = int.Parse(Console.ReadLine());
			int[] M = new int[n];
			//1. Nhập giá trị ngẫu nhiên
			Random rd = new Random();
			for (int i = 0; i < M.Length; i++)
			{
				M[i] = rd.Next(100);
			}
			//2. Xuất các giá trị trong mảng
			for (int i = 0; i < M.Length; i++)
			{
				Console.Write(M[i] + "  ");
			}
			//3. Đảo ngược mảng
			Array.Reverse(M);
			Console.WriteLine("\nMảng sau khi đảo chiều là ");
			for (int i = 0; i < M.Length; i++)
			{
				Console.Write(M[i] + "  ");
			}
			//4. Sắp xếp mảng
			Array.Sort(M);

			Console.WriteLine("\nMảng sau khi sắp xếp là ");
			for (int i = 0; i < M.Length; i++)
			{
				Console.Write(M[i] + "  ");
			}
			//5. Tính tổng mảng
			int sum = 0;
			foreach (int x in M)
			{
				sum += x;
			}
			Console.WriteLine("\nTổng mảng là {0}", sum);
			//6. Tìm kiếm mảng
			Console.WriteLine("Mời bạn nhập số muốn tìm: ");
			int h = int.Parse(Console.ReadLine());
			int kq = Array.BinarySearch(M, h);
			if (kq < 0)
			{
				Console.WriteLine("Không tìm thấy {0} trong mảng", h);

			}
			else
			{
				Console.WriteLine("TÌm thấy {0} tại vị trí {1}", h, kq);

			}
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Mang1chieu();
			Console.ReadLine();
		}
	}
}
