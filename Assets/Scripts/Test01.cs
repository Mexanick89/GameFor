using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Test01 : MonoBehaviour
{
    public GameObject[] objectsArray;

    private string[] tagArray;
    private (string tag, GameObject obj)[] tagObjectPairs;


    private void Update()
    {
        if (objectsArray.Length > 0)
        {
            tagArray = new string[objectsArray.Length];
            tagObjectPairs = new (string, GameObject)[objectsArray.Length];
            for (int i = 0; i < objectsArray.Length; i++)
            {
                tagArray[i] = objectsArray[i].GetComponent<Test2>().tagOfBall;
                tagObjectPairs[i] = (tagArray[i], objectsArray[i]);
            }

            CheckForMatches();
        }
    }


    public void CheckForMatches()
    {
        for (int y = 0; y < 5; y++)
        {
            if (y * 5 < tagArray.Length)
            {
                string currentTag = tagArray[y * 5];
                int count = 1;
                int startIndex = y * 5;
                for (int x = 1; x < 5; x++)
                {
                    if (startIndex + x < tagArray.Length && tagArray[startIndex + x] == currentTag && (x == 1 || startIndex + x - 1 < tagArray.Length && tagArray[startIndex + x - 1] == currentTag))
                    {
                        count++;
                        if (count >= 3)
                        {
                            for (int i = startIndex; i < startIndex + 5 && i < tagObjectPairs.Length; i++)
                            {
                                if (tagObjectPairs[i].tag == currentTag)
                                {
                                    GameObject matchedObject = GameObject.Find($"{tagObjectPairs[i].obj.name}");
                                    Test2 test2Script = matchedObject.GetComponent<Test2>();
                                    if (test2Script != null)
                                    {
                                        StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (startIndex + x < tagArray.Length)
                        {
                            currentTag = tagArray[startIndex + x];
                        }
                        count = 1;
                        startIndex = startIndex + x;
                    }
                }
            }
        }

        for (int x = 0; x < 5; x++)
        {
            if (x < tagArray.Length)
            {
                string currentTag = tagArray[x];
                int count = 1;
                int startIndex = x;
                for (int y = 1; y < 5; y++)
                {
                    if (y * 5 + x < tagArray.Length && tagArray[y * 5 + x] == currentTag && (y == 1 || (y - 1) * 5 + x < tagArray.Length && tagArray[(y - 1) * 5 + x] == currentTag))
                    {
                        count++;
                        if (count >= 3)
                        {
                            for (int i = startIndex; i < 25 && i < tagObjectPairs.Length; i += 5)
                            {
                                if (tagObjectPairs[i].tag == currentTag)
                                {
                                    GameObject matchedObject = GameObject.Find($"{tagObjectPairs[i].obj.name}");
                                    Test2 test2Script = matchedObject.GetComponent<Test2>();
                                    if (test2Script != null)
                                    {
                                        StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (y * 5 + x < tagArray.Length)
                        {
                            currentTag = tagArray[y * 5 + x];
                        }
                        count = 1;
                        startIndex = y * 5 + x;
                    }
                }
            }
        }
    }

    private IEnumerator DestroyWithDelay(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(3f);
        Destroy(objectToDestroy);
    }

}
