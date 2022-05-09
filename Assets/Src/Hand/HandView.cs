using System.Collections.Generic;
using UnityEngine;

public class HandView : MonoBehaviour
{
    [SerializeField]
    private float _circleRadius;

    [SerializeField]
    private List<GameObject> _cards = new();

    private void Start()
    {
        PlaceCardRounded(_cards.Count - 1);
    }

    private void PlaceCardRounded(int cardsCount)
    {
        var angleToRotate = 130f / cardsCount;
        var currentAngle = 25f;
        var rotationAngle = -40f;

        foreach (var item in _cards)
        {
            item.transform.SetPositionAndRotation(
                GetCoordinatesByAngle(currentAngle),
                Quaternion.Euler(0, 0, rotationAngle)
                );

            currentAngle += angleToRotate;
            rotationAngle += 10f;
        }
    }

    private Vector3 GetCoordinatesByAngle(float angle)
    {
        var x = gameObject.transform.position.x + _circleRadius * Mathf.Cos(angle * (Mathf.PI / 180));
        var y = gameObject.transform.position.y + _circleRadius * Mathf.Sin(angle * (Mathf.PI / 180));

        return new Vector3(x, y, 0);
    }
}
