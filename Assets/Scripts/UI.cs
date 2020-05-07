using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GUI;
    public int objects;
    void Start()
    {
        GUI = GameObject.Find("Text");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GUI.GetComponent<Text>().text = "There are " + objects + " ores left";
        if(objects == 0)
        {
            GUI.GetComponent<Text>().text = "You Win!";
        }
    }
}
