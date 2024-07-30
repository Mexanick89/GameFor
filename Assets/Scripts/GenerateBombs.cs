using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateBombs : MonoBehaviour
{
    private GameObject GameMainPoints;
    private LineBox scriptLineBox2;

    public GameObject [] objects;

    public Transform positions1;
    public Transform positions2;
    public Transform positions3;
    public Transform positions4;
    public Transform positions5;

    public float spawnDelay = 3f;
    private float lastSpawnTime = 0f;

    public float spawnDelay2 = 3f;
    private float lastSpawnTime2 = 0f;

    public float spawnDelay3 = 3f;
    private float lastSpawnTime3 = 0f;

    public float spawnDelay4 = 3f;
    private float lastSpawnTime4 = 0f;

    public float spawnDelay5 = 3f;
    private float lastSpawnTime5 = 0f;

    [ContextMenu("Do Something")]

    void Start()
    {
        GameMainPoints = GameObject.Find("MainPoints");
        scriptLineBox2 = GameMainPoints.GetComponent<LineBox>();
    }

    private void Update()
    {
        Engine();

        if (Input.GetKeyDown(KeyCode.W))
        { 
            SpawnBomb();
        }
    }

    private void Engine()
    {
        if (scriptLineBox2.point0101 == true)
        {
            SpawnBomb();
        }

        if (scriptLineBox2.point0201 == true)
        {
            SpawnBomb2();
        }

        if (scriptLineBox2.point0301 == true)
        {
            SpawnBomb3();
        }

        if (scriptLineBox2.point0401 == true)
        {
            SpawnBomb4();
        }

        if (scriptLineBox2.point0501 == true)
        {
            SpawnBomb5();
        }
    }
    private void SpawnBomb()
    {
        if(scriptLineBox2.point0101 == true)
        if (Time.time - lastSpawnTime >= spawnDelay)
        {
            lastSpawnTime = Time.time;
            List<GameObject> objectsList = new List<GameObject>(objects);
            {
                int randomIndex = Random.Range(0, objectsList.Count);
                Instantiate(objectsList[randomIndex], positions1.position, Quaternion.identity, transform);
            }
        }
    }
    private void SpawnBomb2()
    {
        if (scriptLineBox2.point0201 == true)
            if (Time.time - lastSpawnTime2 >= spawnDelay2)
            {
                lastSpawnTime2 = Time.time;
                List<GameObject> objectsList = new List<GameObject>(objects);
                {
                    int randomIndex = Random.Range(0, objectsList.Count);
                    Instantiate(objectsList[randomIndex], positions2.position, Quaternion.identity, transform);
                }
            }
    }
    private void SpawnBomb3()
    {
        if (scriptLineBox2.point0301 == true)
            if (Time.time - lastSpawnTime3 >= spawnDelay3)
            {
                lastSpawnTime3 = Time.time;
                List<GameObject> objectsList = new List<GameObject>(objects);
                {
                    int randomIndex = Random.Range(0, objectsList.Count);
                    Instantiate(objectsList[randomIndex], positions3.position, Quaternion.identity, transform);
                }
            }
    }
    private void SpawnBomb4()
    {
        if (scriptLineBox2.point0401 == true)
            if (Time.time - lastSpawnTime4 >= spawnDelay4)
            {
                lastSpawnTime4 = Time.time;
                List<GameObject> objectsList = new List<GameObject>(objects);
                {
                    int randomIndex = Random.Range(0, objectsList.Count);
                    Instantiate(objectsList[randomIndex], positions4.position, Quaternion.identity, transform);
                }
            }
    }
    private void SpawnBomb5()
    {
        if (scriptLineBox2.point0501 == true)
            if (Time.time - lastSpawnTime5 >= spawnDelay5)
            {
                lastSpawnTime5 = Time.time;
                List<GameObject> objectsList = new List<GameObject>(objects);
                {
                    int randomIndex = Random.Range(0, objectsList.Count);
                    Instantiate(objectsList[randomIndex], positions5.position, Quaternion.identity, transform);
                }
            }
    }
}
