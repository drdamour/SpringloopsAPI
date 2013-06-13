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
    /// Maps to a Task Update like a comment
    /// </summary>
    public class TaskUpdate
    {
       
        /// <summary>
        /// Gets or sets the ID of the update.
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the comment of the update.
        /// </summary>
        public virtual string Comment { get; set;}


        /// <summary>
        /// Gets or sets the time the update was created.
        /// </summary>
        public virtual DateTime Created { get; set; }


        /// <summary>
        /// Gets or sets the owner of this update.
        /// </summary>
        public virtual User Owner { get; set; }


        /// <summary>
        /// Gets or sets the Svn commit number of this update.
        /// </summary>
        public virtual long Svn { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj is TaskUpdate)
            {
                var compareTo = (TaskUpdate)obj;

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
            return Comment;
        }
    }
}
