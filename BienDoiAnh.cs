public class BienDoiAnh
{
    public static void BienDoiAnhHamMu(double[,] maTran)
    {
        Console.WriteLine($"Áp dụng cho f=3*(r+1)^0.5");
        Utils utils = new Utils();
        utils.NhapSoMaxChuyenMien();
        maTran = utils.ChuyenMienMaTran01(maTran);
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double result = Math.Round(3 * Math.Pow((maTran[i, j] + 1), 0.5), 3, MidpointRounding.AwayFromZero);
                Console.WriteLine($"I({i},{j}) = 3 * ({maTran[i, j]} + 1)^{0.5} = {result}");
                maTran[i, j] = result;
            }
        }
        Console.WriteLine("\nKết quả:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(maTran[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
        utils.ChuyenMienMaTranThuong(maTran);
    }
    public static void BienDoiAnhLogarit(double[,] maTran)
    {
        Console.WriteLine($"Áp dụng cho f=3*log(1+0.5*r)");
        Utils utils = new Utils();
        utils.NhapSoMaxChuyenMien();
        maTran = utils.ChuyenMienMaTran01(maTran);
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                double result = Math.Round(3 * Math.Log(1 + 0.5 * (maTran[i, j])), 3, MidpointRounding.AwayFromZero);
                Console.WriteLine($"I({i},{j}) = 3 * log(1+0.5*{maTran[i, j]}) = {result}");
                maTran[i, j] = result;
            }
        }
        Console.WriteLine("\nKết quả:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(maTran[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
        utils.ChuyenMienMaTranThuong(maTran);
    }

}