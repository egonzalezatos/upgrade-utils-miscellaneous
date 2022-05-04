using System;
using FluentAssertions;
using Upgrade.Utils.Miscellaneous.Exceptions;
using Upgrade.Utils.Miscellaneous.Extensions;
using Xunit;

namespace Upgrade.Utils.Miscellaneous.Test.Extensions
{
    public class StringExtensionTest
    {
        [Fact]
        public void ThrowIfNullOrEmpty_StringNull_ShouldThrowNullException()
        {
            //Arrange
            string s = null;
            
            //Act
            Action act = () => s.ThrowIfNullOrEmpty();
            
            //Assert
            act.Should().Throw<NullException>();
        }
        
        [Fact]
        public void ThrowIfNullOrEmpty_StringEmpty_ShouldThrowEmptyException()
        {
            //Arrange
            string s = "";
            
            //Act
            Action act = () => s.ThrowIfNullOrEmpty();
            
            //Assert
            act.Should().Throw<EmptyException>();
        }
        
        [Theory]
        [InlineData(" ")]
        [InlineData("hola")]
        [InlineData("123")]
        [InlineData("   ")]
        [InlineData("\n")]
        public void ThrowIfNullOrEmpty_String_Should(string s)
        {
            //Act
            Action act = () => s.ThrowIfNullOrEmpty();
            
            //Assert
            act.Should().NotThrow<NullException>();
            act.Should().NotThrow<EmptyException>();
            act.Should().NotThrow();
        }
    }
}