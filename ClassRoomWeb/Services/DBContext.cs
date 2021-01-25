using ClassRoomWeb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Services
{
    public class DBContext
    {
        public static IMongoCollection<StudentModel> CollectionStudent { get; set; }
        public static IMongoCollection<TeacherModel> CollectionTeacher { get; set; }
        public static IMongoCollection<ClassRoomModel> CollectionClassRoom { get; set; }

        public static void DbConnection()
        {
            var mongo = new MongoClient("mongodb+srv://chokchai9900:HJ8e6Zg6QhUDoQog@checkindb.83zr9.mongodb.net/CheckinClass?retryWrites=true&w=majority");
            var database = mongo.GetDatabase("CheckInClassroom");
            CollectionStudent = database.GetCollection<StudentModel>("Student");
            CollectionTeacher = database.GetCollection<TeacherModel>("Teacher");
            CollectionClassRoom = database.GetCollection<ClassRoomModel>("Classroom");
        }

        public IMongoCollection<StudentModel> MongoCollectionStudent()
        {
            DbConnection();
            return CollectionStudent;
        }
        public IMongoCollection<TeacherModel> MongoCollectionTeacher()
        {
            DbConnection();
            return CollectionTeacher;
        }
        public IMongoCollection<ClassRoomModel> MongoCollectionClassroom()
        {
            DbConnection();
            return CollectionClassRoom;
        }
    }
}
