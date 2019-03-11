using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButtonEvent : MonoBehaviour
{
    public float moveRadius = 65;

    public static float horizontal = 0;
    public static float vertical = 0;
    
    bool isPress;
    void OnPress(bool isPress){
        this.isPress = isPress;
        if (!isPress){
            transform.Find("Inner").localPosition = Vector2.zero;
            vertical = 0;
            horizontal = 0;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if (isPress){
            Vector2 vector = UICamera.lastTouchPosition - new Vector2(95,105);
            float distance2 = vector.x*vector.x+vector.y*vector.y;
            // Debug.Log(moveRadius);
            if (distance2 > moveRadius*moveRadius){
                vector = vector.normalized*moveRadius;
            }
            horizontal = vector.x/moveRadius;
            vertical = vector.y/moveRadius;
            transform.Find("Inner").localPosition = vector;
        }
    }
}
