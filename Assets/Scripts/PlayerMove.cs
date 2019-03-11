using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController cc;

    float h,v;

    public float speed = 3;

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if(Mathf.Abs(h)>0.1 || Mathf.Abs(v)>0.1){
            Vector3 target = new Vector3(h,0,v);
            transform.LookAt(target+transform.position);
            cc.SimpleMove(transform.forward*speed);
        }
        
    }
}
