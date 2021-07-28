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
    public class Class1
    {
        
        [Theory]
        [InlineData("24", 24)]
        [InlineData("25", 25)]
        [InlineData("2 3 +", 5)]
        [InlineData("7 1 -", 6)]
        public void CanParseAnExpression(string inputExpression, double expectedResult)
        {
            double result = VerificaSeNumero(inputExpression);
            Assert.Equal(expectedResult, result);
        }

        private double VerificaSeNumero(string expression)
        {
            var items = expression.Split(" ");

            var n1 = items.ElementAt(0);
            var n2 = items.ElementAtOrDefault(1);

            if (items.Length == 3)
            {
                switch (items.ElementAt(2))
                {
                    case "+":
                        return double.Parse(n1) + double.Parse(n2 ?? "0");
                    case "-":
                        return double.Parse(n1) - double.Parse(n2 ?? "0");

                }
            }

            return double.Parse(n1);
           

            
        }
    }
}
