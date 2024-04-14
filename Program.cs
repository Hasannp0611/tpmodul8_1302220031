using System.Globalization;
using tpmodul8_1302220031;

class Program
{
    static void Main(string[] args)
    {
        ConfigCovid config = new ConfigCovid().loadData();

        Console.WriteLine(config.satuan_suhu);

        Console.WriteLine("Berapa suhu badan anda saat ini? (Dalam " + config.satuan_suhu + ")");
        double suhu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");
        int hari = int.Parse(Console.ReadLine());

        Console.WriteLine(suhu);

        if (config.satuan_suhu == "celcius")
        {
            if ((suhu >= 36.5 && suhu <= 37.5) && hari < config.batas_hari_demam)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.pesan_ditolak);
            }
        }

        config.UbahSatuan();

        Console.WriteLine(config.satuan_suhu);
        Console.WriteLine("Berapa suhu badan anda saat ini? (Dalam " + config.satuan_suhu + ")");
        double suhu_f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");
        int hari_f = int.Parse(Console.ReadLine());

        if (config.satuan_suhu == "fahrenheit")
        {
            if ((suhu_f >= 97.7 && suhu_f <= 99.5) && hari_f < config.batas_hari_demam)
            {
                Console.WriteLine(config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(config.pesan_ditolak);
            }
        }
    }
}