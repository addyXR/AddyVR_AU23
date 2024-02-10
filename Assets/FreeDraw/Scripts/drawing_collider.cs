using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawing_collider : MonoBehaviour
{

    public bool startDrawing = false;
    public bool startErasing = false;

    void OnTriggerEnter(Collider penCollider)
    {
        if (penCollider.gameObject.tag == "Pencils")
        {
            startDrawing = true;
        }

        else if (penCollider.gameObject.tag == "Eraser")
        {
            startErasing = true;
        }
    }

    void OnTriggerExit(Collider penCollider)
    {
        if (penCollider.gameObject.tag == "Pencils")
        {
            startDrawing = false;
        }

        else if (penCollider.gameObject.tag == "Eraser")
        {
            startErasing = false;
        }
    }
}
