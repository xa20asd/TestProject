using UnityEngine;

public class 練習_10 :MonoBehaviour
{
    private void Start()
    {
        var redWater = new Water("紅水");
        var blueWater = new Water("藍水");
        var helmet = new Equipment("頭盔");

        redWater.inheritinfo();
        blueWater.info(50);
        helmet.info();
    }
}

public class Tool
{
    public string name;

    public Tool(string name1)
    { 
        name = name1;
    }
    public virtual void info()
    {
        Debug.Log($"使用{name}");
    }
}

public class Water : Tool
{
    public Water(string name1) : base(name1)
    { 
    }
    public void info(int mp)
    {
        Debug.Log($"使用{name}，補了{mp}點魔力");
    }
    public void inheritinfo()
    {
        Debug.Log($"使用{base.name}");
    }

}

public class Equipment : Tool
{
    public Equipment(string name1) : base(name1)
    {
    }
    public override void info()
    {
        //base.info();
        Debug.Log($"戴上{name}");
    }
}

