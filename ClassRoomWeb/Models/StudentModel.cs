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
        [Display(Name = "Id")]
        public string studentId { get; set; }

        [BsonElement("studentName")]
        [Display(Name = "Name")]
        public string studentName { get; set; }

        [BsonElement("checkInAt")]
        [Display(Name = "Check-In Time")]
        public DateTime checkInAt { get; set; }
    }
}
