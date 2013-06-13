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
using System.Collections.Generic;
namespace SpringloopsAPI.Models
{
    /// <summary>
    /// Maps to an task summary
    /// </summary>
    public class TaskSummary
    {
        /*
{
            "id": 96473,
            "relativeId": 53,
            "order": 9999510,
            "estimation": null,
            "title": "Extract email address to use in with our current email system",
            "desc": null,
            "visibility": "ALL",
            "visibilityGroup": null,
            "updateCount": 1,
            "updatesViewed": 1,
            "editable": true,
            "deleteable": true,
            "updateable": true,
            "starred": null,
            "created": 1326301248,
            "updated": 1326301248,
            "dueDate": null,
            "late": false,
            "upcoming": false,
            "tomorrow": false,
            "editedBy": 0,
            "projectId": 21578,
            "opener": {
                "id": 16001,
                "shortName": "Pete C.",
                "firstName": null,
                "lastName": null,
                "email": null,
                "title": null,
                "avatarTimestamp": null,
                "isOwner": false
            },
            "timers": [
                
            ],
            "assignment": [
                16000,
                15999
            ],
            "ticketLabels": [
                
            ],
            "lists": [
                
            ],
            "hasAttachment": true,
            "hasDescription": false,
            "imageAttachmentAdded": 0,
            "imageAttachments": 0,
            "attachmentsAdd": [
                
            ],
            "attachmentsUpdate": [
                
            ],
            "priority": {
                "id": "NORMAL",
                "name": "Normal",
                "cssClass": "normal"
            },
            "status": 1,
            "milestone": {
                "id": "@@NULL@@",
                "name": "",
                "url": "\/project\/21578\/milestone\/0"
            },
            "updates": [
                
            ],
            "projectName": "crimedar.com",
            "projectIsSvn": true,
            "projectUrl": "\/project\/21578\/tasks"
        }
         */


        /// <summary>
        /// Indicates if the task has an attachment
        /// </summary>
        public virtual bool HasAttachment { get; set; }

        /// <summary>
        /// Indicates if the task has a description
        /// </summary>
        public virtual bool HasDescription { get; set; }

        /// <summary>
        /// Gets or sets the ID of the task.
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public virtual string Title { get; set;}

        /// <summary>
        /// Gets or sets the ID of the task relative to it's project
        /// </summary>
        public virtual int RelativeId { get; set; }


        /// <summary>
        /// Gets or sets the time this task was created
        /// </summary>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the last time this task was updated
        /// </summary>
        public virtual DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the opener of this task
        /// </summary>
        public virtual User Opener { get; set; }


        /// <summary>
        /// Gets or sets the number of updates this task has
        /// </summary>
        public virtual long UpdateCount { get; set; }

        /// <summary>
        /// Gets or sets the ID of the task relative to it's project
        /// </summary>
        public virtual string Desc { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is TaskSummary)
            {
                var compareTo = (TaskSummary)obj;

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
