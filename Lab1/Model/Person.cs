using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class Person
    {
        public int Id { get; set; } //Код
        public int VerietyID { get; set; } 
        public int StatusID { get; set; }
        public int Inn { get; set; }
        public string Type { get; set; }
        public int Shifer { get; set; }
        public DateTime Data { get; set; }
        public Person() { }
        public Person(int id, int verietyId, int statusID, int inn,
        string type, int shifer, DateTime data)
        {
            this.Id = id;
            this.VerietyID = verietyId;
            this.StatusID = statusID;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }
    }
}
