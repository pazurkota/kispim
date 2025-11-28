using kispim.Model;
using SQLite;

namespace kispim.Services;

public class TransactionsDbService
{
    private const string DbName = "transactions_local_db.db3";
    private readonly SQLiteAsyncConnection _connection;

    public TransactionsDbService()
    {
        _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DbName));
        _connection.CreateTableAsync<Transaction>();
    }

    public async Task<List<Transaction>> GetTransactions()
    {
        return await _connection.Table<Transaction>().ToListAsync();
    }

    public async Task<Transaction> GetById(int id)
    {
        return await _connection.Table<Transaction>().Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task Create(Transaction transaction)
    {
        await _connection.InsertAsync(transaction);
    }

    public async Task Update(Transaction transaction)
    {
        await _connection.UpdateAsync(transaction);
    }

    public async Task Delete(Transaction transaction)
    {
        await _connection.DeleteAsync(transaction);
    }
}