using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    //This method is called on button press
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
