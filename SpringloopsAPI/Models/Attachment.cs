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
    /// Maps to a Attachment
    /// </summary>
    public class Attachment
    {
       
        /// <summary>
        /// Gets or sets the ID of the attachment.
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name of the attachment.
        /// </summary>
        public virtual string Name { get; set;}

        /// <summary>
        /// Gets or sets the path portion of the URL of the attachment.
        /// </summary>
        public virtual string Path { get; set; }

        /// <summary>
        /// Gets or sets the way the attachment was added.
        /// </summary>
        public virtual string AddType { get; set; }

        /// <summary>
        /// Gets or sets the way the content type of the attachment
        /// </summary>
        public virtual string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the create date of the attachment
        /// </summary>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the way the creator of the attachment
        /// </summary>
        public virtual User Creator { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Label)
            {
                var compareTo = (Label)obj;

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
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
