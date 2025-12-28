using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_Data", menuName = "ScriptableObject/MapGame_Data", order = 1)]
public class Level_Data : MonoBehaviour
{
    public int LevelIndex;

    [Header("Trap")]
    public float _iceSpeed;
    public float _iceTime;
}
