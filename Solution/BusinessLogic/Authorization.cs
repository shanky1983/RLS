using System;
using System.Collections.Generic;
using Attune.Podium.BusinessEntities;
using Attune.Solution.DAL;

namespace Attune.Solution.BusinessComponent
{
    class Authorization
    {
        ContextDetails globalContextDetails;
        public Authorization()
        {

        }
        public Authorization(ContextDetails localContextDetails)
        {
            globalContextDetails = localContextDetails;
        }
        //public Patient GetPatientDet(long patientID)
        //{
        //    DALGateway dalGateway = new DALGateway(globalContextDetails);
        //    //dalGateway
        //}



    }
}

//The changes in the finished classes include:

//   1. A permission parameter
//   2. The role parameter has become roles and is a string array
//   3. Each attribute class has an enum which contain the table and column permissions.
//   4. Helper method HasRole which return true if the role is present.
//   5. Helper method HasAnyRole which return true if any of the roles passed in are present.



//[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
//public class TablePermissionsAttribute : System.Attribute
//{
//    // this property is required to work with "AllowMultiple = true" ref David Ebbo
//    // As implemented, this identifier is merely the Type of the attribute. However,
//    // it is intended that the unique identifier be used to identify two
//    // attributes of the same type.
//    public override object TypeId { get { return this; } }

//    /// <summary>
//    /// Constructor
//    /// </summary>
//    /// <param name="permission"></param>
//    /// <param name="roles"></param>
//    public TablePermissionsAttribute(Permissions permission, params String[] roles)
//    {
//        this._permission = permission;
//        this._roles = roles;
//    }

//    private String[] _roles;
//    public String[] Roles
//    {
//        get { return this._roles; }
//        set { this._roles = value; }
//    }

//    private Permissions _permission;
//    public Permissions Permission
//    {
//        get { return this._permission; }
//        set { this._permission = value; }
//    }

//    /// <summary>
//    /// helper method to check for roles in this attribute
//    /// the comparison is case insensitive
//    /// </summary>
//    /// <param name="role"></param>
//    /// <returns></returns>
//    public Boolean HasRole(String role)
//    {
//        // call extension method to convert array to lower case for compare
//        String[] rolesLower = _roles.AllToLower();
//        return rolesLower.Contains(role.ToLower());
//    }

//    /// <summary>
//    /// helper method to check for roles in this attribute
//    /// the comparison is case insensitive
//    /// </summary>
//    /// <param name="roles"></param>
//    /// <returns></returns>
//    public Boolean HasAnyRole(String[] roles)
//    {
//        // call extension method to convert array to lower case for compare
//        foreach (var role in roles.AllToLower())
//        {
//            if (_roles.AllToLower().Contains(role.ToLower()))
//                return true;
//        }
//        return false;
//    }

