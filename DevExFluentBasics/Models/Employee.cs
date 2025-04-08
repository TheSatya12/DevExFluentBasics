using System.ComponentModel.DataAnnotations;

namespace DevExFluentBasics.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Position { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
         public int Age { get; set; }
    }
}
