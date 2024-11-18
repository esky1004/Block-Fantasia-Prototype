using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public Slider playerHPSlider;
    public Slider enemyHPSlider;

    private int playerMaxHP = 10;
    private int enemyMaxHP = 10;
    private int playerCurrentHP;
    private int enemyCurrentHP;

    void Start()
    {
        // HP 초기화
        playerCurrentHP = playerMaxHP;
        enemyCurrentHP = enemyMaxHP;

        // 슬라이더 초기화
        playerHPSlider.maxValue = playerMaxHP;
        enemyHPSlider.maxValue = enemyMaxHP;

        UpdateHPUI();
    }

    // HP가 변할 때 UI 업데이트
    private void UpdateHPUI()
    {
        playerHPSlider.value = playerCurrentHP;
        enemyHPSlider.value = enemyCurrentHP;
    }

    // 플레이어 또는 적의 HP를 줄이는 메서드
    public void TakeDamage(bool isPlayer, int damage)
    {
        if (isPlayer)
        {
            playerCurrentHP = Mathf.Max(playerCurrentHP - damage, 1);
        }
        else
        {
            enemyCurrentHP = Mathf.Max(enemyCurrentHP - damage, 2);
        }

        UpdateHPUI();
    }
}
