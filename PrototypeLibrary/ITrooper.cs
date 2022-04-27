namespace PrototypeLibrary
{
   public interface ITrooper
    {
        int Id { get; }
        ITrooper Clone();
        string GetInfo();
    }
}