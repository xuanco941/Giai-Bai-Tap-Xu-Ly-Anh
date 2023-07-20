public class Utils
{
    long soMaxChuyenMien = 255;
    public void NhapSoMaxChuyenMien()
    {
        System.Console.WriteLine("Nhập số max chuyển miền: (8bit nhập 255, 3bit nhập 7)):");
        soMaxChuyenMien = Convert.ToInt64(Console.ReadLine());
    }
    public double[,] ChuyenMienMaTran01(double[,] maTran)
    {

        System.Console.WriteLine("Chuyển ma trận về miền [0,1]: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                maTran[i, j] = (Math.Round(maTran[i, j] / soMaxChuyenMien, 3, MidpointRounding.AwayFromZero));
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(maTran[i, j] + "\t");
            }
            System.Console.WriteLine();
        }

        return maTran;

    }
    public double[,] ChuyenMienMaTranThuong(double[,] maTran)
    {
        System.Console.WriteLine($"Chuyển ma trận về miền [0,{soMaxChuyenMien}]: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                maTran[i, j] = (Math.Round(maTran[i, j] * soMaxChuyenMien, MidpointRounding.AwayFromZero));
            }

        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(maTran[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("\n=>\n");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if(maTran[i,j] > soMaxChuyenMien){
                    maTran[i,j] = soMaxChuyenMien;
                }
            }

        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                System.Console.Write(maTran[i, j] + "\t");
            }
            System.Console.WriteLine();
        }

        return maTran;

    }
}