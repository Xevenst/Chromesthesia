using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ScoreScreenScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
  }
  public void toSettings()
  {
    SceneManager.LoadScene("SettingsScene", LoadSceneMode.Additive);
  }

  public void toSongList() {
    SceneManager.LoadScene("SongList", LoadSceneMode.Single);
  }

  public void playAgainPressed(){
    SceneManager.LoadScene("GameScreen", LoadSceneMode.Single);
  }

  private bool IsPointerOverUIObject()
  {
    var eventDataCurrentPosition = new PointerEventData(EventSystem.current)
    {
      position = new Vector2(Input.mousePosition.x, Input.mousePosition.y)
    };
    var results = new List<RaycastResult>();
    EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
    return results.Count > 0;
  }
}