using System;
using System.Collections.Generic;
using System.Linq;
using HelpingLibrary;

namespace AdventOfCode2019.Day3
{
    public static class Day3Part1
    {
        public static List<Line> GetLinesFromString(string input)
        {
            var lastPoint = new Point(0, 0);
            var lines = new List<Line>();
            foreach (var lineString in input.Split(','))
            {
                var newLine = LineFactory.CreateLine(lastPoint, lineString);
                lines.Add(newLine);
                lastPoint = newLine.EndPoint;
            }

            return lines;
        }

        public static List<Point> GetIntersectionPoints(List<Line> lines1, List<Line> lines2)
        {
            return (from line1 in lines1
                from line2 in lines2
                where line1.Intersects(line2)
                select LineHelper.CalculateIntersectionPoint(line1, line2)
                into intersectionPoint
                where intersectionPoint.X != 0 || intersectionPoint.Y != 0
                select intersectionPoint).ToList();
        }

        public static int GetClosestDistance(Point fromPoint, List<Point> toPointsList)
        {
            var ret = int.MaxValue;

            foreach (var toPoint in toPointsList)
            {
                var dist = CalculateDistance(fromPoint, toPoint);
                if (dist < ret)
                {
                    ret = dist;
                }
            }

            return ret;
        }

        private static int CalculateDistance(Point fromPoint, Point toPoint)
        {
            return Math.Abs(toPoint.X - fromPoint.X) + Math.Abs(toPoint.Y - fromPoint.Y);
        }
    }
}