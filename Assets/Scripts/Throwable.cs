using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Throwable : MonoBehaviour
{
    [SerializeField] float delay = 5f;
    [SerializeField] float damageRadis = 20f;
    [SerializeField] float explosionForce = 1200f;

    float countdown;

    bool hasExploded = false;
    public bool hasBeenThrow = false;

    public enum ThrowableType
    {
        Grenade
    }

    public ThrowableType throwableType;

    private void Start()
    {
        countdown = delay;   
    }

    private void Update()
    {
        if (hasBeenThrow)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0f && !hasExploded)
            {
                Exploded();
                hasExploded = true;
            }    
        }    
    }

    private void Exploded()
    {
        GetThrowableEffect();
        Destroy(gameObject);
    }

    private void GetThrowableEffect()
    {
        switch (throwableType)
        {
            case ThrowableType.Grenade:
                GrenadeEffect();
                break;
            default:
                break;
        }
    }

    private void GrenadeEffect()
    {
        // Visual effect
        GameObject explosionEffect = GlobalReferences.Instance.grenadeExplosionEffect;
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, damageRadis);
        foreach (Collider objectInRange in colliders)
        {
            Rigidbody rb = objectInRange.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, damageRadis);
            }    
        }    

    }
}
