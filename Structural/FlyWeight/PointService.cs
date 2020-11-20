using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    public class PointService
    {
        private PointIconFactory iconFactory;
        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            
            //List<PointWithTheProblem> points = new List<PointWithTheProblem>();
            //var point = new PointWithTheProblem(1, 2, PointType.CAFE, null);
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, iconFactory.GetPointIcon(PointType.CAFE));
            points.Add(point);

            return points;
        }


    }
}
