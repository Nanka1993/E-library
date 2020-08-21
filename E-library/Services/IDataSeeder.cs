namespace E_library.Services
{
    /// <summary>
    /// Заполнение начальными данными
    /// </summary>
    public interface IDataSeeder
    {
        /// <summary>
        /// Заполняет начальными данными
        /// </summary>
        string Seed();
    }
}