using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<UserModel>> GetUsers() =>
        _db.LoadDataAsync<UserModel, dynamic>("dbo.spUser_GetAll", new { });

    public async Task<UserModel?> GetUser(int id)
    {
        var results = await _db.LoadDataAsync<UserModel, dynamic>("dbo.spuser_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) =>
        _db.SaveDataAsync<dynamic>("dbo.spUser_Insert", new { user.FirstName, user.LastName });

    public Task UpdateUser(UserModel user) =>
        _db.SaveDataAsync("dbo.spUser_Update", user);

    public Task DeleteUser(int id) =>
        _db.SaveDataAsync("spUser_Delete", new { Id = id });

}
