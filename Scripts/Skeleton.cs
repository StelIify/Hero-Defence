using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
     float moveSpeed = 0.7f;
     [SerializeField] int health = 200;
     Animator anim;
     float durationOFDeathAnimation = 1f;

    float timeOfHitAnimation = 0.2f;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damage damageDealer = collision.gameObject.GetComponent<Damage>();
        StartCoroutine(HitAnimation());
        if (!damageDealer)
            return;
        ProcessHit(damageDealer);

    }
    private IEnumerator HitAnimation()
    {
        anim.SetBool("IsHit", true);
        yield return new WaitForSeconds(timeOfHitAnimation);
        anim.SetBool("IsHit", false);
    }
    private void ProcessHit(Damage damageDealer)
    {
        health -= damageDealer.GetDamage();
        damageDealer.Hit();
        if (health <= 0)
        {
            StartCoroutine(Die());
        }

    }
    private IEnumerator Die()
    {
        anim.SetTrigger("IsDead");
        yield return new WaitForSeconds(durationOFDeathAnimation);
        Destroy(gameObject);
    }

    public void SetMovementSpeed(int speed)
    {
        moveSpeed = speed;
    }
}

