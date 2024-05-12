namespace WebAPI.DTOs
{
    public class NoteDTO
    {
        public Guid ID { get; set; }
        public string Relation { get; set; }
        public string RecordID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }

        public string CreatedById { get; set; }

    }
}
