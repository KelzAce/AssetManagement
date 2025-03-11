using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public class DomainEnum
    {
        public enum UserRole
        {
            Administrator,
            Vendor,
        }

        public enum StatusReport
        {
            Assigned,
            InProgress,
            Due,
            Submitted
        }

        public enum ContractStatus
        {
            Ongoing,
            Completed,
            Paused
        }

        public enum ProposalStatus
        {
            Pending,
            Rejected,
            Approved
        }

        public enum PaymentType
        {
            HalfPayment,
            FullPayment
        }

        public enum BusinessInformation
        {
            BusinessName,
            BusinessType,
            BusinessRegNo,
            BusinessAddress,
            StaffSize,
            BusinessInfo
        }
        public enum LicenseStatus
        {
            Active,
            Expired
        }
    }
}

