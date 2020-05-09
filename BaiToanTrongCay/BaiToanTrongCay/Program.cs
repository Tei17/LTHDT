using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom19_CTK42
{
	class Program
	{
		static void BaiToanTTrongCay()
		{
			Random rd = new Random();
			Console.Write("Nhập số hạt giống sẽ mua để trồng cây: ");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = rd.Next(8) + 1;
			}
			Console.WriteLine("Các cây đã mua sẽ trồng có thời gian mọc lên là: ");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + "\t");
			}
			Array.Sort(a);
			Console.WriteLine("\nSắp xếp lại các cây để tối ưu số ngày trồng lên là : ");
			Console.ReadLine();
			int[] b = new int[n];
			for (int j = n - 1, i = 0; i < a.Length; j--, i++)
			{
				Console.Write(a[j] + "\t");
				b[i] = a[j] + i + 1;
			}
			Console.ReadLine();
			Array.Sort(b);
			Console.WriteLine("Số ngày để tất cả các cây đều mọc là: {0}", b[n - 1]);
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			BaiToanTTrongCay();
		}
	}
}
