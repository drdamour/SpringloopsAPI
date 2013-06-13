//-----------------------------------------------------------------------
// <copyright file="Issue.cs" company="TemporalCohesion.co.uk">
//     Copyright [2010] [Stuart Grassie]
//
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.
// </copyright>
//----------------------------------------------------------------------

using System;
namespace SpringloopsAPI.Models
{
    /// <summary>
    /// Maps to a Status of a task
    /// </summary>
    public class Status
    {
       
        /// <summary>
        /// Gets or sets the ID of the status.
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the status.
        /// </summary>
        public virtual string Name { get; set;}

        /// <summary>
        /// Gets or sets the type of the status.
        /// </summary>
        public virtual string Type { get; set; }


        /// <summary>
        /// Gets or sets the verb name ??? of the status.
        /// </summary>
        public virtual string VerbName { get; set; }

        /// <summary>
        /// Indicates if the status is an open status or not
        /// </summary>
        public virtual bool IsOpen { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj is Label)
            {
                var compareTo = (Label)obj;

                if (compareTo.Name.Equals(Name)
                   )
                {
                    return true;
                }

                return false;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
