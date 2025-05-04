using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAttackTransition : Transition
{
    [SerializeField] private float _transitionRange;

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) <= _transitionRange && Target.IsDie == false)
            NeedTransit = true;
    }
}
