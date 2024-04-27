using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopBrodova.Models;

public class TypeBoat
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {  get; set; }
    [MaxLength(30)]
    public string Name { get; set; }
    [DisplayName("Display order")]
    [Range(1, 30)]
    public int DisplayOrder { get; set; }
    public string ImageUrl { get; set; } 
}
