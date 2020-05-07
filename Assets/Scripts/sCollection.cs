using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sCollection : MonoBehaviour
{
    // Start is called before the first frame update
    private int objects = 4;
    public Text countText;

    void Start()
    {
        countText.text = "Count: " + objects.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= 0)
        {
            countText.text = "You Lose!";
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ore")
        {
            objects--;
            countText.text = "Count: " + objects.ToString();
        }
        Destroy(other.gameObject);
        if(objects == 0)
        {
            countText.text = "You Win!";
        }
    }

}

