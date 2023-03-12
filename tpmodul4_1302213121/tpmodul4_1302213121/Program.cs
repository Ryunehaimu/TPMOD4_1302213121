internal class Program
{
    public enum Kelurahan_1302213121
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    };
    public class KodePos_1302213121
    {
        public static int getKodePos_1302213121(Kelurahan_1302213121 kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePos[(int)kelurahan];
        }
    }
    static void Main(string[] args)
    {
        Kelurahan_1302213121 kelurahan = Kelurahan_1302213121.Batununggal;
        int kodePos = KodePos_1302213121.getKodePos_1302213121(kelurahan);
        Console.WriteLine("Kelurahan: " + kelurahan + "\nKode pos: " + kodePos);
    }
}
