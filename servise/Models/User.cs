using System.ServiceModel;

namespace servise.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OperationContext opCon { get; set; }

    }
}
