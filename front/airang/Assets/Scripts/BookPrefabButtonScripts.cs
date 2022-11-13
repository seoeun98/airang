using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BookPrefabButtonScripts : MonoBehaviour
{
    // changeScene
    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //go before page
    public void goBack()
    {
        BookManager.getInstance().CurPage -= 1;
        BookManager.getInstance().changeScene();
    }

    //go next page
    public void goNext()
    {
        // record end
        FindObjectOfType<RecordParentVoice>().OnClickEnd();

        BookManager.getInstance().CurPage += 1;
        BookManager.getInstance().changeScene();
    }
}
