using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.model;

[Table("tracks")]
public class Track
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("track_id")]
    public long id { get; set; }
    
    [Column("title")]
    public string title { get; set; }
    
    [Column("album_id")]
    public long albumId { get; set; }

    [Column("track_duration")]
    public int duration { get; set; }
    
    [Column("genre_id")]
    public long genreId { get; set; }

    public override string ToString()
    {
        return "Title: " + title + "Duration: " + duration;
    }
}