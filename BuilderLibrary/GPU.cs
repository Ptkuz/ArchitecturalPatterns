namespace BuilderLibrary
{
    public class GPU
    {
        public string Performance { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }
        public GPU(string performance, string model, int memory) 
        { 
            this.Performance = performance;
            this.Model = model;
            this.Memory = memory;
        }
    }
}