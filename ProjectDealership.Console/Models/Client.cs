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
            email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetTelephone(string telephone)
        {
            Telephone = telephone;
        }
        public string GetTelephone()
        {
            return Telephone;
        }
    }

}