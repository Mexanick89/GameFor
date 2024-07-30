using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDeleteBombs : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D[] colliders = Physics2D.OverlapPointAll(clickPosition);

            foreach (Collider2D collider in colliders)
            {
                if (collider.gameObject.CompareTag("Color_Blue"))
                {
                    Destroy(collider.gameObject);
                }

                if (collider.gameObject.CompareTag("Color_Green"))
                {
                    Destroy(collider.gameObject);
                }

                if (collider.gameObject.CompareTag("Color_Orange"))
                {
                    Destroy(collider.gameObject);
                }

                if (collider.gameObject.CompareTag("Color_Red"))
                {
                    Destroy(collider.gameObject);
                }

                if (collider.gameObject.CompareTag("Color_Purple"))
                {
                    Destroy(collider.gameObject);
                }
            }
        }
    }
}
