using Project2;

public class SchoolDataStorage : SchoolDataStorageBase
{
    private readonly IDataRepository _dataRepository;

    public SchoolDataStorage(IDataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }

    public Student GetStudentById(int studentId)
    {
        // Business logic for retrieving a student by ID
        return _dataRepository.GetStudentById(studentId);
    }
    // Other methods...
}
