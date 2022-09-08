using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public TMP_Text txt;
    public float life;
    void Start()
    {
        life = 3;
    }

    //I am updating the lives counter in UI through this update method
    void Update()
    {
        txt.text = life.ToString("Lives Remaining: "+life);
        if (life <= 0)
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    void LifeCount()
    {
        life--; ;
    }
}
