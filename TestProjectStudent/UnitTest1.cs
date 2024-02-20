using StudentData;
using System.Security.Claims;
namespace TestProjectStudent
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void StudentConstructor_ValidInputs_PropertiesSetCorrectly()
        {
            int id = 1;
            string name = "Sam";
            string address = "Chennai";
            string email = "sam@gmail.com";
            int marks = 95;
            string className = "8A";
            var student = new Student
            {
                ID = id,
                Name = name,
                Address = address,
                Email = email,
                Marks = marks,
                ClassName = className
            };
            Assert.AreEqual(id, student.ID);
            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(address, student.Address);
            Assert.AreEqual(email, student.Email);
            Assert.AreEqual(marks, student.Marks);
            Assert.AreEqual(className, student.ClassName);
        }
        [Test]
        public void SubjectConstructor_ValidInputs_PropertiesSetCorrectly()
        {
            int subjectId = 101;
            string subjectName = "Math";
            var subject = new Subject
            {
                ID = subjectId,
                Name = subjectName
            };
            Assert.AreEqual(subjectId, subject.ID);
            Assert.AreEqual(subjectName, subject.Name);
        }
        [Test]
        public void ClassConstructor_validInputs_PropertiesSetCorrectly()
        {
            int classId = 564;
            string className = "8A";
            var schoolClass = new Class
            {
                ID = classId,
                Name = className
            };
            Assert.AreEqual(classId, schoolClass.ID);
            Assert.AreEqual(className, schoolClass.Name);
        }
    }
}