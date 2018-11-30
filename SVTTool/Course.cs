using System;

public class Course
{
    private string _subject;
    private string _catalogNbr;
    private string _classDescr;
    private string _section;
    private string _instructor;
    private string _consent;
    private string _enrlCap;
    private string _topicDescr;
    private string _meetingStartDt;
    private string _meetingEndDt;
    private string _facilityId;
    private string _meetingTimeStart;
    private string _meetingTimeEnd;
    private string _mon;
    private string _tues;
    private string _wed;
    private string _thurs;
    private string _fri;
    private string _sat;
    private string _sun;
    private string _unitsMin;
    private string _unitsMax;
    private string _classAssnComponent;

	public Course(string subj, string cata, string clad, string sect, string inst, string cons, string enrl, string topi,
                    string mesd, string meed, string faci, string mets, string mete, string mon, string tues, string wed,
                    string thurs, string fri, string sat, string sun, string unmi, string unma, string clac)
	{
        _subject = subj;
        _catalogNbr = cata;
        _classDescr = clad;
        _section = sect;
        _instructor = inst;
        _consent = cons;
        _enrlCap = enrl;
        _topicDescr = topi;
        _meetingStartDt = mesd;
        _meetingEndDt = meed;
        _facilityId = faci;
        _meetingTimeStart = mets;
        _meetingTimeEnd = mete;
        _mon = mon;
        _tues = tues;
        _wed = wed;
        _thurs = thurs;
        _fri = fri;
        _sat = sat;
        _sun = sun;
        _unitsMin = unmi;
        _unitsMax = unma;
        _classAssnComponent = clac;
    }
}
