using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int PlayerCount = 1;

    public GameObject PlayerPrefab;

    	// Use this for initialization
	void Start () {
        

            for (int x = 0; x <= PlayerCount; x++)
            {
                Instantiate(PlayerPrefab, new Vector2((0+2)*(x%2==0?(-1):(1)), (0+2) * (x % 3 == 0 ? (-1) : (1))), Quaternion.identity);
            }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
