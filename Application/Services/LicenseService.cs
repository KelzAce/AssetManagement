using Application.Dtos;
using Application.Services.Interfaces;
using Domain.Models;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Application.Services;
using static Domain.Enums.DomainEnum;

namespace Application.Services
{
    public class LicenseService
     {
        private readonly LicenseRepository _licenseRepository;
        public LicenseService(LicenseRepository licenseRepository)
        {
            _licenseRepository = licenseRepository;
        }
            public async Task<IServiceResponse<LicenseServiceResponseDto>> AddLicenseAsync(LicenseServiceDto licenseServiceDto)
        {
            var license = new Licenses
            {
                LicenseType = licenseServiceDto.LicenseType,
                LicenseDoc = licenseServiceDto.LicenseDoc,
                LicenseIssueDate = licenseServiceDto.LicenseIssueDate,
                LicenseExpDate = licenseServiceDto.LicenseExpDate,
                LicenseStatus = Enum.Parse<LicenseStatus>(licenseServiceDto.LicenseStatus) // Convert string to enum
            };

            var createdLicense = await _licenseRepository.AddLicenseAsync(license);

            if (createdLicense == null)
            {
                throw new Exception("License creation failed. ");
            }

            var respDto = new LicenseServiceResponseDto
            {
                LicenseType = createdLicense.LicenseType,
                LicenseDoc = createdLicense.LicenseDoc,
                LicenseIssueDate = createdLicense.LicenseIssueDate,
                LicenseExpDate = createdLicense.LicenseExpDate,
                LicenseStatus = createdLicense.LicenseStatus.ToString(),
            };

            return new ServiceResponse<LicenseServiceResponseDto>(
                "License record was added succesfully",
                true,
                respDto
            );
        }

        public async Task<IServiceResponse<LicenseServiceResponseDto>> GetLicenseAsync()
        {
            var license = await _licenseRepository.GetLicenseListAsync();
            var respDto = new LicenseServiceResponseDto
            {
                LicenseType = license.LicenseType,
                LicenseDoc = license.LicenseDoc,
                LicenseIssueDate = license.LicenseIssueDate,
                LicenseExpDate = license.LicenseExpDate,
                LicenseStatus = license.LicenseStatus.ToString(),
            };

            return new ServiceResponse<LicenseServiceResponseDto>(
               "License record was added succesfully",
               true,
               respDto!
           );
        }


    }
    
}

