using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    int x;
    int y;

    public Pawn PlacedPawn {
        get; 
        private set;
    }

    public void Initialize(int x, int y){
        this.x = x;
        this.y = y;
        Player player = GameObject.Find("Player 1").GetComponent<Player>();
        SetFieldState(player);
    }

    public GameObject PawnPrefab;

    public void SetFieldState(Player owner){
        if(owner != null){
            PlacedPawn = Instantiate(PawnPrefab, transform, false).GetComponent<Pawn>();
            PlacedPawn.Initialize(owner, this);
        } else if(PlacedPawn != null){
            Destroy(PlacedPawn);
        }
    }
}
