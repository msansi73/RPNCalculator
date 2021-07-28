using System;
using Xunit;

namespace RPNCalculator.Tests
{
    // Entra un numero singolo, esce un numero
    // Somma di due numeri
    // Sottrazione e altre operazioni di due numeri
    // Testare più di un'operazione
    // Caratteri non validi
    public class Class1
    {
        
        [Theory]
        [InlineData("24", 24)]
        [InlineData("25", 25)]
        public void CanParseAnExpression(string inputExpression, double expectedResult)
        {
            double result = VerificaSeNumero(inputExpression);
            Assert.Equal(expectedResult, result);
        }

        private double VerificaSeNumero(string expression)
        {
            return double.Parse(expression);
        }
    }
}
