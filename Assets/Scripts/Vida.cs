using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Vida : MonoBehaviour
{
    public TextMeshProUGUI textoVida;
    private int vidas;
    private int vidasRestantes;

    void Start()
    {
        vidas = 5;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision Player)
    {
        if(Player.gameObject.CompareTag("Armadilha"))
        {
            vidasRestantes = vidas - 1;
            switch(vidasRestantes)
            {
                case 0:
                    SceneManager.LoadScene("GamePlay");
                    break;
            }
        }
    }
}
