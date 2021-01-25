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
        [Display(Name = "ClassRoom Id")]
        public string classRoomId { get; set; }

        [BsonElement("classRoomName")]
        [Display(Name = "Name")]
        public string classRoomName { get; set; }

        [BsonElement("classRoomDiscription")]
        [Display(Name = "Discription")]
        public string classRoomDiscription { get; set; }

        [BsonElement("classRoomSubject")]
        [Display(Name = "Subject")]
        public string classRoomSubject { get; set; }

        [BsonElement("createAt")]
        [Display(Name = "Create At")]
        public DateTime createAt { get; set; }

        [BsonElement("classStudent")]
        [Display(Name = "Student in Class")]
        public List<StudentModel> classStudent { get; set; }

        [BsonElement("classTeacher")]
        [Display(Name = "Teacher in Class")]
        public List<TeacherModel> classTeacher { get; set; }
    }
}
