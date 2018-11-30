using System;

public class Course
{
    private string _subject { get; }
    private string _catalogNbr { get; }
    private string _classDescr { get; }
    private string _section { get; }
    private string _instructor { get; }
    private string _consent { get; }
    private string _enrlCap { get; }
    private string _topicDescr { get; }
    private string _meetingStartDt { get; }
    private string _meetingEndDt { get; }
    private string _facilityId { get; }
    private string _meetingTimeStart { get; }
    private string _meetingTimeEnd { get; }
    private string _mon { get; }
    private string _tues { get; }
    private string _wed { get; }
    private string _thurs { get; }
    private string _fri { get; }
    private string _sat { get; }
    private string _sun { get; }
    private string _unitsMin { get; }
    private string _unitsMax { get; }
    private string _classAssnComponent { get; }

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


    public bool IsIdenticalTo(Course c)
    {
        if (_subject != c._subject) return false;
        if (_catalogNbr != c._catalogNbr) return false;
        if (_classDescr != c._classDescr) return false;
        if (_section != c._section) return false;
        if (_instructor != c._instructor) return false;
        if (_consent != c._consent) return false;
        if (_enrlCap != c._enrlCap) return false;
        if (_topicDescr != c._topicDescr) return false;
        if (_meetingStartDt != c._meetingStartDt) return false;
        if (_meetingEndDt != c._meetingEndDt) return false;
        if (_facilityId != c._facilityId) return false;
        if (_meetingTimeStart != c._meetingTimeStart) return false;
        if (_meetingTimeEnd != c._meetingTimeEnd) return false;
        if (_mon != c._mon) return false;
        if (_tues != c._tues) return false;
        if (_wed != c._wed) return false;
        if (_thurs != c._thurs) return false;
        if (_fri != c._fri) return false;
        if (_sat != c._sat) return false;
        if (_sun != c._sun) return false;
        if (_unitsMin != c._unitsMin) return false;
        if (_unitsMax != c._unitsMax) return false;
        if (_classAssnComponent != c._classAssnComponent) return false;
        return true;
    }
}
