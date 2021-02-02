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
        [Display(Name = "รหัสอาจารย์")]
        public string teacherId { get; set; }

        [BsonElement("teacherName")]
        [Required]
        [StringLength(100)]
        [Display(Name = "ชื่ออาจารย์")]
        public string teacherName { get; set; }

        [BsonElement("teacherTel")]
        [Required]
        [Phone]
        [Display(Name = "เบอร์โทรศัพท์อาจารย์")]
        public string teacherTel { get; set; }

        [BsonElement("subjectTaught")]
        [Required]
        [StringLength(100)]
        [Display(Name = "รายวิชาที่รับผิดชอบ")]
        public string subjectTaught { get; set; }
    }
}
