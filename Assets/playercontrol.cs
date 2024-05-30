using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Awake ()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _rigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
    }
}

