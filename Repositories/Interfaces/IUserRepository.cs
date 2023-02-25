using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.models;

namespace firstApi.Repositories.Interfaces
{
  public interface IUserRepository
  {
    Task<List<UsersModel>> GetAllUsers();
    Task<UsersModel> GetUserById(int id);
    Task<UsersModel> CreateUser(UsersModel user);
    Task<UsersModel> UpdateUser(UsersModel user);
    Task<bool> Delete(int id);
  }
}