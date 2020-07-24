// Script was generated with < FIFA Series Skills Generator > ver. 7.25 Date :07/18/20 Time: 4:31:09 p. m.
//------------------------------------------------------------------------
/********************************************************************************************** 
This Script was made and intended for www.cronusmax.com & CronusMAX ONLY.                     * 
UNLESS permission is given by the creator and/or copywritee,                                  * 
All rights reserved. This material may not be reproduced, displayed,                          * 
modified or distributed without the express prior written permission of the                   * 
copyright holder. For permission, contact CronusMax.                                          * 
    __  ____   ___   ____   __ __  _____ ___ ___   ____  __ __                                * 
   /  ]|    \ /   \ |    \ |  |  |/ ___/|   |   | /    ||  |  |                               * 
  /  / |  D  )     ||  _  ||  |  (   \_ | _   _ ||  o  ||  |  |                               * 
 /  /  |    /|  O  ||  |  ||  |  |\__  ||  \_/  ||     ||_   _|                               * 
/   \_ |    \|     ||  |  ||  :  |/  \ ||   |   ||  _  ||     |                               * 
\     ||  .  \     ||  |  ||     |\    ||   |   ||  |  ||  |  |                               * 
 \____||__|\_|\___/ |__|__| \__,_| \___||___|___||__|__||__|__|                               * 
                                                                                              * 
************************************************************************************************/ 
                                                                       
/***********************************************************************
                                                                       
 ________  ______  ________   ______          ______    ______              
|        \|      \|        \ /      \        /      \  /      \             
| $$$$$$$$ \$$$$$$| $$$$$$$$|  $$$$$$\      |  $$$$$$\|  $$$$$$\            
| $$__      | $$  | $$__    | $$__| $$       \$$__| $$| $$$\| $$            
| $$  \     | $$  | $$  \   | $$    $$       /      $$| $$$$\ $$            
| $$$$$     | $$  | $$$$$   | $$$$$$$$      |  $$$$$$ | $$\$$\$$            
| $$       _| $$_ | $$      | $$  | $$      | $$_____ | $$_\$$$$            
| $$      |   $$ \| $$      | $$  | $$      | $$     \ \$$  \$$$            
 \$$       \$$$$$$ \$$       \$$   \$$       \$$$$$$$$  \$$$$$$             
                                                                            
                                                                         
*************************************************************************/
                                                                         
///////////////       ONE WAY SKILLS       \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//-----------------------------------------------------------------------
                                                                         
///\ 0. None.//\0. None.//\4. Rainbow //\9. Drag to Drag//\
//////////////////////////////////////////////////////////
//       DESCRIPTIONS - INSTRUCTION                      
//                                                       
//                                                        
//                                                        
// Skill 3  : 4. Rainbow  => one tap : PS4_L3
//                                                        
// Skill 4  : 9. Drag to Drag => one tap : PS4_R3
//                                                        
//           
//           
//           
//           
//-------------------------------------------------------------- 
// DECLARATIONS                                                  
//-------------------------------------------------------------- 
define timelimit     = 300; // Time to Double click     
//////////////////////////////////////////////////////////////////
// YOUR BUTTON LAYOUT 
define PaceCtrol     = PS4_L2; // Pace Control
define FinesseShot   = PS4_R2; // Finesse Shot
define PlayerRun     = PS4_L1; // Player Run  
define ShotBtn       = PS4_SQUARE; // Shot Btn  
define SprintBtn     = PS4_R1; // Sprint Btn 
define PassBtn       = PS4_CROSS; // Pass Btn 
define MOVE_X        = PS4_LX;        
define MOVE_Y        = PS4_LY;        
define SKILL_STICK_X = PS4_RX;        
define SKILL_STICK_Y = PS4_RY;        
//-------------------------------------------------------------- 
// SKILLS LIST                                                   
//-------------------------------------------------------------- 
define FAKE_SHOT_SKILL                 = 1;// Fake Shot                    
define HEEL_TO_HEEL_FLICK_SKILL        = 2;// Heel to Heel                 
define HEEL_FLICK_TURN_SKILL           = 3;// R1 + Heel to Heel            
define RAINBOW_SKILL                   = 4;// Simple Rainbow               
define DRAG_BACK_SOMBRERO_SKILL        = 5;// Drag Back + R3 press         
define FAKE_PASS_SKILL                 = 6;// R2 + Fake Shot               
define DRAG_BACK_UNIVERSAL_SKILL       = 7;// hold R1, LS down              
define STEP_OVER_FEINT_SKILL           = 8;//                               
define DRAG_TO_DRAG_SKILL              = 9;// L2 + Fake Shot + LS zero      
define HOCUS_POCUS_SKILL               =10;// RS D to L, half circle L to R 
define TRIPLE_ELASTICO_SKILL           =11;// RS D to R, half circle R to L 
define ELASTICO_SKILL                  =12;// half circle from R to L       
define REVERSE_ELASTICO_SKILL          =13;// half sircle from L to R       
define CRUYFF_TURN_SKILL               =14;// Fake Shot + LS down           
//--------------------------------------------------------------            
define LA_CROQUETA_SKILL               =15;// L1 + RS                       
//--------------------------------------------------------------            
define RONALDO_CHOP_SKILL              =16;// L2 + Fake Shot                 
define ROULETTE_SKILL                  =17;// Roulette                       
define FLAIR_ROULETTE_SKILL            =18;// L1 + Roulette                  
define BALL_ROLL_SKILL                 =19;// Ball Roll                     
define BERBA_MCGEADY_SPIN_SKILL        =20;// RS Up , <-/->                  
define BOLASIE_FLICK_SKILL             =21;// R1 + BERBA Spin                 
define TORNADO_SKILL                   =22;// L1 + Berba Spin                  
define THREE_TOUCH_ROULETTE_SKILL      =23;// L2 + RS Down, <-/->               
define ALTERNATIVE_ELASTICO_CHOP_SKILL =24;// R1 + RS Down, <-/->                 
define BALL_ROLL_CHOP_SKILL            =25;// hold RS <-/ hold RS ->                
define FEINT_AND_EXIT_SKILL            =26;// hold L1 + RS half circle from L to R / from R to L 
define FEINT_L_EXIT_R_SKILL            =27;// RS half circle from L to R / from R to L 
define LATERAL_HEEL_TO_HEEL_SKILL      =28;//  L1 + RS <-/->
define WAKA_WAKA_SKILL                 =29;// WAKA WAKA 
//--------------------------------------------------------------   
//-----------------------------
                      
// VARIABLES            
//--------------------------------------------------------------
//  ******    IMPORTANT    *******                    
// ****** PENALTY shot power *******                  
// adjust shot power to your player                   
//*************************************************   
int onoff_penalty;                                   
int dir;                                      
int LeftRight,UpDown;                         
//---------------------------                       
                                                  
//-------------------------------------------- 
define TOP_SPIN       = 1;                     
define SIDE_SPIN      = 2;                     
define KNUCKLEBALL_FK = 3;                     
define spin_time      = 80;                    
//-------------------------------------------- 
                                               
// VARIABLES  for FREE KICK MOD                                 
int onoff_FK;                                  
int shot_power = 355;                          
int side_dir   = 100;                          
int FK_mode = 1;  
//---------------------------                 
//--------------------------------------------------------------   
//--------------------------------------------------------------   
// VARIABLES                                                       
//--------------------------------------------------------------   
                                               
int LX, LY;          // Direction of Left Stick         
int OnOffMods          =TRUE;                  
int right_on;                      
int w_rstick  = 40;                
int SKILL;
int fk_timing;             
////////////////////////////////// 
int _currentSlot;
 
init {
 
    _currentSlot = get_slot();
 
}                
                                               
//--------------------------------------------------------------
// MAIN BLOCK                                                   
//--------------------------------------------------------------
main {
  //-------------------------------------------------------------- 
  //  Slot changer 
  if(get_val(PS4_TOUCH)){                      
    if(event_press(PS4_R1)){             
      load_slot(_currentSlot + 1);
      set_val(PS4_R1,0);
    }
    if(event_press(PS4_L1)){             
      load_slot(_currentSlot - 1);
      set_val(PS4_L1,0);
    }                         
  }
  //--------------------------------------------------------------
  //  Finesse Power Restriction                                                      
  if (get_val(FinesseShot) && !onoff_penalty && !onoff_FK ) {                                                     
    if(get_val(ShotBtn) && get_ptime(ShotBtn) > 250 ) {
    	set_val(ShotBtn,0);
    }
  }
  //--------------------------------------------------------------
  //  turn ON Penalty  hold  L1 and press OPTIONS 
  if(get_val(PS4_L1)){                      
    if(event_press(PS4_OPTIONS)){             
      onoff_penalty = !onoff_penalty;
      set_val(PS4_OPTIONS,0);   
    }                                                                  
  }
  //--------------------------------------------------------------
  //  Penalty kicks
  if(onoff_penalty) {
    // Fast penalty kick 
    if(get_val(PS4_TOUCH)) {
      set_val(PS4_TOUCH, 0);
      set_val(PS4_L1,100);
      set_val(PS4_LX, 78);                         
      set_val(PS4_LY,-38);
      combo_run(PK_TimedFinish);
    }
    // --------------------------
    // Menu penalty kick 
    if(event_press(PS4_RIGHT))  LeftRight = 1;// Right
                                                    
    if(event_press(PS4_LEFT)) LeftRight = 2;// Left
                                                    
    if(event_press(PS4_DOWN)) UpDown = 3;//  Down 
                                                    
    if(event_press(PS4_UP)) UpDown = 4; set_val(PS4_UP,0);//  Up
      
    dir = LeftRight * UpDown ;          
      // Right Down   
    if(dir == 3 ){                               
      set_val(PS4_LX,55);                         
      set_val(PS4_LY,90);                         
    }                                            
      //Right Up                         
    if(dir == 4 ){                              
      set_val(PS4_LX, 78);                         
      set_val(PS4_LY,-38);                        
    }                                            
      // Left Up                   
    if(dir == 8 ){                              
      set_val(PS4_LX,-77);                        
      set_val(PS4_LY,-38);                      
    }                                            
      // Left Down                              
    if(dir == 6 ){                              
      set_val(PS4_LX,-54);                        
      set_val(PS4_LY, 90);                        
    }                                            
    if(get_val(ShotBtn)  ){
    	set_val(ShotBtn,0);                           
    	combo_run(PK_TimedFinish);                       
    }                                             
   } else dir = 0;                                
                                                                                                    
  //-----------------------------------------------------------------------
  //--------------------------------------------------------------  
  ////////////////////////////////  
  // LED color indication           
  if(onoff_FK)  colorled(0,0,2,0); 
  else if(onoff_penalty)  colorled(0,2,0,0); 
  else  colorled(2,0,0,0);
	//-----------------------------------------  
	// ON / OFF FREE KICK MODE                   
	// hold R2/RT and press SHARE/MENU           
	if(get_val(PS4_R1)){                          
    if(event_press(PS4_SHARE)){             
      onoff_FK = !onoff_FK;
      set_val(PS4_SHARE,0);               
    }                                                           
  }                                                                                       
  set_val(TRACE_1,onoff_FK);                 
  set_val(TRACE_2,FK_mode);                   
  set_val(TRACE_3,shot_power/10);             
  //-----------------------------------------                                
  //-----------------------------------------
  // Freekicks Menu
  if(onoff_FK){                                             
		/////////////////////////////////////////// 
		// AIMING FIX :                                 
		// AIM and then press and hold R2/RT to fix aiming 
		if(!get_val(PS4_R2)){                             
			LX = get_val(PS4_LX);                           
			LY = get_val(PS4_LY);                           
		} else if(get_val(PS4_R2)){                       
  			set_val(PS4_LX, LX );                           
  			set_val(PS4_LY, LY );                          
  			///////////////////////////////////////////    
  			// SET THE POWER of the SHOOT                  
  			if(event_press(PS4_UP)){
          shot_power = 345;
          set_val(PS4_UP,0);
        } 
                                                       
  			if(event_press(PS4_RIGHT)){
          shot_power = 375;
          set_val(PS4_RIGHT,0);
        } 
                                                       
  			if(event_press(PS4_DOWN)){
          shot_power = 405;
          set_val(PS4_DOWN,0);
        }  
                                                       
  			if(event_press(PS4_LEFT)){
          shot_power = 445;
          set_val(PS4_LEFT,0);
        }                                             	                         
      }                                                
		///////////////////////////////////////////      
		// TOP SPIN FK
    //////////////////////////////////////////                                  
		if(get_val(XB1_Y)){                              
			FK_mode = TOP_SPIN;
      //fk_timing = 2150;
      set_val(XB1_Y,0);
			//shot_power = 450;// 380 / 400               
			combo_run(TS_SHOT_POWER);
		}                                               
		///////////////////////////////////////////     
		// SIDE SPIN FK                                 
		// left side                                    
		if(get_val(XB1_X)){                             
			FK_mode = SIDE_SPIN;
      fk_timing = 2170;
			side_dir = -100;
      set_val(XB1_X,0);
			//shot_power = 300;                           
			combo_run(SHOT_POWER);
		}                                              
		///////////////////////////////////////////    
		// SIDE SPIN FK                                 
		// right side                                   
		if(get_val(XB1_B)){                             
			FK_mode = SIDE_SPIN;
      fk_timing = 2170;
			side_dir =  100;
      set_val(XB1_B,0);
			//shot_power = 300;                           
			combo_run(SHOT_POWER);            
		}                                               
		///////////////////////////////////////////     
		// KNUCKLEBALL_FK                               
		///////////////////////////////////////////                                             
		if(get_val(XB1_A)){                             
			FK_mode = KNUCKLEBALL_FK;
      fk_timing = 2170;
			shot_power = 550;
      set_val(XB1_A,0);
			combo_run(SHOT_POWER);
		}
    ///////////////////////////////////////////     
    // NORMAL FK                               
    ///////////////////////////////////////////                                                  
		if(get_val(PS4_L3)){                        
			FK_mode = 0;
      fk_timing = 2170;
      set_val(PS4_L3,0);
			combo_run(SHOT_POWER);
		}                                             
    set_val(PS4_R2,0);                                                                                
  }
  //////////////////////////////////////////                                                                                                                         
  // ON / OFF All Skills
  //////////////////////////////////////////         
  if(get_val(PS4_SHARE)){                 
    if(event_press(PS4_CROSS))OnOffMods = !OnOffMods; 
    set_val(PS4_CROSS,0);                        
  }                                        
                                                
                                                
  ///////////////////////////////////////////////////////////// 
  //                                                           
  if(abs(get_val(MOVE_X))> 60 || abs(get_val(MOVE_Y))> 60){    
	 LX = get_val(MOVE_X);                                      
	 LY = get_val(MOVE_Y);                                      
  }                                                           
  //-----------------------------------------------------------
    
  if(OnOffMods) { // all Skills mode           
                                                      
  // Skill 3  : 4. Rainbow  => one tap : PS4_L3
      //if (event_press(PS4_L3) && !get_val(PS4_R1))       
       //     { SKILL = RAINBOW_SKILL; combo_run(RAINBOW);   }   //4.  RAINBOW
     // set_val(PS4_L3,0);       
  //                                                        
  // Skill 4  : 9. Drag to Drag => one tap : PS4_R3
    if (event_press(PS4_R3))       
      { SKILL = DRAG_TO_DRAG_SKILL; combo_run(DRAG_TO_DRAG); }//9.  Fake Shot +  L2 + LS zero
    set_val(PS4_R3,0);       
  //                                                        
  }
  //--------------------------------------------------------------
} // End of main block                          
                                                
////////////////////////////////////////////////////////////////
// COMBO BLOCKS   //////////////////////////////////////////////
////////////////////////////////////////////////////////////////
combo SHOT_POWER {                                    
	set_val(ShotBtn,100);                               
	wait(shot_power);                                   
	wait(300);                                          
	/////////////////////////////////////////////////   
	//  FREE KICK MODE
  /////////////////////////////////////////////////                                    
	if(FK_mode == SIDE_SPIN ) {
    combo_run(SIDE_SPIN_FK);
  }    
	if(FK_mode == KNUCKLEBALL_FK ) {
    combo_run(KNUCKLEBALL);
  } 
  set_val(ShotBtn, 0);
  wait(fk_timing);
  set_val(ShotBtn,100);
  wait(100);
  set_val(ShotBtn, 0);
}
//---------------------------------------------------
combo TS_SHOT_POWER {
  set_val(ShotBtn,100);                               
  wait(shot_power);                                  
  wait(300);                                                                        
  combo_run(TOP_SPIN_FK);
}
//--------------------------------------------------- 
combo TOP_SPIN_FK  {                                  
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,0);                                  
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY, 100);                               
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,0);                                  
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,-100);                               
	wait(spin_time);                                           
}                                                     
//--------------------------------------------------- 
combo SIDE_SPIN_FK  {                                 
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,100);// DOWN                         
	wait(spin_time);                                           
	set_val(PS4_RX,side_dir);// LEFT or RIGHT           
	set_val(PS4_RY,0);                                  
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,-100);// UP                          
	wait(spin_time);                                           
}                                                     
//--------------------------------------------------- 
combo KNUCKLEBALL {                                   
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,100);// DOWN                         
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,0);                                  
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,-100); // UP                         
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY,0);                                  
	wait(spin_time);                                           
	set_val(PS4_RX,0);                                  
	set_val(PS4_RY, 100);// DOWN                        
	wait(spin_time);                                           
                                                      
}                                                     
//-----------------------------
///////////////////////////////
// RAINBOW  ///////////////////
///////////////////////////////
combo RAINBOW {          
	RA_DOWN ();    // down 
	wait(w_rstick);        
	RA_ZERO ();    // ZERO 
	wait(w_rstick);        
	RA_UP();       // up   
	wait(w_rstick);        
	RA_ZERO ();    // ZERO 
	wait(w_rstick);        
	RA_UP();       // up   
	wait(w_rstick);        
}                                             
/////////////////////////////// 
// Drag to Drag ///////////////
///////////////////////////////      
combo DRAG_TO_DRAG {    
	LA(0,0);             
	set_val(PaceCtrol,100);
	wait(40);            
	LA(0,0);             
	set_val(PaceCtrol,100);
	set_val(ShotBtn,100);
	wait(40);            
	LA(0,0);             
	set_val(PaceCtrol,100);
	set_val(ShotBtn,100);
	set_val(PassBtn,100);
	wait(80);            
	LA(0,0);             
	set_val(PaceCtrol,100);
	set_val(ShotBtn,0);  
	set_val(PassBtn,100);
	wait(60);            
}
//---------------------------------------------------
combo PK_TimedFinish {                     
    set_val(ShotBtn, 100);             
    wait(250);  
    set_val(ShotBtn, 0);             
    wait(2250); 
    set_val(ShotBtn, 100);             
    wait(200);  
    set_val(ShotBtn, 0);            
}
//---------------------------------------------------                 
function LA (x,y){ 
	set_val(MOVE_X,x);
	set_val(MOVE_Y,y);
}
//---------------------------------------------------                 
function LA_L_R() {          
	if(right_on) {// right      
		set_val(MOVE_X,inv(LY));  
		set_val(MOVE_Y,LX);       
	}                           
	else {       //  left       
	    set_val(MOVE_X,LY );    
	    set_val(MOVE_Y,inv(LX)); 
    }                         
}
//---------------------------------------------------                              
function RA_L_R() {             
	if(right_on) {// right          
		set_val(SKILL_STICK_X,inv(LY));
		set_val(SKILL_STICK_Y,LX);      
	}                                  
	else {       //  left               
	    set_val(SKILL_STICK_X,LY );     
	    set_val(SKILL_STICK_Y,inv(LX)); 
    }                                
}
//---------------------------------------------------                                    
function RA_OPP() {                  
	if(!right_on) {// right             
		set_val(SKILL_STICK_X,inv(LY));   
		set_val(SKILL_STICK_Y,LX);        
	}                                   
	else {       //  left               
	    set_val(SKILL_STICK_X,LY );     
	    set_val(SKILL_STICK_Y,inv(LX)); 
    }                                
} 
//---------------------------------------------------                                   
function RA_UP () {                  
	set_val(SKILL_STICK_X,LX );        
	set_val(SKILL_STICK_Y,LY );        
}
//---------------------------------------------------                                   
function RA_DOWN () {               
	set_val(SKILL_STICK_X,inv(LX) );   
	set_val(SKILL_STICK_Y,inv(LY) );   
} 
//---------------------------------------------------                                 
function RA_ZERO () {             
	set_val(SKILL_STICK_X,0 );      
	set_val(SKILL_STICK_Y,0 );     
}                             
//--------------------------------------------------------------
//LED INDICATION                                         
//--------------------------------------------------------------
function colorled(a,b,c,d) { 
set_led(LED_1,a);            
set_led(LED_2,b);            
set_led(LED_3,c);            
set_led(LED_4,d);            
}// func end                             