using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 5f;
	private Vector2 _movement;
	private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);
        _rb.linearVelocity = _movement * _moveSpeed;
    }
}
