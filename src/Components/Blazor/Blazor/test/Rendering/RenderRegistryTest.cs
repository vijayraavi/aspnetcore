using System;
using Xunit;

namespace Microsoft.AspNetCore.Blazor.Rendering
{
    public class RenderRegistryTest
    {
        [Fact]
        public void RendererRegistry_Find_ThrowsErrorOnNonWASM()
        {
            // Act
            Exception ex = Assert.Throws<InvalidOperationException>(() => RendererRegistry.Find(123));

            // Assert
            Assert.Equal("Renderer registry can only be modified from WebAssembly runtime.", ex.Message);
        }
    }
}
