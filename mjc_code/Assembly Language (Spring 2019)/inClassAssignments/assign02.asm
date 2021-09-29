; Assignment 3.4
; Order of Operations (Challenge Assignment) - NASM (32-bit)
; Copyright (c) 2017 Hall & Slonka
; Create a program that calculates the following
; expression: answer = (A + B) - (C + D)

; * The answer must be stored in a variable of the
;   correct data type given your data.
;   	(A, B, C, D)
; * The values for your data (A, B, C, D) must be stored
;   in registers (e.g., eax, ebx), not variables.
; * You must supply the initial values for the data (A, B, C, D).
; * Create a string that could accompany the answer in an output statement
;   (e.g., "The answer is:"). You do not have to output the string.
; * Comment each line of code, as demonstrated in the Working Examples
;   Section Porgram 3.2 for GAS, to briefly describe each line's meaning.

; Requires some information from Chapter 4 (sub mnemonic)

; Section for initialized variables
SECTION .data
	outString: DB "The answer is: ",0

; Section for uninitialized variables
SECTION .bss
	answer: RESD 1

; Section for code
SECTION .text

global _main		; Make _main available to the linker

_main: 		; Main procedure
mov eax, 1	; moves 1d into eax register
mov ebx, 2	; moves 2d into ebx register 
mov ecx, 3	; moves 3d into ecx register
mov edx, 4	; moves 4d into edx register

add eax, ebx		; Values from ebx are added into eax (1 + 2) = 3 in eax
add ecx, edx		; Values from edx are added into ecx (3 + 4) = 7 in ecx

sub eax, ecx		; Subtracts eax from ecx (3 - 7) = -4

mov DWORD [answer], eax ; moves the result in eax (-4) into the empty address answer

mov eax, 1	;
mov ebx, 0	;
int 80h		;
