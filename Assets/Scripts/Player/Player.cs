using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _currentHealth;
    private Animator _animator;

    public bool IsDie;

    private void Start()
    {
        IsDie = false;
        _currentHealth = _health;
        _animator = GetComponent<Animator>();
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
            Die();
    }

    private void Die()
    {
        IsDie = true;
        _animator.Play("Die");
    }
}
