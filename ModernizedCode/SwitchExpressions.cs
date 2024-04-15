namespace ModernizedCode
{
    public class SwitchExpressions
    {
        
public string CheckStatus(StatusIndicator statusIndicator)
{
    return statusIndicator switch
    {
        StatusIndicator.NotStarted => "Not started",
        StatusIndicator.InProgress => "In Progress",
        StatusIndicator.Paused => "Paused",
        StatusIndicator.Complete => "Complete",
        _ => "Unknown"
    };
}    








    }


    public enum StatusIndicator
    {
        NotStarted=0,
        InProgress=1,
        Complete=2,
        Paused=3
    }
    
    // ********** next sample *********** //
    
    public static class SwitchExample
    {
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static void ToOrientationOriginal(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    break;
                case Direction.Down:
                    break;
                case Direction.Left:
                    break;
                case Direction.Right:
                    break;
            }
        }
        
        
        public static Orientation ToOrientation(Direction direction) => direction switch
        {
            Direction.Up    => Orientation.North,
            Direction.Right => Orientation.East,
            Direction.Down  => Orientation.South,
            Direction.Left  => Orientation.West,
            _ => throw new ArgumentOutOfRangeException(nameof(direction), 
                $"Not expected direction value: {direction}"),
        };

        public static void checkDirection()
        {
            var direction = Direction.Right;
            Console.WriteLine($"Map view direction is {direction}");
            Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}");
            // Output:
            // Map view direction is Right
            // Cardinal orientation is East
            var sw = new SwitchExpressions();
            sw.CheckStatus(StatusIndicator.Complete);
        }
    }
    
    
    
    
    
}