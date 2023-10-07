using NUnit.Framework;
using Moq;

[TestFixture]
public class SchoolDataStorageTests
{
    [Test]
    public void AddTeacher_ValidTeacher_TeacherAddedSuccessfully()
    {
        // Arrange
        var mockDataRepository = new Mock<IDataRepository>();
        var schoolDataStorage = new SchoolDataStorage(mockDataRepository.Object);
        var teacher = new Teacher("John Doe");

        // Act
        schoolDataStorage.AddTeacher(teacher);

        // Assert
        mockDataRepository.Verify(dr => dr.SaveTeacher(teacher), Times.Once);
    }

    [Test]
    public void GetStudentById_ExistingStudentId_ReturnsStudent()
    {
        // Arrange
        var mockDataRepository = new Mock<IDataRepository>();
        var schoolDataStorage = new SchoolDataStorageTests(mockDataRepository.Object);
        var studentId = 1;
        var expectedStudent = new Student("Alice");

        mockDataRepository.Setup(dr => dr.GetStudentById(studentId)).Returns(expectedStudent);

        // Act
        var actualStudent = schoolDataStorage.GetStudentById(studentId);

        // Assert
        Assert.AreEqual(expectedStudent, actualStudent);
    }
}
