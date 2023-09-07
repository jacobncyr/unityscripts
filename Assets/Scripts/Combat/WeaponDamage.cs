using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    [SerializeField] private Collider myCollider;
    private List<Collider> alreadyCollidedWith = new List<Collider>();
    private int Damage;

    private void OnEnable()
    {
        alreadyCollidedWith.Clear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(alreadyCollidedWith.Contains(other)) {return;}
        alreadyCollidedWith.Add(other);
        if(other == myCollider){return;}
        if(other.TryGetComponent<Health>(out Health health))
        {
            health.DealDamage(10);

        }
    }
    public void SetAttack(int Damage)
    {
        this.Damage = Damage;
    }


}
