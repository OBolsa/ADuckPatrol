using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public bool IsTesting;

    [SerializeField] private PlayerConfig m_Configs;
    private ICommand m_Movement;

    private void Start()
    {
        m_Movement = new PlayerMovement(m_Configs.Walk.Speed, m_Configs.Walk.MaxSpeed);
    }

    private void Update()
    {
        if (IsTesting)
        {
            m_Movement = new PlayerMovement(m_Configs.Walk.Speed, m_Configs.Walk.MaxSpeed);
        }

        m_Movement.Execute();
    }
}