using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.MPE;
using UnityEngine;

public class PlayerbodyScript : MonoBehaviour
{
    public float thrust = 10f;
    public float scale = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(0,5f,0,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * thrust * Time.deltaTime,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(-transform.forward * thrust * Time.deltaTime,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(-transform.right * thrust * Time.deltaTime,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right * thrust * Time.deltaTime,ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0,-0.1f,0);
        }
        if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0,0.1f,0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            scale = 1f;
            transform.localScale = new Vector3(scale,scale,scale);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            scale = 3f;
            transform.localScale = new Vector3(scale,scale,scale);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            scale = 5f;
            transform.localScale = new Vector3(scale,scale,scale);
        }
    }
}
