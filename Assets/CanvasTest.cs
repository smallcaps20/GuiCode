using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasTest : MonoBehaviour {

	GameObject _gameObject;
	Canvas _canvas;

	// Use this for initialization
	void Start () {
		_gameObject = new GameObject();
		_gameObject.name = "myGO";
		_gameObject.AddComponent<Canvas>();
		_canvas = _gameObject.GetComponent<Canvas>();
		_canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		
		//Adding a Rect Trnasform
//		_gameObject.AddComponent<RectTransform>();
		
		//Adding a Text component
		_gameObject.AddComponent<Text>();
		Text _text = _gameObject.GetComponent<Text>();
		_text.text = "Blah Blah!";
		_text.font = UnityEngine.Resources.Load( @"Fonts/TitilliumWeb-Black" ) as UnityEngine.Font;
		_text.color = Color.red;
		_text.fontSize = 200;
		_text.transform.position = new Vector2( 10f, 10f );
//		_text.rectTransform.sizeDelta = new Vector2( 100f, 100f );
//		_text.rectTransform.Rotate(0f,10f,0f);

//		_gameObject.GetComponent<RectTransform>().SetParent(this.transform, false);
//		_gameObject.transform.localRotation = Quaternion.Angle (0, 90);

//		RectTransform _canvasRT = _gameObject.GetComponent<RectTransform>();
//		_canvasRT.anchoredPosition3D = new Vector3( 0f, 0f, 0f );
//		_canvasRT.sizeDelta = new Vector2( 0f, 0f );
//		_canvasRT.anchorMax = new Vector2( 1f, 1f );
//		_canvasRT.anchorMin = new Vector2( 0f, 0f );

		//_canvasRT.transform.Rotate(100f,1000f,100f);

		_canvas.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
