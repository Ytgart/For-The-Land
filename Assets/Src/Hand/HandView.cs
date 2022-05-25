using System.Collections.Generic;
using UnityEngine;

public class HandView : MonoBehaviour
{
    public void PlaceCardsWithRotation(List<GameObject> cards)
    {
        var zCoord = 0;
        var cardsCount = cards.Count;
        var rotationAngle = 4f;

        foreach (var item in cards)
        {
            var transform = item.transform;
            transform.SetParent(this.transform);
            transform.SetSiblingIndex(zCoord);

            if (cards.Count == 1)
            {
                transform.rotation = Quaternion.Euler(-25, 0, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(-25, 0, rotationAngle);
            }
            rotationAngle -= 8f / (cardsCount - 1);

            item.GetComponent<Canvas>().sortingOrder = zCoord;
            zCoord++;
        }

    }
}
