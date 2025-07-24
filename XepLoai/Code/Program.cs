class XepLoai
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap diem cua ban : ");
        int diem = Convert.ToInt32(Console.ReadLine());

        if(diem < 0 || diem > 100)
        {
            Console.WriteLine("Diem khong hop le. Vui long nhap lai.");
        }
        else if (diem < 35)
        {
            Console.WriteLine("Xep loai: E");
        }
        else if (diem >= 35 && diem < 45)
        {
            Console.WriteLine("Xep loai: D");
        }
        else if (diem >= 45 && diem < 60)
        {
            Console.WriteLine("Xep loai: C");
        }
        else if (diem >= 60 && diem < 75)
        {
            Console.WriteLine("Xep loai: B");
        }
        else
        {
            Console.WriteLine("Xep loai: A");
        }
        
    }
}