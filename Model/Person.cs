using System;

namespace LR1.Model
{
    public class Person
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person() { }

        public Person(int id, int roleId, string firstName, string lastName, DateTime birthday)
        {
            this.Id = id;
            this.RoleId = roleId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        /// <summary>
        /// Копирование данных из PersonDpo 
        /// </summary>
        public Person CopyFromPersonDPO(PersonDpo personDpo)
        {
            Person p = new Person();
            p.Id = personDpo.Id;
            p.FirstName = personDpo.FirstName;
            p.LastName = personDpo.LastName;
            p.Birthday = personDpo.Birthday;

            // Восстанавливаем RoleId по имени должности
            foreach (var r in new ViewModel.RoleViewModel().ListRole)
            {
                if (r.NameRole == personDpo.RoleName)
                {
                    p.RoleId = r.Id;
                    break;
                }
            }
            return p;
        }
    }
}
