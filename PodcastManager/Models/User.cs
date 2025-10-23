namespace PodcastManager.Models
{

    public enum UserRole
    {
        Admin,
        Podcaster,
        Listener
    }

    public class User
    {
        [Key]
        public Guid UserId { get; set; } = Guid.NewGuid();

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Email { get; set; }

        [Required] // Ensures that the role is always assigned
        public UserRole Role { get; set; }

        // Navigation property for related subscriptions
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>(); // One-to-many relationship

    }
}