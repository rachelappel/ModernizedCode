namespace ModernizedCode
{
    public class StringInterpolation
    {
        void ProcessStrings()
        {
            const string name = "Ada Lovelace";
            const string team = "Web Dev";
            const string olderConst = "Welcome " + name + " to the " + team;
            const string modernConst = $"Welcome {name} to the {team}";
            
            var person = new
            {
                FirstName = "Grace",
                LastName = "Hopper"
            };

            string modernGreeting = $"Welcome to the team. This is your long-winded welcome that must span two lines. " +
                                    $"{ person.FirstName}, Glad to have you here !";
        }

        void stringInterpolationInSwitch(int safetyScore)
        {
            string message = $"The usage policy for {safetyScore} is {
                safetyScore switch
                {
                    > 90 => "Unlimited usage",
                    > 80 => "General usage, with daily safety check",
                    > 70 => "Issues must be addressed within 1 week",
                    > 50 => "Issues must be addressed within 1 day",
                    _ => "Issues must be addressed before continued use",
                }
            }";
        }
    }


    
    
}



