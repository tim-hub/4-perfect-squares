using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetNumberOfPerfectSquare : MonoBehaviour {
	public InputField inputX;
	public Text label;

	int x;




	void Start () {
		
		GetX();
	}
	
	void GetX(){ //get x value from input field

		x=int.Parse(inputX.text.ToString());
		Debug.Log("input:"+x);
	}


	/// <summary>
	/// Use less than 4 loops to calculate the combination.
	/// And plese see the log out to get the seperating values.
	/// </summary>
	int Calculate(){


		if( IsAPerfectSquare(x) ){ //x is a perfecr square

			Debug.Log(x);
			return 1;

		}else{
			for (int i=x;x>=1;i--){
				if(IsAPerfectSquare(i)){
					Debug.Log(i);

					if(IsAPerfectSquare(x-i)){
						Debug.Log(x-i);
						return 2;

					}


					for (int ii=x-i;ii>=1;ii--){
						if(IsAPerfectSquare(ii)){

							Debug.Log(ii);
							if(IsAPerfectSquare(x-i-ii)){
								Debug.Log(x-i-ii);
								return 3;

							}



							for(int iii=x-i-ii;iii>=1;iii--){

								if(IsAPerfectSquare(iii)){

									Debug.Log(iii);
									if(IsAPerfectSquare(x-i-ii-iii)){
										Debug.Log(x-i-ii-iii);
										return 4;

									}

								}

							}

						}

					}

				}

			}
		}


		return 0;
	}

	bool IsAPerfectSquare(int i){


		return (i==Mathf.Floor(i)&&Mathf.Sqrt(i)%1==0); //check the i is an integer and a prefecr square

	}

	public void GetTheSum(){

		GetX();
		label.text=Calculate().ToString();

	}
}
