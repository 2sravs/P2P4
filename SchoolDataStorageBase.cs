using Project2;

public class SchoolDataStorageBase
{

    public void AddTeacher(Teacher teacher)
    {
        // Business logic for adding a teacher
        _dataRepository.SaveTeacher(teacher);
    }
}