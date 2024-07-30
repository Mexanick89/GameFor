using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolColor : MonoBehaviour
{
    public bool Color_Blue = false;
    public bool Color_Orange = false;
    public bool Color_Green = false;
    public bool Color_Red = false;
    public bool Color_Purple = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Color_Blue"))
        {
            Color_Blue = true;
        }

        if (collision.gameObject.CompareTag("Color_Orange"))
        {
            Color_Orange = true;
        }

        if (collision.gameObject.CompareTag("Color_Green"))
        {
            Color_Green = true;
        }

        if (collision.gameObject.CompareTag("Color_Red"))
        {
            Color_Red = true;
        }

        if (collision.gameObject.CompareTag("Color_Purple"))
        {
            Color_Purple = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Color_Blue"))
        {
            Color_Blue = false;
        }

        if (collision.gameObject.CompareTag("Color_Orange"))
        {
            Color_Orange = false;
        }

        if (collision.gameObject.CompareTag("Color_Green"))
        {
            Color_Green = false;
        }

        if (collision.gameObject.CompareTag("Color_Red"))
        {
            Color_Red = false;
        }

        if (collision.gameObject.CompareTag("Color_Purple"))
        {
            Color_Purple = false;
        }
    }
}
