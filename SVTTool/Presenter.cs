using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVTTool;

namespace SVTTool
{
    public class Presenter
    {
        LocalSemester locals;
        SISSemester sis;
        public Presenter()
        {
            
        }

        public void MakeLocalSemester(string time, List<Course> courses)
        {
            locals = null;
            locals = new LocalSemester(time, courses);
        }

        public void MakeSISSemester(string time, List<Course> courses)
        {
            sis = null;
            sis = new SISSemester(time, courses);
        }

        public void Clear(){
            locals = null;
            sis = null;
        }

        public string Verify()
        {
            StringBuilder sb = new StringBuilder();
            List<Course> sisCourses = sis.GetCourses();
            List<Course> localCourses = locals.GetCourses();
            bool error = false;
            for (int i = 0; i < sisCourses.Count; i++) //check for courses in SIS but not Local
            {
                bool inLocal = false;
                for (int j = 0; j < localCourses.Count; j++)
                {
                    if (sisCourses[i].IsIdenticalTo(localCourses[j]))
                    {
                        inLocal = true;
                    }
                    else if (sisCourses[i].GetSubject().Equals(localCourses[j].GetSubject()) &&
                             sisCourses[i].GetCatalogNbr().Equals(localCourses[j].GetCatalogNbr()) &&
                             sisCourses[i].GetSection().Equals(localCourses[j].GetSection()))
                    {
                        inLocal = true;
                    }
                }
                if (!inLocal)
                {
                    sb.Append("<<");
                    sb.Append(sisCourses[i].ToString());
                    sb.Append(" not found in current semester!");
                    sb.Append(Environment.NewLine);
                    error = true;
                }
            }

            for (int i = 0; i < localCourses.Count; i++) //check for courses in Local but not SIS
            {
                bool inSis = false;
                for (int j = 0; j < sisCourses.Count; j++)
                {
                    if (localCourses[i].IsIdenticalTo(sisCourses[j]))
                    {
                        inSis = true;
                    }
                    else if (localCourses[i].GetSubject().Equals(sisCourses[j].GetSubject()) &&
                             localCourses[i].GetCatalogNbr().Equals(sisCourses[j].GetCatalogNbr()) &&
                             localCourses[i].GetSection().Equals(sisCourses[j].GetSection()))
                    {
                        inSis = true;
                        sb.Append(" ");
                        sb.Append(localCourses[i].ToString());
                        sb.Append(" has been changed in the current semester.");
                        sb.Append(Environment.NewLine);
                        error = true;
                    }
                }
                if (!inSis)
                {
                    sb.Append(">>");
                    sb.Append(localCourses[i].ToString());
                    sb.Append(" is new in current semester!");
                    sb.Append(Environment.NewLine);
                    error = true;
                }
            }

            return sb.ToString();

        }
    }
}