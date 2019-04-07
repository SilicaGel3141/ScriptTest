using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start() {
		Debug.Log( "◆課題◆" );
		Task1();

		Debug.Log( "◆発展課題◆" );
		int tmp_cnt;
		Boss mptest = new Boss();

		for( tmp_cnt = 0 ; tmp_cnt < 12 ; tmp_cnt++ ) {
			mptest.Magic();
		}

	}

	// Update is called once per frame
	void Update() {

	}

	void Task1() {
		/* 課題：要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください */
		int[] task_arr = { 10, 20, 30, 40, 50 };
		int lp_cnt;     /* Loop用TMP */

		/* 課題：for文を使い、配列の各要素の値を順番に表示してください */
		for (lp_cnt = 0; lp_cnt < task_arr.Length; lp_cnt++) {
			Debug.Log( task_arr[lp_cnt] );
		}


		/* 課題：for文を使い、配列の各要素の値を逆順に表示してください */
		int arr_disp;
		for (lp_cnt = 0; lp_cnt < task_arr.Length; lp_cnt++) {
			arr_disp = task_arr.Length - ( lp_cnt + 1 );        /* Length - Loop数 + 1 */
			Debug.Log( task_arr[arr_disp] );
		}

	}
}

public class Boss {
	//private int hp = 100;
	//private int power = 25;
	private int mp = 53;

	public void Magic() {

		if (mp >= 5) {  /* MPが足りている? */
			mp -= 5;    /* MPの消費 */
			Debug.Log( "魔法攻撃をした。残りMPは" + mp + "。" );
		} else {        /* MPが足りない */
			Debug.Log( "MPが足りないため魔法が使えない。" );
		}


	}

	//public void Attack() {
	//	Debug.Log( this.power + "のダメージを与えた" );
	//}

	//public void Defence(int damage) {
	//	Debug.Log( damage + "のダメージを受けた" );
	//	this.hp -= damage;
	//}



}