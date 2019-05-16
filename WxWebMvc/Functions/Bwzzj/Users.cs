using Microsoft.EntityFrameworkCore;
using WxWebMvc.Models;

namespace WxWebMvc.Functions.Bwzzj
{
    public class Users : DbContext
    {
        public DbSet<BwzzjModel.T_User> T_User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Data Source=(local);uid=sa;pwd=bwhis8888;DataBase=BWZZJ");
        }

    }


}
