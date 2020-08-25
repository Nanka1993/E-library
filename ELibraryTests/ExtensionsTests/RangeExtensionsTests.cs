using E_library.Dto;
using E_library.Dto.Filters;
using E_library.Extensions;
using E_library.Models;
using ELibraryTests.InstanciatedTestData;
using System.Linq;
using Xunit;

namespace ELibraryTests.ExtensionsTests
{
    public class RangeExtensionsTests
    {
        private static readonly IQueryable<Book> books = BookData.GetItems()
            .AsQueryable();

        [Fact]
        public void AddYearRangeFilter_FilterIsNull_ReturnsNotNull()
        {
            //act
            var actual = books.AddYearRangeFilter(null);

            //assert
            Assert.NotNull(actual);
        }

        [Fact]
        public void AddPageRangeFilter_FilterIsNull_ReturnsNotNull()
        {
            //act
            var actual = books.AddPageRangeFilter(null);

            //assert
            Assert.NotNull(actual);
        }

        [Fact]
        public void AddPageRangeFilter_GteNullAndLteNull_ReturnsFullList()
        {
            //arrange
            var expectedCount = books.Count();
            var filter = new BookFilter
            {
                PageRange = new IntRange
                {

                    Gte = null,
                    Lte = null
                }
            };
            //act
            var actual = books.AddPageRangeFilter(filter.PageRange);

            //assert
            Assert.Equal(expectedCount, actual.Count());
        }

        [Fact]
        public void AddYearRangeFilter_GteNullAndLteNull_ReturnsFullList()
        {
            //arrange
            var expectedCount = books.Count();
            var filter = new MagazineFilter
            {
                YearRange = new IntRange
                {
                    Gte = null,
                    Lte = null
                }
            };
            //act
            var actual = books.AddPageRangeFilter(filter.YearRange);

            //assert
            Assert.Equal(expectedCount, actual.Count());
        }
    }
}
