using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymMoves: MonoBehaviour
{
    public Dictionary<moves, GameObject> movesAndImages = new Dictionary<moves, GameObject>();
    [SerializeField] GameObject rPunchImage;
    [SerializeField]  GameObject lPunchImage;
    [SerializeField]  GameObject rKickImage;
    [SerializeField]  GameObject lKickImage;


    private void Awake()
    {
        movesAndImages.Add(moves.rPunch, rPunchImage);
        movesAndImages.Add(moves.lPunch, lPunchImage);
        movesAndImages.Add(moves.rKick, rKickImage);
        movesAndImages.Add(moves.lKick, lKickImage);
    }
}

public enum moves
{
    rPunch = 1,
    lPunch = 2,
    rKick = 3,
    lKick = 4
}
