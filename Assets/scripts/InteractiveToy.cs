using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveToy : MonoBehaviour
{
    public GameObject face;
    public GameObject smile;
    public GameObject wink;

    // Start is called before the first frame update
    void Start()
    {
        ShowEmotion("neutral");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ShowEmotion("neutral");
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            ShowEmotion("smile");
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            ShowEmotion("wink");
        }
    }
    void ShowEmotion(string emotion)
    {
        face.SetActive(emotion == "neutral");
        smile.SetActive(emotion == "smile");
        wink.SetActive(emotion == "wink");
    }
}
