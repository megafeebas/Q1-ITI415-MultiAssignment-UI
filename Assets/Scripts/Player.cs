using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    void Start()
    {

    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        print("not quite");
        if (other.gameObject.tag == "Player")
        {
            print("we here");
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
