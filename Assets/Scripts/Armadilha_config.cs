using UnityEngine;

public enum TipoArmadilha { Espeto, Torreta }

public class Armadilha_config : MonoBehaviour
{
    
    [Header("Configurações da Armadilha")]
    [SerializeField] private TipoArmadilha tipo = TipoArmadilha.Espeto;

    private Animator anima;


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
        
    }

    private void AtivaTorreta()
    {

    }
}
