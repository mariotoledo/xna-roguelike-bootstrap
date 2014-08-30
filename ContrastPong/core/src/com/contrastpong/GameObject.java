package com.contrastpong;

import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public interface GameObject {
	void create(float initialX, float initialY);
	void render(SpriteBatch batch);
	void dispose();
}
