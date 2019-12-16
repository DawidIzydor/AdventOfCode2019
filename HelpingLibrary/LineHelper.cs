namespace HelpingLibrary
{
    public static class LineHelper
    {
        public static bool Intersects(this Line thisLine, Line line)
        {
            return
                line.StartPoint.X != line.EndPoint.X &&
                IsBetween(thisLine.StartPoint.X, line.StartPoint.X, line.EndPoint.X)
                && IsBetween(line.StartPoint.Y, thisLine.StartPoint.Y, thisLine.EndPoint.Y)
                ||
                line.StartPoint.X == line.EndPoint.X && IsBetween(line.StartPoint.X, thisLine.StartPoint.X,
                                                         thisLine.EndPoint.X)
                                                     && IsBetween(thisLine.StartPoint.Y, line.StartPoint.Y,
                                                         line.EndPoint.Y)
                ;
        }

        private static bool IsBetween(int check, int point1, int point2)
        {
            if (point1 > point2)
            {
                return IsBetween(check, point2, point1);
            }

            return check >= point1 && check <= point2;
        }

        public static Point CalculateIntersectionPoint(Line line1, Line line2)
        {
            if (line1.StartPoint.X == line1.EndPoint.X && line2.StartPoint.Y == line2.EndPoint.Y)
            {
                return new Point(line1.StartPoint.X, line2.StartPoint.Y);
            }

            return new Point(line2.StartPoint.X, line1.StartPoint.Y);
        }
    }
}