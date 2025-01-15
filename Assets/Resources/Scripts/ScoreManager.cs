using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Canvas'taki anlık puan göstergesi
    public GameObject gameOverScreen; // Oyun sonu ekranı
    public Text finalScoreText; // Oyun sonunda gösterilecek puan

    public int score = 0; // Başlangıç puanı
    public int correctAnswerPoints = 10; // Doğru cevapta artacak puan
    public int wrongAnswerPoints = 5; // Yanlış cevapta azalacak puan

    // Puanı artırır ve günceller
    public void AddScore()
    {
        score += correctAnswerPoints;
        UpdateScoreText();
    }

    // Puanı azaltır ve günceller
    public void SubtractScore()
    {
        score -= wrongAnswerPoints;
        if (score < 0)
        {
            score = 0; // Puan sıfırın altına inmesin
        }
        UpdateScoreText();
    }

    // Oyun sonunda puanı gösterir
    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); // Oyun sonu ekranını aç
        finalScoreText.text = "Toplam Puan: " + score.ToString(); // Puanı göster
    }

    // Puan Text'ini günceller
    private void UpdateScoreText()
    {
        scoreText.text = "Toplam Puan: " + score.ToString();
    }
}
