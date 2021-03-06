using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject[] cubes;
    GameObject[] spheres;


    // Start is called before the first frame update
    void Start()
    {

        //GameObject cube = GameObject.FindWithTag("Cube");

        cubes = GameObject.FindGameObjectsWithTag("Cube");
        spheres = GameObject.FindGameObjectsWithTag("Sphere");

        //Destroy(cube);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject g in cubes)
            {
                Destroy(g.gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (GameObject g in spheres)
            {
                Destroy(g.gameObject);
            }
        }
    }

}

