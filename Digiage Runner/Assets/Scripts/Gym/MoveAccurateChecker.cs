using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAccurateChecker : MonoBehaviour
{
    [SerializeField] GymMoves gymMoves;
    [SerializeField] float scoreIncrease;
    [SerializeField] ScoreBarController scoreBarController;

    moves currentMove;
    moves nextMove;

    public Dictionary<moves, GameObject> movesAndImages;


    void Start()
    {
        movesAndImages = gymMoves.movesAndImages;
        SetRandomMove();
    }

    public void SetRandomMove()
    {
        nextMove = (moves)Random.Range(1, 5);
        while(nextMove.Equals(currentMove))
            nextMove = (moves)Random.Range(1, 5);
        currentMove = nextMove; 

        foreach(GameObject obj in movesAndImages.Values)
        {
            obj.SetActive(false);
        }
        movesAndImages[currentMove].SetActive(true);
       
    }

    public void CheckAccurate(int moveInput)
    {
        if (moveInput.Equals((int)currentMove))
        {
            scoreBarController.AddScore(scoreIncrease);
            bool isFinished = scoreBarController.IsFinished();
            if (isFinished)//     GameOver();
               // Debug.Log("Finished");
                
            SetRandomMove();
        }
        else
            scoreBarController.AddScore(-scoreIncrease);
    }


    void Update()
    {
    //    if (Input.GetMouseButtonDown(0))
    //        SetRandomMove();
    }
}