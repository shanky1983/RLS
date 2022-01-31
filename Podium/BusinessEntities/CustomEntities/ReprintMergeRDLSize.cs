using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class ReprintMergeRDLSize
    {
        int movex = 0;
        int movey = 0;
        int linex = 0;
        int liney = 0;
        int fontsize = 0;

        public int MoveX
        {
            get { return movex; }
            set { movex = value; }
        }
        public int MoveY
        {
            get { return movey; }
            set { movey = value; }
        }
       
        public int LineX
        {
            get { return linex; }
            set { linex = value; }
        }
        public int LineY
        {
            get { return liney; }
            set { liney = value; }
        }
        public int FontSize
        {
            get { return fontsize; }
            set { fontsize = value; }
        }

    }
}
