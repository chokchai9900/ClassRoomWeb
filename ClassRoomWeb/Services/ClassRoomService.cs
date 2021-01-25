using ClassRoomWeb.Interface;
using ClassRoomWeb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Services
{
    public class ClassRoomService : IClassRoomRepository<ClassRoomModel>
    {
        static readonly DBContext _dBContext = new DBContext();
        public IMongoCollection<StudentModel> ConnectStudentCollection { get; set; }
        public IMongoCollection<TeacherModel> ConnectTeacherCollection { get; set; }
        public IMongoCollection<ClassRoomModel> ConnectClassRoomCollection { get; set; }

        public static DBContext DBContext => _dBContext;

        public ClassRoomService()
        {
            ConnectStudentCollection = _dBContext.MongoCollectionStudent();
            ConnectTeacherCollection = _dBContext.MongoCollectionTeacher();
            ConnectClassRoomCollection = _dBContext.MongoCollectionClassroom();
        }

        public void AddStudentInClassByClassRoomIdAsync(string classId, StudentModel std)
        {
            std.checkInAt = DateTime.Now;
            if (std == null || classId == null)
            {
                throw new ArgumentNullException("data");
            }
            var classRoom = ConnectClassRoomCollection.Find(it => it.classRoomId == classId).FirstOrDefault();
            var validate = classRoom.classStudent.Find(it => it.studentId == std.studentId);
            var addindex = classRoom.classStudent.Count();
            if (validate == null)
            {
                classRoom.classStudent.Add(std);
                var def = Builders<ClassRoomModel>.Update
                    .Set(x => x.classStudent, classRoom.classStudent);
                ConnectClassRoomCollection.UpdateOne(it => it.classRoomId == classRoom.classRoomId, def);
            }
        }
        public void AddTeacherInClassByClassRoomId(string classId, string teacherId)
        {
            if (teacherId == null || classId == null)
            {
                throw new ArgumentNullException("data");
            }
            var classRoom = ConnectClassRoomCollection.Find(it => it.classRoomId == classId).FirstOrDefault();
            var teacher = ConnectTeacherCollection.Find(it => it.teacherId == teacherId).FirstOrDefault();
            var validate = classRoom.classTeacher.Find(it => it.teacherId == teacherId);
            if (validate == null)
            {
                classRoom.classTeacher.Add(teacher);
                var def = Builders<ClassRoomModel>.Update
                    .Set(x => x.classTeacher, classRoom.classTeacher);
                ConnectClassRoomCollection.UpdateOne(it => it.classRoomId == classRoom.classRoomId, def);
            }
        }
        public ClassRoomModel CreateClassRoom(ClassRoomModel classroom)
        {
            var dateNumber = ($"{DateTime.Now.Millisecond.ToString()}{DateTime.Now.TimeOfDay.ToString()}");
            var splitString = dateNumber.Split(":");
            string uniqueNumber = "";
            foreach (var item in splitString)
            {
                uniqueNumber = uniqueNumber + item;
            }
            var newRoom = new ClassRoomModel()
            {
                classRoomId = uniqueNumber,
                classRoomName = classroom.classRoomName,
                classRoomDiscription = classroom.classRoomDiscription,
                classRoomSubject = classroom.classRoomSubject,
                classStudent = new List<StudentModel>(),
                classTeacher = new List<TeacherModel>(),
                createAt = DateTime.Now
            };
            ConnectClassRoomCollection.InsertOne(newRoom);
            return newRoom;
        }
        public List<ClassRoomModel> GetClassRoom()
        {
            return ConnectClassRoomCollection.Find(it => true).ToList();
        }
        public ClassRoomModel GetDataByClassRoomId(string id)
        {
            return ConnectClassRoomCollection.Find(it => it.classRoomId == id).FirstOrDefault();
        }
        public void RemoveClassRoom(string ClassRoomId)
        {
            ConnectClassRoomCollection.DeleteOne(it => it.classRoomId == ClassRoomId);
        }

        public void Edit(string id, ClassRoomModel data)
        {
            ConnectClassRoomCollection.ReplaceOne(it => it.classRoomId == id, data);
        }
    }
}
