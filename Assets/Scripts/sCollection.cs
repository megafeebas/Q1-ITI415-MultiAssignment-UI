using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sCollection : MonoBehaviour
{
    // Start is called before the first frame update
    private int objects = 4;
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objects--;
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }

}

