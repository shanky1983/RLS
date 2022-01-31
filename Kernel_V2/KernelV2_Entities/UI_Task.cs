using System.Collections;
namespace Attune.KernelV2.Entities
{
    public class UI_TaskActions
    {
        public int TaskActionID { get; set; }
        public string ActionName { get; set; }
        public string RedirectURL { get; set; }
        public string DisplayTextTemplate { get; set; }
       
        public string DisplayText { get; set; }
        public long OtherID { get; set; }
        public long VisitPurposeID { get; set; }
        public string LanguageCode { get; set; }
    }

    public class UI_Tasks
    {
        public long TaskID { get; set; }
        public int TaskActionID { get; set; }
        public string TaskDescription { get; set; }
        public string RedirectURL { get; set; }
        public long PatientID { get; set; }
        public long AssignedTo { get; set; }
        public long CreatedBy { get; set; }
        public long RoleID { get; set; }
        public string RoleName { get; set; }
        public int OrgID { get; set; }
        public long ParentID { get; set; }
        public long PatientVisitID { get; set; }
        public int TaskStatusID { get; set; }
        public string HighlightColor { get; set; }
        public int SpecialityID { get; set; }
        public string RefernceID { get; set; }
        public string Type { get; set; }
        public int LocationID { get; set; }
        public string Remarks { get; set; }
        public int DeptID { get; set; }
        public string FromTable { get; set; }
        public long FTReferenceID { get; set; }
        public string Category { get; set; }
        public string ActionName { get; set; }
        public Hashtable DispTextFiller { get; set; }
        public Hashtable URLFiller { get; set; }
        public string IsStat { get; set; }
    }
}
