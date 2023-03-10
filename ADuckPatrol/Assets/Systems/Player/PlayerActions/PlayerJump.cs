using UnityEngine;

[System.Serializable]
public class PlayerJump : ICommand
{
    private float m_JumpForce;

    #region construtores
    public PlayerJump()
    {
        m_JumpForce = 10f;
    }
    
    public PlayerJump(float jumpForce)
    {
        m_JumpForce = jumpForce;
    }
    #endregion

    public override void Execute()
    {
        
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}
