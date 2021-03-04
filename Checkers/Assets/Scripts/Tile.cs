using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private int x, z;
    public int id;

    private bool occupied;
    private GameObject occupyingChecker;

    public void setId(int id) { this.id = id; }
    public int getId() { return this.id; }

    public void setX(int x) { this.x = x; }
    public void setZ(int z) { this.z = z; }

    public int getX() { return this.x; }
    public int getZ() { return this.z; }

    public void setOccupied(bool o) { this.occupied = o; }
    public bool isOccupied() { return this.occupied; }

    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Entering Tile " + id);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Exiting Tile " + id);
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
