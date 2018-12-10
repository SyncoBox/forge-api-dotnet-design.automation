/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// A WorkItem is a specification of the processing job for an Activity, and it is submitted to and executed by an Engine. Note that a WorkItem cannot be modified after it has been created. ( request only ).
    /// </summary>
    [DataContract]
    public partial class WorkItem 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItem" /> class.
        /// </summary>
        /// <param name="Id">Gets Id..</param>
        /// <param name="ActivityId">Reference to the Activity that this WorkItem will invoke.  Examples: &#x60;MyPlot+Prod&#x60; (an Activity created by the caller) or  &#x60;Autodesk.PlotToPdf&#x60; (an Activity created by someone else and shared with this caller). (required).</param>
        /// <param name="Arguments">Arguments of the WorkItem..</param>
        /// <param name="Signatures">Signatures for various WorkItem attributes..</param>
        public WorkItem(string Id = default(string), string ActivityId = default(string), Argument Arguments = default(Argument), WorkItemSignatures Signatures = default(WorkItemSignatures))
        {
            this.Id = Id;
            this.ActivityId = ActivityId;
            this.Arguments = Arguments;
            this.Signatures = Signatures;
        }
        
        /// <summary>
        /// Gets Id.
        /// </summary>
        /// <value>Gets Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Reference to the Activity that this WorkItem will invoke.  Examples: &#x60;MyPlot+Prod&#x60; (an Activity created by the caller) or  &#x60;Autodesk.PlotToPdf&#x60; (an Activity created by someone else and shared with this caller).
        /// </summary>
        /// <value>Reference to the Activity that this WorkItem will invoke.  Examples: &#x60;MyPlot+Prod&#x60; (an Activity created by the caller) or  &#x60;Autodesk.PlotToPdf&#x60; (an Activity created by someone else and shared with this caller).</value>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Arguments of the WorkItem.
        /// </summary>
        /// <value>Arguments of the WorkItem.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public Argument Arguments { get; set; }

        /// <summary>
        /// Signatures for various WorkItem attributes.
        /// </summary>
        /// <value>Signatures for various WorkItem attributes.</value>
        [DataMember(Name="signatures", EmitDefaultValue=false)]
        public WorkItemSignatures Signatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}