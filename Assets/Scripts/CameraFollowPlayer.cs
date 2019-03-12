using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    Transform player;
    public float speed = 2;
    public float distanceX,distanceY,distanceZ,playerHeight;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = player.position + new Vector3(distanceX,distanceY,distanceZ);
        transform.position = Vector3.Lerp(transform.position,targetPosition,speed*Time.deltaTime);
        targetPosition = player.position + new Vector3(0,playerHeight/2,0);
        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,speed*Time.deltaTime);
    }
}
