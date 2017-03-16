using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageSplashXilo : MonoBehaviour {
    public Sprite trasnparente;
    public Sprite animalito;

	void Start () {
        GetComponent<Image>().sprite = trasnparente;
	}

    public void ChagenGilado(Sprite animalitoAux) {
        StartCoroutine(animalitoSprite(animalitoAux));

    }

    IEnumerator animalitoSprite(Sprite animalitoAux) {

        GetComponent<Image>().sprite = animalitoAux;

        yield return new WaitForSeconds(5);

        GetComponent<Image>().sprite = trasnparente;

        yield return null;
    }
}
