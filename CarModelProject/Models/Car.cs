namespace CarModelProject.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Color {  get; set; }
        public Car(string model, string year, string color)
        {
            Name = model;
            Year = year;
            Color = color;
        }
    }
}
