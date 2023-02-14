using NUnit.Framework;
using System;

namespace Task_16_7_Practice.Tests
{
	[TestFixture]
	public class CalculatorTests
	{
		[Test]
		public void AdditionalMustReturnNotNullValue()
		{
			var calculator = new Calculator();
			Assert.True(calculator.Additional(7, 3) == 10);
		}

		[Test]
		public void SubtractionMustReturnNotNullValue()
		{
			var calculator = new Calculator();
			Assert.AreEqual(calculator.Subtraction(7, 3), 4);
		}

		[Test]
		public void MiltiplicationMustReturnNotNullValue()
		{
			var calculator = new Calculator();
			Assert.That(calculator.Miltiplication(7, 3) == 21);
		}

		[Test]
		public void DivisionMustReturnNotNullValue()
		{
			var calculator = new Calculator();
			Assert.That(calculator.Division(5, 2) == 2);
		}

		[Test]
		public void DivisionMustThrowException()
		{
			var calculator = new Calculator();
			Assert.Throws<DivideByZeroException>(() => calculator.Division(1, 0));
		}
	}
}
