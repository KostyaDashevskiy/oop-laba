using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_2
{
    internal class DecorPre : IDateTimeFormatter
    {
        private IDateTimeFormatter _date;
        public DecorPre(IDateTimeFormatter date)
        {
            _date = date;
        }
        public string FormatDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Das");
            sb.Append(_date.FormatDateTime());
            return sb.ToString();
        }
    }
}
