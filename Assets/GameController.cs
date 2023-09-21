using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public GameObject[] PlayerPrefabs;

    public Player PlayerOne;
    public Player PlayerTwo;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        //Spawn random 
        int randomOne = Random.Range(0, PlayerPrefabs.Length);
        GameObject playerPrefabOne = PlayerPrefabs[randomOne];
        PlayerOne = Instantiate(playerPrefabOne, new Vector3(-5, 1, 0), Quaternion.identity).GetComponent<Player>();

        int randomTwo = Random.Range(0, PlayerPrefabs.Length);
        GameObject playerPrefabTwo = PlayerPrefabs[randomTwo];
        PlayerTwo = Instantiate(playerPrefabTwo, new Vector3(5, 1, 0), Quaternion.identity).GetComponent<Player>();
    }
}
