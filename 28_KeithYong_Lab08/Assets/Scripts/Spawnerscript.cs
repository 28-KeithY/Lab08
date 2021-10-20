using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
        InvokeRepeating("SpawnObjects2", 3, 3);
        InvokeRepeating("SpawnObjects3", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }

    void SpawnObjects2()
    {
        PositionY = Random.Range(7, -7f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject2, transform.position, transform.rotation);
    }

    void SpawnObjects3()
    {
        PositionY = Random.Range(10, -10f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject3, transform.position, transform.rotation);
    }
}
