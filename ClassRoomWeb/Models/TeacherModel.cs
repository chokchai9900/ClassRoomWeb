using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Models
{
    public class TeacherModel
    {
        [BsonId]
        [Display(Name = "Teacher Id")]
        public string teacherId { get; set; }

        [BsonElement("teacherName")]
        [Display(Name = "Name")]
        public string teacherName { get; set; }

        [BsonElement("teacherTel")]
        [Display(Name = "Tel.")]
        public string teacherTel { get; set; }

        [BsonElement("subjectTaught")]
        [Display(Name = "Subject")]
        public string subjectTaught { get; set; }
    }
}
