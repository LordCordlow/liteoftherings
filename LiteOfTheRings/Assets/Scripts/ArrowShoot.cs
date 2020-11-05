using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    public Rigidbody2D arrowPrototype = null;
    public Transform firePoint;
    
    public float speed = 1.0f;
    public int arrowPoolSize = 10;
    public List<Rigidbody2D> arrowPool;
    // Start is called before the first frame update
    void Start()
    {
        arrowPool = new List<Rigidbody2D>();
        for (int i = 0; i < arrowPoolSize; i++)
        {
            Rigidbody2D arrowClone = Instantiate(arrowPrototype, firePoint.position, arrowPrototype.transform.rotation);
            arrowClone.gameObject.SetActive(false);
            arrowPool.Add(arrowClone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shootArrow();
        }
    }

    void shootArrow()
    {
        Rigidbody2D arrowClone = getArrowFromPool();
        arrowClone.transform.position = firePoint.position;
        arrowClone.gameObject.SetActive(true);
        float direction = CharacterMovement.facingRight ? +1 : -1;
        
        Vector3 force = transform.right * speed * direction;
        arrowClone.velocity = force;
    }

    private Rigidbody2D getArrowFromPool()
    {
        foreach (var arrow in arrowPool)
        {
            if (!arrow.gameObject.activeSelf)
            {
                return arrow;
            }
        }
        return null;
    }
}
