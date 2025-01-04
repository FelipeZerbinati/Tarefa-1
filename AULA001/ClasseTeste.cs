using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA001
{
    public class ClasseTeste
    {
        public string Str { get; set; }
        public string Str2 { get; set; }
        public string Str3 { get; set; }

        public ClasseTeste()
        {
            this.Str = "ABCTPX";
            this.Str2 = "QWERTY";
            this.Str3 = "ASDFGH";
        }

        public ClasseTeste(string str, string str2, string str3)
        {
            this.Str = str;
            this.Str2 = str2;
            this.Str3 = str3;
        }

        public void PrintarEnum(EnumTeste enumTeste)
        {
            switch (enumTeste)
            {
                case EnumTeste.PrimeiraStr:
                    Console.WriteLine(Str);
                    break;
                case EnumTeste.SegundaStr:
                    Console.WriteLine(Str2);
                    break;
                case EnumTeste.TerceiraStr:
                    Console.WriteLine(Str3);
                    break;
                default:
                    Console.WriteLine("Enum não encontrado");
                    break;
            }
        }
    }
}
