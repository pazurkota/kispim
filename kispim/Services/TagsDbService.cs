using kispim.Model;
using SQLite;

namespace kispim.Services;

public class TagsDbService
{
    private const string DbName = "tags_local_db.db3";
    private readonly SQLiteAsyncConnection _connection;

    public TagsDbService()
    {
        _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DbName));
        _connection.CreateTableAsync<Tag>();
    }

    public async Task<List<Tag>> GetTags()
    {
        return await _connection.Table<Tag>().ToListAsync();
    }

    public async Task<Tag> GetById(int id)
    {
        return await _connection.Table<Tag>().Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task Create(Tag tag)
    {
        await _connection.InsertAsync(tag);
    }

    public async Task Update(Tag tag)
    {
        await _connection.UpdateAsync(tag);
    }

    public async Task Delete(Tag tag)
    {
        await _connection.DeleteAsync(tag);
    }
}