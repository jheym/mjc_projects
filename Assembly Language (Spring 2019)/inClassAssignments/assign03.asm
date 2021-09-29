; Justin Heyman
; CSCI 273-5724
; Date and Time - NASM (32-bit)

section .data
	decimal: dd 10
	e_time: dd 0
	year: dd 0
	month: dd 0
	day: dd 0
	hour: dd 0
	minutes: dd 0
	seconds: dd 0
	value: dd 0
	return: db 0, 10
	slash: db 47
	colon: db 58
	msg: db "Spooderboi3000", 0ah
	msgLen: equ ($ - msg)
	
section .text
global _main
_main:

call print_colon
call print_return
call print_msg
call print_return

;end program

mov eax, 1
mov ebx, 0
int 80h



year_convert:
	xor edx, edx
	mov eax, [e_time]
	mov ecx, 31556926
	div ecx
	mov [month], edx
	add eax, 1970
	mov [value], eax
	mov edi, value+3
	call ascii_convet
	mov edx, 4
	call print
	call print_slash

print:
   mov ebx, 1   	; file descriptor STDOUT
   mov ecx, value	; string address
   mov eax, 4		; call number 
   int 80h
   ret

print_slash:
   mov ebx, 1     ; file descriptor STDOUT
   mov ecx, slash ; string address
   mov edx, 1	  ; String Length
   mov eax, 4     ; call number 4 (WRITE)
   int 80h        ; system call
   ret

print_colon:
   mov ebx, 1
   mov ecx, colon
   mov edx, 1
   mov eax, 4
   int 80h
   ret

print_return:
   mov ebx, 1
   mov ecx, return
   mov edx, 2
   mov eax, 4
   int 80h
   ret

print_msg:
mov ebx, 1
mov ecx, msg
mov edx, msgLen
mov eax, 4
int 80h
ret
