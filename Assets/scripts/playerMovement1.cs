using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement1 : MonoBehaviour
{
    [SerializeField]
    private KeyCode moveUp = KeyCode.W;
    [SerializeField]
    private KeyCode moveDown = KeyCode.S;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float boundY;
    [SerializeField]
    private Rigidbody2D rB2D;

    // Start is called before the first frame update
    void Start()
    {
        rB2D = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        var vel = rB2D.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rB2D.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    } } 
