using Application.Dtos;
using Application.Services.Interfaces;
using Domain.Models;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Application.Services;

namespace Application.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IServiceResponse<RegisterUserResponseDto>> AddUserAsync(RegisterUserDto registerUserDto)
        {
            var user = new User
            {
                FirstName = registerUserDto.FirstName,
                LastName = registerUserDto.LastName,
                Email = registerUserDto.Email,
                PasswordHash = registerUserDto.Password,
                NIN = registerUserDto.NIN,
                Phone = registerUserDto.Phone,
                BusinessInformation = registerUserDto.BusinessInformation,

            };
            var createdUser = await _userRepository.AddUserAsync(user);

            if (createdUser == null)
            {
                throw new Exception("User creation failed or email already exists.");
            }

            var respDto = new RegisterUserResponseDto
            {
                Id = createdUser.Id,
                FirstName = createdUser.FirstName,
                Email = createdUser.Email,
                LastName = createdUser.LastName,
                //CreatedAt = (DateTime)createdUser.CreatedAt,
            };

            return new ServiceResponse<RegisterUserResponseDto>(
                "User record was added succesfully",
                true,
                respDto
                );
        }
    }
}


