using System;
using Xunit;

namespace Qwack.Excel.Tests
{
    public class ObjectCacheTests
    {
        [Fact]
        public void CanCreateCache()
        {
            var objectStore = ContainerStores.GetObjectCache<string>();
        }
    }
}
