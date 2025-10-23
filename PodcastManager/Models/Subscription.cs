namespace PodcastManager.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [ForeignKey("PodcastId")]
        public int PodcastId { get; set; }

        public DateTime SubscribedDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; } = null!;
        public Podcast Podcast { get; set; } = null!;

    }
}
