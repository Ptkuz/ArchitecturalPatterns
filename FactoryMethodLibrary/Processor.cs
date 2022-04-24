namespace FactoryMethodLibrary
{
    
    public abstract class Processor
    {
        
       public string Name { get; set; } 

        public Processor(string name) 
        {
            Name = name;

        
        }

    }
}
