using UnityEngine;

public class Projetil : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float velocidade = 4f;
    [SerializeField] private float destruiApos = 1f;
   





    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        rb.linearVelocity = transform.up * velocidade;
        Destroy(gameObject, destruiApos);

    }
}
