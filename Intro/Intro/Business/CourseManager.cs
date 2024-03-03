using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concrete;
using Intro.Entities;

namespace Intro.Business;

public class CourseManager
{
    // dependency injection
    private readonly ICourseDal _courseDal;
    
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // business rules
        
        return _courseDal.GetAll();
    }
}