namespace csharpfoodtruck.Models
{
    public class Taco
    {
        public string Shell { get; set; }
        public string Protein { get; set; }
        public string Cheese { get; set; }
        public bool IsAvailable { get; set; }

        public Taco(string shell, string protein, string cheese)
        {
            Shell = shell;
            Protein = protein;
            Cheese = cheese;
            IsAvailable = true;
        }
    }
}