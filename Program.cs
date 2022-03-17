using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Console.WriteLine();
System.Console.WriteLine("CODE BY ĐỖ VĂN XUÂN - 61PM2");
System.Console.WriteLine();
Console.WriteLine("Áp Dụng Cho Ma Trận 5x5 Nhé!!! Hãy nhập tất cả bằng số !!!!");
System.Console.WriteLine("Hiện có: Sobel và Prewitt, Alpha, Lọc nhị thức, Lọc nhiễu Min, Lọc nhiễu Max, Lọc nhiễu trung điểm, ");
System.Console.WriteLine("Lọc nhiễu trung bình hình học, Dò biên Kirsch, Laplacian");
System.Console.WriteLine();
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
System.Console.WriteLine("4.Lọc nhiễu Min");
System.Console.WriteLine("5.Lọc nhiễu Max");
System.Console.WriteLine("6.Lọc nhiễu trung điểm");
System.Console.WriteLine("7.Lọc nhiễu trung bình hình học");
System.Console.WriteLine("8.Dò biên Kirsch");
System.Console.WriteLine("9.Sử dụng toán tử Laplacian");
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
    case 4:
        thuattoan.LocNhieuMin(maTran);
        break;
    case 5:
        thuattoan.LocNhieuMax(maTran);
        break;
    case 6:
        thuattoan.LocNhieuTrungDiem(maTran);
        break;
    case 7:
        thuattoan.LocNhieuTrungBinhHinhHoc(maTran);
        break;
    case 8:
        thuattoan.DoBienKirsch(maTran);
        break;
    case 9:
        thuattoan.Laplacian(maTran);
        break;
}
