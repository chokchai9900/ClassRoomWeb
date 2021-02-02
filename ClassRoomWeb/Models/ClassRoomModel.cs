using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Models
{
    public class ClassRoomModel
    {
        [BsonId]
        [Display(Name = "รหัสห้องเรียน")]
        public string classRoomId { get; set; }

        [BsonElement("classRoomName")]
        //[Required]
        [StringLength(100)]
        [Display(Name = "ชื่อห้อง")]
        public string classRoomName { get; set; }

        [BsonElement("classRoomDiscription")]
        //[Required]
        [StringLength(5000)]
        [Display(Name = "รายละเอียดห้องเรียน")]
        public string classRoomDiscription { get; set; }

        [BsonElement("classRoomSubject")]
        //[Required]
        [StringLength(5000)]
        [Display(Name = "วิชาเรียน")]
        public string classRoomSubject { get; set; }

        [BsonElement("createAt")]
        [Display(Name = "ถูกสร้างขึ้นเมื่อ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
        public DateTime createAt { get; set; }

        [BsonElement("classStudent")]
        [Display(Name = "นักเรียนในห้องเรียน")]
        public List<StudentModel> classStudent { get; set; }

        [BsonElement("classTeacher")]
        [Display(Name = "อาจารย์ที่อยู๋ในห้องเรียน")]
        public List<TeacherModel> classTeacher { get; set; }
    }
}
