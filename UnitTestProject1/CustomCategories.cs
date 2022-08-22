using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class PlayDefaultAttribute : TestCategoryBaseAttribute
    {
        public override IList<string> TestCategories => new[] { "Player Default"};
    }
}
