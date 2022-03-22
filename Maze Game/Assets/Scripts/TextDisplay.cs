using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{

    public float waitTime = 4.0f;
    public float fadeOut = 2.0f;
    public float time;

    void Start()
    {
        time = waitTime + fadeOut;
    }


    //Sets the beginning text on a timer and fades out once it reaches a certain time
    void Update()
    {
        time -= Time.deltaTime;

        if (time < fadeOut && time > 0)
        {
            float alpha = time / fadeOut;
            foreach (CanvasRenderer r in GetComponentsInChildren<CanvasRenderer>())
            {
                r.SetAlpha(alpha);
            }
        }

        //Once the text has faded, it will destroy the text gameObject
        if (time <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}
