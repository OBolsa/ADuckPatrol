using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    [SerializeField] private float m_DecreaseTimeInSeconds = 1f;
    private float _Counter;
    private bool _Initialized;

    private void Update()
    {
        if( _Initialized)
        {
            UpdateDecrease();

            _Counter -= Time.deltaTime;

            if(_Counter <= 0)
            {
                UpdateDecrease();
                StopDecrease();
            }
        }
    }

    private void UpdateDecrease()
    {
        transform.localScale = new Vector3(RemappedValue(), RemappedValue(), 1f);
    }

    private float RemappedValue()
    {
        return Mathf.Lerp(0f, 1f, _Counter / m_DecreaseTimeInSeconds);
    }

    private void StopDecrease()
    {
        _Initialized = false;
        gameObject.SetActive(false);
    }

    private void StartDecrease()
    {
        _Initialized = true;
        _Counter = m_DecreaseTimeInSeconds;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerEntity player = collision.GetComponent<PlayerEntity>();

        if (player != null)
        {
            StartDecrease();
        }
    }
}
