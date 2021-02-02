using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Models
{
    public class StudentModel
    {
        [BsonId]
        [Required]
        [Display(Name = "เลขประจำตัวนักศึกษา")]
        public string studentId { get; set; }

        [BsonElement("studentName")]
        [Required]
        [StringLength(100)]
        [Display(Name = "ชื่อนักศึกษา")]
        public string studentName { get; set; }

        [BsonElement("checkInAt")]
        [Display(Name = "เวลาลงชื่อ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
        public DateTime checkInAt { get; set; }
    }
}
