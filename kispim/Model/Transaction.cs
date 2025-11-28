using SQLite;

namespace kispim.Model;

[Table("transactions")]
public class Transaction
{
    [PrimaryKey]
    [AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")] 
    public string Name { get; set; } = null!;
    
    [Column("amount")]
    public decimal Amount { get; set; }
    
    // [Column("currency")]
    // public CurrencyType Currency { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set; }

    [Column("tags")]
    public Tag[] Tags { get; set; } = null!;
}