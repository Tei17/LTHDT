using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiToanDoiTien
{
	class Program
	{

		static void BaiToanDongXu()
		{
			int xu25, xu20, xu10, xu5, xu1;
			Console.WriteLine("Nhập giá trị đồng xu: ");
			int n = int.Parse(Console.ReadLine());
			xu25 = n / 25; n -= 25 * xu25;
			xu20 = n / 20; n -= 20 * xu20;
			xu10 = n / 10; n -= 10 * xu10;
			xu5 = n / 5; n -= 5 * xu5;
			Console.WriteLine("Số đồng xu các loại là: ");
			Console.WriteLine("Loại 25 xu: {0}", xu25);
			Console.WriteLine("Loại 20 xu: {0}", xu20);
			Console.WriteLine("Loại 10 xu: {0}", xu10);
			Console.WriteLine("Loại 5 xu: {0}", xu5);
			Console.WriteLine("Loại 1 xu: {0}", n);
			Console.WriteLine("Tổng số tờ các loại là: {0}", xu25 + xu20 + xu10 + xu5 + n);
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			BaiToanDongXu();
		}
	}
}
