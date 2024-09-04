﻿using App.DAL.DataContext;
using App.DAL.Entities;
using App.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace App.DAL.Repositories
{
    public class UsersRepository:IUsersRepository
    {
        public ChocoledetContext dbContext;
        public UsersRepository(ChocoledetContext chocoledetContext)
        {
            dbContext = chocoledetContext;
        }       
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await dbContext.Users.ToListAsync();
            }catch (Exception)
            {
                throw new Exception("שגיאה בשליפת נתונים");
            }
        }
        public async Task<User> GetUserById(Guid id)
        {
            try
            {
                return await dbContext.Users.Include(u => u.Orders)
                    .ThenInclude(o => o.OrderItems)
                    .SingleOrDefaultAsync(u => u.UserId == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> CreateUser(User user)
        {
            try
            {
                await dbContext.Users.AddAsync(user);
                await dbContext.SaveChangesAsync();
                return (Guid)user.UserId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Guid> UpdateUser(Guid id, User user)
        {
            try
            {
                User userToUpdate = await dbContext.Users.SingleOrDefaultAsync(u => u.UserId == id);
                userToUpdate.UserName = user.UserName;
                userToUpdate.Password = user.Password;
                userToUpdate.Phone = user.Phone;
                await dbContext.SaveChangesAsync();
                return user.UserId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<User>> DeleteUser(Guid id)
        {
            try
            {
                var user = await dbContext.Users
                    .Include(u => u.Orders)
                    .ThenInclude(o => o.OrderItems)
                    .SingleOrDefaultAsync(u => u.UserId == id);
                foreach (var order in user.Orders)
                {
                    dbContext.OrderItems.RemoveRange(order.OrderItems);
                }
                dbContext.Orders.RemoveRange(user.Orders);
                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();

                return await dbContext.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user", ex);
            }
        }

        public async Task<string> LoginUser(string email, string password)
        {
            try
            {
                if (email == null || password == null || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    return "null";

                var userEmail = await dbContext.Users.SingleOrDefaultAsync(u => u.Email == email);

                if (userEmail == null)
                    return "Invalid email";

                if (userEmail.Password.Trim() != password)
                    return "Invalid password";
                return "Login successful";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
