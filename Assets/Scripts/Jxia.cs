using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class JogoDaVelhaia : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;

    private bool clicado1;
    private bool clicado2;
    private bool clicado3;
    private bool clicado4;
    private bool clicado5;
    private bool clicado6;
    private bool clicado7;
    private bool clicado8;
    private bool clicado9;

    public bool turnX = true;
    public Text messageText;
    public AudioSource audioSourcePlayer;
    public AudioSource audioSourcePlayerO;

    void Start()
    {
        // Inicializa todas as variáveis clicado como false
        clicado1 = false;
        clicado2 = false;
        clicado3 = false;
        clicado4 = false;
        clicado5 = false;
        clicado6 = false;
        clicado7 = false;
        clicado8 = false;
        clicado9 = false;
    }

    void Update()
    {
        // Chama a função AIMove apenas se for a vez da IA jogar
        if (!turnX)
        {
            AIMove();
        }
        else
        {
            // Se for a vez do jogador, você pode colocar qualquer lógica específica aqui
        }
    }

    public void ClickButton1ia()
    {
        if (!clicado1)
        {
            if (turnX)
            {
                text1.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text1.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado1 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton2ia()
    {
        if (!clicado2)
        {
            if (turnX)
            {
                text2.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text2.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado2 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton3ia()
    {
        if (!clicado3)
        {
            if (turnX)
            {
                text3.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text3.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado3 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton4ia()
    {
        if (!clicado4)
        {
            if (turnX)
            {
                text4.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text4.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado4 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton5ia()
    {
        if (!clicado5)
        {
            if (turnX)
            {
                text5.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text5.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado5 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton6ia()
    {
        if (!clicado6)
        {
            if (turnX)
            {
                text6.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text6.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado6 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton7ia()
    {
        if (!clicado7)
        {
            if (turnX)
            {
                text7.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text7.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado7 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton8ia()
    {
        if (!clicado8)
        {
            if (turnX)
            {
                text8.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text8.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado8 = true;
            VerificarVitoria();
        }
    }

    public void ClickButton9ia()
    {
        if (!clicado9)
        {
            if (turnX)
            {
                text9.text = "X";
                turnX = false;
                messageText.text = "IA: O";
                audioSourcePlayer.Play();
            }
            else
            {
                text9.text = "O";
                turnX = true;
                messageText.text = "Jogador: X";
                audioSourcePlayerO.Play();
            }
            clicado9 = true;
            VerificarVitoria();
        }
    }

    public void AIMove()
    {
        // Array para armazenar as posições dos textos
        Text[] texts = { text1, text2, text3, text4, text5, text6, text7, text8, text9 };

        // Estratégia para bloquear as jogadas do jogador
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                // Simula a jogada do jogador e verifica se o jogador ganharia na próxima jogada
                texts[i].text = "O";
                if (CheckForWin("O"))
                {
                    texts[i].text = "O"; // Bloqueia a jogada do jogador
                    turnX = true;
                    messageText.text = "Jogador: X";
                    VerificarVitoria();
                    return;
                }
                else
                {
                    texts[i].text = ""; // Desfaz a simulação
                }
            }
        }

        // Estratégia para buscar uma vitória iminente
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                // Simula a jogada da IA e verifica se ela ganharia na próxima jogada
                texts[i].text = "X";
                if (CheckForWin("X"))
                {
                    texts[i].text = "O"; // Faz a jogada da IA para ganhar o jogo
                    turnX = true;
                    messageText.text = "Jogador: X";
                    VerificarVitoria();
                    return;
                }
                else
                {
                    texts[i].text = ""; // Desfaz a simulação
                }
            }
        }

        // Se nenhuma estratégia for possível, escolhe uma posição aleatória
        List<int> emptyCellsIndexes = new List<int>();
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                emptyCellsIndexes.Add(i);
            }
        }

        if (emptyCellsIndexes.Count > 0)
        {
            int randomIndex = Random.Range(0, emptyCellsIndexes.Count);
            int cellIndex = emptyCellsIndexes[randomIndex];
            texts[cellIndex].text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
            VerificarVitoria();
        }
    }

    private bool CheckForWin(string player)
    {
        // Array para armazenar as posições dos textos
        Text[] texts = { text1, text2, text3, text4, text5, text6, text7, text8, text9 };

        // Verificações de vitória para linhas, colunas e diagonais
        for (int i = 0; i < 3; i++)
        {
            // Linhas
            if (texts[i * 3].text == player && texts[i * 3].text == texts[i * 3 + 1].text && texts[i * 3].text == texts[i * 3 + 2].text)
            {
                return true;
            }

            // Colunas
            if (texts[i].text == player && texts[i].text == texts[i + 3].text && texts[i].text == texts[i + 6].text)
            {
                return true;
            }
        }

        // Diagonal principal
        if (texts[0].text == player && texts[0].text == texts[4].text && texts[0].text == texts[8].text)
        {
            return true;
        }

        // Diagonal secundária
        if (texts[2].text == player && texts[2].text == texts[4].text && texts[2].text == texts[6].text)
        {
            return true;
        }

        return false;
    }

    private void VerificarVitoria()
    {
        // Array para armazenar as posições dos textos
        Text[] texts = { text1, text2, text3, text4, text5, text6, text7, text8, text9 };

        // Verificações de vitória para linhas, colunas e diagonais
        for (int i = 0; i < 3; i++)
        {
            // Linhas
            if (texts[i * 3].text != "" && texts[i * 3].text == texts[i * 3 + 1].text && texts[i * 3].text == texts[i * 3 + 2].text)
            {
                messageText.text = texts[i * 3].text + " ganhou!";
                PararJogo();
                return;
            }

            // Colunas
            if (texts[i].text != "" && texts[i].text == texts[i + 3].text && texts[i].text == texts[i + 6].text)
            {
                messageText.text = texts[i].text + " ganhou!";
                PararJogo();
                return;
            }
        }

        // Diagonal principal
        if (texts[0].text != "" && texts[0].text == texts[4].text && texts[0].text == texts[8].text)
        {
            messageText.text = texts[0].text + " ganhou!";
            PararJogo();
            return;
        }

        // Diagonal secundária
        if (texts[2].text != "" && texts[2].text == texts[4].text && texts[2].text == texts[6].text)
        {
            messageText.text = texts[2].text + " ganhou!";
            PararJogo();
            return;
        }

        // Checa se todos os botões foram clicados e não há vencedor
        if (text1.text != "" && text2.text != "" && text3.text != "" &&
            text4.text != "" && text5.text != "" && text6.text != "" &&
            text7.text != "" && text8.text != "" && text9.text != "")
        {
            messageText.text = "Empate";
        }
    }

    private void PararJogo()
    {
        // Desativa a interação com os botões
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
    }
}
