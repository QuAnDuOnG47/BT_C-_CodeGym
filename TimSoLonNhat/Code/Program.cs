class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong so trong day : ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Khong hop le, So luong phai la so > 0.");
            return;
        }

        Console.WriteLine("Nhap cac so trong day : ");
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("So lon nhat trong day la: " + max);
    }

}