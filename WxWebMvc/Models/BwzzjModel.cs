using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WxWebMvc.Models
{
    public class BwzzjModel
    {
        [Table("T_User")]
        public class T_User
        {
            [Key]
            public int N_ID { get; set; }
            [Required]
            public string C_HotelId { get; set; }
            [Required]
            [MaxLength(10)]
            public string C_Code { get; set; }
            public string C_Name { get; set; }
            public string C_Pwd { get; set; }
            public string C_Phone { get; set; }
            public string C_Title { get; set; }
            public byte I_Status { get; set; }
            public byte I_BonWin { get; set; }
            public string C_OpenID { get; set; }
            public byte I_IsWork { get; set; }

        }

        [Table("T_HotelInfo")]
        public class T_HotelInfo
        {
            [Key]
            public decimal N_ID { get; set; }
            public string C_HotelID{get;set;}
            public string C_HotelName{get;set;}
            public string C_HotelAddr{get;set;}
            public string C_LinkMan{get;set;}
            public string C_LinkPhone{get;set;}
            public string C_Logo{get;set;}
            public DateTime dt_Begin{get;set;}
            public DateTime dt_End{get;set;}
            public byte I_Status{get;set;}
            public DateTime dt_Create{get;set;}
            public string C_UserName{get;set;}
            public byte I_Web{get;set;}
            public string C_WxUrl{get;set;}
            public DateTime Dt_Lastbeat{get;set;}
        }

    }
}
