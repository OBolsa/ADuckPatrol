using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    [SerializeField] private CommandSet[] m_Commands;
}

[System.Serializable]
public struct CommandSet
{
    public ICommandTrigger m_Trigger;
    public ICommand m_Command;
}