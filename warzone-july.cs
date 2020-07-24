/*
 = = = = = = = = = = = = = = = = = = =
 = /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\  =
 = /\/\/\  Made By ItzSnack  /\/\/\  =
 = /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\  =
 = = = = = = = = = = = = = = = = = = =
 
 ===============================
 === Modern Warfare Ultimate ===
 ===============================
 
 
 ===================
 === Version 3.0 ===
 ===================
 
 ================
 === FEATURES ===
 ================
 Aim Assist
 Anti Recoil
 Akimbo Rapid Fire
 Rapid Fire
 Burst Fire
 Drop Shot
 Jump On Shot
 Drop On Shot
 Prone On Shot
 Hold Breath
 Hair Trigger
 Custom Sensitivity
 
 
 =================
 === Important ===
 ========================================================================
 === Recommended you read all the text below to understand everything ===
 ========================================================================
 
 ======================
 === In-Game Layout ===
 ===========================================
 === Default - Can be adjusted in Layout ===
 ===========================================
 
 =====================
 === Reset Toggles ===
 ==================================================
 === OPTIONS/MENU + SHARE/VIEW To Reset Toggles ===
 ==================================================
 
 ===================
 === Toggle Menu ===
 =============================================================================================================
 === Before being able to turn ON/OFF Toggles you will have to open the Toggle Menu by doing the following ===
 === OPTIONS/MENU + D-PAD UP                                                                               ===
 === When ON your LED will flash Rainbow now you able to turn on any features you want                     ===
 === After you done make sure to disable the Toggle Menu                                                   ===
 === Your LED will be Black when your out of the Toggle Menu                                               ===
 =============================================================================================================
 
 ===============================================================================
 ===                          TOGGLES YOU CAN ACTIVATE                       ===
 ===============================================================================
 === Hold L2/LT And Press SQUARE/X For Akimbo Rapid Fire                     ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press R3/RS For Rapid Fire                               ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press L1/LB For Burst Fire                               ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press UP For Jump On Shot                                ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press DOWN For Drop Shot                                 ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press RIGHT For Drop On Shot                             ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press LEFT For Prone On Shot                             ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 ===============================================================================
 === Hold L2/LT And Press R1/RB For Anti Recoil                              ===
 === 1 Rumble = ON 2 = OFF                                                   ===
 === Hold CROSS/A And Press UP For +1 to Anti Recoil and DOWN For -1         ===
 === Hold CROSS/A And Press RIGHT For +1 to Horizontal and LEFT For -1       ===
 === Heavy Rumble = Increase Light Rumble = Decrease                         ===
 ===============================================================================
 */
define ON = TRUE;
define OFF = FALSE;

//Layout
define PS = PS4_PS; //XBOX
define SHARE = PS4_SHARE; //VIEW
define OPTIONS = PS4_OPTIONS; //MENU
define R1 = PS4_R1; //RB
define R2 = PS4_R2; //RT
define R3 = PS4_R3; //RS
define L1 = PS4_L1; //LB
define L2 = PS4_L2; //LT
define L3 = PS4_L3; //LS
define RX = PS4_RX;
define RY = PS4_RY;
define LX = PS4_LX;
define LY = PS4_LY;
define UP = PS4_UP;
define DOWN = PS4_DOWN;
define LEFT = PS4_LEFT;
define RIGHT = PS4_RIGHT;
define TRIANGLE = PS4_TRIANGLE; //Y
define CIRCLE = PS4_CIRCLE; //B
define CROSS = PS4_CROSS; //A
define SQUARE = PS4_SQUARE; //X
define TOUCHPAD = PS4_TOUCH;

//Customize Non Toggles
int Flipped = OFF; //Change OFF TO ON If you play with Flipped Triggers
int AS = ON; //Change ON TO OFF If you don't want Aim Assist
int HT = ON; //Change ON TO OFF If you don't want Hair Trigger
int CS = ON; //Change ON TO OFF If you don't want Custom Sensitivity
int HB = ON; //Change ON TO OFF If you don't want Hold Breath

//Customize Toggles
int AR_Toggle = ON; //Change OFF TO ON If you want Anti Recoil ON By Default
int ARF_Toggle = OFF; //Change OFF TO ON If you want Akimbo Rapid Fire ON By Default
int RF_Toggle = OFF; //Change OFF TO ON If you want Rapid Fire ON By Default
int DS_Toggle = OFF; //Change OFF TO ON If you want Drop Shot ON By Default
int JOS_Toggle = OFF; //Change OFF TO ON If you want Jump On Shot ON By Default
int COS_Toggle = OFF; //Change OFF TO ON If you want Crouch On Shot ON By Default
int PS_Toggle = OFF; //Change OFF TO ON If you want Prone On Shot ON By Default

//Speed Of Features
int ARF_Speed = 40; //Akimbo Rapid Fire
int RF_Speed = 40; //Rapid Fire
int BF_Speed = 340; //Burst Fire
int DS_Speed = 60; //Drop Shot
int Prone_Speed = 80; //Prone On Shot - How long before you prone
/*NOTE:
Higher values = Slower
Lower values = Faster*/

//Custom Sensitivity
int GEN_SENS = 100;
int ADS_SENS = 100;
int FIRE_SENS = 100;
int ADS_FIRE_SENS = 100;
int GRENADE_SENS = 100;
/*NOTE:
Default = 100
Ranges from 0 to 327*/

//Anti Recoil
int AR = 23; //Vertical Recoil
int AR_H = 0; //Horizontal Recoil
int AR_I = 1; //Change 1 to -1 If you play with Inverted

//Aim Assist
int AP = 20; //Decrease if shake
int AM = -20; //Decrease if shake
int Release = 21; //Recommended to be 1 higher than AP & AM

//Toggles
int ARS;
int USE_SENS;
int Remove_Block;
int Toggle_Menu;
int Toggle_Rumble;
int _currentSlot;

init {
    _currentSlot = get_slot();
} 

main {

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
    
    if(get_val(OPTIONS) && event_press(SHARE)) {
    ARF_Toggle = OFF;
    RF_Toggle = OFF;
    JOS_Toggle = OFF;
    DS_Toggle = OFF;
    COS_Toggle = OFF;
    PS_Toggle = OFF;
    AR_Toggle = OFF;
    Toggle_Menu = OFF;
    combo_run(Menu_Rumble);}
 
    if(CS)
    if(!get_val(L2) && !get_val(R2)) { 
    USE_SENS=GEN_SENS;}
    else if(get_val(L2) && !get_val(R2)) { 
    USE_SENS=ADS_SENS;}    
    else if(!get_val(L2) && get_val(R2)) { 
    USE_SENS=FIRE_SENS;}
    else if(get_val(L2) && get_val(R2)) { 
    USE_SENS=ADS_FIRE_SENS;}
    else if(get_val(R1)) { 
    USE_SENS=GRENADE_SENS;}
    sensitivity(RY,NOT_USE,USE_SENS);
    sensitivity(RX,NOT_USE,USE_SENS);
 
    LED(0,0,0,0);
 
    if(get_val(TRIANGLE) && get_ptime(TRIANGLE) > 500)
    combo_run(cPLATE);
 
    if(Flipped) {
    swap(R1,R2);
    swap(L1,L2);}
 
    if(HT)
    deadzone(L2,R2,100,100);
    if(HB)
    if(get_val(L2)) set_val(L3,100);
    if(HB)
    if(get_val(LY) <-90 && get_val(L2) && get_ptime(L2) > 200) combo_stop(cCH);
    if(HB)
    if(event_press(L2)) combo_run(cCH);
    if(HB)
    if(get_val(L2) && get_lval(L3)) set_val(L3,0);
 
    if(AS)
    if(get_val(L2)) combo_run(cAS);
 
    if(AR_Toggle) {
        if(get_val(L2) && get_val(R2)) {
            combo_run(cAR);
        }
    }
    if(get_val(L2) && event_press(R2)) {
            combo_run(ping);
        }
 
    if(RF_Toggle && get_val(R2))
    combo_run(cRF);
 
    if(ARF_Toggle && get_val(R2))
    combo_run(cARF);
  
    if(COS_Toggle && event_press(R2))
    combo_run(cCOS);
 
    if(JOS_Toggle && event_press(R2))
    combo_run(cJOS);
 
    if(DS_Toggle && get_val(R2))
    combo_run(cDS);
 
    if(PS_Toggle && get_val(R2) && get_ptime(R2) > Prone_Speed)
    set_val(CIRCLE,100);
 
    if(get_val(OPTIONS) && event_press(UP)) {
    Toggle_Menu=!Toggle_Menu;
    Toggle_Rumble=!Toggle_Rumble;}
    if(Toggle_Rumble) 
    combo_run(Menu_Rumble);
 
    if(Toggle_Menu) {
    combo_run(Rainbow_Flash);
 
    if(get_val(L2) && event_press(SQUARE)) {
    ARF_Toggle=!ARF_Toggle;
    if(RF_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(L2) && event_press(R3)) {
    RF_Toggle=!RF_Toggle;
    if(RF_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
  
 
    if(get_val(L2) && event_press(UP)) {
    JOS_Toggle=!JOS_Toggle;
    if(JOS_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(L2) && event_press(DOWN)) {
    DS_Toggle=!DS_Toggle;
    if(DS_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(L2) && event_press(RIGHT)) {
    COS_Toggle=!COS_Toggle;
    if(COS_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(L2) && event_press(LEFT)) {
    PS_Toggle=!PS_Toggle;
    if(PS_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(L2) && event_press(R1)) {
    AR_Toggle=!AR_Toggle;
    if(AR_Toggle) combo_run(Flash_ON);
    else combo_run(Flash_OFF);}
 
    if(get_val(CROSS)) {
    if(event_press(UP)) {
    AR = AR + 1;
    combo_run(cIncrease);}
    if(event_press(DOWN)) {
    AR = AR - 1;
    combo_run(cDecrease);}
    if(event_press(RIGHT)) {
    AR_H = AR_H + 1;
    combo_run(cIncrease);}
    if(event_press(LEFT)) {
    AR_H = AR_H - 1;
    combo_run(cDecrease);}
    set_val(UP,0);set_val(DOWN,0);set_val(RIGHT,0);set_val(LEFT,0);}
 
    if(get_val(L2)) {
    if(event_press(UP)) {
    Remove_Block=!Remove_Block;}
    if(event_press(RIGHT)) {
    Remove_Block=!Remove_Block;}
    if(event_press(DOWN)) {
    Remove_Block=!Remove_Block;}
    if(event_press(LEFT)) {
    Remove_Block=!Remove_Block;}
    if(event_press(R3)) {
    Remove_Block=!Remove_Block;}
    if(event_press(SQUARE)) {
    Remove_Block=!Remove_Block;}
    if(event_press(R1)) {
    Remove_Block=!Remove_Block;}
    if(event_press(L1)) {
    Remove_Block=!Remove_Block;}
    set_val(UP,0);set_val(RIGHT,0);set_val(DOWN,0);set_val(LEFT,0);set_val(R3,0);set_val(SQUARE,0);set_val(R1,0);set_val(L1,0);}}
    if(get_val(OPTIONS)) {
    if(event_press(SHARE)) {
    Remove_Block=!Remove_Block;}
    set_val(SHARE,0);}
 
 
    if(abs(get_val(RY)) > AR + 2 || abs(get_val(RX)) > AR + 2) {
    combo_stop(cAR);}
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
    ARS = get_val(RY) + AR;
    if(ARS > 100) ARS = 100;
    set_val(RY,ARS * AR_I);
    ARS = get_val(RX) + AR_H;
    if(ARS > 100) ARS = 100;
    set_val(RX,ARS);
}

combo cPLATE {
    set_val(TRIANGLE,100);
    wait(4000);
}

combo cAS { 
    set_val(RY,a_f(RY,AP));
    wait(20)
    set_val(RX,a_f(RX,AP));
    wait(20)
    set_val(RY,a_f(RY,AM));
    wait(20)
    set_val(RX,a_f(RX,AM));
    wait(20)
}

combo cDS {
    set_val(CIRCLE,100);
    wait(40);
    set_val(CIRCLE,0);
    wait(DS_Speed);
}

combo cCH {
    set_val(L3,0);
    wait(60);
    set_val(L3,100);
    wait(110);
    set_val(L3,0);
    wait(110);
}

combo cCOS {
    set_val(CIRCLE,100);
    wait(100);
}

combo cJOS {
    set_val(CROSS,100);
    wait(100);
}

combo cRF {
    set_val(R2,100);
    wait(40);
    set_val(R2,0);
    wait(RF_Speed);
}

combo cARF {
    set_val(R2,100);
    set_val(L2,100);
    wait(40);
    set_val(R2,0);
    set_val(L2,0);
    wait(ARF_Speed);
}

combo cIncrease {
    set_rumble(RUMBLE_A,100);
    wait(100);
    reset_rumble();}

combo cDecrease {
    set_rumble(RUMBLE_B,100);
    wait(50);
    reset_rumble();
}

combo Menu_Rumble {
    set_rumble(RUMBLE_B,100);
    wait(200);
    reset_rumble();
    Toggle_Rumble = OFF;
}

combo Rainbow_Flash {
    LED(2,0,2,0);
    wait(100);
    LED(0,0,0,0);
    wait(100);
    LED(0,0,0,2);
    wait(100);
    LED(0,0,0,0);
    wait(100);
    LED(0,2,2,0);
    wait(100);
    LED(0,0,0,0);
    wait(100);
}

combo Flash_ON {
    LED(0,0,2,0);
    set_rumble(RUMBLE_A,100);
    wait(400);
    reset_rumble();
    reset_leds();
}

combo Flash_OFF {
    LED(0,2,0,0);
    set_rumble(RUMBLE_B,100);
    wait(200);
    reset_rumble();
    LED(0,0,0,0);
    wait(100);
    set_rumble(RUMBLE_B,100);
    LED(0,2,0,0);
    wait(200);
    reset_rumble();
    reset_leds();
}

function a_f(p,m) {
    if(abs(get_val(p)) < Release)
    return m;
    return get_val(p);
}

function LED(a,b,c,d) {
    set_led(LED_1,a);
    set_led(LED_2,b);
    set_led(LED_3,c);
    set_led(LED_4,d);
}
 