using EduRp.Data;
using EduRp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Service.Service
{
    public class MenuService : IMenuService
    {
        encomp_devEntities db = new encomp_devEntities();

        public List<GetMenuList_Result> GetMenuList(int? id,int? userid,string token)
        {
           return db.GetMenuList(id, userid, token).ToList();
        }
    }
}