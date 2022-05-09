using System.Collections;
using System.Collections.Generic;

public enum Element
{
    Water,
    Earth,
    Air,
    Fire
}

public class Card
{
    public int Attack {get; private set;}
    public int Defence {get; private set;}
    public int Cost {get; private set;}
    public string Description {get; private set;}
    public string Name {get; private set;}
    public Element Element {get; private set;}
}
