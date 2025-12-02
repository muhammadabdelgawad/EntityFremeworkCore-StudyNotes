using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    /// -- Rename Table Using Data Annotations
    //[Table("AuditEntriesForTestRename")]

    /// -- Change Table Name & Schema Using Data Annotations
   // [Table("AuditEntriesForTest", Schema = "TestNewSchema")]
    public class AuditEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }

        /// -- Exclude the property  
        // [NotMapped]

        /// -- Change Column Name By Data Annotation
        // [Column("NewNameOfAction")]


        /// -- Add Comment to Column By Data Annotation
        //[Comment("the action of auditentry")]
        public string Action { get; set; }
    }
}
