using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    Card Card {get;}

    [SerializeField]
    Text Description {get;}

    [SerializeField]
    Image Image {get;}

    [SerializeField]
    Text Name {get;}

    [SerializeField] 
    Text Attack { get; }

    [SerializeField]
    Text Defence {get;}

    [SerializeField]
    Text Cost {get;}

    void Start()
    {
        Description.text = Card.Description;
        Name.text = Card.Name;
        Attack.text = Card.Attack.ToString();
        Defence.text = Card.Defence.ToString();
        Cost.text = Card.Cost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
