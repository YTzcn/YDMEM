namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
