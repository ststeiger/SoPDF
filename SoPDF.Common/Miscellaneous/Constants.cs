using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPDF.Common.Miscellaneous
{
    public static class Constants
    {
        /// <summary>
        /// 1 inch = 72 points
        /// </summary>
        public const double InchToPoint = 72;

        /// <summary>
        /// 1 point = 1 point
        /// </summary>
        public const double PointToPoint = 1.0;

        /// <summary>
        /// 1 cm = 72.0 / 2.54 points
        /// </summary>
        public const double CMToPoint = 72.0 / 2.54;

        /// <summary>
        /// 1 mm = 72.0 / 25.4 points
        /// </summary>
        public const double MMToPoint = 72.0 / 25.4;

        /// <summary>
        /// 1 inch = 300 epsilon
        /// </summary>
        public const double InchToEpsilon = 300.0;
    }
}
