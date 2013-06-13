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

using System.Collections.Generic;
namespace SpringloopsAPI.Models
{
    /// <summary>
    /// Maps to an issue summary
    /// </summary>
    public class TaskReportSummary
    {
        /// <summary>
        /// Gets or sets the title of the task report.
        /// </summary>
        public virtual string Title { get; set;}


        /// <summary>
        /// Gets or sets the collecion of task summaries in the report.
        /// </summary>
        public virtual List<TaskSummary> Tickets { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is TaskReportSummary)
            {
                var compareTo = (TaskReportSummary)obj;

                if (compareTo.Title.Equals(Title)
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
            return Title.GetHashCode();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
