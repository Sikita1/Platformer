using UnityEngine;
using DG.Tweening;

public class LevitationScrolls : MonoBehaviour
{
    private Tween _tween;

    private void Start()
    {
        _tween = transform.DOMoveY(-1.6f, 1).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        _tween.Kill();
    }
}
