using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOyunController : MonoBehaviour
{
    [SerializeField] float moveSpeed, jumpForce;
    Rigidbody2D _rigidPlayer;
    bool sagaDonukMu;
    [SerializeField] SpriteRenderer spritePlayer;
    bool ziplayabilirMi, yerdeMi;

    private void Awake()
    {
        _rigidPlayer = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ziplayabilirMi = true;
        }
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);

        if (ziplayabilirMi && yerdeMi)
        {
            _rigidPlayer.AddForce(new Vector2(0, Input.GetAxis("Jump") * jumpForce));
            _rigidPlayer.velocity = Vector2.zero;
        }
        ziplayabilirMi = false;
    }
    private void LateUpdate()
    {
        switch (Input.GetAxis("Horizontal") < 0)
        {
            case false:
                transform.rotation = new Quaternion(0, 0, 0, 0);
                break;
            case true:
                transform.rotation = new Quaternion(0, 180, 0, 1);
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "zemin":
                yerdeMi = true;
                break;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "zemin":
                yerdeMi = false;
                break;
        }
    }
}
