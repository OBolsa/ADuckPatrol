using UnityEngine;

[System.Serializable]
public class PlayerMovement : ICommand
{
    private float m_Speed;
    private float m_MaxSpeed;
    private float m_Break;
    private float _InputDirection => Input.GetAxisRaw("Horizontal");
    private Vector3 _NewVelocity = Vector3.zero;
    private Vector3 _OldVelocity = Vector3.zero;

    #region Construtores
    public PlayerMovement()
    {
        m_Speed = 20f;
        m_MaxSpeed = 10f;
        m_Break = 0.9f;
    }

    public PlayerMovement(float speed)
    {
        m_Speed = speed;
        m_MaxSpeed = 10f;
        m_Break = 0.9f;
    }

    public PlayerMovement(float speed, float maxSpeed)
    {
        m_Speed = speed;
        m_MaxSpeed = maxSpeed;
        m_Break = 0.9f;
    }

    public PlayerMovement(float speed, float maxSpeed, float brake)
    {
        m_Speed = speed;
        m_MaxSpeed = maxSpeed;
        m_Break = brake;
    }
    #endregion

    private bool CanMove() => Mathf.Abs(_InputDirection) >= 0.1f;

    public override void Execute()
    {
        _OldVelocity = PlayerManager.Instance.Components.Rigidbody.velocity;

        if (!CanMove())
        {
            _NewVelocity.x = Mathf.Abs(_OldVelocity.x) > 0 ? _OldVelocity.x * m_Break : 0;
            _NewVelocity.y = _OldVelocity.y;
        }
        else
        {
            float direction = _InputDirection > 0 ? 1 : -1;
            float growthRate = (m_Speed * direction) * Time.fixedDeltaTime;

            _NewVelocity.x = _OldVelocity.x + growthRate;
            _NewVelocity.y = _OldVelocity.y;
        }

        _NewVelocity.x = Mathf.Clamp(_NewVelocity.x, -m_MaxSpeed, m_MaxSpeed);

        PlayerManager.Instance.Components.Rigidbody.velocity = _NewVelocity;
    }

    public override void Undo()
    {
        throw new System.NotImplementedException();
    }
}