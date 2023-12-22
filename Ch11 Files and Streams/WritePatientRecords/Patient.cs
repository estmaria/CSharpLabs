using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Information of a patient*/

namespace WritePatientRecords
{
    class Patient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public Patient(string id, string name, int balance)
        {
            ID = id;
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Balance}";
        }

    }
}
