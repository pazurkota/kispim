using SQLite;

namespace kispim.Model;

[Table("tags")]
public class Tag
{
    [PrimaryKey]
    [AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;
}