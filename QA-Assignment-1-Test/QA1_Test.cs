using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using NUnit.Framework;

namespace QA_Assignment_1_Test
{
    [TestFixture]
     class QA1_Test
    {
        [Test]
        public void SetWidth_input3_expectWidthEquals3()
        {
            //Arrange
            int l = 4;
            int w = 3;
//int ln=newln;
            Rectangle testRectangle = new Rectangle();

            //Act
            int newwidth = testRectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(newwidth, 3);

        }

    }
}
