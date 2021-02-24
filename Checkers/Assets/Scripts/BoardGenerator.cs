using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    private int width, height;

    public GameObject tile;
    public Material tileBlack;
    public Material tileRed;

    public GameObject[,] CreateBoard(int w, int h)
    {
        GameObject board = new GameObject("Board");
        this.width = w;
        this.height = h;

        GameObject[,] boardMatrix = new GameObject[w, h];
        for(int x = 0; x < w; x++)
        {
            for(int z = 0; z < h; z++)
            {
                GameObject tile = CreateTile(x, z);
                tile.transform.parent = board.transform;
                boardMatrix[x, z] = tile;
            }
        }
        return boardMatrix;
    }

    public GameObject CreateTile(int x, int z)
    {
        GameObject tileObject = Instantiate(tile, new Vector3(x * tile.transform.localScale.x, 0, z * tile.transform.localScale.z), Quaternion.identity);
        Tile tileSettings = tileObject.GetComponent<Tile>();
        tileSettings.setX(x);
        tileSettings.setZ(z);

        if((x+z)%2 == 0)
        {
            tileObject.GetComponent<MeshRenderer>().material = tileBlack;
        } else {
            tileObject.GetComponent<MeshRenderer>().material = tileRed;
        }

        return tileObject;
    }


        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
