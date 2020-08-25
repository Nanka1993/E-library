using System.Collections.Generic;
using E_library.Models;

namespace E_library.Services.FilteringService
{
    /// <summary>
    /// Сервис фильтрации для публикаций
    /// </summary>
    public interface IFilteringService<out TResult, in TFilter>
        where TResult : AbstractPublication
    {
        /// <summary>
        /// Возвращает отфильтрованный результат
        /// </summary>
        IEnumerable<TResult> GetPublications(TFilter filter);

    }
}