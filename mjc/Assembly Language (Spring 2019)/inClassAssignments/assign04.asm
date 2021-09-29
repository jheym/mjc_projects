


section .data
a: dd 0

section .text
global _main
_main:
	
mov eax, [a]

l1:
ADD eax, 1
CMP DWORD [a], eax
JO l2
JNO l2


l2:	
ADD eax, 1
CMP DWORD [a], eax
JP l3
JNP l3

l3:
ADD eax, 1
CMP DWORD [a], eax
JS l4
JNS l4

l4:
ADD eax, 1
CMP [a], eax
JE l5
JNE l5

l5:
ADD eax, 1
CMP [a], eax
JZ l6
JNZ l6

l6:
ADD eax, 1
mov ecx, 1
JCXZ, l7
JECXZ, l7

l7:
mov ecx, 0
JCXZ, l8
JECXZ, l8

l8:




mov eax, 1
mov ebx, 0
int 80h
