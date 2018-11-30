using System;
using System.Collections.Generic;

public class SISSemester : Semester
{
    private string _semesterName;
    private List<Course> _courses;

    public SISSemester(string semName, List<Course> courses)
	{
        _semesterName = semName;
        _courses = courses;
    }
}
