using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BusinessEntityBase
    {
        private long primaryKeyValue;

        public long PrimaryKeyValue
        {
            get
            {
                return primaryKeyValue;
            }
            set
            {
                primaryKeyValue = value;
            }
        }
    }
}
