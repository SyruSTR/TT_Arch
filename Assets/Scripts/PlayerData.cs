using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int _movesCount;
    
    public delegate void PlayerHandler(int currentMovesCount);

    public event PlayerHandler ChangeMoves;

    public int MovesCount
    {
        get { return _movesCount; }
        set
        {
            _movesCount = value;
            ChangeMoves?.Invoke(_movesCount);
        }
    }
}
