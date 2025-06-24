namespace ManagementSystem;

using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

[Table("Product")]
public class ProductModel : BaseModel
{
    [Column("id")]
    public int id { get; set; }
    
    [Column("created_at")]
    public DateTime created_at { get; set; }
}