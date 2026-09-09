using UnityEngine;
using UnityEngine.Experimental.Playables;

public enum TipoArmadilha { Espeto, Torreta }

public class Armadilha_config : MonoBehaviour
{
    
    [Header("Configurações da Armadilha")]
    [SerializeField] private TipoArmadilha tipo = TipoArmadilha.Espeto;
    //espeto
    [SerializeField] private float tempoAtivo = 5f;
    [SerializeField] private float tempoSubindo = 2f;
    [SerializeField] private float tempoInativo = 3.5f;
    //torreta
    [SerializeField] private float tempoEntreDisparos = 2f;
    [SerializeField] private float velocidadeDisparo = 20f;

    private Animator anim;
    private float tempo = 0;
    private float cronometro;
    private Collider colisorEspeto;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        switch(tipo)
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
        tempo += Time.deltaTime;

        if (tempo < tempoAtivo)
        {
            anim.SetInteger("Estado", 1);
            colisorEspeto.enabled = true;
        }
        else if ( tempo < tempoAtivo + tempoInativo)
        {
           anim.SetInteger("Estado", 2);
            colisorEspeto.enabled = false; 
        }
        else
        {
            tempo = 0f;
        }
        //else if (tempo < tempoSubindo + tempoAtivo + tempoInativo )
        //{
        //    anim.SetInteger("Estado", 3); //desativa espeto
        //    colisorEspeto.enabled = false;
        //    tempo = 0;
        //}
        //else
        //{
        //    tempo = 0;
        //}

        //switch (tempo)
        //{
        //    case 1:
        //        anim.Play("Active_Espeto");
        //        colisorEspeto.enabled = true;
        //        break;

        //    case 2:
        //        anim.Play("Idle_Espeto");
        //        colisorEspeto.enabled = true;
        //        break;

        //    case 3:
        //        anim.Play("Deactive_Espeto");
        //        colisorEspeto.enabled = false;
        //        break;
        //}

    }
    
    private void AtivaTorreta()
    {
        
    }
}
