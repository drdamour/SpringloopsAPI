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
    /// Maps to a User
    /// </summary>
    public class User
    {
       
        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the Last Name of the user.
        /// </summary>
        public virtual string LastName { get; set;}

        /// <summary>
        /// Gets or sets the First Name of the user.
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Short Name of the user.
        /// </summary>
        public virtual string ShortName { get; set; }


        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public virtual string Email { get; set;}


        /// <summary>
        /// Gets or sets the title of the user.
        /// </summary>
        public virtual string Title { get; set;}
        
        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                var compareTo = (User)obj;

                if (compareTo.Id.Equals(Id)
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
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
