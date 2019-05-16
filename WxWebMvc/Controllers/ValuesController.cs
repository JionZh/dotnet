using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using WxWebMvc.Models;
using WxWebMvc.Functions.Bwzzj;

namespace WxWebMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }


        //api/Values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                return id.ToString();
            }
            catch (Exception ee)
            {
                return ee.Message.ToString();
            }
        }


        [HttpGet]
        [Route("users")]
        public ActionResult<IEnumerable<BwzzjModel.T_User>> GetUsers()
        {
            Users user = new Users();
            List<BwzzjModel.T_User> module = new List<BwzzjModel.T_User>();
            module = user.T_User.ToList<BwzzjModel.T_User>();
            user.Dispose();
            foreach (var tmp in module)
            {
                tmp.C_Pwd = "";
            }
            return module;
        }

        [HttpGet]
        [Route("users/{id}")]
        public ActionResult<BwzzjModel.T_User> GetUsers(int id)
        {
            BwzzjModel.T_User module = new BwzzjModel.T_User();
            using (Users user = new Users())
            {
                //module = user.T_User.FirstOrDefault(f => f.N_ID == id);
                module = user.T_User.Find(id);
                if (module != null)
                    module.C_Pwd = "";
            }
            return module;
        }

        [HttpGet]
        [Route("hotelinfos")]
        public ActionResult<IEnumerable<BwzzjModel.T_HotelInfo>> GetHotelInfos()
        {
            HotelInfos hotelinfo = new HotelInfos();
            List<BwzzjModel.T_HotelInfo> module = new List<BwzzjModel.T_HotelInfo>();
            module = hotelinfo.T_HotelInfo.ToList<BwzzjModel.T_HotelInfo>();
            hotelinfo.Dispose();
            return module;
        }

    }
}
