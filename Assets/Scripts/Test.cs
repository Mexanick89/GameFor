using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] objectsArray;

    private string[] tagArray;
    private (string tag, GameObject obj)[] tagObjectPairs;

    public bool bomb_blue = false;
    public bool bomb_green = false;
    public bool bomb_orange = false;
    public bool bomb_red = false;
    public bool bomb_purple = false;

    public bool MainCheckMuve = false;

    private void Start()
    {
        MainCheckMuve = false;
    }

    private void Update()
    {

        GameObject[] taggedObjects1 = GameObject.FindGameObjectsWithTag("Color_Blue");
        GameObject[] taggedObjects2 = GameObject.FindGameObjectsWithTag("Color_Green");
        GameObject[] taggedObjects3 = GameObject.FindGameObjectsWithTag("Color_Orange");
        GameObject[] taggedObjects4 = GameObject.FindGameObjectsWithTag("Color_Red");
        GameObject[] taggedObjects5 = GameObject.FindGameObjectsWithTag("Color_Purple");

        foreach (GameObject obj in taggedObjects1)
        {
            FishkaControll objScript = obj.GetComponent<FishkaControll>();

            if (objScript != null && objScript.TargetMuve)
            {
                bomb_blue = true;
            }
            else
            {
                bomb_blue = false;
            }
        }

        foreach (GameObject obj in taggedObjects2)
        {
            FishkaControll objScript2 = obj.GetComponent<FishkaControll>();

            if (objScript2 != null && objScript2.TargetMuve)
            {
                bomb_green = true;
            }
            else
            {
                bomb_green = false;
            }
        }

        foreach (GameObject obj in taggedObjects3)
        {
            FishkaControll objScript3 = obj.GetComponent<FishkaControll>();

            if (objScript3 != null && objScript3.TargetMuve)
            {
                bomb_orange = true;
            }
            else
            {
                bomb_orange = false;
            }
        }

        foreach (GameObject obj in taggedObjects4)
        {
            FishkaControll objScript4 = obj.GetComponent<FishkaControll>();

            if (objScript4 != null && objScript4.TargetMuve)
            {
                bomb_red = true;
            }
            else
            {
                bomb_red = false;
            }
        }

        foreach (GameObject obj in taggedObjects5)
        {
            FishkaControll objScript5 = obj.GetComponent<FishkaControll>();

            if (objScript5 != null && objScript5.TargetMuve)
            {
                bomb_purple = true;
            }
            else
            {
                bomb_purple = false;
            }
        }

        if (objectsArray.Length > 0)
        {
            tagArray = new string[objectsArray.Length];
            tagObjectPairs = new (string, GameObject)[objectsArray.Length];
            for (int i = 0; i < objectsArray.Length; i++)
            {
                tagArray[i] = objectsArray[i].GetComponent<Test2>().tagOfBall;
                tagObjectPairs[i] = (tagArray[i], objectsArray[i]);
            }

            if (MainCheckMuve == false)
            {
                Invoke("CheckForMatches", 5f);
            }
        }
    }

    public void CheckForMatches()
    {
        bool[,] toDestroy = new bool[5, 5];

        // Проверка по горизонтали
        for (int y = 0; y < 5; y++)
        {
            string currentTag = null;
            int count = 0;
            for (int x = 0; x < 5; x++)
            {
                int index = y * 5 + x;
                if (index < tagArray.Length && tagArray[index] == currentTag)
                {
                    count++;
                    if (count >= 3)
                    {
                        for (int i = index - 2; i <= index; i++)
                        {
                            toDestroy[i % 5, i / 5] = true;
                        }
                    }
                }
                else
                {
                    currentTag = tagArray[index];
                    count = 1;
                }
            }
        }

        // Проверка по вертикали
        for (int x = 0; x < 5; x++)
        {
            string currentTag = null;
            int count = 0;
            for (int y = 0; y < 5; y++)
            {
                int index = y * 5 + x;
                if (index < tagArray.Length && tagArray[index] == currentTag)
                {
                    count++;
                    if (count >= 3)
                    {
                        for (int i = index - 2 * 5; i <= index; i += 5)
                        {
                            toDestroy[i % 5, i / 5] = true;
                        }
                    }
                }
                else
                {
                    currentTag = tagArray[index];
                    count = 1;
                }
            }
        }

        // Удаление фишек
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                if (toDestroy[x, y])
                {
                    GameObject matchedObject = GameObject.Find($"{tagObjectPairs[y * 5 + x].obj.name}");
                    Test2 test2Script = matchedObject.GetComponent<Test2>();
                    if (test2Script != null)
                    {
                        StartCoroutine(DestroyWithDelay(test2Script.collidedObject));
                    }
                }
            }
        }

        MainCheckMuve = true;
        ForBombs();


    }

    public void ForBombs()
    {
        if (bomb_blue == true)
        {
            MainCheckMuve = true;
            Debug.Log("Проверки нет");
        }

        if (bomb_green == true)
        {
            MainCheckMuve = true;
            Debug.Log("Проверки нет");
        }

        if (bomb_orange == true)
        {
            MainCheckMuve = true;
            Debug.Log("Проверки нет");
        }

        if (bomb_red == true)
        {
            MainCheckMuve = true;
            Debug.Log("Проверки нет");
        }

        if (bomb_purple == true)
        {
            MainCheckMuve = true;
            Debug.Log("Проверки нет");
        }

        if (!bomb_blue && !bomb_green && !bomb_orange && !bomb_purple && !bomb_red)
        {
            MainCheckMuve = false;
            Debug.Log("Запущено разрешение");
        }

    }


    private IEnumerator DestroyWithDelay(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(objectToDestroy);
    }
}
