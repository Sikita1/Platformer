using System.Collections;
using UnityEngine;

public class SpawnScrolls : MonoBehaviour
{
    [SerializeField] private Scroll _scroll;
    [SerializeField] private int _numberScrolls;
    [SerializeField] private float _interval;

    [SerializeField] private Transform _leftEdge;
    [SerializeField] private Transform _rightEdge;

    private WaitForSeconds _delay;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        _delay = new WaitForSeconds(_interval);

        for (int i = 0; i < _numberScrolls; i++)
        {
            int randomPositionX = Random.Range((int)_leftEdge.position.x, (int)_rightEdge.position.x);
            Instantiate(_scroll,
                        new Vector2(randomPositionX, _rightEdge.position.y),
                        Quaternion.identity);
            yield return _delay;
        }
    }
}
