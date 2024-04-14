using System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tpmodul8_1302220031
{
    internal class ConfigCovid
    {

        public ConfigCovid loadData()
        {
            string data = File.ReadAllText("/Users/hasannp/SEMESTER (4)/5. Konstruksi PL/tpmodul8_1302220031/covid_config.json");
            ConfigCovid json = JsonConvert.DeserializeObject<ConfigCovid>(data);
            return json;
        }

        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else if (satuan_suhu == "fahrenheit")
            {
                satuan_suhu = "celcius";
            }
        }

        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }

        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }


    }
}

