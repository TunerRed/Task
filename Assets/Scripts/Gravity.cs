using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    private Rigidbody rigidBody;

    public float g;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -0.01){
            Debug.Log("positionY<0 "+transform.position.y);
            rigidBody.velocity = new Vector3(0, 0,0);
            transform.position = new Vector3(transform.position.x, 0,transform.position.z);
        }
        if(transform.position.y > 0.01){
            //Debug.Log("positionY>0 "+transform.position.y+" velocityY "+rigidBody.velocity.y);
            transform.position = new Vector3(transform.position.x,
                transform.position.y+0.5f*g*Time.deltaTime,
                transform.position.z);
            // rigidBody.velocity = new Vector3(rigidBody.velocity.x,
            //     rigidBody.velocity.y + g*Time.deltaTime,rigidBody.velocity.z);
        }
        if(transform.rotation.x != 0 || transform.rotation.z != 0)
            transform.rotation = Quaternion.Euler(0,transform.rotation.y,0);
    }
}
