using ProjectDealership.Exceptions;
namespace ProjectDealership.Models
{
    public class Client : Person
    {
        private string Email { get; set; }
        private string Telephone { get; set; }
        public Client(string email, string name, string cpf, DateTime birthdate, string telephone) : base(name, cpf, birthdate)
        {
            SetEmail(email);
            SetTelephone(telephone);
        }
        public void SetEmail(string email)
        {

            if (EmailValidation(email))
            {
                Email = email;
            }
            throw new ValidationErrorException("Precisa conter @");
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelephone(string telephone)
        {
            if (TelphoneValidation(telephone))
            {
                Telephone = telephone;
            }
            throw new ValidationErrorException("Tamanho inválido");
        }
        public string GetTelephone()
        {
            return Telephone;
        }
        public bool TelphoneValidation(string telephone)
        {
            if (telephone.Length < 15 && telephone.Length > 8)
            {
                return true;
            }
            return false;
        }
        public bool EmailValidation(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false;

        }

    }
}