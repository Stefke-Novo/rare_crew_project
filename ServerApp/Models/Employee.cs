using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ServerApp.Models
{
    [Table("employee_data")]
    public class Employee
    {
        private DateTime startTimeUTC;
        private DateTime endTimeUTC;
        private int _HoursWorked;
        public Employee() {
            this.Id = "";
            this.EntryNotes = "";
        }

        [Key]
        [Column("id"), StringLength(36), JsonPropertyName("Id")]
        public string Id { get; set; }
        [Column("name"),AllowNull, JsonPropertyName("EmployeeName")]
        public string? Name { get; set; }
        [Column("start_time_utc"), Required, JsonPropertyName("StarTimeUtc")]
        public DateTime StartTimeUTC { get => startTimeUTC; set => startTimeUTC = value; }
        [Column("end_time_utc"), Required, JsonPropertyName("EndTimeUtc")]
        public DateTime EndTimeUTC { get => endTimeUTC; set => endTimeUTC = value; }
        [Column("entry_notes"), Required, JsonPropertyName("EntryNotes")]
        public string EntryNotes { get; set; }
        [Column("deleted_on"), AllowNull, JsonPropertyName("DeletedOn")]
        public DateTime? DeletedOn { get; set; }
        [Column("hours_worked"),JsonIgnore]
        public int HoursWorked {
            get => _HoursWorked;
            set => DateTime.Parse(endTimeUTC.ToLongDateString()).Subtract(DateTime.Parse(startTimeUTC.ToLongDateString()));
        }
    }
}
