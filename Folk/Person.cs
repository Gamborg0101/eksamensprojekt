using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Transactions;

namespace Folk
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Begrundelse { get; set; }
        public DateTime Starttidspunkt { get; set; }
        public DateTime Sluttidspunkt { get; set; }
        public int maxMødeTid { get; set; }
        private static int currentId = 1;

        /*Constructor*/
        public Person()
        {
            Id = IdGenerator();
            maxMødeTid = 1; /*Kan som minimum booke én time*/
        }

        /*Custom constructor*/
        public Person(string name, string begrunelse, DateTime starttidspunkt, DateTime sluttidspunkt)
        {
            Id = IdGenerator();
            Name = name;
            Begrundelse = begrunelse;
            Starttidspunkt = starttidspunkt;
            Sluttidspunkt = sluttidspunkt;
        }

        private static int IdGenerator()
        {
            return currentId++;
        }

       
    }
}