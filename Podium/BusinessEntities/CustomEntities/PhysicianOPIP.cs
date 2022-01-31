using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class PhysicianOPIP: Patient
    {
        private string visitNotes;
        private string condition;
        private string bgcolor;
        private string nurseNotes;

         /// <summary>
        /// Gets or sets the VisitNotes value.
        /// </summary>
        public string VisitNotes
        {
            get
            {
                return visitNotes;
            }
            set
            {
                visitNotes = value;
            }
        }

        /// <summary>
        /// Gets or sets the VisitNotes value.
        /// </summary>
        public string NurseNotes
        {
            get
            {
                return nurseNotes;
            }
            set
            {
                nurseNotes = value;
            }
        }

        /// <summary>
        /// Gets or sets the Condition value.
        /// </summary>
        public string Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
            }
        }

        /// <summary>
        /// Gets or sets the BGColor value.
        /// </summary>
        public string BGColor
        {
            get
            {
                return bgcolor;
            }
            set
            {
                bgcolor = value;
            }
        }
    }
}
