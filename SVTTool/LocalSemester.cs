using System;
using System.Collections.Generic;

public class LocalSemester : Semester
{
    private string _semesterName;
    private List<Course> _courses;

    public LocalSemester(string semName, List<Course> courses)
	{
        _semesterName = semName;
        _courses = courses;
	}

    public List<Course> GetCourses()
    {
        return _courses;
    }
}
