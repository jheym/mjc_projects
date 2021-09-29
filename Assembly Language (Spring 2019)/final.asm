; Justin Heyman
; CSCI 273
; Final Part 1 - In Class
; 4/29/2019 @ 1:00 PM
; Summing Array Elements in a Range


SECTION .data
	lowerLimit: dd 20
	upperLimit: dd 40
	array_1 dd 10, 30, 25, 15, 17, 19, 40, 41, 43
	count_1: EQU ($ - array_1) / 4
	array_2 dd 10, -30, 25, 15, -17, 55, 40, 41, 43
	count_2: EQU ($ - array_2) / 4

SECTION .bss
sum: RESD 1

SECTION .text
global _main
_main:

; CalcSumRange Function


mov ebx, [lowerLimit]
mov edx, [upperLimit]
mov esi, [array_1 + 4]
mov ecx, count_1
call CalcSumRange
call CalcSumRange

mov esi, [array_2 + 4]
mov ecx, count_2
call CalcSumRange

;--------------------------------------------------------------

CalcSumRange:

push esi
push ecx

L1:
	mov eax, esi
	cmp eax, ebx
	jl next
	cmp eax, edx
	jg next
	add [sum], eax

next:
	add esi, 4
	loop L1

	mov eax, sum
	pop ecx
	pop esi
	ret

mov eax, 1
mov ebx, 0
int 80h
