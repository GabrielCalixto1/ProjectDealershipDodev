using ProjectDeleaship.Lib.Exceptions;
namespace ProjectDeleaship.Lib.Models
{
    public class Person
    {
        protected string Name { get; set; }
        protected string Cpf { get; set; }
        protected DateTime Birthdate { get; set; }
        public Person(string name, string cpf, DateTime birthdate)
        {
            SetName(name);
            SetCpf(cpf);
            SetBirthdate(birthdate);
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetBirthdate(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return Birthdate;
        }


    }

}