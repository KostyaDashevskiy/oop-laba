using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_2
{
    internal class DecorPre : IDateTimeFormatter
    {
        private IDateTimeFormatter pole;
        public DecorPre(IDateTimeFormatter mama)
        {
            pole = mama;
        }
        public string FormatDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tse");
            sb.Append(pole.FormatDateTime());
            return sb.ToString();
        }
    }
}
