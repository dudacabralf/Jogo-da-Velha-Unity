using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class JogoDaVelha : MonoBehaviour
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


    public void ClickButton1()
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
            VictoryCheck();
        }
    }

    public void ClickButton2()
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
            VictoryCheck();
        }
    }

    public void ClickButton3()
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
            VictoryCheck();
        }
    }

    public void ClickButton4()
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
            VictoryCheck();
        }
    }

    public void ClickButton5()
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
            VictoryCheck();
        }
    }

    public void ClickButton6()
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
            VictoryCheck();
        }
    }

    public void ClickButton7()
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
            VictoryCheck();
        }
    }

    public void ClickButton8()
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
            VictoryCheck();
        }
    }

    public void ClickButton9()
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
            VictoryCheck();
        }
    }

    private void VictoryCheck()
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
                StopGame();
                return;
            }

            // Colunas
            if (texts[i].text != "" && texts[i].text == texts[i + 3].text && texts[i].text == texts[i + 6].text)
            {
                messageText.text = texts[i].text + " ganhou!";
                StopGame();
                return;
            }
        }

        // Diagonal principal
        if (texts[0].text != "" && texts[0].text == texts[4].text && texts[0].text == texts[8].text)
        {
            messageText.text = texts[0].text + " ganhou!";
            StopGame();
            return;
        }

        // Diagonal secundária
        if (texts[2].text != "" && texts[2].text == texts[4].text && texts[2].text == texts[6].text)
        {
            messageText.text = texts[2].text + " ganhou!";
            StopGame();
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

    private void StopGame()
    {
        // Desativa a interação com os botões
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
    }
}
