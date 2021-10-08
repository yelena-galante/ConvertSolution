namespace NorthWindConnections.Classes
{
    public class Task
    {
        public string Success { get; set; }
        public string Name { get; set; }
        public string ErrorMessage { get; set; }
        public string[] ItemArray => new[]
        {
            Success,
            Name,
            ErrorMessage
        };

    }


}
