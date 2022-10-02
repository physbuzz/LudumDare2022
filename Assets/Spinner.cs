using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Vector3 surfVelo;
    public bool grounded;
    public float jumpHeight;
    public float gravityValue = 9.81f;
    public float playerSpeed = 1f;
    public float sensitivity;
    public GameObject Core;
    //private Transform spawner = GameObject.Find("IcoSpawner").GetComponent<Transform>();

    public Player player;
    public Rocket rocket;

    // Start is called before the first frame update
    void Start()
    {
        //Transform spawner = GameObject.Find("IcoSpawner").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left shift"))
        {
            playerSpeed = 200f;
        }

        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        surfVelo = move * playerSpeed;
        bool spinning = true;
        //transform.rotation *= Quaternion.Euler(-move.y*player.transform.up.y,0, -move.x);
        /*if (Input.GetKey("f"))
        {
            spinning = false;
            transform.RotateAround(Core.transform.position, rocket.transform.right, -move.y * Time.deltaTime * playerSpeed);
            transform.RotateAround(Core.transform.position, rocket.transform.forward, move.x * Time.deltaTime * playerSpeed);
        }
        */
        if (spinning)
        {
            transform.RotateAround(Core.transform.position, player.transform.right, -move.y * Time.deltaTime * playerSpeed);
            transform.RotateAround(Core.transform.position, player.transform.forward, move.x * Time.deltaTime * playerSpeed);
        }
        
    }
    
}
