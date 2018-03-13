using EduRp.Service.IService;
using EduRp.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EduRp.WebApi.Controllers
{
    public class MenusController : ApiController
    {
        IMenuService menuService = new MenuService();
        public IHttpActionResult GetMenuList(int? id, int? userid,string token)
        {
            return Ok(new { results = menuService.GetMenuList(id, userid, token) });
        }
    }
}
