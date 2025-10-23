namespace PodcastManager.Models
{
    public class Comment
    {
        public int EpisodeId { get; set; }
        public int PodcastId { get; set; }
        public Guid CommentId { get; set; }
        public Guid UserId { get; set; }
        public required string Text { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Auto-generated timestamp
    }
}
