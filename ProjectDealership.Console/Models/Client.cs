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

             EmailValidation(email);
            
                Email = email;
          
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelephone(string telephone)
        {
                TelephoneValidation(telephone);
                Telephone = telephone;
        
        }
        public string GetTelephone()
        {
            return Telephone;
        }
        public bool TelephoneValidation(string telephone)
        {
            if (telephone.Length > 8 && telephone.Length < 15)
            {
                return true;
           }
            throw new ValidationErrorException("Precisa conter @"); 
        }
        public bool EmailValidation(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }

            throw new ValidationErrorException("Telefone inválido");


        }

    }
}