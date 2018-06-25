[FeatureFile("./Calculator.feature")]
public sealed class AddTwoNumbers : Feature
{
    private int _firstNumber;
    private int _secondNumber;
    private int _result;

    [Given(@"I chose (\d+) as first number")]
    public void I_chose_first_number(int firstNumber)
    {
        _firstNumber = firstNumber;
    }

    [And(@"I chose (\d+) as second number")]
    public void I_chose_second_number(int secondNumber)
    {
        _secondNumber = secondNumber;
    }

    [When(@"I press add")]
    public void I_press_add()
    {
        _result = _firstNumber + _secondNumber;
    }

    [Then(@"the result should be (\d+) on the screen")]
    public void The_result_should_be_z_on_the_screen(int expectedResult)
    {
        Assert.Equal(expectedResult, _result);
    }
}