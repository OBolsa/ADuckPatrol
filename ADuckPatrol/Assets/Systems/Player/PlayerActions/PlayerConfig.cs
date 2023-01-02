using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Configs/Player", fileName = "PlayerConfigs")]
public class PlayerConfig : ScriptableObject
{
    public WalkConfig Walk;
}

[System.Serializable]
public struct WalkConfig
{
    public float Speed;
    public float MaxSpeed;
    [Range(0.5f, 1f)] public float Brake;
}