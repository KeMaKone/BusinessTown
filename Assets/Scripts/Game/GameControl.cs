using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl:ScriptableObject{
    private GameData gameData;

    public GameControl(){
        gameData = GameData.Instance;
    }

    //Note moveAmount can be negative to go backwards
    public void MovePlayer(int playerID, int moveAmount){
        int currentPlayerTileID = gameData.GetPlayerCurrentTile(playerID).GetID();
        int nextPlayerTileID = (currentPlayerTileID + moveAmount) % gameData.GetTileManager().GetTileAmount();
        gameData.SetPlayerCurrentTile(playerID, nextPlayerTileID);
    }


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
