using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wastelander.Models;
using Xunit;

namespace Wastelander.Tests.ModelTest
{
    public class ItemTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var item = new Item();

            //Act
            item.Name = "gek";
            var result = item.Name;

            //Assert
            Assert.Equal("gek", result);
        }
    }
}
