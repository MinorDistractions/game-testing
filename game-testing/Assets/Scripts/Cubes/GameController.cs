using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public Transform spawnPoint;
    public float mouseZ = 10f;
    public float maxX = 6;
    public float maxZ = 6;

    // Start is called before the first frame update
    void Start()
    {
        //spawnBall();

        InvokeRepeating("spawnBall", 1f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnBall();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            Debug.Log(mousePos.x +" ," + mousePos.y + ", " + mousePos.z);

            mousePos.z = mouseZ;

            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);

            Instantiate(ball, spawnPos, Quaternion.identity);

        }
        
    }

    void spawnBall()
    {
        //Debug.Log("spawned");

        float randomX = Random.Range(-maxX,maxX);
        float randomZ = Random.Range(-maxZ, maxZ);

        Vector3 randomSpawnPos = new Vector3(randomX, 8f, randomZ);

        Instantiate(ball, randomSpawnPos, Quaternion.identity);
        //Instantiate(ball, spawnPoint.position, Quaternion.identity);



    }



}
