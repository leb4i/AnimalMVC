namespace animalsMVC.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public bool IsDomestic { get; set; }

        // Comma-separated list of image file names (relative to wwwroot/images/animals)
        public string ImageFiles { get; set; }

        public Animal() { }
    }
}
