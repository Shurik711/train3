//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace train3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Train3Entities1 : DbContext
    {
        public Train3Entities1()
            : base("name=Train3Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADRESS> ADRESS { get; set; }
        public virtual DbSet<INFO> INFO { get; set; }
        public virtual DbSet<NACHALSTVO> NACHALSTVO { get; set; }
        public virtual DbSet<PRIBYL> PRIBYL { get; set; }
        public virtual DbSet<RASHODY> RASHODY { get; set; }
        public virtual DbSet<SKLAD> SKLAD { get; set; }
        public virtual DbSet<SOTRUDNIKI> SOTRUDNIKI { get; set; }
        public virtual DbSet<TOVARY> TOVARY { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<ZAKAZY> ZAKAZY { get; set; }
    }
}
