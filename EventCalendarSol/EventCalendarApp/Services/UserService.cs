﻿using EventCalendarApp.Interface;
using EventCalendarApp.Models.DTOs;
using EventCalendarApp.Models;
using System.Security.Cryptography;
using System.Text;

namespace EventCalendarApp.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<string, User> _repository;
        private readonly ITokenService _tokenService;

        public UserService(IRepository<string, User> repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }
        public UserDTO Login(UserDTO userDTO)
        {
            var user = _repository.GetById(userDTO.Email);
            if (user != null)
            {
                HMACSHA512 hmac = new HMACSHA512(user.Key);
                var userpass = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));
                for (int i = 0; i < userpass.Length; i++)
                {
                    if (user.Password[i] != userpass[i])
                        return null;
                }
                userDTO.Token = _tokenService.GetToken(userDTO);
                userDTO.Password = "";
                return userDTO;
            }
            return null;
        }

        public UserDTO Register(UserDTO userDTO)
        {
            HMACSHA512 hmac = new HMACSHA512();
            User user = new User()
            {
                Email = userDTO.Email,
                FirstName=userDTO.FirstName,
                LastName=userDTO.LastName,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)),
                Key = hmac.Key,
                Role = userDTO.Role
            };
            var result = _repository.Add(user);
            if (result != null)
            {
                userDTO.Password = "";
                return userDTO;
            }
            return null;

        }
    }
}
