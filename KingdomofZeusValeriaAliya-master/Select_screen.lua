-----------------------------------------------------------------------------------------
-- CreditsScreen.lua
-- Created by: Valeria Veverita
-- ICS2O
-- Description: This is the credits screen of the game
local composer = require( "composer" )

local widget = require("widget")

--give the name to the scene
sceneName = "Select_screen"

--creating scene object 
local scene = composer.newScene(sceneName)
  
-- -----------------------------------------------------------------------------------
-- Scene event functions
-- -----------------------------------------------------------------------------------
 
 --------------------------------------------------------------------------------
 --LOCAL VARIABLES
 ----------------------------------------------------------------------------
 local bkg
 local backButton

 local pannel
 local level1
 local level2
 local level2Button
 local level3
 local level3Button

 local lock1
 local lock2

 local tv
 local archer
 -------------------------------------------------------------------------------------
 --LOCAL FUNCTIONS
 -----------------------------------------------------------------------------
 --this function moves to main menu
 local function menuTransition()
    composer.gotoScene("main_menu", {effect = "fade", time = 300})
 end

--this functions moves to the charcater select screen
 local function characterLevel1()
    composer.gotoScene("Characters_Level1", {effect = "fade", time = 300})

 end

 --this functions moves to the charcater select screen
 local function characterLevel2()
    composer.gotoScene("Characters_Level2", {effect = "fade", time = 300})
 end

 --this functions moves to the charcater select screen
 local function characterLevel3()
    composer.gotoScene("Characters_Level3", {effect = "fade", time = 300})
 end

 --this function unlocks the levels (depends if the user passed previous level)
 local function unlockLevels()
   if (selectCounter == 1) then
     transition.to(lock1, {alpha = 0, time = 1000})
     level2.isVisible = false
     level2Button.isVisible = true
    elseif (selectCounter == 2) then
      transition.to(lock2, {alpha = 0, time = 1000})
      level3.isVisible = false
      level3Button.isVisible = true
      level2.isVisible = false
      level2Button.isVisible = true
      lock1.isVisible = false
   end
 end
-----------------------------------------------------------------------------
--GLOBAL SECENE FUNCTIONS
----------------------------------------------------------------------------------

-- create()
function scene:create( event )
 
    local sceneGroup = self.view
    -- Code here runs when the scene is first created but has not yet appeared on screen

    --create the background image
   bkg = display.newImageRect("MenuImages/MainMenuValeriaV.png", 0, 0, 0, 0)
   bkg.x = 510
   bkg.y = 385
   bkg.width = display.contentWidth
   bkg.height = display.contentHeight
   -- --Associating display objects with this scene
   sceneGroup:insert(bkg)
   
    --create the pannel
    pannel = display.newImage("SelectImages/SelectValeriaV.png")
    pannel.x = display.contentWidth/2
    pannel.y = display.contentHeight/2+50
    pannel.width = 900
    pannel.height = 500
    -- --Associating display objects with this scene
   sceneGroup:insert(pannel)
   
   ------------------------------
   --LEVELS BUTTONS
   -----------------------------
   --create the level1
   level1 = widget.newButton(
     {
     --load the image files
     defaultFile = "SelectImages/level1.png",
     --set the possition
     x = 250,
     y = 400,
     --set the size
     width = 270,
     height = 300,
     -- when the button is pressed call the function go to main scene
     onRelease = characterLevel1
      })
   -- --Associating display objects with this scene
   sceneGroup:insert(level1)

   --create the level2
   level2 = display.newImage("SelectImages/level2.png")
   level2.x = 520
   level2.y = 400
   level2.width = 270
   level2.height = 300
   -- --Associating display objects with this scene
   sceneGroup:insert(level2)

   --create the level2Button
   level2Button = widget.newButton(
     {
     --load the image files
     defaultFile = "SelectImages/level2.png",
     --set the possition
     x = 520,
     y = 400,
     --set the size
     width = 270,
     height = 300,
     -- when the button is pressed call the function go to main scene
     onRelease = characterLevel2
      })

   -- set the visibility of the level2Button
   level2Button.isVisible = false
   -- --Associating display objects with this scene
   sceneGroup:insert(level2Button)

   --create the level3
   level3 = display.newImage("SelectImages/level3.png")
   level3.x = 780
   level3.y = 400
   level3.width = 270
   level3.height = 300
   -- --Associating display objects with this scene
   sceneGroup:insert(level3)
   
   --create the level3Button
   level3Button = widget.newButton(
     {
     --load the image files
     defaultFile = "SelectImages/level3.png",
     --set the possition
     x = 780,
     y = 400,
     --set the size
     width = 270,
     height = 300,
     -- when the button is pressed call the function go to main scene
     onRelease = characterLevel3
      })

   -- set the visibility of the level2Button
   level3Button.isVisible = false
   -- --Associating display objects with this scene
   sceneGroup:insert(level3Button)

   ---------------------------------
   --LOCKS
   ---------------------------------
   --CREATE THE FIRST LOCK
   lock1 = display.newImage("SelectImages/lockValeriaV.png")
   lock1.x = 526
   lock1.y = 540
   lock1.alpha = 1
   -- --Associating display objects with this scene
   sceneGroup:insert(lock1)

   --create the second lock
   lock2 = display.newImage("SelectImages/lockValeriaV.png")
   lock2.x = 780
   lock2.y = 540
   lock2.alpha = 1
   -- --Associating display objects with this scene
   sceneGroup:insert(lock2)
   ------------------------------
   --BUTTONS
   -----------------------------
   --create the back button
   backButton = widget.newButton(
     { 
     --load the image files
     defaultFile = "ButtonImages/BackButtonUnpressed.png",
       overFile = "ButtonImages/BackButtonPressed.png",
     --set the possition
     x = 120,
     y = 100,
     --set the size
     width = 200,
     height = 200,
     -- when the button is pressed call the function go to main scene
     onRelease = menuTransition
      })
     sceneGroup:insert(backButton)



   
end
 
 
-- show()
function scene:show( event )
 
    local sceneGroup = self.view
    local phase = event.phase
    if ( phase == "will" ) then
        -- Code here runs when the scene is still off screen (but is about to come on screen)
        
    elseif ( phase == "did" ) then
        -- Code here runs when the scene is entirely on screen
        unlockLevels()
 
    end
end
 
 
-- hide()
function scene:hide( event )
 
    local sceneGroup = self.view
    local phase = event.phase
 
    if ( phase == "will" ) then
        -- Code here runs when the scene is on screen (but is about to go off screen)
 
    elseif ( phase == "did" ) then
        -- Code here runs immediately after the scene goes entirely off screen
    end
end
 
 
-- destroy()
function scene:destroy( event )
 
    local sceneGroup = self.view
    -- Code here runs prior to the removal of scene's view
 
end
 
 
-- -----------------------------------------------------------------------------------
-- Scene event function listeners
-- -----------------------------------------------------------------------------------
scene:addEventListener( "create", scene )
scene:addEventListener( "show", scene )
scene:addEventListener( "hide", scene )
scene:addEventListener( "destroy", scene )
-- -----------------------------------------------------------------------------------
 
return scene