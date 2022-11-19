using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 movement;
    public float x = 0;
    public float z = 1;

    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(x, 0f, z);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movement;
    }
}
/*
void Start(){
    Bu fonksiyon ilk kez çalıştırıldığında çalışır.
}
void Update(){
    Bu fonksiyon her frame çalışır.
}
print() komutu console üzerine yazı yazmayı sağlar.
* Kodlar yukarıdan aşağıya doğru okunur.

DEĞİŞKENLER
* Değişkenler verdiğmiz bilgileri depolamamızı, değiştirmemize ve bu bilgiere erişmeye olanak sağlar.
* Her değişkenin bir tipi vardır.
* Her değişkenin bir ismi vardır.
* Her değişkenin bir değeri vardır.
* Her değişkenin bir erişim belirleyicisi vardır.

Erişim Belirleyicileri
* public: Her yerden erişilebilir.
* private: Sadece bu script içerisinden erişilebilir.
* null: Sadece bu script içerisinden erişilebilir.

Veri Tipleri
* int: Tam sayılar için kullanılır.
* float: Ondalıklı sayılar için kullanılır.
* string: Metinler için kullanılır.
* bool: True/False değerler için kullanılır.

Değişken Tanımlama

erişim belirleyicisi veriTipi degiskenIsmi = deger;
public int sayi = 5;
public bool isTrue = true;
private string metin = "Merhaba Dünya";
private float ondalikliSayi = 5.5f;

VEKTÖRLER
* Vektörler içinde yön belirten üç tane float değer tutar(x,y,z).
* Vektörlere değer atarken başına "new" yazılır.
* V harfi büyük olmalıdır.
* Vektörler bir değişkendir.
* private Vector3 vektor = new Vector3(1f,2f,3f);


*/