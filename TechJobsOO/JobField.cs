using System;
namespace TechJobsOO
{
    public class JobField
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
            if (String.IsNullOrEmpty(Value))
            {
                Value = "Data not available";
            }
        }
        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {

            return Value;
        }

    }
}
