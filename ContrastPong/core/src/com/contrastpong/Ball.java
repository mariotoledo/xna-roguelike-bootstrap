package com.contrastpong;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.math.Rectangle;

public class Ball implements GameObject{

	Texture texture;	
	float mult;
	float x, y, xin, yin;
	float posx = 1, posy = 1;
	Rectangle recball = new Rectangle();
	
	@Override
	public void create(float initialX, float initialY) {
		texture = new Texture(Gdx.files.internal("ball.png"));
		this.xin = initialX;
		this.yin = initialY;
		x = xin;
		y = yin;
	}
	
	public void setMult(float mult){
		this.mult = mult;
	}

	@Override
	public void render(SpriteBatch batch) {
		x = x + mult*(5*(posx));
		y = y + mult*(5*(posy));
		recball.set(this.x, this.y, texture.getWidth(), texture.getHeight());
		
		if (y >= Settings.height - 30){
			posy = -1;
		}
		
		if (y <= 0){
			posy = 1;
		}
		
		if (x >= Settings.width || x <= 0){
			reset();
		}
		
		batch.draw(texture, this.x, this.y);
	}
	
	public void reset(){
		x = Settings.width/2 - 15;
		y = Settings.height/2 - 15;
		invertx();
		mult = 0;
	}
	public void invertx(){
		posx = posx * -1;
	}

	@Override
	public void dispose() {
		texture.dispose();
	}

	public boolean outLeft(){
		return x<5;
	}
	
	public boolean outRight(){
		return x>635;
	}
}
