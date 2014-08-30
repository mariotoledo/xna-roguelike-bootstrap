package com.contrastpong;

import com.badlogic.gdx.Game;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class ContrastPong extends Game{
	
	MyGame game;
	Menu gameMenu;
    public Texture menu;
    public SpriteBatch batch;

   @Override
   public void create() {
	   batch = new SpriteBatch();
       game = new MyGame(this);
       gameMenu = new Menu(this);
       menu = new Texture(Gdx.files.internal("menu.png"));
       this.setScreen(gameMenu);
   }   
}