using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
	class Program
	{
		static void chuoi()
		{
			string s;
			Console.WriteLine("Nhap 1 chuoi:");
			s = Console.ReadLine();
			int demInHoa = 0, demInThuong = 0, demSo = 0, demKhoangTrang = 0;
			char[] arr = s.ToCharArray();
			for (int i = 0; i < arr.Length; i++)
			{
				if (char.IsLower(arr[i]))
					demInThuong++;
				if (char.IsUpper(arr[i]))
					demInHoa++;
				if (char.IsDigit(arr[i]))
					demSo++;
				if (char.IsWhiteSpace(arr[i]))
					demKhoangTrang++;
			}
			Console.WriteLine("Có {0} kí tự in thường", demInThuong);
			Console.WriteLine("Có {0} kí tự in hoa", demInHoa);
			Console.WriteLine("Có {0} kí tự số: ", demSo);
			Console.WriteLine("Có {0} khoảng trắng: ", demKhoangTrang);
			Console.ReadLine();
		}
		static void chuoi2()
		{
			string s;
			while (true)
			{
				Console.WriteLine("Nhap 1 chuoi:");
				s = Console.ReadLine();
				int demInHoa = 0, demInThuong = 0, demSo = 0, demKhoangTrang = 0;
				for (int i = 0; i < s.Length; i++)
				{
					char kt = s[i];
					if (char.IsLower(kt))
						demInThuong++;
					if (char.IsUpper(kt))
						demInHoa++;
					if (char.IsDigit(kt))
						demSo++;
					if (char.IsWhiteSpace(kt))
						demKhoangTrang++;
				}
				Console.WriteLine("Có {0} kí tự in thường", demInThuong);
				Console.WriteLine("Có {0} kí tự in hoa", demInHoa);
				Console.WriteLine("Có {0} kí tự số: ", demSo);
				Console.WriteLine("Có {0} khoảng trắng: ", demKhoangTrang);
				Console.WriteLine("Bạn có muốn nhập lại không (y/n) ?: ");
				string n = Console.ReadLine();
				if (n == "n")
				{
					break;
				}
				if (n == "y")
				{

				}
				else
				{
					Console.WriteLine("Nhập sai, vui lòng nhập y/n");
					n = Console.ReadLine();
					do
					{
						if (n == "n")
						{
							break;
						}
						if (n == "y")
						{
							break;
						}
						else
						{
							Console.WriteLine("Nhập sai, vui lòng nhập y/n");
							n = Console.ReadLine();
						}
					} while (true);
					if (n == "n")
					{
						break;
					}
					if (n == "y")
					{

					}
				}
			}

		}
		static void XulyChuoi()
		{
			Console.OutputEncoding = Encoding.UTF8;
			string s;
			Console.WriteLine("Nhap chuoi: ");
			s = Console.ReadLine();
			Console.WriteLine("Nhap chuoi tiep theo: ");
			string s2 = Console.ReadLine();
			int kq = s.CompareTo(s2);
			if (kq == 0)
			{
				Console.WriteLine("chuoi bang nhau");
			}
			else if (kq < 0)
			{
				Console.WriteLine("chuoi đầu bé hon chuoi sau");
			}
			else
			{
				Console.WriteLine("chuoi đầu lớn hon chuoi sau");
			}
			Console.ReadLine();
		}
		static void Xulychuoi1()
		{
			string line = "1812759,LeQuocHoang,CTK42";
			string[] arr = line.Split(',');
			Console.WriteLine("MSSV: {0}", arr[0]);
			Console.WriteLine("HVT: {0}", arr[1]);
			Console.WriteLine("Khoa: {0}", arr[2]);
			Console.ReadLine();
		}
		static void toiUuChuoi()
		{
			Console.WriteLine("Nhập tên: ");
			string ten = Console.ReadLine();
			Console.WriteLine("Chuỗi gốc đã nhập: ");
			Console.WriteLine(ten);
			ten = ten.Trim();
			Console.WriteLine("Chuỗi tối ưu: ");
			Console.WriteLine(ten);
			Console.ReadLine();
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			//chuoi();
			//chuoi2();
			//XulyChuoi();

			toiUuChuoi();
		}
	}
}
