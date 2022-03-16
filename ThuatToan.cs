class ThuatToan
{
    public void SobelAndPrewitt(double[,] maTran)

    {
        Console.WriteLine("----------Sobel and Prewitt-----------");
        double[,] H1 = new double[3, 3];
        double[,] H2 = new double[3, 3];
        Console.WriteLine("Nhập ma trận 3x3 H1:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Điểm ({i},{j}): ");
                var x = Console.ReadLine();
                H1[i, j] = Convert.ToDouble(x);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Nhập ma trận 3x3 H2:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Điểm ({i},{j}): ");
                var x = Console.ReadLine();
                H2[i, j] = Convert.ToDouble(x);
            }
            Console.WriteLine();
        }

        double[,] Gx = new double[5, 5];
        double[,] Gy = new double[5, 5];
        System.Console.WriteLine("----------Kết quả----------");

        System.Console.WriteLine("---------Ma trận G(x)--------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                double result = (firstPosition * H1[0, 0]) + (secondPosition * H1[1, 0]) + (thirdPosition * H1[2, 0]) + (fourthPosition * H1[0, 2]) + (fifthPosition * H1[1, 2]) + (sixthPosition * H1[2, 2]);
                Gx[i, j] = result;
                Console.WriteLine($"Gx({i},{j}): ({firstPosition}*{H1[0, 0]}) + ({secondPosition}*{H1[1, 0]}) + ({thirdPosition}*{H1[2, 0]}) + ({fourthPosition}*{H1[0, 2]}) + ({fifthPosition}*{H1[1, 2]}) + ({sixthPosition}*{H1[2, 2]}) = {result}");
            }
        }
        System.Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write($"{Math.Abs(Gx[i, j])} \t");
            }
            System.Console.WriteLine();

        }
        System.Console.WriteLine();
        System.Console.WriteLine("--------Ma trận G(y)----------");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                double result = (firstPosition * H2[0, 0]) + (secondPosition * H2[0, 1]) + (thirdPosition * H2[0, 2]) + (fourthPosition * H2[2, 0]) + (fifthPosition * H2[2, 1]) + (sixthPosition * H2[2, 2]);
                Gy[i, j] = result;
                Console.WriteLine($"Gy({i},{j}): ({firstPosition}*{H2[0, 0]}) + ({secondPosition}*{H2[0, 1]}) + ({thirdPosition}*{H2[0, 2]}) + ({fourthPosition}*{H2[2, 0]}) + ({fifthPosition}*{H2[2, 1]}) + ({sixthPosition}*{H2[2, 2]}) = {result}");
            }
        }


        System.Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write($"{Math.Abs(Gy[i, j])} \t");
            }
            System.Console.WriteLine();

        }
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("--------G=|G(x)|+|G(y)|----------");
        System.Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write($"{(Math.Abs(Gx[i, j])) + (Math.Abs(Gy[i, j]))} \t");
            }
            System.Console.WriteLine();

        }

    }

    public void Alpha(double[,] maTran)
    {
        Console.WriteLine("----------Alpha với cửa sổ 3x3 với d = ?-----------");
        System.Console.WriteLine("Nhập giá trị của d: ");
        double d = Convert.ToDouble(Console.ReadLine());
        double[,] matrixResult = new double[5, 5];
        System.Console.WriteLine("-------------Kết quả------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                try
                {
                    seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    seventhPosition = 0;
                }
                try
                {
                    eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    eighthPosition = 0;
                }
                try
                {
                    ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    ninethPosition = 0;
                }


                double[] arrMatrixSmall = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                double result = 0;
                string stringResult = "";
                bool isPassMax = false;
                bool isPassMin = false;
                for (int e = 0; e < arrMatrixSmall.Length; e++)
                {
                    if (arrMatrixSmall[e] == 0)
                    {
                        continue;
                    }
                    if (arrMatrixSmall[e] == arrMatrixSmall.Max() && isPassMax == false)
                    {
                        isPassMax = true;
                        continue;
                    }
                    if (arrMatrixSmall[e] == arrMatrixSmall.Min() && isPassMin == false)
                    {
                        isPassMin = true;
                        continue;
                    }
                    result += arrMatrixSmall[e];
                    stringResult += "+" + arrMatrixSmall[e].ToString();
                }

                double newResult = Math.Round(result / (3 * 3 - d),MidpointRounding.AwayFromZero);
                matrixResult[i, j] = newResult;
                Array.Sort(arrMatrixSmall);
                foreach (double item in arrMatrixSmall)
                {
                    System.Console.Write(item + "   ");
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"I({i},{j})=({stringResult})/(3*3-{d})={Math.Round(result / (3 * 3 - d), 4)}={newResult}");
                System.Console.WriteLine();

            }
        }

        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận hoàn chỉnh-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }

    }

    public void LocNhiThuc(double[,] maTran)
    {
        Console.WriteLine("----------Lọc Nhị Thức-----------");
        System.Console.WriteLine("Nhập ma trận mặt nạ 3x3: ");
        double[,] B = new double[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Điểm ({i},{j}): ");
                var x = Console.ReadLine();
                B[i, j] = Convert.ToDouble(x);
            }
            Console.WriteLine();
        }
        System.Console.WriteLine("Nhập mẫu số (dạng 1 phần) của K(b) (vd: 1/16 thì nhập 16 thôi) : ");
        double K_b = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("----------Kết quả----------");

        double[,] matrixResult = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                try
                {
                    seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    seventhPosition = 0;
                }
                try
                {
                    eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    eighthPosition = 0;
                }
                try
                {
                    ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    ninethPosition = 0;
                }

                double result = ((firstPosition * B[0, 0]) + (secondPosition * B[0, 1]) + (thirdPosition * B[0, 2]) + (fourthPosition * B[1, 0]) + (fifthPosition * B[1, 1]) + (sixthPosition * B[1, 2]) + (seventhPosition * B[2, 0]) + (eighthPosition * B[2, 1]) + (ninethPosition * B[2, 2])) / K_b;
                matrixResult[i, j] = Math.Round(result,MidpointRounding.AwayFromZero);
                System.Console.WriteLine($"({firstPosition}*{B[0, 0]})+({secondPosition}*{B[0, 1]})+({thirdPosition}*{B[0, 2]})+({fourthPosition}*{B[1, 0]})+({fifthPosition}*{B[1, 1]})+({sixthPosition}*{B[1, 2]})+({seventhPosition}*{B[2, 0]})+({eighthPosition}*{B[2, 1]})+({ninethPosition}*{B[2, 2]})={Math.Round(result, 5)}={Math.Round(result)}");
                System.Console.WriteLine();
            }
        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận hoàn chỉnh-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }


    public void LocNhieuMin(double[,] maTran)

    {
        System.Console.WriteLine("----------Lọc Nhiễu Min--------------");
        System.Console.WriteLine("----------Kết quả----------");

        double[,] matrixResult = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                try
                {
                    seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    seventhPosition = 0;
                }
                try
                {
                    eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    eighthPosition = 0;
                }
                try
                {
                    ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    ninethPosition = 0;
                }

                double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                System.Console.WriteLine($"Điểm({i},{j}): ");
                for (int item = 0; item < result.Length; item++)
                {
                    System.Console.Write($"{result[item]}   ");
                    if((item+1)==3 || (item+1)==6){
                        System.Console.WriteLine();
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"Giá trị nhỏ nhất là: {result.Min()}");
                matrixResult[i, j] = result.Min();
                System.Console.WriteLine();
            }

        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận hoàn chỉnh-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public void LocNhieuMax(double[,] maTran)
    {
        System.Console.WriteLine("----------Lọc Nhiễu Max--------------");
        System.Console.WriteLine("----------Kết quả----------");

        double[,] matrixResult = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                try
                {
                    seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    seventhPosition = 0;
                }
                try
                {
                    eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    eighthPosition = 0;
                }
                try
                {
                    ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    ninethPosition = 0;
                }

                double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                System.Console.WriteLine($"Điểm({i},{j}): ");
                for (int item = 0; item < result.Length; item++)
                {
                    System.Console.Write($"{result[item]}   ");
                    if((item+1)==3 || (item+1)==6){
                        System.Console.WriteLine();
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"Giá trị lớn nhất là: {result.Max()}");
                matrixResult[i, j] = result.Max();
                System.Console.WriteLine();
            }

        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận hoàn chỉnh-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }

public void LocNhieuTrungDiem(double[,] maTran)
    {
        System.Console.WriteLine("----------Lọc Nhiễu Trung Điểm--------------");
        System.Console.WriteLine("----------Kết quả----------");

        double[,] matrixResult = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

                try
                {
                    firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
                }
                catch
                {
                    firstPosition = 0;
                }
                try
                {
                    secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
                }
                catch
                {
                    secondPosition = 0;
                }
                try
                {
                    thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
                }
                catch
                {
                    thirdPosition = 0;
                }
                try
                {
                    fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
                }
                catch
                {
                    fourthPosition = 0;
                }
                try
                {
                    fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
                }
                catch
                {
                    fifthPosition = 0;
                }
                try
                {
                    sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
                }
                catch
                {
                    sixthPosition = 0;
                }
                try
                {
                    seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
                }
                catch
                {
                    seventhPosition = 0;
                }
                try
                {
                    eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
                }
                catch
                {
                    eighthPosition = 0;
                }
                try
                {
                    ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
                }
                catch
                {
                    ninethPosition = 0;
                }

                double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                System.Console.WriteLine($"Điểm({i},{j}): ");
                for (int item = 0; item < result.Length; item++)
                {
                    System.Console.Write($"{result[item]}   ");
                    if((item+1)==3 || (item+1)==6){
                        System.Console.WriteLine();
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"I({i},{j}): ({result.Max()}+{result.Min()})/2 = {Math.Round((result.Max()+result.Min())/2,4)} = {Math.Round((result.Max()+result.Min())/2,MidpointRounding.AwayFromZero)}");
                matrixResult[i, j] = Math.Round((result.Max()+result.Min())/2,MidpointRounding.AwayFromZero);
                System.Console.WriteLine();
            }

        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận hoàn chỉnh-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }





}