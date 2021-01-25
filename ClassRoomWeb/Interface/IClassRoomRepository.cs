using ClassRoomWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Interface
{
    interface IClassRoomRepository<T>
    {
        public List<T> GetClassRoom();
        public T GetDataByClassRoomId(string id);
        public T CreateClassRoom(T classroom);
        public void AddTeacherInClassByClassRoomId(string classId, string teacherId);
        public void AddStudentInClassByClassRoomIdAsync(string classId, StudentModel std);
        public void Edit(string id, T data);
        void RemoveClassRoom(string ClassRoomId);
    }
}
