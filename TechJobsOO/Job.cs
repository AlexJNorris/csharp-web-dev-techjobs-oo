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
        private string warning = "Data not available";

    public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string v, Employer emp, Location loc, PositionType posT, CoreCompetency CorC) : this()
        {
            Name = v;

            if (String.IsNullOrEmpty(Name))
            {
                Name = "Data not available";
            }

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
            if (this.Name + this.EmployerName.Value + this.EmployerLocation.Value + this.JobType.Value + this.JobCoreCompetency.ToString() == warning + warning + warning + warning + warning)
            {
                str = '\n' + "OOPS! This job does not seem to exist." + '\n';
            }
            else
            {

                str = '\n' + JobItems[0] + this.Id.ToString() + '\n' + JobItems[1] + this.Name + '\n'
                    + JobItems[2] + this.EmployerName.Value + '\n' + JobItems[3] + this.EmployerLocation.Value + '\n'
                    + JobItems[4] + this.JobType.Value + '\n' + JobItems[5] + this.JobCoreCompetency.ToString() + '\n';
            }

            return str;
        }
    }
}
