using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class GlassesAttributeForSave
    {
        //#region Fields

        //private long patientExaminationAttributeID = 0;
        //private long patientVisitID = 0;
        //private long examinationID = 0;
        //private long seqID = 0;
        //private long attributeID = 0;
        //private long attributevalueID = 0;
        //private string attributeValueName = String.Empty;
        //private long createdBy = 0;
        //private DateTime createdAt = DateTime.MaxValue;
        //private long modifiedBy = 0;
        //private DateTime modifiedAt = DateTime.MaxValue;
        //private bool status = false;

        //#endregion

        //#region Properties
        ///// <summary>
        ///// Gets or sets the PatientExaminationAttributeID value.
        ///// </summary>
        //public long PatientExaminationAttributeID
        //{
        //    get { return patientExaminationAttributeID; }
        //    set { patientExaminationAttributeID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the PatientVisitID value.
        ///// </summary>
        //public long PatientVisitID
        //{
        //    get { return patientVisitID; }
        //    set { patientVisitID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the ExaminationID value.
        ///// </summary>
        //public long ExaminationID
        //{
        //    get { return examinationID; }
        //    set { examinationID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the SeqID value.
        ///// </summary>
        //public long SeqID
        //{
        //    get { return seqID; }
        //    set { seqID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the AttributeID value.
        ///// </summary>
        //public long AttributeID
        //{
        //    get { return attributeID; }
        //    set { attributeID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the AttributevalueID value.
        ///// </summary>
        //public long AttributevalueID
        //{
        //    get { return attributevalueID; }
        //    set { attributevalueID = value; }
        //}

        ///// <summary>
        ///// Gets or sets the AttributeValueName value.
        ///// </summary>
        //public string AttributeValueName
        //{
        //    get { return attributeValueName; }
        //    set { attributeValueName = value; }
        //}

        ///// <summary>
        ///// Gets or sets the CreatedBy value.
        ///// </summary>
        //public long CreatedBy
        //{
        //    get { return createdBy; }
        //    set { createdBy = value; }
        //}

        ///// <summary>
        ///// Gets or sets the CreatedAt value.
        ///// </summary>
        //public DateTime CreatedAt
        //{
        //    get { return createdAt; }
        //    set { createdAt = value; }
        //}

        ///// <summary>
        ///// Gets or sets the ModifiedBy value.
        ///// </summary>
        //public long ModifiedBy
        //{
        //    get { return modifiedBy; }
        //    set { modifiedBy = value; }
        //}

        ///// <summary>
        ///// Gets or sets the ModifiedAt value.
        ///// </summary>
        //public DateTime ModifiedAt
        //{
        //    get { return modifiedAt; }
        //    set { modifiedAt = value; }
        //}

        ///// <summary>
        ///// Gets or sets the Status value.
        ///// </summary>
        //public bool Status
        //{
        //    get { return status; }
        //    set { status = value; }
        //}

        ///// <summary>
        ///// Gets or sets the ExaminationName value.
        ///// </summary>
        //private string examinationName = String.Empty;
        //public string ExaminationName
        //{
        //    get { return examinationName; }
        //    set { examinationName = value; }
        //}

        ///// <summary>
        ///// Gets or sets the AttributeName value.
        ///// </summary>
        //private string attributeName = String.Empty;
        //public string AttributeName
        //{
        //    get { return attributeName; }
        //    set { attributeName = value; }
        //}


        //#endregion

        public long LoginId { get; set; }
        public long PatientVisitID { get; set; }
        public long ExaminationID { get; set; }
        public long ComplaintId { get; set; }
        public string Description { get; set; }
        public long AttributeID { get; set; }
        public long AttributevalueID { get; set; }
        public string AttributeValueName { get; set; }
        public long PatientExaminationAttributeID { get; set; }
        public long seqid { get; set; }
        public int SNO { get; set; }


    }
}
