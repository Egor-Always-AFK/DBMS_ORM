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
    public ulong artistId { get; set; }
    
    [Column("media_id")]
    public ulong mediaId { get; set; }
}