using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public GameObject Cube;
    public move player;

    int checkedSides;

    public string[] sides = new string[6] { "up", "down", "left", "right", "forward", "back" };

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<move>();

    }

    private void Update()
    {
        if (player.cubeCount <= player.maxCubeCount)
        {            
            player.cubeCount++;
            string side = sides[Random.Range(0, sides.Length)];
            RaycastHit hit;
            if (side == sides[0])
            {
                if (!Physics.Raycast(transform.position, new Vector3(25, 0, 0), out hit, 1))
                {
                    Instantiate(Cube, new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z), Quaternion.identity);
                }
            }
            if (side == sides[1])
            {
                if (!Physics.Raycast(transform.position, new Vector3(-25, 0, 0), out hit, 1))
                {
                    Instantiate(Cube, new Vector3(transform.position.x + 1, transform.position.y - 1, transform.position.z), Quaternion.identity);
                }
            }
            if (side == sides[2])
            {
                if (!Physics.Raycast(transform.position, -transform.right, out hit, 1))
                {
                    if (!Physics.Raycast(transform.position, new Vector3(0, 0, -25), out hit, 1))
                    {
                        Instantiate(Cube, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), Quaternion.identity);
                    }
                }
            }
            if (side == sides[3])
            {
                if (!Physics.Raycast(transform.position, transform.right, out hit, 1))
                {
                    if (!Physics.Raycast(transform.position, new Vector3(0, 0, 25), out hit, 1))
                    {
                        Instantiate(Cube, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
                    }
                }
            }
            if (side == sides[4])
            {
                if (!Physics.Raycast(transform.position, transform.forward, out hit, 1))
                {
                    if (!Physics.Raycast(transform.position, new Vector3(25, 0, 0), out hit, 1))
                    {
                        Instantiate(Cube, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), Quaternion.identity);
                    }
                }
            }
            if (side == sides[5])
            {
                if (!Physics.Raycast(transform.position, -transform.forward, out hit, 1))
                {
                    if (!Physics.Raycast(transform.position, new Vector3(25, 0, 0), out hit, 1))
                    {
                        Instantiate(Cube, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), Quaternion.identity);
                    }
                }
            }
        }
    }

}


    


