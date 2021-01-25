using ClassRoomWeb.Interface;
using ClassRoomWeb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Services
{
    public class TeacherService : IPersionManage<TeacherModel>
    {
        static readonly DBContext _dBContext = new DBContext();
        public IMongoCollection<TeacherModel> ConnectTeacherCollection { get; set; }

        public static DBContext DBContext => _dBContext;

        public TeacherService()
        {
            ConnectTeacherCollection = _dBContext.MongoCollectionTeacher();
        }
        public TeacherModel Create(TeacherModel data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            ConnectTeacherCollection.InsertOne(data);
            return data;
        }

        public void Edit(TeacherModel TeacherData)
        {
            if (TeacherData == null)
            {
                throw new ArgumentNullException("item");
            }
            var def = Builders<TeacherModel>.Update
                .Set(x => x.teacherId, TeacherData.teacherId)
                .Set(x => x.teacherName, TeacherData.teacherName)
                .Set(x => x.teacherTel, TeacherData.teacherTel)
                .Set(x => x.subjectTaught, TeacherData.subjectTaught);
            ConnectTeacherCollection.UpdateOne(x => x.teacherId == TeacherData.teacherId, def);
        }

        public List<TeacherModel> Get()
        {
            return ConnectTeacherCollection.Find(it => true).ToList();
        }

        public TeacherModel GetById(string id)
        {
            return ConnectTeacherCollection.Find(it => it.teacherId == id).FirstOrDefault();
        }

        public void Remove(string TeacherId)
        {
            ConnectTeacherCollection.DeleteMany(it => it.teacherId == TeacherId);
        }

        public void Checkin(string classID, TeacherModel StudentData)
        {
            throw new NotImplementedException();
        }
    }
}
