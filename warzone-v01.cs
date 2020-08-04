define WALK=PS4_LY;                    
define STRAFE=PS4_LX;                    
define AIM_H=PS4_RX;                
define AIM_V=PS4_RY;                     
//--BUTTONS                        
define FIRE=PS4_R2;    //change to R1 for flipped bumpers                  
define ADS=PS4_L2;     //change to L1 for flipped bumpers                    
define SPRINT=PS4_L3;                
define TACTICAL=PS4_L1;//change to L2 for flipped bumpers                  
define LETHAL=PS4_R1;  //change to R2 for flipped bumpers                  
define PRONE=PS4_CIRCLE;                              
define MELEE=PS4_R3;
define JUMP=PS4_CROSS;
// check and adjust the customization section below
//--CUSTOMIZATION
define in_game_menu_sens=7;      // controls how much sensitivity you lose while hipfire and while ads and fire[higher numbers decrease sensitivity]
define aim_sens_corrections=1; // [0 = OFF / 1 = ON] sensitivity corrections while hipfire and while ADS+FIRE adjust your ADS sensitivity through the in game menu
define StickNoise=12;          // Dead Zone value for your thumbsticks (only active when you fire, allowing micro aiming)
define recoiladsonly= ADS;     // [FIRE = anti recoil while hipfire & ADS] (ADS = anti recoil only while aim down sights)
define aim_perfection= 1;   // [0 = OFF / 1 = ON] sweet evils aim perfection, this should be run together with sticky aim
define sticky_aim_assist=1;    // [0 = OFF / 1 = ON]   strongest aim assist for COD [crescens]
define _v=21;                  // (sticky aim only) If your screen shakes whilst using aim assist - lower this value (not recomended below 20)
define easy_slide=0;   // [0 = OFF / 1 = ON] recomended to turn off if you play without the in game auto sprint
define easy_plate=0;           // [0 = OFF / 1 = ON] holding triangle to place one plate will automatically hold triangle until all plates are full, cancel by firing, ads or tapping reload
define hair_trigger =1;       // [0 = OFF / 1 = ON] hair triggers on both ads and fire, with bumpers flipped this is redundant
define hold_time=40;       // length of button push during rapid fire
define rest_time=50;           // time between button pushes during rapid fire
define easy_pronecontrol=PS4_L3; //button that must be held for easy prone/crouch to activate while firing
define prone_crouch = 350;      //[350 = prone / 40 = crouch] prone or crouch on easy_pronecontrol + fire or vice versa
// easy prone/crouch activates when you fire and hold the easy_pronecontrol or vice versa
// and you get up when you stop firing or let go of the easy_pronecontrol
//--END CUSTOMIZATION
//-- AR values
int reset_defaults;
int interval, iteration_point;
int i_, i_count;
int AR_V;
int RY, RX;
int ledz;        
int current_x, current_y;
 
    //---aim corrections variables
int ads_fire_sens, Sens, hip_fire_sens;
 //Sweet_Evil 7.10
int mvt = 0;
int Current_State          = 0;
int Aim_Abuse_State        = 2;
define Get_Last_Value      = 0;
define Get_Current_Value   = 1;
define Aim_Correction      = 12;
define Aim_Boost           = 9;
define Aim_Perfection_Limit= 99;
int X_Last_Value      = 0;
int Y_Last_Value      = 0;
int X_Current_Value   = 0;
int Y_Current_Value   = 0;
int Aim_Boost_Val     = 0;
int Aim_Correction_Val= 0;
 
    //---other variables used by the script

int double__tap[30];
int code;
int notify, notifier;
int auto_hold_breath;
int rapid_fire;
int easy_prone;
int quick_melee;
int edit=FALSE;
int no_recoil;
int weapon;
int _currentSlot;
int mod;
int AntiRecoil_Horizontal;
int ARS;
int AR;
int AR_Value1;
int AR_Value2;
int AR_H1;
int AR_H2;

init {
    _currentSlot = get_slot();
    __(0);
}
main
{
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
   
    if (get_val (FIRE))
    {    
    current_x = dz(AIM_H,0);
    current_y = dz(AIM_V,0);
    }
 
        ////////////////////////////////////////////////////    
      //-------->>>>START AIM DOWN SIGHTS MENU HERE<<<<------
      //--0=0ff/1=Blue/3=Pink/4=Green/5=Sky/6=Yellow/7=White
    if(get_val(ADS) && get_val(JUMP))// <<--- HOLD DOWN AIM DOWN SIGHTS AND TAP
    {
     //DPAD-UP
     if(event_press(PS4_UP))//change to PS4_SHARE or PS4_OPTIONS if you want to ping while ads
                 {
                        // m4a1
                        AR_Value1 = 18;
                        AR_H1 = -12;

                        // fal
                        AR_Value2 = 20;
                        AR_H2 = 0;                        

                        //MOD
                        weapon=FALSE;
                        mod = 1;
                        quick_melee=TRUE;      // quick melee [TRUE = on FALSE = off]                
                        easy_prone=TRUE;         //easy prone / crouch [TRUE = on FALSE = off]
                        rapid_fire=FALSE;       //rapid fire [TRUE = on FALSE = off]
                        auto_hold_breath=FALSE; //auto hold breath [TRUE = on FALSE = off]
                        no_recoil=TRUE;         //anti recoil [TRUE = on  FALSE = off]
                        fnotify (0);   // rumble   [ 0 = double  1 = single]              
                        // __(4);                   // colour
                 }  
 
       //D-PAD DOWN
     if(event_press(PS4_DOWN))    //D-PAD DOWN
                 {      //sniper mode
                        //MOD
                        mod = 2;
                   quick_melee=TRUE;      // quick melee [TRUE = on FALSE = off]                
                   easy_prone=TRUE;         //easy prone / crouch [TRUE = on FALSE = off]
                   rapid_fire=FALSE;      //rapid fire [TRUE = on FALSE = off]
                   auto_hold_breath=TRUE;//auto hold breath [TRUE = on FALSE = off]
                   no_recoil=FALSE;       //anti recoil [TRUE = on FALSE = off]
                   fnotify (0);   // rumble   [ 0 = double  1 = single]              
                    //  __(1);                  // colour        
                  }
 
 
     //DPAD-RIGHT
     if(event_press(PS4_RIGHT))   //DPAD-RIGHT
                  {
                        // bruen
                        AR_Value1 = 18;
                        AR_H1 = 6;

                        // mp5
                        AR_Value2 = 20;
                        AR_H2 = -10; 

                        //MOD
                        mod = 3;
                        weapon=FALSE;
                        quick_melee=TRUE;      // quick melee [TRUE = on FALSE = off]                  
                        easy_prone=TRUE;         //easy prone / crouch [TRUE = on FALSE = off]
                        rapid_fire=FALSE;        //rapid fire [TRUE = on FALSE = off]  
                        auto_hold_breath=FALSE; //auto hold breath [TRUE = on FALSE = off]
                        no_recoil=FALSE;         //anti recoil [TRUE = on FALSE = off]
                        fnotify (0);   // rumble   [ 0 = double  1 = single]              
                //  __(3)                   // colour
                  }  
 
     //DPAD-LEFT
     if(event_press(PS4_LEFT))    //DPAD-LEFT
                 {
                        // galil
                        AR_Value1 = 18;
                        AR_H1 = -12;

                        // p90
                        AR_Value2 = 20;
                        AR_H2 = 0;

                        //MOD
                        mod = 4;
                 quick_melee=TRUE;      // quick melee [TRUE = on FALSE = off]                
                 easy_prone=TRUE;         //easy prone / crouch [TRUE = on FALSE = off]
                 rapid_fire=FALSE;       //rapid fire [TRUE = on FALSE = off]
                 auto_hold_breath=FALSE; //auto hold breath [TRUE = on FALSE = off]
                 no_recoil=TRUE;        //anti recoil [TRUE = on FALSE = off]
                 fnotify (0);   // rumble   [ 0 = double  1 = single]              
                // __(7)        // colour    
                 }
btn(PS4_SHARE);btn(PS4_LEFT);btn(PS4_RIGHT);btn(PS4_UP);btn(PS4_DOWN);}   // buttons console ignores while ads  
                   //-------->>>>END AIM DOWN SIGHTS MENU HERE END<<<<------                
                 /////////////////////////////////////////////////////////////
 
 
//-- hair trigger
if (hair_trigger)
{
if(get_val(FIRE)&&!rapid_fire)
set_val(FIRE,100)
if(get_val(ADS)&&!akimbo)
set_val(ADS,100)
}
 
//-- easy prone
if (easy_prone)
{
if(get_val(FIRE) && event_press(easy_pronecontrol))
combo_run(ceasy_prone);
if(get_val(easy_pronecontrol) && event_press(FIRE))
combo_run(ceasy_prone);
if(get_val(easy_pronecontrol)&& event_release(FIRE))
combo_run(cget_up);
if(get_val(FIRE)&& event_release(easy_pronecontrol))
combo_run(cget_up);
}
 
//-- auto hold breath
if (auto_hold_breath)
      {
      if(get_val(ADS)&&get_ptime(ADS)>50)
        {set_val(SPRINT, 100);}
        if(get_val(ADS)&&get_val(FIRE))
        {set_val(SPRINT, 0);}
        }
 
 
//-- Rapid fire
if (rapid_fire)
{
  if(get_val(FIRE)>60)// change for percent(%) you press trigger before rapid fire activates
  combo_run(crapid_fire)
  if (get_val(FIRE))
  set_val(SPRINT, 100);
  if(get_val(ADS)&&get_ptime(ADS)>100)
          set_val(SPRINT, 100);
}
 
//-- quick melee
 
 
if(quick_melee){
  if(get_val(MELEE) && !get_val(ADS))
    {combo_run(cquick_melee);}
    }
 
//-- easy slide
if
(easy_slide)
if(get_val(WALK)<-99 && get_val(PRONE))
combo_run(cslide);
 
//-- aim corrections
if(aim_sens_corrections)
      {
      ads_fire_sens=100-(in_game_menu_sens); hip_fire_sens= 95-(in_game_menu_sens);
 
      if(get_val(FIRE) && !get_val(ADS))
      Sens = hip_fire_sens;
             if(get_val(ADS) && get_val(FIRE))                              
             Sens = ads_fire_sens;
             if(!get_val(FIRE))
             Sens = 100;
            if(Sens > 100) Sens = 100;  
      sensitivity(AIM_H, NOT_USE, Sens);
        sensitivity(AIM_V, NOT_USE, Sens);
    }
 
//-- sticky aim(crescens)
if (sticky_aim_assist)
    {
        if(get_val(ADS)) combo_run(cSTICKY_AIM);
          if(get_val(FIRE)){
            combo_run(cAR);
          }                
       }
 if(get_val(ADS) && event_press(FIRE)) {
            combo_run(ping);
        }
 if (event_press(PS4_TRIANGLE) || (event_press(PS4_DOWN) && get_val(PS4_L2)))
    { 
      weapon=!weapon;
      if (mod==1){
        rapid_fire=!rapid_fire;
        } 
    }
if(abs(get_val(PS4_RY)) > AR + 2 || abs(get_val(PS4_RX)) > AR + 2)
     {combo_stop(cAR);}        
//-- aim perfection(sweet_evil_14)
if(aim_perfection)
{
if(get_val(ADS))
        {        
        if (Current_State == Get_Last_Value)
        {
        X_Last_Value = get_lval(AIM_H);
        Y_Last_Value = get_lval(AIM_V);
  Current_State = Get_Current_Value;
  }
        else if (Current_State == Get_Current_Value)
        {
        X_Current_Value = get_val(AIM_H);
        Y_Current_Value = get_val(AIM_V);
  if(Aim_Abuse_State == Aim_Correction)
        {    
        Current_State = Aim_Boost;
        }
        else
        {
        Current_State = Aim_Correction;
        }    
        }
        if (Current_State == Aim_Boost)
        {
        Aim_Perfection(X_Last_Value, X_Current_Value, 1, 0, 1, 0 );
        Aim_Perfection(Y_Last_Value, Y_Current_Value, 1, 0, 0, 1 );
  Current_State = Get_Last_Value;
        Aim_Abuse_State = Aim_Boost;  
        }
        else if (Current_State == Aim_Correction)
        {
        Aim_Perfection(X_Last_Value, X_Current_Value, 0, 1, 1, 0 );
        Aim_Perfection(Y_Last_Value, Y_Current_Value, 0, 1, 0, 1 );
  Current_State = Get_Last_Value;
        Aim_Abuse_State = Aim_Correction;
        }
        }
        else
        {
        Current_State = Get_Last_Value;
        Aim_Abuse_State = Aim_Correction;
        }
        }
if (!mod || mod ==2){
    __(0);
}
if (mod==1 && !weapon){
    __(1);
}
if (mod==1 && rapid_fire){
    __(5);
}
if (mod==3 && !weapon){
    __(2);
}
if (mod==3 && weapon){
    __(6);
}
if (mod==4){
    __(7);
}
    //-- anti recoil                
    if (no_recoil && !weapon)
    {
      AR = AR_Value1;
      AntiRecoil_Horizontal = AR_H1;  
    }
   
    if (no_recoil && weapon)
    {
      AR = AR_Value2;
      AntiRecoil_Horizontal = AR_H2; 
    }
 

//-- rumble            
 
    if(notify) {
        notifier = notifier + get_rtime();
        if(notifier < 150) set_rumble(1,75);
        else if(notifier < 400) reset_rumble();
        else
        {
        notify--;
        notifier = 0;
        }
    }
}//--------------END OF MAIN----------------
//--------------COMBO SECTION----------------          
combo cslide{
    wait(1000);// time before you get up after sliding
    set_val(JUMP, 100);
    wait(20);
    }
 
combo ceasy_plate
{set_val(PS4_TRIANGLE,100);
wait(6000)//time triangle is held for adjust higher or lower 500 if you only get 2 plates or cant switch weapons after replating
}
 
 
combo cquick_melee {
    set_val(MELEE, 100);
    wait(20);
    set_val(MELEE,0)
    }
 
 
combo ceasy_prone
{
    set_val(PRONE,100);
    wait(prone_crouch);// 350 = prone / 40 = crouch
    }
 
combo cget_up {
set_val(JUMP,100);
wait (50)
}
 
combo cSTICKY_AIM
  {
    set_val(AIM_V,xy_val(AIM_V, _v));
    wait(20);
    set_val(AIM_H,xy_val(AIM_H, _v));
    set_val(STRAFE,xy_val(STRAFE, _v));
    wait(20);
    set_val(AIM_V,xy_val(AIM_V, _v * -1));
    wait(20);
    set_val(AIM_H,xy_val(AIM_H, _v * -1));
    set_val(STRAFE,xy_val(STRAFE, _v * -1));
    wait(20);
    }
 
combo crapid_fire
{
set_val(FIRE,100);
wait(hold_time);
set_val(FIRE,  0);
wait(rest_time);
}
 
combo cakimbo_fire
{
set_val(ADS,100);
wait(hold_time);
set_val(ADS,  0);
wait(rest_time);
}
 
 combo ping {
    wait(300);
    set_val(XB1_UP, 100);
    wait(60);
    set_val(XB1_UP, 0);
    wait(60);
    set_val(XB1_UP, 100);
    wait(60);
    set_val(XB1_UP, 0);
    wait(60);
}
combo cAR {
  ARS = get_val(PS4_RY) + AR;
  if(ARS > 100) ARS = 100;
  set_val(PS4_RY,ARS * Invert_Look);
  ARS = get_val(PS4_RX) + AntiRecoil_Horizontal;
  if(ARS > 100) ARS = 100;
  set_val(PS4_RX,ARS);
}

//--------------FUNCTION SECTION----------------

 
function double_click(button) {        
    if (double__tap[button] >= 0) {                    
    double__tap[button] = double__tap[button] + get_rtime();
    if (double__tap[button] > 450)
    double__tap[button] = -1;                                                                                      
    }          
    if (event_release(button) && get_ptime(button) <= 200) {
    if (double__tap[button] < 0) {                    
    double__tap[button] = 0;                        
    } else {            
    double__tap[button] = -1;                      
    return 1;                                  
    }                                                    
    }                                                  
    return 0;
    }
 
function Aim_Perfection(Last_Value, Current_Value, Boost, Correction, X_AXIS, Y_AXIS)
    {
    mvt = abs(Last_Value) + abs(Current_Value);
    Aim_Boost_Val = ( mvt + 1 )/2;
    Aim_Correction_Val = Aim_Boost_Val + 4;
  if(Aim_Boost_Val >= 10)
    {
    Aim_Boost_Val = 10;
    Aim_Correction_Val = 14;
    }
    else if(Aim_Boost_Val == 0)
    {
    Aim_Boost_Val = 2
    Aim_Correction_Val = 4;
    }
  if(mvt < Aim_Perfection_Limit)
    {
    if(Last_Value < Current_Value)
    {          
    if (Boost)
    {
    if (X_AXIS)
    set_val(AIM_H, (Current_Value + Aim_Boost_Val));
    if (Y_AXIS)
    set_val(AIM_V, (Current_Value + Aim_Boost_Val));
    }
    else if(Correction)
    {
    if (X_AXIS)
    set_val(AIM_H, (Current_Value - Aim_Correction_Val));
  if (Y_AXIS)
    set_val(AIM_V, (Current_Value - Aim_Correction_Val));            
    }
    }
    else //--moving left
    {
    if (Boost)
    {
    if (X_AXIS)
    set_val(AIM_H, (Current_Value - Aim_Boost_Val));
  if (Y_AXIS)
    set_val(AIM_V, (Current_Value - Aim_Boost_Val));
    }
    else if(Correction)
    {
    if (X_AXIS)
    set_val(AIM_H, (Current_Value + Aim_Correction_Val));
  if (Y_AXIS)
    set_val(AIM_V, (Current_Value + Aim_Correction_Val));            
    }
    }
    }
    }
 
function xy_val(f_axis,f_val)
     {
     if(abs(get_val(f_axis)) < (_v + 1))  
         return f_val;    
     return get_val(f_axis);    
}
 
 
function __(col){
    ledz=0;
    while(ledz < 3){
        set_led(ledz, test_bit(col, ledz));
        ledz++;
    }
    }
 
function fnotify(pos)
       {
      if(pos)
      notify = 1;
      else
      notify = 2;
 }
 
function btn(f__btn)
      {
      if (!get_val(f__btn)) return;
      set_val(f__btn, 0);
      }  
 
 
function dz(f_axis,f_val)
      {
      f_val = get_val(f_axis);
      if(abs(f_val) < StickNoise)
      {
      set_val(f_axis,0);
      return 0;
      }
      return f_val;
 }
 
function c()
     {
     i_++;
     if(i_ == iteration_point)
     {
     i_ = 0;
     AR_V = AR_V + interval;
     }
     return AR_V;
     }


