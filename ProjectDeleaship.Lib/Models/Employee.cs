using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDeleaship.Lib.Models
{
    public class Employee : Person
    {
        private string Position { get; set; }
        public Employee(string position, string name, string cpf, DateTime birthdate) : base(name, cpf, birthdate)
        {
            SetPosition(position);
        }
        public void SetPosition(string position)
        {
            Position = position;
        }
        public string GetPosition()
        {
            return Position;
        }
    }

}