using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FreeDraw;
using Oculus.Interaction;

public class customDrawing : MonoBehaviour
{
    public DrawingSettings ds;
    public drawing_collider dc;
    
    public Transform pointsTransform;
    public GameObject[] Pencils;
    public GameObject[] Erasers;

    [HideInInspector]
    public bool canDraw = false;

    private void Awake()
    {
        Pencils = GameObject.FindGameObjectsWithTag("Pencils");
        Erasers = GameObject.FindGameObjectsWithTag("Eraser");
    }

    public void Update()
    {
        foreach (GameObject pen in Pencils)
        {
            if (pen.GetComponentInParent<Grabbable>().isGrabbed)
            {
                pointsTransform = pen.transform.GetChild(0);

                if (dc.startDrawing)
                {
                    //UnityEngine.Debug.Log("touching");
                    canDraw = true;
                    Color c = pen.GetComponentInChildren<Renderer>().material.color;
                    ds.CustomColor(c);
                    accadDrawable.Pen_Width = 1;
                }
                else
                {
                    //UnityEngine.Debug.Log("not touching");
                    canDraw = false;
                }
            }
        }

        
        foreach (GameObject eraser in Erasers)
        {
            if (eraser.GetComponentInParent<Grabbable>().isGrabbed)
            {
                pointsTransform = eraser.transform.GetChild(0);
                
                if (dc.startErasing)
                {
                    canDraw = true;
                    Color c = new Color(1f, 1f, 1f, 1f);
                    ds.CustomColor(c);
                    accadDrawable.Pen_Width = 10;
                }
                else
                {
                    canDraw = false;
                }
            }
        }
    }

}
