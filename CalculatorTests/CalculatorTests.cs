using FluentAssertions;
using MindboxCodeTask_GeometryCalc;
using System;
using Xunit;

namespace TestMindboxCalculatorTask.CalculatorTests
{
    public class AreaCalcTest
    {
        private readonly GeometryCalc _geometryCalc;
        public AreaCalcTest() 
        {
            //SUT
            _geometryCalc = new GeometryCalc();

        }
        [Fact]
        public void GeometryCalc_GiveUserAnswer_ReturnInputMessage()
        {
            //Arrange
            //Act
            var result = _geometryCalc.GiveUserAnswer("This is the correct answer.");
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<string>();
            result.Should().Be("This is the correct answer.");
        }
        [Fact]
        public void GeometryCalc_AreaOfCircle_ReturnCorrectValueInDecimal()
        {
            //Arrange
            //Act
            var result = _geometryCalc.AreaOfCircle(5);
            //Assert
            result.Should().Be((decimal)25);
        }

        [Fact]
        public void GeometryCalc_AreaOfTriangle_ReturnCorrectValueInDecimal()
        {
            //Arrange
            //Act
            var result = _geometryCalc.AreaOfTriangle(5,5,5);
            //Assert
            result.Should().Be((decimal)10.8253175473055);

        }

        [Fact]
        public void GeometryCalc_TriangleIsRightAngled_ReturnCorrectBoolSolution()
        {
            //Arrange
            //Act
            var resultTrue = _geometryCalc.TriangleIsRightAngled(3,4,5);
            var resultFalse = _geometryCalc.TriangleIsRightAngled(5, 5, 10);
            //Assert
            resultTrue.Should().Be(true);
            resultFalse.Should().Be(false);

        }

    }
}