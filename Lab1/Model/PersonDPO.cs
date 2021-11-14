using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    class PersonDPO
    {
        public int Id { get; set; } //Код
        public string Veriety { get; set; }
        public string Status { get; set; }
        public int Inn { get; set; }
        public string Type { get; set; }
        public int Shifer { get; set; }
        public DateTime Data { get; set; }
        public PersonDPO() { }
        public PersonDPO(int id, string veriety, string status, int inn,
        string type, int shifer, DateTime data)
        {
            this.Id = id;
            this.Veriety = veriety;
            this.Status = status;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }
    }
}
