package com.contrastpong;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Input;
import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class Menu implements Screen {
	private final ContrastPong jogo;
	public Texture menu;
	public SpriteBatch batch;
	public MyGame game;
	
	public Menu(final ContrastPong jogo){
		this.jogo = jogo;
		batch = new SpriteBatch();
		menu = new Texture(Gdx.files.internal("menu.png"));
		game = new MyGame(this.jogo);
	}
	public void render(float delta) {
		batch.begin();
		batch.draw(menu, 0, 0, 640, 480);
		if(Gdx.input.isKeyPressed(Input.Keys.ENTER)){
			jogo.setScreen(game);
		}
		batch.end();
	}

	@Override
	public void resize(int width, int height) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void show() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void hide() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void pause() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void resume() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void dispose() {
		// TODO Auto-generated method stub
		
	}

}
