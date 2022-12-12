using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextBlink : MonoBehaviour
{
    public float blinkSpeed;
    private bool isAddAlpha;
    private float timer;
    public float timeval = 1;

    private Text tmp;
    private void Start()
    {
        tmp = GetComponent<Text>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (isAddAlpha)
        {
            tmp.color += new Color(0, 0, 0, Time.deltaTime * blinkSpeed);
            if (timer >= timeval)
            {
                tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, 1);
                isAddAlpha = false;
                timer = 0;
            }
        }
        else
        {
            tmp.color -= new Color(0, 0, 0, Time.deltaTime * blinkSpeed);
            if (timer >= timeval)
            {
                tmp.color = new Color(tmp.color.r, tmp.color.g, tmp.color.b, 0);
                isAddAlpha = true;
                timer = 0;
            }
        }
    }

}