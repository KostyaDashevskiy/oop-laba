using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1_2
{
    internal class DecorPost : IDateTimeFormatter
    {
        private IDateTimeFormatter _date;
        public DecorPost(IDateTimeFormatter date)
        {
            _date = date;
        }
        public string FormatDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_date.FormatDateTime());
            sb.Append("Kon");
            return sb.ToString();
        }
    }
}
