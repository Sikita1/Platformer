using UnityEngine;
using DG.Tweening;

public class LevitationScrolls : MonoBehaviour
{
    Tween tween;

    private void Start()
    {
        tween = transform.DOMoveY(-1.6f, 1).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        tween.Kill();
    }
}
