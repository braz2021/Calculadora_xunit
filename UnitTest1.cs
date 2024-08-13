using Xunit;

namespace calculadora.xunit;

public class UnitTest1
{
    [Fact]
    public void Somar_DeveRetornar5()
    {
        // Definir o valor esperado
        double resultadoEsperado = 5;

        // Criar uma instância da calculadora e definir os valores
        Calculadora calc = new Calculadora()
        {
            num1 = 2,
            num2 = 3
        };

        // Executar a operação de soma
        calc.Somar();

        // Verificar o resultado
        Assert.Equal(resultadoEsperado, calc.resultado);
    }

    [Fact]
    public void Subtrair_DeveRetornar5()
    {
        // Definir o valor esperado
        double resultadoEsperado = 5;

        // Criar uma instância da calculadora e definir os valores
        Calculadora calc = new Calculadora()
        {
            num1 = 7,
            num2 = 2
        };

        // Executar a operação de subtração
        calc.Subtrair();

        // Verificar o resultado
        Assert.Equal(resultadoEsperado, calc.resultado);
    }

    [Theory]
    [InlineData(2, 4, 8)]
    [InlineData(3, 5, 15)]
    [InlineData(7, 4, 28)]
    public void Multiplicar(double num1, double num2, double resultadoEsperado)
    {
        // Criar uma instância da calculadora e definir os valores
        Calculadora calc = new Calculadora()
        {
            num1 = num1,
            num2 = num2
        };

        // Executar a operação de multiplicação
        calc.Multiplicar();

        // Verificar o resultado
        Assert.Equal(resultadoEsperado, calc.resultado);
    }
    [Fact]
    public void Dividir_NaoDeveRetornar5()
    {
        double resultadoNaoEsperado = 5;
        Calculadora cal = new Calculadora()
        {
            num1 = 8,
            num2 = 2
        };
        cal.Dividir();
        Assert.NotEqual(resultadoNaoEsperado, cal.resultado);

    }
}
