using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
    public interface IMenuService
    {
        List<GetMenuList_Result> GetMenuList(int? id, int? userid, string token);
    }
}
