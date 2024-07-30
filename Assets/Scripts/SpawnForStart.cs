using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnForStart : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] positions;

    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        List<GameObject> Objectlist = new List<GameObject>(objects);
        for (int i = 0; i < positions.Length; i++)
        {
            int randomIndex = Random.Range(0, Objectlist.Count);
            GameObject newObject = Instantiate(objects[randomIndex], positions[i].position, Quaternion.identity, transform);
        }
    }
}
