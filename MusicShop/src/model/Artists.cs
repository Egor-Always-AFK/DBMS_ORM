using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.model;

[Table("artists")]
public class Artists
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("artists_id")]
    public long id { get; set; }

    [Column("name")]
    public string name { get; set; }
    
    [Column("bio")]
    public string bio { get; set; }
}