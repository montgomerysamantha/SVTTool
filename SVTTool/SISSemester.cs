using System;
using System.Collections.Generic;

public class SISSemester : Semester
{
    private string _semesterName { get; }
    private List<Course> _courses { get; }

    public SISSemester(string semName, List<Course> courses)
	{
        _semesterName = semName;
        _courses = courses;
    }
}
