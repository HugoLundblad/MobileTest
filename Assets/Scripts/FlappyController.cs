using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    public float flappingStrength;
    private Rigidbody2D _rb;
    private bool _isDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }

    public struct V2
    {
        public float x, y;
    }

    private V2 velocity;

    public V2 GetVelocity()
    {
        return velocity;
    }
    
    public void SetVelocity(V2 newVelocity)
    {
        velocity = newVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isDead) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (_rb.simulated)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, flappingStrength);
            }
            else
            {
                _rb.simulated = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(Co_OnDeath());
    }

    IEnumerator Co_OnDeath()
    {
        _isDead = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
