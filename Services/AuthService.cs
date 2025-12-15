using Clininc_Management_System.Data;
using Clininc_Management_System.Models;

namespace Clininc_Management_System.Services
{
    public enum UserRole
    {
        Admin,
        Manager,
        Doctor
    }

    public class AuthResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public UserRole? Role { get; set; }
        public Doctor Doctor { get; set; }
    }

    /// <summary>
    /// Central authentication service for all roles.
    /// </summary>
    public class AuthService
    {
        private readonly DoctorRepository _doctorRepository;

        public AuthService()
        {
            _doctorRepository = new DoctorRepository();
        }

        public AuthResult Login(string username, string password, UserRole selectedRole)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return new AuthResult
                {
                    Success = false,
                    ErrorMessage = "Please enter both username and password."
                };
            }

            switch (selectedRole)
            {
                case UserRole.Admin:
                    return ValidateAdmin(username, password);
                case UserRole.Manager:
                    return ValidateManager(username, password);
                case UserRole.Doctor:
                    return ValidateDoctor(username, password);
                default:
                    return new AuthResult
                    {
                        Success = false,
                        ErrorMessage = "Unknown role selected."
                    };
            }
        }

        private static AuthResult ValidateAdmin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return new AuthResult { Success = true, Role = UserRole.Admin };
            }

            return new AuthResult
            {
                Success = false,
                ErrorMessage = "Invalid admin credentials."
            };
        }

        private static AuthResult ValidateManager(string username, string password)
        {
            if (username == "manager" && password == "manager")
            {
                return new AuthResult { Success = true, Role = UserRole.Manager };
            }

            return new AuthResult
            {
                Success = false,
                ErrorMessage = "Invalid manager credentials."
            };
        }

        private AuthResult ValidateDoctor(string doctorId, string password)
        {
            var doctor = _doctorRepository.ValidateDoctorLogin(doctorId, password);
            if (doctor == null)
            {
                return new AuthResult
                {
                    Success = false,
                    ErrorMessage = "Invalid credentials or your account is not approved yet."
                };
            }

            return new AuthResult
            {
                Success = true,
                Role = UserRole.Doctor,
                Doctor = doctor
            };
        }
    }
}


