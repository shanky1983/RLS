using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using Attune.Solution.DAL;
using Attune.Podium.BusinessEntities;
namespace Attune.Solution.BusinessComponent
{
    public class State_BL
    {
          ContextDetails globalContextDetails;
        public State_BL()
        {

        }
        public State_BL(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        public DataSet GetState(Attune.Podium.BusinessEntities.State objState,int CountryID)
        {
            Attune.Solution.DAL.State_DAL obj = new State_DAL(globalContextDetails);
            DataSet dsState = new DataSet();
            dsState = obj.LoadComboState(objState,CountryID);
            return dsState;
        }

        public long GetStateByCountry(int CountryID,out List<State> states)
        {
            long returnCode = -1;
            State_DAL stateDAL = new State_DAL(globalContextDetails);
            returnCode = stateDAL.GetStateByCountry(CountryID, out states);
            return returnCode;
        }
    }
}
