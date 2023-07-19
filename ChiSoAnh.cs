public class ChiSoAnh
{
    public static void Tinh4ChiSo(double[,] maTran)
    {
        // System.Console.WriteLine("Nhập số max bit: (8bit nhập 255, 3bit nhập 7)):");
        // double x = Convert.ToDouble(Console.ReadLine());



        // double[,] maTran01 = new double[5, 5];
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j < 5; j++)
        //     {
        //         maTran01[i, j] = Math.Round(maTran[i, j] / x, 2, MidpointRounding.AwayFromZero);
        //     }
        // }

        // Console.WriteLine();

        // Console.WriteLine("Ma trận miền [0,1]: ");
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j < 5; j++)
        //     {
        //         Console.Write($"{maTran01[i, j]} \t");
        //     }
        //     Console.WriteLine();
        // }

        Console.WriteLine("Chỉ số trung bình cường độ sáng: ");
        double tong = 0;
        Console.Write("u = ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                tong = tong + maTran[i, j];
                if (i == 0 && j == 0)
                {
                    Console.Write($"({maTran[i, j].ToString()} + ");
                }
                else if (i == 4 && j == 4)
                {
                    Console.Write($"{maTran[i, j].ToString()}) / 25 = ");
                }
                else
                {
                    Console.Write($"{maTran[i, j].ToString()} + ");
                }
            }
        }
        Console.Write(Math.Round(tong / 25, 2, MidpointRounding.AwayFromZero));
        Console.WriteLine();



        Console.WriteLine("\nChỉ số tương phản: ");
        double value1 = 0;
        string str = "a^2 = ";
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                value1 = value1 + (maTran[i, j] * maTran[i, j]);
                if (i == 0 && j == 0)
                {
                    str = str + "(" + maTran[i, j].ToString() + "^2" + " + ";
                }
                else if (i == 4 && j == 4)
                {
                    str = str + maTran[i, j].ToString() + "^2" + ") / 25";
                }
                else
                {
                    str = str + maTran[i, j].ToString() + "^2" + " + ";
                }
            }
        }
        double value2 = 0;
        str = str + " - ";
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                value2 = value2 + maTran[i, j];
                if (i == 0 && j == 0)
                {
                    str = str + $"(({maTran[i, j].ToString()} + ";
                }
                else if (i == 4 && j == 4)
                {
                    str = str + $"{maTran[i, j].ToString()}) / 25)^2 = ";
                }
                else
                {
                    str = str + $"{maTran[i, j].ToString()} + ";
                }
            }
        }
        Console.Write(str + " = " + Math.Round(value1 / 25 - Math.Pow(value2 / 25, 2), 2, MidpointRounding.AwayFromZero));
        Console.WriteLine();


        Console.WriteLine("\nChỉ số Entropy: ");


        Dictionary<double, int> valueCounts = new Dictionary<double, int>(); // Tạo một từ điển để lưu trữ giá trị và số lần xuất hiện

        int rows = maTran.GetLength(0);
        int columns = maTran.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                double value = maTran[i, j];
                if (valueCounts.ContainsKey(value))
                {
                    valueCounts[value]++;
                }
                else
                {
                    valueCounts[value] = 1;
                }
            }
        }
        // Chuyển đổi từ điển thành danh sách để sắp xếp
        List<KeyValuePair<double, int>> sortedValueCounts = valueCounts.ToList();

        // Sắp xếp danh sách theo key tăng dần
        sortedValueCounts.Sort((x, y) => x.Key.CompareTo(y.Key));

        Console.Write("Mức xám\t\t\t");
        foreach (KeyValuePair<double, int> kvp in sortedValueCounts)
        {
            Console.Write(kvp.Key + "\t");
        }
        Console.Write("\nSố lần xuất hiện\t");
        foreach (KeyValuePair<double, int> kvp in sortedValueCounts)
        {
            Console.Write(kvp.Value + "\t");
        }
        Console.Write("\nXác xuất\t\t");
        foreach (KeyValuePair<double, int> kvp in sortedValueCounts)
        {
            Console.Write(kvp.Value + "/25" + "\t");
        }
        Console.WriteLine();
        string strE = "";
        foreach (KeyValuePair<double, int> kvp in sortedValueCounts)
        {
            if (kvp.Key != sortedValueCounts.Max(e => e.Key))
            {
                strE = strE + $"{kvp.Value}/25*log2({kvp.Value}/25) + ";
            }
            else
            {
                strE = strE + $"{kvp.Value}/25*log2({kvp.Value}/25)";
            }
        }
        double valueE = 0;
        foreach (KeyValuePair<double, int> kvp in sortedValueCounts)
        {
            double ratio = kvp.Value / 25.0;
            if (ratio > 0)
            {
                valueE += (ratio * Math.Log2(ratio));
            }
        }
        Console.WriteLine($"E = -({strE}) = {Math.Round(-(valueE), 2, MidpointRounding.AwayFromZero)}");



        Console.WriteLine("\nChỉ số độ sắc nét: ");
        //tính gx
        double[,] gx = new double[5, 5];
        double[,] gy = new double[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                try
                {
                    gx[i, j] = Math.Round(maTran[i, j + 1] - maTran[i, j], 2, MidpointRounding.AwayFromZero);
                }
                catch
                {
                    gx[i, j] = 0;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                try
                {
                    gy[i, j] = Math.Round(maTran[i + 1, j] - maTran[i, j], 2, MidpointRounding.AwayFromZero);
                }
                catch
                {
                    gy[i, j] = 0;
                }
            }
        }

        Console.WriteLine("G(x): ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{gx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("G(y): ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{gy[i, j]} \t");
            }
            Console.WriteLine();
        }
        string strG = "";
        double valueG = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                valueG = valueG + Math.Sqrt(Math.Pow(gx[i,j],2) + Math.Pow(gy[i,j],2));
                
                if (i == 4 && j == 4)
                {
                    strG = strG + $"\u221A(({gx[i, j]})^2 + ({gy[i, j]})^2)";
                }
                else
                {
                    strG = strG + $"\u221A(({gx[i, j]})^2 + ({gy[i, j]})^2)" + " + ";
                }
            }
        }
        Console.WriteLine($"G = ({strG})/25 = " + Math.Round(valueG/25,3,MidpointRounding.AwayFromZero));




    }
}