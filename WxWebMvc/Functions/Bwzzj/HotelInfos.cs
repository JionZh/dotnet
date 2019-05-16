using Microsoft.EntityFrameworkCore;
using WxWebMvc.Models;
namespace WxWebMvc.Functions.Bwzzj
{
    public class HotelInfos:DbContext
    {

        public DbSet<BwzzjModel.T_HotelInfo> T_HotelInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Data Source=(local);uid=sa;pwd=bwhis8888;DataBase=BWZZJ");
        }

    }
}
