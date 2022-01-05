using SQLite.CodeFirst;
using System.Data.Entity;

namespace Exercicio_1
{
    class MeuContexto: DbContext
    {
        public MeuContexto()
        : base("C:\\Users\\USUARIO\\Documents\\meuDb.db") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MeuContexto>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<Compra> Compras { get; set; }
        public  DbSet<Produto> Pecas { get; set; }

    }
}
