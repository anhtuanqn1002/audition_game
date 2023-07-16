using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject prefabCharacter;
    public GameObject startButton;
    GameObject character;
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Debug.Log("start game");
        if (character == null)
        {
            startButton.SetActive(false);
            mainCamera.enabled = false;
            character = Instantiate(prefabCharacter);
            character.GetComponent<Transform>().position = Vector3.zero;
            character.GetComponent<Camera>().enabled = true;
        }
    }
}
