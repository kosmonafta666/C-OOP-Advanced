
namespace Event_Implementation
{
    public class NameChangeEventArgs
    {
        public string Name { get; set; }

        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }
    }
}
