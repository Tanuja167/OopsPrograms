using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Date
    {
        private int day, year;
        private String month;

        public void AcceptDate(int dd, string mm,  int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }
        public string PrintDate()
        {
            return $"Date: {day} / {month} / {year}";

        }
    }
}
