using UnityEngine;
using DG.Tweening;

public class LevitationScrolls : MonoBehaviour
{
    private Tween _tween;
    private float _upperBoundary = -1.6f;
    private float _speed = 1f;

    private void Start()
    {
        _tween = transform.DOMoveY(_upperBoundary, _speed).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        _tween.Kill();
    }
}
