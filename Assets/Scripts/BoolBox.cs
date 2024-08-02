using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BoolBox : MonoBehaviour
{
    public bool MainCheck = false;

    private void Start()
    {
        MainCheck = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Color_Blue"))
        {
            Invoke("MiniPause", 0.22f);
        }

        if (collision.gameObject.CompareTag("Color_Green"))
        {
            Invoke("MiniPause", 0.22f);
        }

        if (collision.gameObject.CompareTag("Color_Orange"))
        {
            Invoke("MiniPause", 0.22f);
        }

        if (collision.gameObject.CompareTag("Color_Red"))
        {
            Invoke("MiniPause", 0.22f);
        }

        if (collision.gameObject.CompareTag("Color_Purple"))
        {
            Invoke("MiniPause", 0.22f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Color_Blue"))
        {
            Invoke("MiniStart", 0.05f);
        }

        if (collision.gameObject.CompareTag("Color_Green"))
        {
            Invoke("MiniStart", 0.05f);
        }

        if (collision.gameObject.CompareTag("Color_Orange"))
        {
            Invoke("MiniStart", 0.05f);
        }

        if (collision.gameObject.CompareTag("Color_Red"))
        {
            Invoke("MiniStart", 0.05f);
        }

        if (collision.gameObject.CompareTag("Color_Purple"))
        {
            Invoke("MiniStart", 0.05f);
        }
    }


    private void MiniPause()
    {
        MainCheck = false;
    }

    private void MiniStart()
    {
        MainCheck = true;
    }
}
