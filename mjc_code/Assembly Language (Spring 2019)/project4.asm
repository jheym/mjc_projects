; Justin Heyman
; CSCI 273-6724
; Project 4, Bubblesort


SECTION .data
	array: db 8, 42, 16, 11, 3, 25, 9, 10, 0 	; array members                               
    length: db 8                                       


SECTION .text				
global _main			

_main:                               

mov edx, [length]			; counter for outer loop
dec ecx							; ecx must start with 1 less than the number of elements in the array (ecx = -1)

outerloop:
	add ecx, [length]			; move length into ecx to act as counter for loop. (ecx = (- 1 + 8) = 7)
	lea esp, [array]			; mov array members to esp

	innerloop:
		mov al, [esp+1]			; mov values from esp into lower ax
		cmp al, [esp+1]			; compare value in al to next value in esi
		jl nextindex			; if al is less than next value in esp, jump to next index
		
		xchg al, [esp+1]		; put the next index of esp into al while putting the value of al into the next index of esp
		mov [esp], al			; movs the value from al into the first slot of esp
	
		nextindex:
			inc esp				; adds 4 bytes to esp, moving to the next value in the array
			loop innerloop		; goes back to loop and decrements ecx

	dec edx						; decrease counter for outer loop iterations	
	cmp edx, 0
	jnz outerloop				; reiterate outer loop if edx is not 0

 
mov eax, 1
mov ebx, 0
int 80h







