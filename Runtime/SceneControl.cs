using UnityEngine;
using UnityEngine.SceneManagement;
namespace elvis.tool 
{
    /// <summary>
    /// 場景控制 載入與離開
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="senceName">要載入的場景名稱</param>
        public void LoadScence(string senceName)
        {
            //場景管理器 讀取場景(場景名稱)
            SceneManager.LoadScene(senceName);

        }
        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            //應用程式 離開()
            Application.Quit();

        }
    }
}

