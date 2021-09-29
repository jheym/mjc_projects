;
; Justin Heyman
; CSCI 273-6724 Spring 2019
; Project 1 - Assignment 4.1
;

SECTION .data		; Section for declared variables
	
	volts: DW 120	; Stores 120d into 16-bit variable, volts (divisor)
	watts: DW 1200	; Stores 1200d into 16-bit variable, watts (dividend)

SECTION .bss		; Section for undeclared variables
	
	amps: RESW 1	; Reserves 16 bits of space pointing to variable, amps

SECTION .text		; Section for executable instructions

global _main		
_main:			

; dx:ax will store the remainder and the quotient, respectively

mov dx, 0 		; reserves dx as a positive signed number
mov ax, [watts]		; moves dividend pointed to in [watts] (1200) into ax
mov cx, [volts]		; moves divisor pointed to in [volts] (120) into cx
DIV cx			; Performs the divide instruction using cx as the divisor
mov WORD [amps], ax	; Moves the new value in ax (10) into the undeclared variable (amps)


mov eax, 1	; End program process
mov ebx, 0
int 80h
