using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Test2 : MonoBehaviour
{
    public string tagOfBall = "";

    public string objectName = "";

    public GameObject collidedObject;



    void Start()
    {
        objectName = this.gameObject.name;
    }



    private void OnTriggerEnter2D(Collider2D colisions)
    {
        if (colisions.gameObject.CompareTag("Color_Blue"))
        {
            tagOfBall = colisions.gameObject.tag;
            collidedObject = colisions.gameObject;
        }

        if (colisions.gameObject.CompareTag("Color_Green"))
        {
            tagOfBall = colisions.gameObject.tag;
            collidedObject = colisions.gameObject;
        }

        if (colisions.gameObject.CompareTag("Color_Orange"))
        {
            tagOfBall = colisions.gameObject.tag;
            collidedObject = colisions.gameObject;
        }

        if (colisions.gameObject.CompareTag("Color_Red"))
        {
            tagOfBall = colisions.gameObject.tag;
            collidedObject = colisions.gameObject;
        }

        if (colisions.gameObject.CompareTag("Color_Purple"))
        {
            tagOfBall = colisions.gameObject.tag;
            collidedObject = colisions.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D colisions)
    {
        if (colisions.gameObject.CompareTag("Color_Blue"))
        {
            tagOfBall = "";
            collidedObject = null;
        }

        if (colisions.gameObject.CompareTag("Color_Green"))
        {
            tagOfBall = "";
            collidedObject = null;
        }

        if (colisions.gameObject.CompareTag("Color_Orange"))
        {
            tagOfBall = "";
            collidedObject = null;
        }

        if (colisions.gameObject.CompareTag("Color_Red"))
        {
            tagOfBall = "";
            collidedObject = null;
        }

        if (colisions.gameObject.CompareTag("Color_Purple"))
        {
            tagOfBall = "";
            collidedObject = null;
        }
    }
}
