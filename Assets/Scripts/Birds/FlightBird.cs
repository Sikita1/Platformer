using UnityEngine;
using DG.Tweening;

public class FlightBird : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private int _speed;

    private void Start()
    {
        transform.DOMoveX(_endPoint.position.x, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
