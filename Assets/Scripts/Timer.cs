using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 0.0f;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 3.0f)
        {
            rb.velocity = new Vector3(0, -2, 0);
            print("Should be starting");
        }
        timer += Time.deltaTime;
        print("The time is :" + timer);
        if(this.gameObject.transform.position.y <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
