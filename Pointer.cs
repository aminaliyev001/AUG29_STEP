namespace PointerSpace;
public class Pointer {
    private int x;
    public int X {
        get {return x;}
        set {if (value != 0) x = value;}
    }
    private int y;
    public int Y {
        get {return y;}
        set {if (value != 0) y = value;}
    }
    Pointer() {
        X = 1;
        Y = 1;
    }
    public Pointer(int x, int y) {
        Y = y;
        X = x;
    }
    public void showMethod() {
    Console.WriteLine($"X: {x} ve Y: {y}");
    }
    public override string ToString()
    {
        return $"X: {x} ve Y: {y}";
    }
}