using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    /// -- Rename Table Using Data Annotations
    //[Table("AuditEntriesForTestRename")]

    /// -- Change Schema Using Data Annotations
   // [Table("AuditEntries", Schema = "TestNewSchema")]
    public class AuditEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
    }
}
