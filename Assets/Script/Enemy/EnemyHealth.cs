using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;
    public AudioClip deathClip;
    public static int enemiesKilledCount = 0;


    Animator anim;
    AudioSource enemyAudio;
    ParticleSystem hitParticle;
    CapsuleCollider capsuleCollider;
    bool isDead;
    bool isSinking;

    void Awake()
    {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        hitParticle = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        //currentHealth = startingHealth;
        currentHealth = 100;
    }
    void Update()
    {
       if(isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        } 
    }

    public void TakeDamage(int amount, Vector3 hitPoint)
    {
        if (isDead)
        {
            return;
        }

        if (enemyAudio != null)
        {
            enemyAudio.Play();
        }

        currentHealth -= amount;

        if (hitParticle != null)
        {
            hitParticle.transform.position = hitPoint;
            hitParticle.Play();
        }

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        capsuleCollider.isTrigger = true;
        anim.SetTrigger("Dead");
        StartSinking();
        enemyAudio.clip = deathClip;
        enemyAudio.Play();
        enemiesKilledCount++;
    }

    public void StartSinking()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        isSinking = true;
        ScoreManages.score += scoreValue;
        Destroy(gameObject, 2f);
        
    }
}
