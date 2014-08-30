
package com.contrastpong;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Input;
import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.g2d.BitmapFont;

public class MyGame extends ApplicationAdapter implements Screen{

	private final ContrastPong jogo;
	Pad pad1 = new Pad();
	Pad pad2 = new Pad();
	Ball ball = new Ball();
	GameHelper gh;
	float elapsedTime;
	boolean troca = false;
	
	BitmapFont font;
	
	public MyGame(final ContrastPong jogo){
		this.jogo = jogo;
		
		gh = new GameHelper();
		font = new BitmapFont();
		
		pad1.create(10, Settings.height/2 - 125/2, true);
		pad2.create(Settings.width - 35, Settings.height/2 - 125/2, false);
		ball.create(Settings.width/2 - 15, Settings.height/2 - 15);
	}
	
	@Override
	public void render (float delta) {
		int random = (int) (Math.random()*200)+1;
		if(random == 1){
			troca = !troca;
		}
		
		if(troca == true){
			Gdx.gl.glClearColor(1, 0, 0, 1);
		}else{
			Gdx.gl.glClearColor(0, 1, 0, 1);
		}
		Gdx.gl.glClear(GL20.GL_COLOR_BUFFER_BIT);
		jogo.batch.begin();
		pad1.render(jogo.batch);
		pad2.render(jogo.batch);
		ball.render(jogo.batch);
		this.font.draw(jogo.batch, ""+gh.getScoreJogador1(), 200, 470);
		this.font.draw(jogo.batch, ""+gh.getScoreJogador2(), 400, 470);
		elapsedTime += Gdx.graphics.getDeltaTime();
		ball.setMult(elapsedTime/10);
		
		if(troca == false){
			if(Gdx.input.isKeyPressed(Input.Keys.W)){
				pad1.moveUp(10);
			}
			
			if(Gdx.input.isKeyPressed(Input.Keys.S)){
				pad1.moveDown(10);
			}
			if(Gdx.input.isKeyPressed(Input.Keys.UP)){
				pad2.moveUp(10);
			}
			
			if(Gdx.input.isKeyPressed(Input.Keys.DOWN)){
				pad2.moveDown(10);
			}
		}else{
			if(Gdx.input.isKeyPressed(Input.Keys.W)){
				pad2.moveUp(10);
			}
			
			if(Gdx.input.isKeyPressed(Input.Keys.S)){
				pad2.moveDown(10);
			}
			if(Gdx.input.isKeyPressed(Input.Keys.UP)){
				pad1.moveUp(10);
			}
			
			if(Gdx.input.isKeyPressed(Input.Keys.DOWN)){
				pad1.moveDown(10);
			}
		}
		if(Gdx.input.isKeyPressed(Input.Keys.ENTER))
			troca = !troca;
		
		if(pad1.recpad.overlaps(ball.recball)){
			ball.invertx();
		}
		if(pad2.recpad.overlaps(ball.recball)){
			ball.invertx();
		}
		if(ball.outLeft()){
			gh.pontuaJog2();
			ball.reset();
			elapsedTime = 0;
		}
		if(ball.outRight()){
			gh.pontuaJog1();
			ball.reset();
			elapsedTime = 0;
		}
		jogo.batch.end();
	}

	@Override
	public void show() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void hide() {
		// TODO Auto-generated method stub
		
	}

}
