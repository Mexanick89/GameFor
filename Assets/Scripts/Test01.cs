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

    private bool bomb_blue = false;
    private bool bomb_green = false;
    private bool bomb_orange = false;
    private bool bomb_red = false;
    private bool bomb_purple = false;

    private void Start()
    {
        InvokeRepeating("CheckForMatches", 1f, 1f);
    }

    private void Update()
    {
        UpdateBombFlags();
    }

    private void UpdateBombFlags()
    {
        bomb_blue = CheckBomb("Color_Blue");
        bomb_green = CheckBomb("Color_Green");
        bomb_orange = CheckBomb("Color_Orange");
        bomb_red = CheckBomb("Color_Red");
        bomb_purple = CheckBomb("Color_Purple");
    }

    private bool CheckBomb(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);

        foreach (GameObject obj in taggedObjects)
        {
            FishkaControll objScript = obj.GetComponent<FishkaControll>();
            if (objScript != null && objScript.TargetMuve)
            {
                return true;
            }
        }

        return false;
    }

    private void CheckForMatches()
    {
        if (objectsArray.Length == 0)
            return;

        tagArray = new string[objectsArray.Length];
        tagObjectPairs = new (string, GameObject)[objectsArray.Length];

        for (int i = 0; i < objectsArray.Length; i++)
        {
            tagArray[i] = objectsArray[i].GetComponent<Test2>().tagOfBall;
            tagObjectPairs[i] = (tagArray[i], objectsArray[i]);
        }

        FindHorizontalMatches();
        FindVerticalMatches();
    }

    private void FindHorizontalMatches()
    {
        for (int y = 0; y < 5; y++)
        {
            List<int> matchedIndices = new List<int>();

            for (int x = 0; x < 5; x++)
            {
                int index = y * 5 + x;
                if (index < tagObjectPairs.Length)
                {
                    string currentTag = tagObjectPairs[index].tag;
                    int count = 1;

                    for (int i = x + 1; i < 5; i++)
                    {
                        int nextIndex = y * 5 + i;
                        if (nextIndex < tagObjectPairs.Length && tagObjectPairs[nextIndex].tag == currentTag)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= 3)
                    {
                        for (int i = x; i < x + count; i++)
                        {
                            int currentIndex = y * 5 + i;
                            if (!matchedIndices.Contains(currentIndex))
                            {
                                GameObject matchedObject = tagObjectPairs[currentIndex].obj;
                                Debug.Log($"Найдено совпадение по горизонтали: {currentTag} ({i}, {y}) - {matchedObject.name}");
                                Test2 test2Script = matchedObject.GetComponent<Test2>();
                                if (test2Script != null)
                                {
                                    StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                }
                                matchedIndices.Add(currentIndex);
                            }
                        }
                    }

                    x += count - 1;
                }
            }
        }
    }

    private void FindVerticalMatches()
    {
        for (int x = 0; x < 5; x++)
        {
            List<int> matchedIndices = new List<int>(); 

            for (int y = 0; y < 5; y++)
            {
                int index = y * 5 + x;
                if (index < tagObjectPairs.Length)
                {
                    string currentTag = tagObjectPairs[index].tag;
                    int count = 1;

                    for (int i = y + 1; i < 5; i++)
                    {
                        int nextIndex = i * 5 + x;
                        if (nextIndex < tagObjectPairs.Length && tagObjectPairs[nextIndex].tag == currentTag)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count >= 3)
                    {
                        for (int i = y; i < y + count; i++)
                        {
                            int currentIndex = i * 5 + x;
                            if (!matchedIndices.Contains(currentIndex))
                            {
                                GameObject matchedObject = tagObjectPairs[currentIndex].obj;
                                Debug.Log($"Найдено совпадение по вертикали: {currentTag} ({x}, {i}) - {matchedObject.name}");
                                Test2 test2Script = matchedObject.GetComponent<Test2>();
                                if (test2Script != null)
                                {
                                    StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                }
                                matchedIndices.Add(currentIndex);
                            }
                        }
                    }

                    y += count - 1; 
                }
            }
        }
    }

    private IEnumerator DestroyWithDelay(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(1f);
        Destroy(objectToDestroy);
    }
}
