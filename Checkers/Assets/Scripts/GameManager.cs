using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private BoardGenerator boardGen;
    private GameObject[,] board;
    public int width, height;

    void Awake()
    {
        // Make Sure Only One Game Manager Exists
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public GameObject[,] GenerateBoard(BoardGenerator boardGen)
    {
        return boardGen.CreateBoard(width, height);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.boardGen = gameObject.GetComponent<BoardGenerator>();
        this.board = GenerateBoard(boardGen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
