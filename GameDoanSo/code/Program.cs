class DoanSo()
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Chuong trinh doan so ngau nhien tu 0 den 9");
        int m = random.Next(0, 10);
        Console.Write("Nhap so nguyen duong n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n == m)
        {
           Console.WriteLine("So ban nhap la: " + n + " va so ngau nhien la: " + m + ". Ban da doan dung.");   
        }
        else
        {
            Console.WriteLine("So ban nhap la: " + n + " va so ngau nhien la: " + m + ". Ban da doan sai.");
        }
        
    }
}