namespace mayviet.Migrations
{
    using mayviet.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mayviet.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mayviet.Models.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.DM_MoHinhHoatDongs.AddOrUpdate(x => x.Id,
            new DM_MoHinhHoatDong() { TenMoHinhHoatDong = "Jane Austen" , Status = 1, Order = 100},
            new DM_MoHinhHoatDong() { TenMoHinhHoatDong = "Charles Dickens", Status = 1, Order = 100 },
            new DM_MoHinhHoatDong() { TenMoHinhHoatDong = "Miguel de Cervantes", Status = 1, Order = 100 }
        );
        }
    }
}
