/*
 * <summary>
 *  This is an podcast model class for a podcast management application.
 *  The class name is the table name in the database.
 *  The fields are the columns in the table.
 *  Implementation uses Entity Framework Core attributes for database mapping and validation.
 * </summary>
 */

namespace PodcastManager.Models
{
    public class Podcast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PodcastId { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        //Auto-generated fields
        public Guid CreatorId { get; set; } = Guid.NewGuid();

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; 
    }
}
