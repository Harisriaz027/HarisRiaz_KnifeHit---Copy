using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 15;
    public bool isstuck;
    private Rigidbody rb;
    public float lives;
    private Lives livescounter;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        livescounter = GameObject.Find("Canvas").GetComponent<Lives>();
       isstuck = false;
        lives = 3;
    }

   //moving to rockets on keypress and if the stick to planet they lose speed
    void Update()
    {
        if (!isstuck)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }else if (isstuck)
        {
            transform.Translate(Vector3.zero * Time.deltaTime * speed);
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
       //on hitting earth, rocket's tag is changed and earth is made it's parent
       //so they revolve with it. THey are sticking to earth with kinematics turned on
        if (collision.gameObject.CompareTag("Earth"))
        {
            rb.isKinematic = true;
            transform.SetParent(collision.transform);
            isstuck = true;
            gameObject.tag = "stuckrocket";
        }
        //if rocket hits already stuck rocket, life is decreased
        else if (collision.gameObject.CompareTag("stuckrocket"))
        {
            livescounter.life--;
            Destroy(gameObject);
        }
    }
}
