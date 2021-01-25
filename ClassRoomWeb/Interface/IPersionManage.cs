using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoomWeb.Interface
{
    interface IPersionManage<T>
    {
        public List<T> Get();
        public T GetById(string id);
        public T Create(T data);
        public void Edit(T TeacherData);
        public void Remove(string TeacherId);
        public void Checkin(string classID, T StudentData);
    }
}
