// Models/AgeDetails.cs
namespace age_mate_v2.Models
{
    public class AgeDetails
    {
        public int Age1 { get; set; }
        public int Age2 { get; set; }
        public int TotalAge { get; set; }

        public AgeDetails(int age1, int age2)
        {
            Age1 = age1;
            Age2 = age2;
            TotalAge = age1 + age2;
        }

        // Default constructor for model binding
        public AgeDetails()
        {
        }
    }
}