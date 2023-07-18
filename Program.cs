

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Áp Dụng Cho Ma Trận 5x5 !!! Hãy nhập tất cả bằng số !!!!");
System.Console.WriteLine("Hiện có: Sobel và Prewitt, Alpha, Lọc nhị thức, Lọc nhiễu Min, Lọc nhiễu Max, Lọc nhiễu trung điểm, ");
System.Console.WriteLine("Lọc nhiễu trung bình hình học, Dò biên Kirsch, Laplacian");
System.Console.WriteLine();
double[,] maTran = new double[5, 5];

// Console.WriteLine("Nhập ma trận 5x5 đầu vào: ");
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"Điểm ({i},{j}): ");
//         var x = Console.ReadLine();
//         maTran[i, j] = Convert.ToDouble(x);
//     }
// }

//xuân
maTran[0,0] = 5;
maTran[0,1] = 7;
maTran[0,2] = 6;
maTran[0,3] = 4;
maTran[0,4] = 3;
maTran[1,0] = 2;
maTran[1,1] = 2;
maTran[1,2] = 3;
maTran[1,3] = 7;
maTran[1,4] = 5;
maTran[2,0] = 5;
maTran[2,1] = 6;
maTran[2,2] = 7;
maTran[2,3] = 2;
maTran[2,4] = 7;
maTran[3,0] = 4;
maTran[3,1] = 3;
maTran[3,2] = 5;
maTran[3,3] = 3;
maTran[3,4] = 3;
maTran[4,0] = 4;
maTran[4,1] = 4;
maTran[4,2] = 7;
maTran[4,3] = 5;
maTran[4,4] = 5;


// maTran[0, 0] = 7;
// maTran[0, 1] = 6;
// maTran[0, 2] = 6;
// maTran[0, 3] = 3;
// maTran[0, 4] = 5;
// maTran[1, 0] = 6;
// maTran[1, 1] = 2;
// maTran[1, 2] = 5;
// maTran[1, 3] = 6;
// maTran[1, 4] = 7;
// maTran[2, 0] = 5;
// maTran[2, 1] = 1;
// maTran[2, 2] = 3;
// maTran[2, 3] = 6;
// maTran[2, 4] = 4;
// maTran[3, 0] = 4;
// maTran[3, 1] = 6;
// maTran[3, 2] = 3;
// maTran[3, 3] = 6;
// maTran[3, 4] = 1;
// maTran[4, 0] = 2;
// maTran[4, 1] = 5;
// maTran[4, 2] = 6;
// maTran[4, 3] = 4;
// maTran[4, 4] = 7;



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
void writeSomthing()
{
    System.Console.WriteLine("1.Sobel và Prewitt");
    System.Console.WriteLine("2.Alpha");
    System.Console.WriteLine("3.Lọc nhị thức");
    System.Console.WriteLine("4.Lọc nhiễu Min");
    System.Console.WriteLine("5.Lọc nhiễu Max");
    System.Console.WriteLine("6.Lọc nhiễu trung điểm");
    System.Console.WriteLine("7.Lọc nhiễu trung bình hình học");
    System.Console.WriteLine("8.Dò biên Kirsch");
    System.Console.WriteLine("9.Sử dụng toán tử Laplacian");
    System.Console.WriteLine("10.Cân bằng Histogram");
    System.Console.WriteLine("11.Lọc trung bình");
    System.Console.WriteLine("12.Tính 4 chỉ số đánh giá chất lượng ảnh");
    System.Console.WriteLine("----------------------------------------------------");
}

int next = 1;
while (next == 1)
{
    writeSomthing();
    ThuatToan thuattoan = new ThuatToan();
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("------------------------------------");

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
        case 10:
            thuattoan.CanBangHistogram(maTran);
            break;
        case 11:
            thuattoan.LocTrungBinh(maTran);
            break;
        case 12:
            ThuatToan2.Tinh4ChiSo(maTran);
            break;
    }
    System.Console.WriteLine();
    System.Console.WriteLine("---------------------------------");
    System.Console.WriteLine("Bạn muốn giải tiếp không?");
    System.Console.WriteLine("1.Có       2.Không");

    next = Convert.ToInt32(Console.ReadLine());
    if (next == 2)
    {
        break;
    }
}

