using System.Text.Json.Serialization;

namespace BlazorSyncfushionCrm.Shared
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
        [JsonIgnore]
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}