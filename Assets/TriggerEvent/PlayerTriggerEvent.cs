using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class PlayerTriggerEvent : MonoBehaviour
{
    public UnityEvent TriggerEnter;
    public UnityEvent TriggerStay;
    public UnityEvent TriggerExit;

    Rigidbody rb;
    BoxCollider bc;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        bc = this.GetComponent<BoxCollider>();

        if(!rb.isKinematic)
        {
            rb.isKinematic = true;
        }

        if(!bc.isTrigger)
        {
            bc.isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            TriggerEnter.Invoke();
        }
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            TriggerStay.Invoke();
        }
    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            TriggerExit.Invoke();
        }
    }
}
