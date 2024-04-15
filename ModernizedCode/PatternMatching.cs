namespace ModernizedCode
{
    public class Rectangle
    {
        public double Length { get; init; }
        public double Height { get; init; }
    }

    public class Triangle
    {
        public double Base { get; init; }
        public double Height { get; init; }
    }

    public class Circle
    {
        public double Radius { get; init; }
    }

    public class Square
    {
        public double Length { get; init; }


        public class PatternMatching
        {
            public void Start()
            {
                object c = new Circle { Radius = 110 };
                IsBigCircle(c);

                Triangle triangle = new Triangle { Base = 4, Height = 6 };
                IsSpecificTriangle(triangle);

                // null check with declaration pattern
                object shape = new Rectangle { Length = 9, Height = 4 };
                if (shape is Square)
                {
                }

                if (shape is not null)
                {
                }
            }

            // property pattern c# 8
            public void IsSpecificTriangle(Triangle triangle)
            {
                if (triangle is Triangle { Base: 4, Height: 6 } specificTriangle)
                {
                    Console.WriteLine(
                        $"Shape is a triangle wih a base of {specificTriangle.Base} and a height of {specificTriangle.Height}");
                }
            }


            // var pattern C# 8
            public void IsLengthMultipleOfThree(object shape)
            {
                if (shape is Rectangle
                        {
                            Length: var length
                        }
                        rect && length % 3 == 0)
                {
                    Console.WriteLine("This shape is a rectangle with a length which is a multiple of 3");
                }
            }


            // declaration pattern, C# 9
            public void IsBigCircle(object shape)
            {
                if (shape is Circle { Radius: 100 })
                {
                    Console.WriteLine($"This is a big circle");
                }

                // parenthesized pattern C# 9
                if ((shape is not Square) || (shape is not Rectangle))
                {
                    Console.WriteLine($"This could be a big circle");
                }

                if (shape is not (Square or Rectangle))
                {
                    Console.WriteLine($"This could be a big circle");
                }
            }

            // list patterns in C# 11 enable you to match an array or list against a sequence of patterns
            // good old fashioned delete and replace code
            public void ListPatterns()
            {
                int[] numbers = { 1, 2, 3 };

                if (numbers.Contains(1) &&
                    numbers.Contains(2) &&
                    numbers.Contains(3))
                {
                    Console.WriteLine("Found it");
                }

                /*Console.WriteLine(numbers is [1, 2, 3]);  // True
                Console.WriteLine(numbers is [1, 2, 4]);  // False
                Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
                Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True*/
            }
        }
    }
}