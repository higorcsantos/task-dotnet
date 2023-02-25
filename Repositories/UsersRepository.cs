using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.Data;
using firstApi.models;
using Microsoft.EntityFrameworkCore;

namespace firstApi.Repositories
{
  public class UsersRepository : Interfaces.IUsersRepository
  {
    private readonly TaskListDBContext _dbContext;
    public UsersRepository(TaskListDBContext taskListDBContext)
    {
      _dbContext = taskListDBContext;
    }
    public async Task<List<UsersModel>> GetAllUsers()
    {
      return await _dbContext.Users.ToListAsync();
    }

    public async Task<UsersModel> GetUserById(int id)
    {
      return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
    }
    public async Task<UsersModel> CreateUser(UsersModel user)
    {
      await _dbContext.Users.AddAsync(user);
      await _dbContext.SaveChangesAsync();
      return user;
    }

    public async Task<bool> Delete(int id)
    {
      UsersModel userById = await GetUserById(id);
      if (userById == null)
      {
        throw new Exception($"Usuário para o id {id} não foi encontrado");
      }
      _dbContext.Users.Remove(userById);
      await _dbContext.SaveChangesAsync();
      return true;
    }

    public async Task<UsersModel> UpdateUser(UsersModel user, int id)
    {
      UsersModel userById = await GetUserById(id);
      if (userById == null)
      {
        throw new Exception($"Usuário para o id {id} não foi encontrado");
      }
      userById.Name = user.Name;
      userById.Email = user.Email;
      _dbContext.Users.Update(userById);
      return userById;
    }
  }
}