class ThuatToan
{
    public void Sobel(double[,] maTran)

    {
        Console.WriteLine("----------Sobel-----------");
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
                System.Console.Write($"{(Math.Abs(Gx[i,j])) + (Math.Abs(Gy[i, j]))} \t");
            }
            System.Console.WriteLine();

        }

    }




}