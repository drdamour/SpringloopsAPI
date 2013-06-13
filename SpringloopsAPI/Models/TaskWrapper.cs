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

namespace SpringloopsAPI.Models
{
    /// <summary>
    /// Maps to an issue summary
    /// </summary>
    public class TaskWrapper
    {

        /// <summary>
        /// Gets or sets the task this item wraps
        /// </summary>
        public virtual Task Ticket { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is TaskWrapper)
            {
                var compareTo = (TaskWrapper)obj;

                if (compareTo.Ticket.Title.Equals(Ticket.Title)
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
            return Ticket.Title.GetHashCode();
        }

        public override string ToString()
        {
            return Ticket.Title;
        }
    }
}
