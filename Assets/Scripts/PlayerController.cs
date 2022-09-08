using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public GameObject prefabShoot;
   
    // I am instantiating the rockets in this update method.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabShoot,new Vector3(0,-5,0),prefabShoot.transform.rotation);
        }
    }
}
