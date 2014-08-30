package com.contrastpong;

public class GameHelper {
	int scorej1, scorej2;
	
	public void pontuaJog1(){
		scorej1 += 1;
	}
	
	public void pontuaJog2(){
		scorej2 += 1;
	}
	
	public int getScoreJogador1(){
		return scorej1;
	}
	public int getScoreJogador2(){
		return scorej2;
	}
}
