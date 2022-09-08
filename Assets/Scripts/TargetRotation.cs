using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetRotation : MonoBehaviour
{
    public float speed = 30;
    private AudioSource playerAudio;
    public int score;
    public AudioClip hitSound;
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        score = 0;
    }

    // This update method is rotating the earth
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }

    //Value in score variable is updating in this method.
    private void OnCollisionEnter(Collision collision)
    {
        score++;
        playerAudio.PlayOneShot(hitSound, 2f);
    }
}
