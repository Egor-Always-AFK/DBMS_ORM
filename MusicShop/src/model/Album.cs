using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.model;

[Table("albums")]
public class Album
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("album_id")]
    public long id { get; set; }
    
    [Column("title")]
    public string title { get; set; }
    
    [Column("artist_id")]
    [ForeignKey("artist_id")]
    public long artistId { get; set; }
    
    [Column("media_id")]
    public long mediaId { get; set; }

    public Album(long artistId, long mediaId, string title)
    {
        this.artistId = artistId;
        this.mediaId = mediaId;
        this.title = title;
    }
}