using UnityEngine;
using DG.Tweening;

public class FlightBird : MonoBehaviour
{
    private int _endPoint = -20;
    private int _speed = 25;

    private void Start()
    {
        transform.DOMoveX(_endPoint, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
