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

        public void MakeSemester(string time, List<Course> courses)
        {
            locals = new LocalSemester(time, courses);
        }
    }
}