using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS
{
    class Manager
    {
        public object FillAllPurpose()
        {
            var obj = new MISDBEntities();
            var q = from p in obj.PurposeInfoes select p;
            return q.ToList();
        }

        public List<SP_FollowUp_Result> FillFollowGrid()
        {
            var context = new MISDBEntities();
            var q = context.SP_FollowUp();
            return q.ToList();
        }

        internal List<SP_Report_Result> GetAllPurposeWiseReport(int pid)
        {
            var context = new MISDBEntities();
            var q = context.SP_Report(pid);
            return q.ToList();
        }
    }
}
