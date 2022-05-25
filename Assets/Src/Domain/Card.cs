using UnityEngine;

public enum Element
{
    Water,
    Earth,
    Air,
    Fire
}

[CreateAssetMenu(menuName = "Cards/DefaultCard")]
public class Card : ScriptableObject
{
    public string Name;
    public string Description;
    public int Attack;
    public int Health;
    public int Cost;
    public Element Element;
    public Sprite Image;
}
