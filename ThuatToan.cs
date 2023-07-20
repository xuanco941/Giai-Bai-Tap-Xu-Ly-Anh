using System;
using System.Collections.Generic;
using System.Collections;
class ThuatToan
{
    public void Sobel(double[,] maTran)

    {
        Console.WriteLine("----------Sobel-----------");
        double[,] H1 = new double[3, 3];
        double[,] H2 = new double[3, 3];
        // Console.WriteLine("Nhập ma trận 3x3 H1:");
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.WriteLine($"Điểm ({i},{j}): ");
        //         var x = Console.ReadLine();
        //         H1[i, j] = Convert.ToDouble(x);
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine("Nhập ma trận 3x3 H2:");
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.WriteLine($"Điểm ({i},{j}): ");
        //         var x = Console.ReadLine();
        //         H2[i, j] = Convert.ToDouble(x);
        //     }
        //     Console.WriteLine();
        // }
        H1[0, 0] = -1;
        H1[0, 1] = 0;
        H1[0, 2] = 1;
        H1[1, 0] = -2;
        H1[1, 1] = 0;
        H1[1, 2] = 2;
        H1[2, 0] = -1;
        H1[2, 1] = 0;
        H1[2, 2] = 1;

        H2[0, 0] = -1;
        H2[0, 1] = -2;
        H2[0, 2] = -1;
        H2[1, 0] = 0;
        H2[1, 1] = 0;
        H2[1, 2] = 0;
        H2[2, 0] = 1;
        H2[2, 1] = 2;
        H2[2, 2] = 1;

        Console.WriteLine();

        Console.WriteLine("H1: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{H1[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("H2: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{H2[i, j]} \t");
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
                System.Console.Write($"{Gx[i, j]} \t");
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
                System.Console.Write($"{Gy[i, j]} \t");
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
    public void Prewitt(double[,] maTran)

    {
        Console.WriteLine("----------Prewitt-----------");
        double[,] H1 = new double[3, 3];
        double[,] H2 = new double[3, 3];
        // Console.WriteLine("Nhập ma trận 3x3 H1:");
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.WriteLine($"Điểm ({i},{j}): ");
        //         var x = Console.ReadLine();
        //         H1[i, j] = Convert.ToDouble(x);
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine("Nhập ma trận 3x3 H2:");
        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         Console.WriteLine($"Điểm ({i},{j}): ");
        //         var x = Console.ReadLine();
        //         H2[i, j] = Convert.ToDouble(x);
        //     }
        //     Console.WriteLine();
        // }
        H1[0, 0] = -1;
        H1[0, 1] = 0;
        H1[0, 2] = 1;
        H1[1, 0] = -1;
        H1[1, 1] = 0;
        H1[1, 2] = 1;
        H1[2, 0] = -1;
        H1[2, 1] = 0;
        H1[2, 2] = 1;

        H2[0, 0] = -1;
        H2[0, 1] = -1;
        H2[0, 2] = -1;
        H2[1, 0] = 0;
        H2[1, 1] = 0;
        H2[1, 2] = 0;
        H2[2, 0] = 1;
        H2[2, 1] = 1;
        H2[2, 2] = 1;

        Console.WriteLine();

        Console.WriteLine("H1: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{H1[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("H2: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{H2[i, j]} \t");
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
                System.Console.Write($"{Gx[i, j]} \t");
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
                System.Console.Write($"{Gy[i, j]} \t");
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

                double newResult = Math.Round(result / (3 * 3 - d), MidpointRounding.AwayFromZero);
                matrixResult[i, j] = newResult;
                Array.Sort(arrMatrixSmall);
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
                matrixResult[i, j] = Math.Round(result, MidpointRounding.AwayFromZero);
                System.Console.WriteLine($"I({i},{j})=(({firstPosition}*{B[0, 0]})+({secondPosition}*{B[0, 1]})+({thirdPosition}*{B[0, 2]})+({fourthPosition}*{B[1, 0]})+({fifthPosition}*{B[1, 1]})+({sixthPosition}*{B[1, 2]})+({seventhPosition}*{B[2, 0]})+({eighthPosition}*{B[2, 1]})+({ninethPosition}*{B[2, 2]}))/16={Math.Round(result, 5)}={Math.Round(result, MidpointRounding.AwayFromZero)}");
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
                    if ((item + 1) == 3 || (item + 1) == 6)
                    {
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
                    if ((item + 1) == 3 || (item + 1) == 6)
                    {
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
                    if ((item + 1) == 3 || (item + 1) == 6)
                    {
                        System.Console.WriteLine();
                    }
                }
                System.Console.WriteLine();
                System.Console.WriteLine($"I({i},{j}): ({result.Max()}+{result.Min()})/2 = {Math.Round((result.Max() + result.Min()) / 2, 4)} = {Math.Round((result.Max() + result.Min()) / 2, MidpointRounding.AwayFromZero)}");
                matrixResult[i, j] = Math.Round((result.Max() + result.Min()) / 2, MidpointRounding.AwayFromZero);
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

    public void LocNhieuTrungBinhHinhHoc(double[,] maTran)
    {
        System.Console.WriteLine("----------Lọc Nhiễu Trung Bình Hình Học--------------");
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

                string bieuthuc = "";
                double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                System.Console.WriteLine($"Điểm({i},{j}): ");
                for (int item = 0; item < result.Length; item++)
                {
                    bieuthuc += result[item].ToString() + "*";
                    System.Console.Write($"{result[item]}   ");
                    if ((item + 1) == 3 || (item + 1) == 6)
                    {
                        System.Console.WriteLine();
                    }
                }
                double TichCacDiem = firstPosition * secondPosition * thirdPosition * fourthPosition * fifthPosition * sixthPosition * seventhPosition * eighthPosition * ninethPosition;
                System.Console.WriteLine();
                System.Console.WriteLine($"I({i},{j}): TB = ({bieuthuc})^1/9 = {Math.Round(Math.Pow(TichCacDiem, 0.11111), 5, MidpointRounding.AwayFromZero)} = {Math.Round(Math.Pow(TichCacDiem, 0.11111), MidpointRounding.AwayFromZero)}");
                matrixResult[i, j] = Math.Round(Math.Pow(TichCacDiem, 0.11111), MidpointRounding.AwayFromZero);
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

    // public void DoBienKirsch(double[,] maTran)
    // {
    //     System.Console.WriteLine("----------Dò Biên Kirsch--------------");
    //     System.Console.WriteLine("----------Kết quả----------");

    //     int[,] K1 = new int[3, 3];
    //     int[,] K2 = new int[3, 3];
    //     int[,] K3 = new int[3, 3];
    //     int[,] K4 = new int[3, 3];
    //     int[,] K5 = new int[3, 3];
    //     int[,] K6 = new int[3, 3];
    //     int[,] K7 = new int[3, 3];
    //     int[,] K8 = new int[3, 3];

    //     int[] arrK1 = { -3, -3, 5, -3, 0, 5, -3, -3, 5 };
    //     int[] arrK2 = { -3, 5, 5, -3, 0, 5, -3, -3, -3 };
    //     int[] arrK3 = { 5, 5, 5, -3, 0, -3, -3, -3, -3 };
    //     int[] arrK4 = { 5, 5, -3, 5, 0, -3, -3, -3, -3 };
    //     int[] arrK5 = { 5, -3, -3, 5, 0, -3, 5, -3, -3 };
    //     int[] arrK6 = { -3, -3, -3, 5, 0, -3, 5, 5, -3 };
    //     int[] arrK7 = { -3, -3, -3, -3, 0, -3, 5, 5, 5 };
    //     int[] arrK8 = { -3, -3, -3, -3, 0, 5, -3, 5, 5 };
    //     int num = 0;
    //     for (int i = 0; i < 3; i++)
    //     {
    //         for (int j = 0; j < 3; j++)
    //         {
    //             int v1 = arrK1[num];
    //             K1[i, j] = v1;
    //             int v2 = arrK2[num];
    //             K2[i, j] = v2;
    //             int v3 = arrK3[num];
    //             K3[i, j] = v3;
    //             int v4 = arrK4[num];
    //             K4[i, j] = v4;
    //             int v5 = arrK5[num];
    //             K5[i, j] = v5;
    //             int v6 = arrK6[num];
    //             K6[i, j] = v6;
    //             int v7 = arrK7[num];
    //             K7[i, j] = v7;
    //             int v8 = arrK8[num];
    //             K8[i, j] = v8;

    //             num++;
    //         }

    //     }
    //     // double[,] maTranChuyenMien = new double[5, 5];
    //     // Array.Copy(maTran, maTranChuyenMien,25);

    //     // System.Console.WriteLine("Ma trận chuyển miền [0,1]: ");
    //     // for (int i = 0; i < 5; i++)
    //     // {
    //     //     for (int j = 0; j < 5; j++)
    //     //     {
    //     //         maTran[i, j] = (Math.Round(maTran[i, j] / 255, 4, MidpointRounding.AwayFromZero));
    //     //     }

    //     // }
    //     // for (int i = 0; i < 5; i++)
    //     // {
    //     //     for (int j = 0; j < 5; j++)
    //     //     {
    //     //         System.Console.Write(maTran[i, j] + "\t");
    //     //     }
    //     //     System.Console.WriteLine();

    //     // }
    //     System.Console.WriteLine();
    //     double[,] matrixResult = new double[5, 5];
    //     double[,] matrixK1 = new double[5, 5];
    //     double[,] matrixK2 = new double[5, 5];
    //     double[,] matrixK3 = new double[5, 5];
    //     double[,] matrixK4 = new double[5, 5];
    //     double[,] matrixK5 = new double[5, 5];
    //     double[,] matrixK6 = new double[5, 5];
    //     double[,] matrixK7 = new double[5, 5];
    //     double[,] matrixK8 = new double[5, 5];

    //     for (int i = 0; i < 5; i++)
    //     {
    //         for (int j = 0; j < 5; j++)
    //         {
    //             double firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition;

    //             try
    //             {
    //                 firstPosition = (maTran[i - 1, j - 1] != 0) ? maTran[i - 1, j - 1] : 0;
    //             }
    //             catch
    //             {
    //                 firstPosition = 0;
    //             }
    //             try
    //             {
    //                 secondPosition = (maTran[i - 1, j] != 0) ? maTran[i - 1, j] : 0;
    //             }
    //             catch
    //             {
    //                 secondPosition = 0;
    //             }
    //             try
    //             {
    //                 thirdPosition = (maTran[i - 1, j + 1] != 0) ? maTran[i - 1, j + 1] : 0;
    //             }
    //             catch
    //             {
    //                 thirdPosition = 0;
    //             }
    //             try
    //             {
    //                 fourthPosition = (maTran[i, j - 1] != 0) ? maTran[i, j - 1] : 0;
    //             }
    //             catch
    //             {
    //                 fourthPosition = 0;
    //             }
    //             try
    //             {
    //                 fifthPosition = (maTran[i, j] != 0) ? maTran[i, j] : 0;
    //             }
    //             catch
    //             {
    //                 fifthPosition = 0;
    //             }
    //             try
    //             {
    //                 sixthPosition = (maTran[i, j + 1] != 0) ? maTran[i, j + 1] : 0;
    //             }
    //             catch
    //             {
    //                 sixthPosition = 0;
    //             }
    //             try
    //             {
    //                 seventhPosition = (maTran[i + 1, j - 1] != 0) ? maTran[i + 1, j - 1] : 0;
    //             }
    //             catch
    //             {
    //                 seventhPosition = 0;
    //             }
    //             try
    //             {
    //                 eighthPosition = (maTran[i + 1, j] != 0) ? maTran[i + 1, j] : 0;
    //             }
    //             catch
    //             {
    //                 eighthPosition = 0;
    //             }
    //             try
    //             {
    //                 ninethPosition = (maTran[i + 1, j + 1] != 0) ? maTran[i + 1, j + 1] : 0;
    //             }
    //             catch
    //             {
    //                 ninethPosition = 0;
    //             }

    //             // đảo cột 1 sang cột 3, cột 3 sang cột 1

    //             double saveOne = firstPosition;
    //             double saveTwo = fourthPosition;
    //             double saveThree = seventhPosition;

    //             firstPosition = thirdPosition;
    //             fourthPosition = sixthPosition;
    //             seventhPosition = ninethPosition;

    //             thirdPosition = saveOne;
    //             sixthPosition = saveTwo;
    //             ninethPosition = saveThree;

    //             // double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };

    //             // Nhân chập 3x3 với K

    //             double result1 = Math.Round(firstPosition * K1[0, 0] + secondPosition * K1[0, 1] + thirdPosition * K1[0, 2] + fourthPosition * K1[1, 0] + fifthPosition * K1[1, 1] + sixthPosition * K1[1, 2] + seventhPosition * K1[2, 0] + eighthPosition * K1[2, 1] + ninethPosition * K1[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result2 = Math.Round(firstPosition * K2[0, 0] + secondPosition * K2[0, 1] + thirdPosition * K2[0, 2] + fourthPosition * K2[1, 0] + fifthPosition * K2[1, 1] + sixthPosition * K2[1, 2] + seventhPosition * K2[2, 0] + eighthPosition * K2[2, 1] + ninethPosition * K2[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result3 = Math.Round(firstPosition * K3[0, 0] + secondPosition * K3[0, 1] + thirdPosition * K3[0, 2] + fourthPosition * K3[1, 0] + fifthPosition * K3[1, 1] + sixthPosition * K3[1, 2] + seventhPosition * K3[2, 0] + eighthPosition * K3[2, 1] + ninethPosition * K3[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result4 = Math.Round(firstPosition * K4[0, 0] + secondPosition * K4[0, 1] + thirdPosition * K4[0, 2] + fourthPosition * K4[1, 0] + fifthPosition * K4[1, 1] + sixthPosition * K4[1, 2] + seventhPosition * K4[2, 0] + eighthPosition * K4[2, 1] + ninethPosition * K4[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result5 = Math.Round(firstPosition * K5[0, 0] + secondPosition * K5[0, 1] + thirdPosition * K5[0, 2] + fourthPosition * K5[1, 0] + fifthPosition * K5[1, 1] + sixthPosition * K5[1, 2] + seventhPosition * K5[2, 0] + eighthPosition * K5[2, 1] + ninethPosition * K5[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result6 = Math.Round(firstPosition * K6[0, 0] + secondPosition * K6[0, 1] + thirdPosition * K6[0, 2] + fourthPosition * K6[1, 0] + fifthPosition * K6[1, 1] + sixthPosition * K6[1, 2] + seventhPosition * K6[2, 0] + eighthPosition * K6[2, 1] + ninethPosition * K6[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result7 = Math.Round(firstPosition * K7[0, 0] + secondPosition * K7[0, 1] + thirdPosition * K7[0, 2] + fourthPosition * K7[1, 0] + fifthPosition * K7[1, 1] + sixthPosition * K7[1, 2] + seventhPosition * K7[2, 0] + eighthPosition * K7[2, 1] + ninethPosition * K7[2, 2], 4, MidpointRounding.AwayFromZero);
    //             double result8 = Math.Round(firstPosition * K8[0, 0] + secondPosition * K8[0, 1] + thirdPosition * K8[0, 2] + fourthPosition * K8[1, 0] + fifthPosition * K8[1, 1] + sixthPosition * K8[1, 2] + seventhPosition * K8[2, 0] + eighthPosition * K8[2, 1] + ninethPosition * K8[2, 2], 4, MidpointRounding.AwayFromZero);

    //             matrixK1[i, j] = result1;
    //             matrixK2[i, j] = result2;
    //             matrixK3[i, j] = result3;
    //             matrixK4[i, j] = result4;
    //             matrixK5[i, j] = result5;
    //             matrixK6[i, j] = result6;
    //             matrixK7[i, j] = result7;
    //             matrixK8[i, j] = result8;

    //             double[] arrMatrix = { result1, result2, result3, result4, result5, result6, result7, result8 };
    //             matrixResult[i, j] = arrMatrix.Max();
    //         }

    //     }
    //     System.Console.WriteLine("Đường biên theo mặt nạ K1:");
    //     OutPutMaTrixFive(matrixK1);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K2:");
    //     OutPutMaTrixFive(matrixK2);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K3:");
    //     OutPutMaTrixFive(matrixK3);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K4:");
    //     OutPutMaTrixFive(matrixK4);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K5:");
    //     OutPutMaTrixFive(matrixK5);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K6:");
    //     OutPutMaTrixFive(matrixK6);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K7:");
    //     OutPutMaTrixFive(matrixK7);

    //     System.Console.WriteLine("Đường biên theo mặt nạ K8:");
    //     OutPutMaTrixFive(matrixK8);


    //     System.Console.WriteLine();
    //     System.Console.WriteLine("-Ma trận G=max{|G1|,|G2|...,|G8|}-");
    //     for (int i = 0; i < 5; i++)
    //     {
    //         for (int j = 0; j < 5; j++)
    //         {
    //             System.Console.Write(matrixResult[i, j] + "\t");
    //         }
    //         System.Console.WriteLine();
    //     }

    //     System.Console.WriteLine();
    //     // System.Console.WriteLine("-Chuyển về miền [0,255]-");
    //     for (int i = 0; i < 5; i++)
    //     {
    //         for (int j = 0; j < 5; j++)
    //         {
    //             System.Console.Write(Math.Round(matrixResult[i, j],2, MidpointRounding.AwayFromZero) + "\t");
    //         }
    //         System.Console.WriteLine();
    //     }
    // }

    public void OutPutMaTrixFive(double[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrix[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    public void Laplacian(double[,] maTran)
    {
        Console.WriteLine("----------Laplacian-----------");
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

                double result = ((firstPosition * B[0, 0]) + (secondPosition * B[0, 1]) + (thirdPosition * B[0, 2]) + (fourthPosition * B[1, 0]) + (fifthPosition * B[1, 1]) + (sixthPosition * B[1, 2]) + (seventhPosition * B[2, 0]) + (eighthPosition * B[2, 1]) + (ninethPosition * B[2, 2]));
                matrixResult[i, j] = Math.Round(result, 3, MidpointRounding.AwayFromZero);
                System.Console.WriteLine($"I({i},{j})=({firstPosition}*{B[0, 0]})+({secondPosition}*{B[0, 1]})+({thirdPosition}*{B[0, 2]})+({fourthPosition}*{B[1, 0]})+({fifthPosition}*{B[1, 1]})+({sixthPosition}*{B[1, 2]})+({seventhPosition}*{B[2, 0]})+({eighthPosition}*{B[2, 1]})+({ninethPosition}*{B[2, 2]})={Math.Round(result, 5, MidpointRounding.AwayFromZero)}={Math.Round(result, MidpointRounding.AwayFromZero)}");
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
        System.Console.WriteLine("----------Kết quả-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(Math.Abs(matrixResult[i, j]) + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public void CanBangHistogram(double[,] maTran)
    {
        System.Console.Write("Mức xám là: ");
        double mucxam = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine();
        System.Console.WriteLine("------------Histogram------------");
        ArrayList rk = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (rk.Count != 0)
                {
                    if (rk.Contains(maTran[i, j]) == false)
                    {
                        rk.Add(maTran[i, j]);
                    }
                }
                else
                {
                    rk.Add(maTran[i, j]);
                }
            }
        }
        rk.Sort();
        System.Console.Write("Rk:\t");
        for (int i = 0; i < rk.Count; i++)
        {
            System.Console.Write(rk[i] + "\t");
        }


        //NK
        ArrayList nk = new ArrayList();
        double[] cloneRK = (double[])rk.ToArray(typeof(double));


        for (int k = 0; k < cloneRK.Length; k++)
        {
            double count = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (maTran[i, j] == cloneRK[k])
                    {
                        count = count + 1;
                    }
                }
            }
            nk.Add(count);
        }
        System.Console.WriteLine();
        System.Console.Write("Nk:\t");
        for (int i = 0; i < nk.Count; i++)
        {
            System.Console.Write(nk[i] + "\t");
        }


        //CDF
        ArrayList cdf = new ArrayList();
        double[] cloneNK = (double[])nk.ToArray(typeof(double));
        double x = 0;
        double y = 0;
        for (int i = 0; i < cloneNK.Length; i++)
        {
            x = cloneNK[i];
            if (i != 0)
            {
                x = x + y;
            }
            cdf.Add(x);
            y = x;
        }
        System.Console.WriteLine();
        System.Console.Write("CDF:\t");
        for (int i = 0; i < cdf.Count; i++)
        {
            System.Console.Write(cdf[i] + "\t");
        }




        //Sk
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Tính Sk theo công thức: ((cdf(nk)-cdf(min))*(L-1)/(M*N)-cdf(min))");
        System.Console.WriteLine();
        ArrayList sk = new ArrayList();
        double[] cloneCDF = (double[])cdf.ToArray(typeof(double));
        double minCDF = cloneCDF.Min();
        for (int i = 0; i < cloneCDF.Length; i++)
        {

            double s = ((cloneCDF[i] - minCDF) * (mucxam - 1)) / ((5 * 5) - minCDF);
            double s2 = Math.Round(s, 4, MidpointRounding.AwayFromZero);
            System.Console.WriteLine($"s{i}: (({cloneCDF[i]}-{minCDF})*({mucxam}-{1})/(5*5-{minCDF}) = {s2} = {Math.Round(s, MidpointRounding.AwayFromZero)}");
            sk.Add(Math.Round(s, MidpointRounding.AwayFromZero));
        }
        System.Console.WriteLine();
        System.Console.Write("Sk:\t");
        for (int i = 0; i < sk.Count; i++)
        {
            System.Console.Write(sk[i] + "\t");
        }

        Dictionary<double, double> dik = new Dictionary<double, double>();

        for (int i = 0; i < rk.Count; i++)
        {
            dik.Add(Convert.ToDouble(rk[i]), Convert.ToDouble(sk[i]));
        }
        foreach (var k in dik)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (maTran[i, j] == k.Key)
                    {
                        maTran[i, j] = k.Value;
                    }
                }
            }
        }
        Console.WriteLine("\n\nKết quả sau khi cân bằng Histogram: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{maTran[i, j]} \t");
            }
            Console.WriteLine();
        }




    }

    public void LocTrungBinh(double[,] maTran)

    {
        System.Console.WriteLine("Nhập mẫu số của K: ");
        double k = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("----------Lọc Trung bình--------------");
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

                // double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                // System.Console.WriteLine($"Điểm({i},{j}): ");
                // for (int item = 0; item < result.Length; item++)
                // {
                //     System.Console.Write($"{result[item]}   ");
                //     if ((item + 1) == 3 || (item + 1) == 6)
                //     {
                //         System.Console.WriteLine();
                //     }
                // }
                double TongCacDiem = (firstPosition + secondPosition + thirdPosition + fourthPosition + fifthPosition + sixthPosition + seventhPosition + eighthPosition + ninethPosition) / k;
                System.Console.WriteLine($"Itb({i},{j}): 1/{k}*({firstPosition}+{secondPosition}+{thirdPosition}+{fourthPosition}+{fifthPosition}+{sixthPosition}+{seventhPosition}+{eighthPosition}+{ninethPosition}) = {Math.Round(TongCacDiem, 4, MidpointRounding.AwayFromZero)} = {Math.Round(TongCacDiem, MidpointRounding.AwayFromZero)}");

                matrixResult[i, j] = Math.Round(TongCacDiem, MidpointRounding.AwayFromZero);
            }
        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận sau khi lọc trung bình-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public void TuongQuan(double[,] maTran)
    {
        Console.WriteLine("----------Tương quan-----------");
        System.Console.WriteLine("Nhập ma trận mặt nạ 3x3: ");
        List<double> B = new List<double>();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Điểm ({i},{j}): ");
                var x = Console.ReadLine();
                B.Add(Convert.ToDouble(x));
            }
            Console.WriteLine();
        }
        System.Console.WriteLine("----------Kết quả----------");

        double[,] matrixResult = new double[5, 5];
        double[,] sumOf9Pow2 = new double[5, 5];

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

                string bieuthuc = "";
                double[] result = { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                System.Console.WriteLine($"Điểm({i},{j}): ");
                double kq = 0;
                double m = 0;
                foreach (var item in result)
                {
                    m = m + Math.Pow(item, 2);
                }
                sumOf9Pow2[i, j] = m;

                for (int item = 0; item < result.Length; item++)
                {
                    bieuthuc += "(" + result[item].ToString() + $"*{B[item]}" + ") + ";
                    kq = kq + (result[item] * B[item]);
                    System.Console.Write($"{result[item]}   ");
                    if ((item + 1) == 3 || (item + 1) == 6)
                    {
                        System.Console.WriteLine();
                    }
                }
                System.Console.WriteLine();
                kq = Math.Round(kq, 2, MidpointRounding.AwayFromZero);
                System.Console.WriteLine($"I({i},{j}) = {bieuthuc} = {kq}");
                matrixResult[i, j] = kq;
                System.Console.WriteLine();
            }

        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Kết quả-------------");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(matrixResult[i, j] + "\t");
            }
            System.Console.WriteLine();
        }


        System.Console.WriteLine("\n\nÁp dụng tính tương quan giữa ma trận K và ảnh I:");


        double n2 = 0;
        foreach (var item in B)
        {
            n2 = n2 + Math.Pow(item, 2);
        }


        double[,] valueTUongQuan = new double[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                valueTUongQuan[i, j] = Math.Round(matrixResult[i, j] / (Math.Sqrt(n2) * Math.Sqrt(sumOf9Pow2[i, j])), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine($"C{i},{j} = {matrixResult[i, j]}/(\u221A{n2}*\u221A{sumOf9Pow2[i, j]})");
            }
        }



        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(valueTUongQuan[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }

    public void LocTrungVi(double[,] maTran)

    {
        System.Console.WriteLine("Nhập m,n (3 hoặc 5):");
        double k = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("----------Lọc Trung vị--------------");
        System.Console.WriteLine("----------Kết quả----------");
        double[,] matrixResult = new double[5, 5];
        if (k == 3)
        {
            k = 3;
            System.Console.WriteLine("m,n = 3");
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

                    List<double> result = new List<double> { firstPosition, secondPosition, thirdPosition, fourthPosition, fifthPosition, sixthPosition, seventhPosition, eighthPosition, ninethPosition };
                    result.Sort();
                    Console.WriteLine($"\nĐiểm[{i},{j}]:");
                    for (int o = 0; o < 9; o++)
                    {
                        if (o == 4)
                        {
                            matrixResult[i, j] = result[4];
                            Console.Write($"-[{result[4]}]-");
                            continue;
                        }
                        else if (o == 0)
                        {
                            Console.Write(result[o] + "-");
                        }
                        else if (o == 8)
                        {
                            Console.Write("-" + result[o]);
                        }
                        else
                        {
                            Console.Write("-" + result[o] + "-");
                        }
                    }
                    Console.WriteLine();

                }
            }

        }
        else
        {
            k = 5;
            System.Console.WriteLine("m,n = 5");

            List<List<double>> resultLists = new List<List<double>>();

            int arraySize = 5;
            int range = 2; // Half of the range, so the total range is 5x5

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    List<double> currentList = new List<double>();

                    for (int x = i - range; x <= i + range; x++)
                    {
                        for (int y = j - range; y <= j + range; y++)
                        {
                            if (x >= 0 && x < arraySize && y >= 0 && y < arraySize)
                            {
                                currentList.Add(maTran[x, y]);
                            }
                            else
                            {
                                currentList.Add(0); // Add 0 for elements outside the array boundaries
                            }
                        }
                    }

                    resultLists.Add(currentList);
                }
            }

            // Printing the result lists
            int t = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"\nĐiểm[{i},{j}]:");
                    for (int o = 0; o < 25; o++)
                    {
                        resultLists[t].Sort();
                        if (o == 13)
                        {
                            matrixResult[i, j] = resultLists[t][13];
                            Console.Write($"-[{resultLists[t][13]}]-");
                        }
                        else if (o == 0)
                        {
                            Console.Write(resultLists[t][o] + "-");
                        }
                        else if (o == 24)
                        {
                            Console.Write("-" + resultLists[t][o]);
                        }
                        else
                        {
                            Console.Write("-" + resultLists[t][o] + "-");
                        }
                    }
                    t+=1;
                    Console.WriteLine();
                }
            }
        }
        System.Console.WriteLine();

        System.Console.WriteLine("----------Ma trận sau khi lọc trung vị-------------");
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