using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.App.Dtos.Common
{
    public class PagedResultDto<T>
    {
        private IReadOnlyList<T> _items;

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public long TotalCount { get; set; }

        public IReadOnlyList<T> Items
        {
            get => _items ??= new List<T>(0);
            set => _items = value;
        }

        public PagedResultDto()
        {
        }

        public PagedResultDto(IReadOnlyList<T> items, int pageIndex, int pageSize, long totalCount)
        {
            Items = items;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
        }
    }
}
