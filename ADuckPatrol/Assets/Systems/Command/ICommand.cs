using UnityEngine;

[System.Serializable]
public abstract class ICommand : MonoBehaviour
{
    public abstract void Execute();
    public abstract void Undo();
}