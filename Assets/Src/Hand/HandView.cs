using System.Collections.Generic;
using UnityEngine;

public class HandView : MonoBehaviour
{
    [SerializeField]
    private float _circleRadius;

    public void PlaceCardRounded(List<GameObject> cards)
    {
        var cardsCount = cards.Count;

        var angleToRotate = 20f / cardsCount;
        var startAngle = 80f;
        var rotationAngle = -10f;
        var zCoord = 0;

        foreach (var item in cards)
        {
            item.transform.position = GetCoordinatesByAngle(startAngle);

            if (cards.Count > 4)
            {
                item.transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
            }

            item.GetComponent<Canvas>().sortingOrder = zCoord;

            startAngle += angleToRotate;
            rotationAngle += 2.5f;
            zCoord--;

        }
    }

    private Vector3 GetCoordinatesByAngle(float angle)
    {
        var x = gameObject.transform.position.x + _circleRadius * Mathf.Cos(angle * (Mathf.PI / 180));
        var y = gameObject.transform.position.y + _circleRadius * Mathf.Sin(angle * (Mathf.PI / 180));

        return new Vector3(x, y, 0);
    }
}
