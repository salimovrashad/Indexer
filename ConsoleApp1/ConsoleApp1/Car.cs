namespace ConsoleApp1
{
    internal class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int ProductYear { get; set; }

        public override string ToString()
        {
            return $"{Name}--{Color}--{ProductYear}";
        }
    }
}
