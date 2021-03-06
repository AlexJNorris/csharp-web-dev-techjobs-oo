using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job empty;
        string testString1;
        string testString2;
        string testString3;

       [TestInitialize]
        public void CreateCarObject()
        {
            job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            job3 = new Job("Web Developer", new Employer(""), new Location(""), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            empty = new Job("",new Employer(""),new Location(""), new PositionType(""), new CoreCompetency(""));
            testString1 = '\n' + "OOPS! This job does not seem to exist." + '\n';
            testString2 = '\n' + "Id: 22\n" + "Name: Web Developer\n" + "Employer: LaunchCode\n" + "Location: St. Louis\n" + "Position Type: Front-end developer\n" + "Core Competency: JavaScript\n";
            testString3 = '\n' + "Id: 28\n" + "Name: Web Developer\n" + "Employer: Data not available\n" + "Location: Data not available\n" + "Position Type: Front-end developer\n" + "Core Competency: JavaScript\n";

        }


        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse((job1.Id == job2.Id));
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job4));
        }
        [TestMethod]
        public void TestForBlankLines()
        {
            Assert.AreEqual(testString1, empty.ToString());
        }
        [TestMethod]
        public void TestForCorrectFormat()
        {
            Assert.AreEqual(testString2, job2.ToString());
        }
        [TestMethod]
        public void TestForMissingDataNotifier()
        {
            Assert.AreEqual(testString3, job3.ToString());
        }
    }
}
