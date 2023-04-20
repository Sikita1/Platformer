using System.Collections;
using UnityEngine;

public class SpawnScrolls : MonoBehaviour
{
    [SerializeField] private Scroll _scroll;
    [SerializeField] private int _numberScrolls;
    [SerializeField] private float _interval;

    private WaitForSeconds _delay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        int minInclusive = -8;
        int maxInclusive = 58;
        float positionY = -2.5f;

        _delay = new WaitForSeconds(_interval);

        for (int i = 0; i < _numberScrolls; i++)
        {
            int randomPositionX = Random.Range(minInclusive, maxInclusive);
            Instantiate(_scroll,
                        new Vector2(randomPositionX, positionY),
                        Quaternion.identity);
            yield return _delay;
        }
    }
}
