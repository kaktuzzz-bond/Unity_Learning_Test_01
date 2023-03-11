using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Shape : MonoBehaviour
{
    protected Vector2 Direction;

    protected float Speed = 10f;

    protected abstract void ChangeAppearance();

    private Rigidbody2D _rb;

    protected void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Direction = Random.insideUnitCircle.normalized;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Direction = Vector2.Reflect(Direction, col.contacts[0].normal);
        ChangeAppearance();
    }

    private void FixedUpdate()
    {
        _rb.velocity = Direction * Speed;
    }
}