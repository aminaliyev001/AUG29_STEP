using System.ComponentModel;

namespace Calc;
public class Calculator {

    private double result;
    public double Result {
        get;
        set;
    }
    public Calculator() {
        result = 0;
    }
    public double add(int number1, int number2,bool save = true) {
        if(save == false)
            result = 0;
        return result+number1+number2;
    }
    public double subtract(int number1, int number2, bool save = true) {
        if(save == false)
            result = 0;
        return number1-number2;
    }
    public double multiple(int number1, int number2, bool save = true) {
        if(save == false)
            result = 0;
        return number1*number2;
    }
    public double divide(int number1, int number2, bool save = true) {
        if(save == false)
            result = 0;
        return number1/number2;
    }
    public void print_last_result() {
        Console.WriteLine(result);
    }
    public double last_result() {
        return result;
    }
};