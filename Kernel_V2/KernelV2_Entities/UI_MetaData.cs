namespace Attune.KernelV2.Entities
{
    public class UI_MetaData
    {
        public int MetaDataID { get; set; }
        public string Domain { get; set; }
        public string Code { get; set; }
        public string DisplayText { get; set; }
        public string LangCode { get; set; }
        public long ParentID { get; set; }
        public int SeqNo { get; set; }
        public bool IsChecked { get; set; }
    }

    public class UI_MetaValues
    {
        public int ActionTypeID { get; set; }
        public string ActionType { get; set; }
        public string IsDisplay { get; set; }
        public string ActionCode { get; set; }
        public string Type { get; set; }
        public bool IsChecked { get; set; }
    }
    public class UI_Attributes
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeType { get; set; }
    }
}
