Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Áp Dụng Cho Ma Trận 5x5 Nhé!!! Hãy nhập tất cả bằng số !!!!");
double[,] maTran = new double[5, 5];
Console.WriteLine("Nhập ma trận 5x5 đầu vào: ");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Điểm ({i},{j}): ");
        var x = Console.ReadLine();
        maTran[i, j] = Convert.ToDouble(x);
    }
}
Console.WriteLine();

Console.WriteLine("Ma trận của bạn là: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{maTran[i, j]} \t");
    }
    Console.WriteLine();
}
System.Console.WriteLine();
Console.WriteLine("Chọn loại thuật toán muốn giải: ");
System.Console.WriteLine("1.Sobel và Prewitt");
System.Console.WriteLine("2.Alpha");
System.Console.WriteLine("3.Lọc nhị thức");
System.Console.WriteLine("----------------------------------------------------");

ThuatToan thuattoan = new ThuatToan();
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        thuattoan.SobelAndPrewitt(maTran);
        break;
    case 2:
        thuattoan.Alpha(maTran);
        break;
    case 3:
        thuattoan.LocNhiThuc(maTran);
        break;
}
