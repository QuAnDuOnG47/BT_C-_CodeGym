class TinhDiemTB()
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap diem Toan: ");
        int toan = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem Ly: ");
        int ly = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem Hoa: ");
        int hoa = int.Parse(Console.ReadLine());

        double diemTB = (toan + ly + hoa) / 3.0;
        Console.WriteLine($"Diem trung binh: {diemTB}");
    }
}