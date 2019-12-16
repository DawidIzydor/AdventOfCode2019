using System;

namespace HelpingLibrary
{
    public static class LineFactory
    {
        public static Line CreateLine(Point startPoint, string direction)
        {
            return new Line
            {
                StartPoint = startPoint,
                EndPoint = ParseDirection(startPoint, direction)
            };
        }

        private static Point ParseDirection(Point startPoint, string direction)
        {
            var dir = direction[0];
            var moveDistance = direction.Substring(1);
            switch (dir)
            {
                case 'U':
                    return new Point(startPoint.X, startPoint.Y + int.Parse(moveDistance));

                case 'D':
                    return new Point(startPoint.X, startPoint.Y - int.Parse(moveDistance));
                case 'R':
                    return new Point(startPoint.X + int.Parse(moveDistance), startPoint.Y);
                case 'L':
                    return new Point(startPoint.X - int.Parse(moveDistance), startPoint.Y);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}