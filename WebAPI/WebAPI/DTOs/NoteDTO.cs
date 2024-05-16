namespace WebAPI.DTOs
{
    public class NoteDto
    {
        public string id { get; set; }
        public string relation { get; set; }
        public string recordId { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime lastModified { get; set; }
        public UserDTO createdBy{ get; set; }
    }
}
