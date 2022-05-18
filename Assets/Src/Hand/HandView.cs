using System.Collections.Generic;
using UnityEngine;

public class HandView : MonoBehaviour
{
    [SerializeField]
    private float _circleRadius;

    public void PlaceCardsWithRotation(List<GameObject> cards)
    {
        var zCoord = 0;
        var cardsCount = cards.Count;
        var rotationAngle = 4f;

        if (cardsCount >= 4)
        {
            foreach (var item in cards)
            {
                item.transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
                item.GetComponent<Canvas>().sortingOrder = zCoord;

                rotationAngle -= 8f / (cardsCount - 1);
                zCoord--;
            }
        }
    }

    private Vector3 GetCoordinatesByAngle(float angle)
    {
        var x = gameObject.transform.position.x + _circleRadius * Mathf.Cos(angle * (Mathf.PI / 180));
        var y = gameObject.transform.position.y + _circleRadius * Mathf.Sin(angle * (Mathf.PI / 180));

        return new Vector3(x, y, 0);
    }
}
