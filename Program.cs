using System;

namespace DemoBai8
{
    public class HoaDon
    {
        public int Loai { get; set; } // 1 - ca phe, 2 - lam banh
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
    }


    internal class Program
    {
        public delegate void EventHandler(HoaDon hoadon);
        public static event EventHandler _event;

        public static void PhaCaPhe(HoaDon hoadon)
        {
            if(hoadon.Loai == 1)
            {
                Console.WriteLine("Man hinh Pha Ca Phe");
                HienThi(hoadon);
            }
        }

        public static void LamBanh(HoaDon hoadon)
        {
            if (hoadon.Loai == 2)
            {
                Console.WriteLine("Man hinh Lam Banh");
                HienThi(hoadon);
            }
        }

        public static void HienThi(HoaDon hoadon)
        {
            Console.WriteLine("Ten mon: \t{0}", hoadon.TenMon);
            Console.WriteLine("So luong: \t{0}", hoadon.SoLuong);
            Console.WriteLine("Don Gia: \t{0}", hoadon.DonGia);
            Console.WriteLine("Tong: \t\t{0}", hoadon.SoLuong * hoadon.DonGia);
        }

        static void Main(string[] args)
        {
            _event += new EventHandler(PhaCaPhe);
            _event += new EventHandler(LamBanh);

            HoaDon hdCaPhe = new HoaDon();
            hdCaPhe.Loai = 1;
            hdCaPhe.TenMon = "Ca phe sua";
            hdCaPhe.SoLuong = 2;
            hdCaPhe.DonGia = 20000;

            HoaDon hdLamBanh = new HoaDon();
            hdLamBanh.Loai = 2;
            hdLamBanh.TenMon = "Banh socola";
            hdLamBanh.SoLuong = 2;
            hdLamBanh.DonGia = 50000;

            //if (hdCaPhe.Loai == 1) PhaCaPhe(hdCaPhe);
            //if (hdLamBanh.Loai == 2) LamBanh(hdLamBanh);

            _event(hdCaPhe);
            _event(hdLamBanh);

            //_event("test event");

            //Console.Write("Nhap noi dung: ");
            //string content = Console.ReadLine();

            //_event(content);

            Console.ReadKey();
        }
    }
}
