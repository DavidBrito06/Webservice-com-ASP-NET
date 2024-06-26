﻿using br.com.fiap.alert.api.Models;

namespace br.com.fiap.alert.Services
{
    public class AuthService : IAuthService
    {
        private List<UserModel> _users = new List<UserModel>
                {
                    new UserModel { Email = "teste@mail.com", Name = "Teste", PasswordHash = "123456" }
                };


        public UserModel Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.PasswordHash == password);
        }
    }
}