using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuFadeIn : MonoBehaviour
{
    public float speed;
    public float targetAlpha;
    float v;


    void Start(){
        v = 1.0f;
        if(speed == 0)
            speed = 0.95f;
        if(targetAlpha == 0)
            targetAlpha = 0.05f;
    }
    // Update is called once per frame
    void Update()
    {
        //v -= Time.deltaTime*speed;
        // if(v<0)
        //     v = 0.1f;
        Color c = gameObject.GetComponent<UISprite>().color;
        c = new Color(c.r,c.g,c.b,c.a*speed);
        if (c.a < targetAlpha)
            Destroy(this.gameObject);
        else
            gameObject.GetComponent<UISprite>().color = c;
    }
}
