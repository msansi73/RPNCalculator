using System;
using System.Diagnostics;
using System.Linq;

using Xunit;

namespace RPNCalculator.Tests
{
    // Sottrazione e altre operazioni di due numeri
    // Testare più di un'operazione
    // Caratteri non validi
    // Gestire risultati negativi
    // Gestire input negativi
    // Controllare divisioni per zero
    public class Class1
    {

        [Theory]
        [InlineData("24", 24)]
        [InlineData("25", 25)]
        [InlineData("2 3 +", 5)]
        [InlineData("7 1 -", 6)]
        [InlineData("2 8 *", 16)]
        [InlineData("6 2 /", 3)]
        public void CanParseAnExpression(string inputExpression, double expectedResult)
        {
            double result = EvaluateExpression(inputExpression);
            Assert.Equal(expectedResult, result);
        }

        private static double EvaluateExpression(string expression)
        {
            var items = expression.Split(" ");

            var firstValue = double.Parse(items.ElementAt(0));
            
            if (items.Length == 1) return firstValue;
            
            var secondValue = double.Parse(items.ElementAt(1));

            return DoArithmetics(firstValue, secondValue, items.ElementAt(2));
        }

        private static double DoArithmetics(double firstValue, double secondValue, string operation)
        {
            return operation switch
            {
                "+" => firstValue + secondValue,
                "-" => firstValue - secondValue,
                "*" => firstValue * secondValue,
                "/" => firstValue / secondValue,
                _ => firstValue
            };
        }
    }
}
