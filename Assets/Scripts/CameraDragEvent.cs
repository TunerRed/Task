using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDragEvent : MonoBehaviour
{
    Vector2 startPosition;
    public CameraFollowPlayer mainCameraFollower;

    bool isPress;
    void OnPress(bool isPress){
        this.isPress = isPress;
        startPosition = UICamera.lastTouchPosition;
        // mainCameraFollower = mainCameraFollower.gameObject.GetComponent<CameraFollowPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        /* 在拖动画面时，需要对角色与相机间的距离参数在计算后重新赋值
        具体在
        */
        if(isPress){
            float width = UICamera.lastTouchPosition.x - startPosition.x;
            startPosition = UICamera.lastTouchPosition;
            float angle = (-width/Screen.width)*180;
            Vector3 target = Quaternion.Euler(0,angle,0)*
                (new Vector3(mainCameraFollower.distanceX,mainCameraFollower.distanceY,mainCameraFollower.distanceZ));
            mainCameraFollower.distanceX = target.x;
            mainCameraFollower.distanceZ = target.z;
        }
    }
}
