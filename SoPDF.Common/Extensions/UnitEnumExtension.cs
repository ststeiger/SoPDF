using SoPDF.Common.Enums;
using SoPDF.Common.Miscellaneous;

namespace SoPDF.Common.Extensions
{
    public static class UnitEnumExtension
    {
        public static double ToPoints(this UnitEnum unit)
        {
            double points;

            switch (unit)
            {
                case UnitEnum.points:
                    points = Constants.PointToPoint;
                    break;
                case UnitEnum.inch:
                    points = Constants.InchToPoint;
                    break;
                case UnitEnum.cm:
                    points = Constants.CMToPoint;
                    break;
                case UnitEnum.mm:
                    points = Constants.MMToPoint;
                    break;
                default:
                    points = Constants.PointToPoint;
                    break;
            }

            return points;
        }
    }
}
