using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingScript : MonoBehaviour
{
    public GameObject Floor;
    public int FloorRows = 27;
    public int FloorColumns = 27;
    public GameObject Wall;
    public int WallRows = 28;
    public int WallColumns = 28;

    // Start is called before the first frame update
    void Start()
    {
        float sizeX = Floor.transform.localScale.x;
        float sizeZ = Floor.transform.localScale.z;
        for(int i = 0; i < FloorRows; i++)
        {
            for(int j = 0; j < FloorColumns; j++)
            {
                Instantiate(Floor, new Vector3(j * sizeX, 0, -i * sizeZ), Quaternion.identity);
            }
        }
        float angle = 70f;
        Vector3 angleVector = new Vector3(0, 0, 0);
        
        for (int i = 0; i < WallRows; i++)
        {
            for(int j = 0; j < WallColumns; j++)
            {
                Instantiate(Wall, new Vector3(j * sizeX, 0, -i * sizeZ), Quaternion.identity);
                Wall.transform.rotation = Quaternion.AngleAxis(-10, new Vector3(0, 0, 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
