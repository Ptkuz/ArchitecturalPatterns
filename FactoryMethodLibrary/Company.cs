namespace FactoryMethodLibrary
{
    public abstract class Company
    {
        public string Name { get; set; }

        public Company(string name) => Name = name;

        public abstract Processor Create(string name);
    }
}