using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audyt_innowacyjności.Extensions
{
   public static class IntExtensions
    {



        public static int Map(this int value,
            int originalStart, int originalEnd, // original range
            int newStart, int newEnd // desired range
            ) // value to convert
        {
            if (value > originalEnd)
                return newEnd;
            if (value < originalStart)
            {
                return newStart;

            }
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (int)(newStart + ((value - originalStart) * scale));

        }


    }

}
