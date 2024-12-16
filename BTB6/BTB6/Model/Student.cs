namespace BTB6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string StudentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 2)]
        public double AverageScore { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FacultyID { get; set; }
    }
}
