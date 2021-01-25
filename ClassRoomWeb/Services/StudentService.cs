using ClassRoomWeb.Interface;
using ClassRoomWeb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Services
{
    public class StudentService : IPersionManage<StudentModel>
    {
        static readonly DBContext _dBContext = new DBContext();
        private IMongoCollection<StudentModel> connectStudentCollection = DBContext.MongoCollectionStudent();
        private IMongoCollection<ClassRoomModel> connectClassroomCollection = DBContext.MongoCollectionClassroom();

        public static DBContext DBContext => _dBContext;

        public IMongoCollection<StudentModel> ConnectStudentCollection { get => connectStudentCollection; set => connectStudentCollection = value; }

        public void Checkin(string classID, StudentModel StudentData)
        {
            var getClassRoom = connectClassroomCollection.Find(it => it.classRoomId == classID).FirstOrDefault();
            if (getClassRoom == null)
            {
                throw new ArgumentNullException("data");
            }
            else
            {
                var filter = Builders<ClassRoomModel>.Filter.Where(x => x.classRoomId == classID);
                var update = Builders<ClassRoomModel>.Update.Push(x => x.classStudent, StudentData);
                var result = connectClassroomCollection.UpdateOneAsync(filter, update).Result;
                var x = 1;
            }
        }

        public StudentModel Create(StudentModel data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            ConnectStudentCollection.InsertOne(data);
            return data;
        }

        public void Edit(StudentModel stdData)
        {
            if (stdData == null)
            {
                throw new ArgumentNullException("data");
            }
            var def = Builders<StudentModel>.Update
                .Set(x => x.studentId, stdData.studentId)
                .Set(x => x.studentName, stdData.studentName);
            ConnectStudentCollection.UpdateOne(x => x.studentId == stdData.studentId, def);
        }

        public List<StudentModel> Get()
        {
            return ConnectStudentCollection.Find(it => true).ToList();
        }

        public StudentModel GetById(string id)
        {
            return ConnectStudentCollection.Find(it => it.studentId == id).FirstOrDefault();
        }

        public void Remove(string stdId)
        {
            ConnectStudentCollection.DeleteMany(it => it.studentId == stdId);
        }

        //public string StudentCheckIn(StudentModel student,string classRoomId)
        //{
        //    var getClassRoom = connectClassroomCollection.Find(it => it.classRoomId == classRoomId).FirstOrDefault();
        //    if (getClassRoom == null)
        //    {
        //        return "Fail Process";
        //    }
        //    else
        //    {
        //        var filter = Builders<ClassRoomModel>.Filter.Where(x => x.classRoomId == classRoomId);
        //        var update = Builders<ClassRoomModel>.Update.Set(x => x.classStudent[-1], student);
        //        var result = connectClassroomCollection.UpdateOneAsync(filter, update).Result;
        //    }

        //    return "Success";
        //}
    }
}
