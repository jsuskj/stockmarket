namespace API
{
    public class Stock
    {
        public Stock()
        {
        }

        public Stock(int id, string name, string description, decimal value)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

    }
}