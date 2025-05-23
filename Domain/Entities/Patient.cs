using System.Text.Json.Serialization;

namespace Domain
{
    [Serializable]
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Disease { get; set; } = string.Empty;
    }
}
