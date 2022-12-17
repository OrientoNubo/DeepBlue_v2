using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{

    public float charsPerSecond = 0.2f;
    private string words;

    private bool isActive = false;
    private float timer;
    private Text myText;
    private int currentPos = 0;

    // Use this for initialization
    void Start()
    {
        timer = 0;
        isActive = true;
        charsPerSecond = Mathf.Max(0.2f, charsPerSecond);
        myText = GetComponent<Text>();
        words = myText.text;
        myText.text = "";
    }

    void Update()
    {
        OnStartWriter();
    }

    public void StartEffect()
    {
        isActive = true;
    }

    void OnStartWriter()
    {

        if (isActive)
        {
            timer += Time.deltaTime;
            if (timer >= charsPerSecond)
            {
                timer = 0;
                currentPos++;
                myText.text = words.Substring(0, currentPos);

                if (currentPos >= words.Length)
                {
                    OnFinish();
                }
            }

        }
    }

    void OnFinish()
    {
        isActive = false;
        timer = 0;
        currentPos = 0;
        myText.text = words;
    }


}
