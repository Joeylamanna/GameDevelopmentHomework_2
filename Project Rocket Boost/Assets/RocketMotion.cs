using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMoment : MonoBehaviour
{
 public AudioSource audioSource; 
 public AudioClip thrustSound; 
new Rigidbody rigidbody;
   [SerializeField] float rocketThrust = 100f;
   [SerializeField] float rocketRotation = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    void ProcessThrust()
    {
       if( Input.GetKey(KeyCode.Space))
       {
         if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(thrustSound);
            }
            rigidbody.AddRelativeForce(Vector3.up * rocketThrust * Time.deltaTime);
            // Add your movement logic here (e.g., applying force)
        }
        else
        {
            // Stop the sound when the 'W' key is released
            audioSource.Stop();
       }
    }

    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            
            transform.Rotate(Vector3.forward * Time.deltaTime * rocketRotation);
        }
        else if(Input.GetKey(KeyCode.D))
        {
           
            transform.Rotate(-Vector3.forward * Time.deltaTime * rocketRotation);
        }
    }
}
