using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponents : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_Rigidbody;
    [SerializeField] private SpriteRenderer m_SpriteRenderer;
    [SerializeField] private Collider2D m_Collider2D;

    public Rigidbody2D Rigidbody => m_Rigidbody;
    public SpriteRenderer SpriteRenderer => m_SpriteRenderer;
    public Collider2D Collider2D => m_Collider2D;
}