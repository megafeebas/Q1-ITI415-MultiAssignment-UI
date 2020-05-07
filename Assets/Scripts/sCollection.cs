using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sCollection : MonoBehaviour
{
    // Start is called before the first frame update
    private int objects;
    public GameObject GUI;
    void Awake()
    {
        objects = 4;
        GUI.GetComponent<Text>().text = "There are " + objects + " ores left";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ore")
        {
            objects--;
            GUI.GetComponent<Text>().text = "There are " + objects + " ores left";
            if (objects == 0)
            {
                GUI.GetComponent<Text>().text = "You Win!";
            }
        }
        other.gameObject.SetActive(false);

    }

}

