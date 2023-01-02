using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    [SerializeField] private PlayerComponents m_Components;
    public PlayerComponents Components => m_Components;

    private void Awake()
    {
        Instance = this;
    }
}