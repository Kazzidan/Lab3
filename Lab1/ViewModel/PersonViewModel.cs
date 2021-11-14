using System;
using System.Collections.ObjectModel;
using Lab1.Model;


namespace Lab1.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } =
        new ObservableCollection<Person>();
        public PersonViewModel()
        {
            this.ListPerson.Add(
            new Person
            {
                Id = 1,
                VerietyID = 1,
                StatusID = 2,
                Inn = 12345678,
                Type = "физическое",
                Shifer = 159357,
                Data = new DateTime(1980, 02, 28)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 2,
                VerietyID = 2,
                StatusID = 1,
                Inn = 12345678,
                Type = "физическое",
                Shifer = 159357,
                Data = new DateTime(1981, 03, 20)
            });
            this.ListPerson.Add(
             new Person
             {
                 Id = 3,
                 VerietyID = 1,
                 StatusID = 2,
                 Inn = 12345678,
                 Type = "физическое",
                 Shifer = 159357,
                 Data = new DateTime(1982, 04, 15)
             });
            this.ListPerson.Add(
            new Person
            {
                Id = 4,
                VerietyID = 2,
                StatusID = 1,
                Inn = 12345678,
                Type = "физическое",
                Shifer = 159357,
                Data = new DateTime(1983, 05, 10)
            });
        }
    }
}