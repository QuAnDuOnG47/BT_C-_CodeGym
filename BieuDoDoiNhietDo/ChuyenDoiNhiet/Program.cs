class ChuyenDoiNhiet()
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Chương trình chuyển đổi nhiệt độ từ độ C sang độ F");
    Console.Write("Nhập nhiệt độ (độ C): ");
    float input = float.Parse(Console.ReadLine());

      float fahrenheit = (input * 9 / 5) + 32;
      Console.WriteLine($"Nhiệt độ {input}°C tương đương với {fahrenheit}°F");


  }
}