using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    private const string Run = "Run";
    private const string Jump = "Jump";

    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Transform _feetPosition;
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private float _checkRadius;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _moveInput;
    [SerializeField] private float _speed;

    private Animator _animator;
    private bool _facingRight = true;
    private bool _isGrounded;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
        _isGrounded = Physics2D.OverlapCircle(_feetPosition.position, _checkRadius, _whatIsGround);

        RunPlayer();
        JumpPlayer();
        TurnPlayer();
    }

    private void RunPlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);

            RunAnimPlayer();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);

            RunAnimPlayer();
        }
        else
        {
            StopAnimPlayer();
        }
    }

    private void JumpPlayer()
    {
        if (_isGrounded == true && Input.GetKey(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _animator.SetBool(Jump, true);
        }
        else
        {
            _animator.SetBool(Jump, false);
        }
    }

    private void TurnPlayer()
    {
        if (!_facingRight && _moveInput > 0)
            Flip();
        else if (_facingRight && _moveInput < 0)
            Flip();
    }

    private void RunAnimPlayer()
    {
        if (_isGrounded == true)
            _animator.SetBool(Run, true);
    }

    private void StopAnimPlayer()
    {
        _animator.SetBool(Run, false);
    }

    private void Flip()
    {
        _facingRight = !_facingRight;
        Vector2 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
