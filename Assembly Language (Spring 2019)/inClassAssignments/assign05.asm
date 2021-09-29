; Justin Heyman
; CSCI 273-6724	
; Spring 2019
; In-class assignment 5

section .data			; section for initialized variables
a: dd 0				; reserves 4 bytes for variable a and stores the value 0
b: dd 1				; reserves 4 bytes for variable b and stores the value 0
sum: dd 0

section .text			; section for main program
global _main			
_main:

top:	mov eax, [b]		; moves value pointed to by b into eax
	and eax, 1		; [b] AND 1 = 0010
	cmp eax, 1		; if (b&1) compares eax with 1.
	jne count		; jumps to count if eax and 1 = true, otherwise save

save:	mov eax, [b]		; moves value of [b] into eax
	add DWORD [sum], eax	; sum = sum + b

count: 	mov eax, [a]		; moves value of [a] into eax
	add DWORD [b], eax	; b = b + a
	mov eax, [b]		; moves value of [b] to eax
	sub eax, [a]		; subtracts value of [a] from eax
	mov DWORD [a], eax	; a = b - a
	cmp DWORD [b], 1000000	; if (b<1000000), goes down to next line
	jb top			; jumps to the function top

mov eax, 1			; moves value of 1 into eax
mov ebx, 0			; moves value of 0 into ebx
int 80h				; ends program