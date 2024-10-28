using IdentityValidator.Models.Swedish;


namespace IdentityValidator.Tests;

public class UnitTest1
{
    public class SwedishPersonalIdentityNumberTests
    {
        [Fact]
        public void Valid_PersonalIdentityNumber_Should_Return_True()
        {
            // Arrange
            var personalIdentityNumber= new SwedishPersonalIdentityNumber("810724-9289");

            // Act
            bool isValid = personalIdentityNumber.IsValid();

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void Invalid_PersonalIdentityNumber_Should_Return_False()
        {
            // Arrange
            var personalIdentityNumber = new SwedishPersonalIdentityNumber("810724-9999");

            // Act
            bool isValid = personalIdentityNumber.IsValid();

            // Assert
            Assert.False(isValid);
        }
    }
}