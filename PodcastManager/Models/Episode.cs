/*
 * <summary>
 *  This is an podcast model class for a podcast management application.
 *  The class name is the table name in the database.
 *  The fields are the columns in the table.
 *  Implementation uses Entity Framework Core attributes for database mapping and valIdation.
 * </summary>
 */

namespace PodcastManager.Models
{
    public class Episode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EpisodeId { get; set; }

        public int PodcastId { get; set; }

        public Podcast Podcast { get; set; } = null!;

        [Required]
        public required string Title { get; set; }

        public DateTime ReleaseDate { get; set; }


        public int DurationInMinutes { get; set; }

        public int PlayCount { get; set; }

        [Required]
        public required string AudioFileUrl { get; set; }

    }
}
