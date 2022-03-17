using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float speed = 5f;
    public float jumpForce = 5f;
    private SpriteRenderer _dirMirada;
    float _dirX;
    private Rigidbody2D _rbody;
    public bool isGrounded;


    void Awake()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _dirMirada = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _dirX = Input.GetAxisRaw("Horizontal");
        Debug.Log(_dirX);
        if (_dirX == -1)
        {
            _dirMirada.flipX = true;
        } else if(_dirX == 1)
        {
            _dirMirada.flipX = false;
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            _rbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        _rbody.velocity = new Vector2(_dirX * speed, _rbody.velocity.y);
    }
}
