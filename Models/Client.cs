namespace ProjectDealership.Models
{
    public class Client : Person
    {
        private string Email { get; set; }
        private string Telephone { get; set; }
        public Client(string email, string name, string cpf, DateTime birthdate) : base(name, cpf, birthdate)
        {
            SetEmail(email);
        }
        public void SetEmail(string email)
        {
            email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
    }

}