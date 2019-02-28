using ProjetoMobile;
using ProjetoMobile.Droid;
using SQLite;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(IandroidSQLite))]
namespace ProjetoMobile
{
    public class IandroidSQLite : ISQLite
    {
        public SQLiteAsyncConnection AcessarDB()
        {
            var pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var banco = Path.Combine(pasta, "AppSQLite.db");

            return new SQLiteAsyncConnection(banco);
        }

    }
}
