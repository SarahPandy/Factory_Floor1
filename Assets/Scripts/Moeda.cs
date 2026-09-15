using UnityEngine;

public class Moeda : MonoBehaviour
{
    private bool moeda1;
    private bool moeda2;
    private bool taComemorando;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision1)
    {
        if(collision1.gameObject.CompareTag("Player") && gameObject.CompareTag("Moeda1"))
        {
            moeda1 = true;
            Destroy(gameObject);
            anim.SetTrigger("IsTalles");
        }
        if (collision1.gameObject.CompareTag("Player2") && gameObject.CompareTag("Moeda2"))
        {
            moeda2 = true;
            Destroy(gameObject);
            anim.SetTrigger("IsTalles");
        }
    }

}