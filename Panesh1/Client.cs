using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panesh1
{
    public class Client
    {
        private int id;
        private string lastName;
        private string firstName;
        private string middleName;
        private string comment;

        public int Id => id;
        public string LastName => lastName;
        public string FirstName => firstName;
        public string MiddleName => middleName;
        public string Comment => comment;

        public Client(int id, string lastName, string firstName, string middleName, string comment)
        {
            ValidateFields(lastName, firstName, middleName, comment);
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.comment = comment;
        }

        private void ValidateString(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{fieldName} не может быть пустым.");
        }

        private void ValidateFields(string lastName, string firstName, string middleName, string comment)
        {
            ValidateString(lastName, "Фамилия");
            ValidateString(firstName, "Имя");
            ValidateString(middleName, "Отчество");

            if (comment.Length > 500)
                throw new ArgumentException("Комментарий слишком длинный.");
        }



    }

}
