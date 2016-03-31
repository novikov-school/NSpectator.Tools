using System.Collections.Generic;
using Gallio.Model;
using Gallio.Runtime.Extensibility;
using Gallio.Runtime.Logging;
using NSpectator.GallioPlugin.Services;

namespace NSpectator.GallioPlugin
{
    /// <summary>
    /// Builds a test object model based on reflection against NUnit framework attributes.
    /// </summary>
    public class NSpectatorTestFramework : BaseTestFramework
    {
        /// <inheritdoc />
        public sealed override TestDriverFactory GetTestDriverFactory()
        {
            return CreateTestDriver;
        }

        private static ITestDriver CreateTestDriver(
            IList<ComponentHandle<ITestFramework, TestFrameworkTraits>> testFrameworkHandles,
            TestFrameworkOptions testFrameworkOptions,
            ILogger logger)
        {
            return new NSpectatorTestDriver();
        }
    }
}
