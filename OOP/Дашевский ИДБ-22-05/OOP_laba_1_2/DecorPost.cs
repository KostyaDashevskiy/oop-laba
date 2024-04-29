using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_2
{
    internal class DecorPost : IDateTimeFormatter
    {
        private IDateTimeFormatter pole;
        public DecorPost(IDateTimeFormatter mama)
        {
            pole = mama;
        }
        public string FormatDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(pole.FormatDateTime());
            sb.Append("Mis");
            return sb.ToString();
        }
    }
}
