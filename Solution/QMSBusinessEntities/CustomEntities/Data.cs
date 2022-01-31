using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Data
/// </summary>
namespace Attune.Solution.QMSBusinessEntities
{
    public class Data
    {
		#region Variables
        public string name = "";
        public int count = 0;
		#endregion
		
		#region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int COUNT
        {
            get { return count; }
            set { count = value; }
        }
		#endregion
    }
}


