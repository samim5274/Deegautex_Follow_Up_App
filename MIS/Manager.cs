using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS
{
    class Manager
    {
        public String Id { get; set; }
        public String Name { get; set; }

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

        internal List<SP_DAY_WISE_MONEY_REPORT_Result> GetDateWiseReport(DateTime SDate, DateTime EDate)
        {
            var context = new MISDBEntities();
            var q = context.SP_DAY_WISE_MONEY_REPORT(SDate, EDate);
            return q.ToList();
        }

        public List<SP_Purpose_Wise_Fill_Follow_Item_Result> FillFollowCombo(int pid)
        {
            var context = new MISDBEntities();
            var q = context.SP_Purpose_Wise_Fill_Follow_Item(pid);
            return q.ToList();
        }

        internal object FillItem()
        {
            var obj = new MISDBEntities();
            var q = from i in obj.FollowUpTables select i;
            return q.ToList();
        }

        internal List<SP_MoneyType_Wise_Transection_Report_Result> GettMoneyTypeReport(int mtp)
        {
            var context = new MISDBEntities();
            var q = context.SP_MoneyType_Wise_Transection_Report(mtp);
            return q.ToList();
        }

        public List<SP_Day_And_MoneyType_Report_Result> GetDayAndMoneyTypeReport(DateTime sdate, DateTime edate, int moneyType)
        {
            var context = new MISDBEntities();
            var q = context.SP_Day_And_MoneyType_Report(sdate,edate,moneyType);
            return q.ToList();
        }

        internal object GetAllMoneyInfo()
        {
            var obj = new MISDBEntities();
            var q = from m in obj.GiveAndReciveDeailTables select m;
            return q.ToList();
        }
    }
}
