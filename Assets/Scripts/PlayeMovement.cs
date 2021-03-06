using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMovement : MonoBehaviour
{
    [SerializeField] private float runSpeed = 2f;

    Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
       myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }


    private void Run()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(x * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }

}
