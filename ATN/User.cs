using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATN
{
    public class User
    {
        public int id { get; set; }
        public string card { get; set; }
        public string pin { get; set; }
        public string name { get; set; }
        public int balance { get; set; }
        public string[] operations { get; set; } = new string[3];
        public User() { }
        public User(string card, string pin, string name, int balance, string[] operations)
        {
            this.card = card;
            this.pin = pin;
            this.name = name;
            this.balance = balance;
            for (int i = 5; i < 8; i++) this.operations[i] = operations[i];
        }
    }
}