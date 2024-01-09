using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Jira.Net.Lib.Models.Issue;

/// <summary>
/// The list of issue type IDs.
/// </summary>
[DataContract]
public partial class IssueTypeIds : IEquatable<IssueTypeIds>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IssueTypeIds" /> class.
    /// </summary>
    /// <param name="issueTypeIds">The list of issue type IDs. (required).</param>
    public IssueTypeIds(List<string>? issueTypeIds = default)
    {
        // to ensure "issueTypeIds" is required (not null)
        if (issueTypeIds == null)
        {
            throw new InvalidDataException("issueTypeIds is a required property for IssueTypeIds and cannot be null");
        }
        else
        {
            this._IssueTypeIds = issueTypeIds;
        }
    }

    /// <summary>
    /// The list of issue type IDs.
    /// </summary>
    /// <value>The list of issue type IDs.</value>
    [DataMember(Name = "issueTypeIds", EmitDefaultValue = false)]
    public List<string> _IssueTypeIds { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IssueTypeIds {\n");
        sb.Append("  _IssueTypeIds: ").Append(_IssueTypeIds).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return this.Equals(input as IssueTypeIds);
    }

    /// <summary>
    /// Returns true if IssueTypeIds instances are equal
    /// </summary>
    /// <param name="input">Instance of IssueTypeIds to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IssueTypeIds input)
    {
        if (input == null)
            return false;

        return
            (
                this._IssueTypeIds == input._IssueTypeIds ||
                this._IssueTypeIds != null &&
                input._IssueTypeIds != null &&
                this._IssueTypeIds.SequenceEqual(input._IssueTypeIds)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            int hashCode = 41;
            if (this._IssueTypeIds != null)
                hashCode = hashCode * 59 + this._IssueTypeIds.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }
}
