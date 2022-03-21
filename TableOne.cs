using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class TableOne
    {
        public int KayıtNo { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public TimeSpan TimeDiff { get; set; }
        public string Statu { get; set; }
        public string Description { get; set; }

        public void Time()
        {
            TimeDiff = FinishDateTime - StartDateTime;
        }
    }
}
