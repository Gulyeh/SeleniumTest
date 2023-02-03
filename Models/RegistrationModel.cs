namespace Task3_1.Models
{
    public class RegistrationModel
    {
        public RegistrationModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Department = string.Empty;
            Email = string.Empty;
            Age = string.Empty;
            Salary = string.Empty;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
    }
}