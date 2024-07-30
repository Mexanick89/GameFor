using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] objectsArray;

    private string[] tagArray;
    private (string tag, GameObject obj)[] tagObjectPairs;


    private void Update()
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


    public void CheckForMatches()
    {

        for (int y = 0; y < 5; y++)
        {
            string currentTag = tagArray[y * 5];
            int count = 1;
            int startIndex = y * 5;
            for (int x = 1; x < 5; x++)
            {
                if (tagArray[y * 5 + x] == currentTag && (x == 1 || tagArray[y * 5 + x - 1] == currentTag))
                {
                    count++;
                    if (count >= 3)
                    {
                        for (int i = startIndex; i < startIndex + 5; i++)
                        {
                            if (tagObjectPairs[i].tag == currentTag)
                            {
                                GameObject matchedObject = GameObject.Find($"{tagObjectPairs[i].obj.name}");
                                //Debug.Log($"Найдено совпадение по вертикали: {currentTag} ({i % 5}, {i / 5}) - {matchedObject.name}");

                                Test2 test2Script = matchedObject.GetComponent<Test2>();
                                if (test2Script != null)
                                {
                                    StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                }

                                IEnumerator DestroyWithDelay(GameObject objectToDestroy)
                                {
                                    yield return new WaitForSeconds(2f);
                                    Destroy(objectToDestroy);
                                }
                            }
                        }
                    }
                }
                else
                {
                    currentTag = tagArray[y * 5 + x];
                    count = 1;
                    startIndex = y * 5 + x;
                }
            }
        }

        for (int x = 0; x < 5; x++)
        {
            string currentTag = tagArray[x];
            int count = 1;
            int startIndex = x;
            for (int y = 1; y < 5; y++)
            {
                if (tagArray[y * 5 + x] == currentTag && (y == 1 || tagArray[(y - 1) * 5 + x] == currentTag))
                {
                    count++;
                    if (count >= 3)
                    {
                        for (int i = startIndex; i < 25; i += 5)
                        {
                            if (tagObjectPairs[i].tag == currentTag)
                            {
                                GameObject matchedObject = GameObject.Find($"{tagObjectPairs[i].obj.name}");
                                // Debug.Log($"Найдено совпадение по горизонтали: {currentTag} ({i % 5}, {i / 5}) - {matchedObject.name}");

                                Test2 test2Script = matchedObject.GetComponent<Test2>();
                                if (test2Script != null)
                                {
                                    StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                                }

                                IEnumerator DestroyWithDelay(GameObject objectToDestroy)
                                {
                                    yield return new WaitForSeconds(2f);
                                    Destroy(objectToDestroy);
                                }

                            }
                        }
                    }
                }
                else
                {
                    currentTag = tagArray[y * 5 + x];
                    count = 1;
                    startIndex = y * 5 + x;
                }
            }
        }
    }
}
