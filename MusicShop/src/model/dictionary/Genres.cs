using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.model.dictionary;

[Table("genres")]
public class Genres
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("genre_id")]
    public long id { get; set; }
    
    [Column("name")]
    public string name { get; set; }
}