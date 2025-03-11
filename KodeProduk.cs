using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace ProdukElektronik
{
    public class KodeProduk
    {
        private Dictionary<string, string> produk;

        public KodeProduk()
        {

            produk = new Dictionary<string, string>
            {
                { "Laptop", "E100" },
                { "SmartPhone", "E101"},
                { "Tablet", "E102" },
                { "Headset", "E103" },
                { "mouse", "E105" },
                { "Printer", "E106" },
                {"Monitor", "E107" },
                { "Smartwatch", "E108" },
                   { "Kamera", "E109" }
            };
        }

        public string GetKodeProduk(string namaProduk)
        {
            if (produk.TryGetValue(namaProduk, out string kode))
            {
                return kode;
            }
            else
            {
                return "Produk tidak ditemukan";
            }
        }

       
            }
        }
    
