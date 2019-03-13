using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public CharacterController cc;

    public GameObject mainCamera;
    private Animator animator;

    public float speed = 3;

    void Start(){
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        float h = LeftButtonEvent.horizontal;
        float v = LeftButtonEvent.vertical;
        if(Mathf.Abs(h)>0.05 || Mathf.Abs(v)>0.05){
            animator.SetBool("isRunning",true);
            /*
            *人物真正的行走角度是从摄像机来看的坐标
            因此有必要将获取的方向进行旋转
            旋转的角度是摄像机在世界的旋转角度
            rotation的值并不正确，需要使用eulerAngle
            同时使用的函数也是求欧拉角（大概）
             */
            Vector3 target = new Vector3( h,0,v);
            //Debug.Log("Old "+target);
            target = Quaternion.Euler(0,mainCamera.transform.eulerAngles.y,0)*target;
            //Debug.Log("rotationY "+mainCamera.transform.eulerAngles.y);
            //Debug.Log("New "+target);
            transform.LookAt(transform.position+target);

            if (animator.GetCurrentAnimatorStateInfo(0).IsName("RUN00_F")||
                animator.GetCurrentAnimatorStateInfo(0).IsName("WAIT00"))
                cc.SimpleMove(transform.forward*speed);
        } else{
            animator.SetBool("isRunning",false);
        }
        //Vector3 target = new Vector3(0,0,1);
        //transform.LookAt(transform.position-target);
    }
}
