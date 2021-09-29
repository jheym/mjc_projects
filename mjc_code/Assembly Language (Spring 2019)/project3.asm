; Justin Heyman
; Adding_sum3


section .data
num1: dd 2
num2: dd 4
num3: dd 6

section .text
global _main, _sum
_main:

mov eax, 10 		; move 10 into eax
dec eax			; dec eax by 1
mov ebx, 5		; move 5 into ebx

push DWORD[num2]	; Pushes value in num2 onto the stack
push DWORD[num1]
call _sum
add esp, 8

add eax, ebx
dec eax

mov eax, 1
mov ebx, 0
int 80h

_sum:
push ebp		; save base pointer for main
mov ebp, esp		; changing base pointer is dangerous
push ebx		; save value in ebx from main
mov ebx, [ebp + 8]	; move 2 into ebx (takes the value from 8 bytes up the stack)
mov eax, [ebp + 12]	; move 4 into ebx (takes the value from 12 bytes up the stack)
add eax, ebx		; add 2 and 4 and put sum into eax
pop ebx			  
pop ebp
ret			; returns to where the function was called from (ln 15)

_sum3:
push ebp
mov ebp, esp
push ebx
mov ebx, [ebp + 8]
mov eax, [ebp + 12]
mov ecx, [ebp + 16]
add eax, ebx
add ecx, eax
pop ebx
pop ebp
ret








