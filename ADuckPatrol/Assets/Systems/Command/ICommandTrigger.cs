using UnityEngine;

[System.Serializable]
public abstract class ICommandTrigger : MonoBehaviour
{
    public abstract bool Triggered();
}