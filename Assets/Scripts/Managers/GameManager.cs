using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameState currentState;
    // Start is called before the first frame update
    void Awake()
    {

      if(Instance == null){
        Instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else{
        Destroy(gameObject);
      }  
    }

    
    public bool IsGamePlay(){

        return currentState == GameState.Gameplay;
    }
}
