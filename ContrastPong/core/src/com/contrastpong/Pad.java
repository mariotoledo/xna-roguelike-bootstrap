package com.contrastpong;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.math.Rectangle;

public class Pad implements GameObject {
	
	Texture texture;
	
	private float x, y;
	boolean isLeft;
	Rectangle recpad = new Rectangle();

	public void create(float initialX, float initialY, boolean isLeft) {
		texture = new Texture(Gdx.files.internal("pad1.png"));
		this.x = initialX;
		this.y = initialY;
		this.isLeft = isLeft;
	}

	@Override
	public void render(SpriteBatch batch) {
		int aux = isLeft == false?0:25;
		recpad.set(this.x+aux, this.y, 1, texture.getHeight());
		batch.draw(texture, this.x, this.y);
	}

	@Override
	public void dispose() {
		texture.dispose();
	}
	
	public void moveUp(long space){
		if(y <= Settings.height-recpad.getHeight()){
			y += space;
		}
	}
	
	public void moveDown(long space){
		if(y >= 0){
			y -= space;
		}
	}

	@Override
	public void create(float initialX, float initialY) {
		// TODO Auto-generated method stub
		
	}
	
}
