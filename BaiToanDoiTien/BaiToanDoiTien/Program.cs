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
			Console.Write("Nhập giá trị đồng xu cần quy đổi: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Nhập số lượng đồng xu quy đổi: ");
			int sL = int.Parse(Console.ReadLine());
			int[] mangLoaiTien = new int[sL];
			int[] mangSL = new int[sL];
			for (int i = 0; i < mangLoaiTien.Length; i++)
			{
				Console.WriteLine("Nhập loại tiền theo thứ tự giảm dần: ");
				int loaiTien = int.Parse(Console.ReadLine());
				int soLuong;
				mangLoaiTien[i] = loaiTien;
				soLuong = n / loaiTien;
				n -= loaiTien * soLuong;
				mangSL[i] = soLuong;
			}
			for (int j = 0; j < mangLoaiTien.Length; j++)
			{
				Console.WriteLine("Loại {0} là: {1}", mangLoaiTien[j], mangSL[j]);
			}
			int sum = 0;
			foreach (int x in mangSL)
			{
				sum += x;
			}
			Console.WriteLine("Tổng số tờ các loại là: {0} ", sum);
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			BaiToanDongXu();
		}
	}
}
