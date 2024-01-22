using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Shouldly;
using Xunit;

namespace AElf.Contracts.aelf_devcontainer_template
{
    // This class is unit test class, and it inherit TestBase. Write your unit test code inside it
    public class aelf_devcontainer_templateTests : TestBase
    {
        [Fact]
        public async Task Update_ShouldUpdateMessageAndFireEvent()
        {
            // Arrange
            var inputValue = "Hello, World!";
            var input = new StringValue { Value = inputValue };

            // Act
            await aelf_devcontainer_templateStub.Update.SendAsync(input);

            // Assert
            var updatedMessage = await aelf_devcontainer_templateStub.Read.CallAsync(new Empty());
            updatedMessage.Value.ShouldBe(inputValue);
        }
    }
    
}