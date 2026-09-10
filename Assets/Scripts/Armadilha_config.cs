using UnityEngine;

public enum TipoArmadilha { Espeto, Torreta }

public class Armadilha_config : MonoBehaviour
{

    [Header("Configurações da Armadilha")]
    [SerializeField] private TipoArmadilha tipo = TipoArmadilha.Espeto;
    private Animator anim;

    [Header("Configurações Espetos")]
    //espeto
    [SerializeField] private float tempoAtivoE = 5f;
    [SerializeField] private float tempoInativoE = 3.5f;
    private float tempoE = 0;
    private Collider2D colisorEspeto;


    [Header("Configurações Torreta")]
    //torreta
    [SerializeField] private float tempoEntreDisparos = 3f;
    [SerializeField] private GameObject prefabProjetil;
    [SerializeField] private Transform disparador;
    [SerializeField] private float tempoAtivoT = 4f;
    [SerializeField] private float tempoIdleT = 4f;
    private float tempoT = 0;
    private Collider2D colisorTorreta;


















    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        switch (tipo)
        {
            case TipoArmadilha.Espeto:
                AtivaEspeto();
                break;
            case TipoArmadilha.Torreta:
                AtivaTorreta();
                break;
        }
    }

    private void AtivaEspeto()
    {
        tempoE += Time.deltaTime;

        if (tempoE < tempoAtivoE)
        {
            anim.SetInteger("Estado", 1);
            colisorEspeto.enabled = true;
        }
        else if (tempoE < tempoAtivoE + tempoInativoE)
        {
            anim.SetInteger("Estado", 2);
            colisorEspeto.enabled = false;
        }
        else
        {
            tempoE = 0f;
        }
    }

    private void AtivaTorreta()
    {
        tempoT += Time.deltaTime;
        if (tempoT < tempoAtivoT)
        {
            anim.SetInteger("EstadoT", 1);
            colisorTorreta.enabled = true;
        }
        else if (tempoT < tempoAtivoT + tempoIdleT)
        {
            anim.SetInteger("EstadoT", 2);
            colisorTorreta.enabled = true;
        }
        else
        {
            tempoT = 0f;
        }
    }
    public void DisparoTorreta()
    {
        Instantiate(prefabProjetil, disparador.position, disparador.rotation);
    }
}
