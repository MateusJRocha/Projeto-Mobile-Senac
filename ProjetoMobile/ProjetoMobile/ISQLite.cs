using SQLite;

namespace ProjetoMobile.Droid
{
    public interface ISQLite
    {
        SQLiteAsyncConnection AcessarDB();
    }
}