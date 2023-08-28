namespace CounterSpace;
public class Counter {
    private int count;
    public int Count {
        get{return count;}
        set{if(value >= 0 && 100>=value) count = value;}
    }
    private int max;
    public int Max {
        get;
        set;
    }
    private int min;
    public int Min {
        get;
        set;
    }
    public Counter() {
        Count = 0;
        Min = 0;
        Max = 0;
    }
    public Counter(int min, int max) {
        this.min = min;
        this.max = max;
        Count = min;
    }
    public void increament() {
        if(max > count) {
        Count+=1;

        }
    }
    public void decreament() {
        if(min < count)
        count-=1;
    }
    public override string ToString()
    {
        return count.ToString();
    }
}