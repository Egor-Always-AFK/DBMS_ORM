using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.model.dictionary;

[Table("media")]
public class MediaType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("media_id")]
    public long id { get; set; }

    [Column("type")]
    public string name { get; set; }
}