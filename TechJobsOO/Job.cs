using System;
using System.Collections;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        private string[] JobItems = {"Id: ", "Name: ", "Employer: ", "Location: ", "Position Type: ", "Core Competency: " };

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string v, Employer emp, Location loc, PositionType posT, CoreCompetency CorC) : this()
        {
            Name = v;
            EmployerName = emp;
            EmployerLocation = loc;
            JobType = posT;
            JobCoreCompetency = CorC;

        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            string str;
            str = '\n' + JobItems[0] + this.Id.ToString() + '\n' + JobItems[1] + this.Name + '\n'
                + JobItems[2] + this.EmployerName.Value + '\n' + JobItems[3] + this.EmployerLocation.Value + '\n'
                + JobItems[4] + this.JobType.Value + '\n' + JobItems[5] + this.JobCoreCompetency.ToString() + '\n';


            return str;
        }
    }
}
