using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Transactions;

namespace Folk
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Begrundelse { get; set; }
        public DateTime Starttidspunkt { get; set; }
        public DateTime Sluttidspunkt { get; set; }
        public int MaxMødeTid { get; set; }
        private static int currentId = 1;

        /*Constructor*/
        public Person()
        {
            Id = IdGenerator();
            MaxMødeTid = 1; /*Kan som minimum booke én time*/
        }
        private static int IdGenerator()
        {
            return currentId++;
        }
    }
}